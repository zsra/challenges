SELECT product_name, SUM(unit) AS unit
FROM products p
JOIN orders o ON p.product_id = o.product_id
WHERE order_date BETWEEN '2020-02-01' AND '2020-02-29'
GROUP BY product_name, p.product_id
HAVING SUM(unit) >= 100