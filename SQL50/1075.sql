SELECT p.project_id, IFNULL(ROUND(AVG(e.experience_years),2),0) as average_years 
FROM Project p
INNER JOIN Employee e
ON p.employee_id = e.employee_id
GROUP BY  p.project_id