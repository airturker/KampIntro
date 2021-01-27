--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City= 'London'

--case insensitive
select * from Products where categoryId = 1 or categoryId = 3

--büyük küçük problem değil
sEleCt * from Products where categoryId = 1 and UnitPrice >= 10

select * from Products order by UnitPrice --ascending (baştan sona sırala)

select * from Products order by UnitPrice desc --descending (azalan düşen)

select * from Products where categoryId=1 order by UnitPrice desc --kategori 1 dekileri fiyata göre azalan sırala

select * from Products order by CategoryId, ProductName

--adet (ismini değiştirdik ya da yeni isim verdik
select count(*) adet from Products where CategoryID = 2

select CategoryID, count(*) from Products group by CategoryID

select CategoryID, count(*) adet from Products group by CategoryID

select CategoryID, count(*) adet from Products group by CategoryID having count(*)<10

select CategoryID, count(*) adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO data transformation object
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID 
where UnitPrice>10

select * from Products p left join [Order Details] od --solda olup sağda olmayanları da getir
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --orders(sipariş) daki customerId leri null olanları getir
--null ile "=" kullanılmaz "is" kullanılır

select * from Products p inner join [Order Details] od --ikiden fazla join
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID



