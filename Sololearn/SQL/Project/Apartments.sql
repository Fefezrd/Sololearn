SELECT *
FROM apartments
WHERE price > ( select avg(price) from apartments)
and status='Not rented'
order by price;