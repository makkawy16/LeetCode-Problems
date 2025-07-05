# Write your MySQL query statement below
select p.product_id , COALESCE(Round(Sum(p.price*u.units)/Sum(u.units),2),0) as average_price
from Prices as p
left join UnitsSold as u on p.product_id = u.product_id
and u.purchase_date between p.start_date AND p.end_date
group by p.product_id