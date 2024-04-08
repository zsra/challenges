SELECT 
    p.product_name as product_name,
    s.year as year,
    s.price as price
FROM Sales s 
INNER JOIN  Product p
ON
    s.product_id = p.product_id