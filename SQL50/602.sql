SELECT id, COUNT(id) AS num
FROM (
    SELECT requester_id AS id
    FROM RequestAccepted
    UNION ALL 
    SELECT accepter_id AS id
    FROM RequestAccepted
) t1
GROUP BY id
ORDER BY num DESC
LIMIT 1