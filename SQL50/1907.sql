SELECT "Low Salary" AS category, sum(if(income < 20000, 1, 0)) AS accounts_count FROM Accounts
UNION
SELECT "Average Salary" AS category, sum(if(income >= 20000 AND income <= 50000, 1, 0)) AS accounts_count FROM Accounts
UNION
SELECT "High Salary" AS category, sum(if(income > 50000, 1, 0)) AS accounts_count FROM Accounts