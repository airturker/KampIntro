Select p.ProductName AS 'Ürün Adı', 
SUM(od.Quantity * od.UnitPrice) AS 'Kazanılan Toplam Miktar'
from Products p inner join [Order Details] od on p.ProductID = od.ProductId 
inner join Orders o on od.OrderID = o.OrderID
group by p.ProductName