SELECT round(count(distinct player_id)
/(SELECT count(distinct player_id) FROM activity),2) as fraction
FROM activity
WHERE (player_id, event_date) IN
(SELECT player_id, date_add(min(event_date), interval 1 day)
FROM activity
GROUP BY player_id)