-- MIN and Max
--SELECT MIN(productID) FROM Products

-- AVG 
--select AVG(productId)  From Products
-- sum
--select SUM(productId) from Products where productID >50;

-- Like, The LIKE operator is used in a WHERE clause to search for a specified pattern in a column.
-- % and __ 
-- Finds any value that end with 'a'
--Select * from Customers where ContactName LIKE '%a'

-- Finds any values that start with 'M' and are at least 2 chars in length
--select * from Customers where ContactName LIKE 'M__%'

-- WildCharcters
-- select * from Customers Where ContactName LIKE '[!ar]%'

-- IN, satış danışmanı ve ürün sahiplerini getirdik
--select * from Customers Where ContactTitle IN ('Owner','Sales Agent');

-- BETWEEN
-- fiyatı 5 ila 10 arasında olan ürünleri getirdik
--select UnitPrice from Products where UnitPrice between 5 and 10

-- select * from Products Where UnitPrice between 5 and 10 and productID not in (45,47,54)

-- Union
--select productName from Products union select contactName from customers

-- group by

--select count(productID),productName from Products group by productName
--order by count(productID) asc
--select productName,UnitsInStock,UnitPrice,UnitsOnOrder, UnitPrice * (UnitsInStock+UnitsOnOrder) as price from Products

-- ProductName, SupplierId, CategoryID, QuantityPerUnit,
-- UnitPrice, UnitslnStock, UnitsOnOrder, ReorderLevel, discontinued

-- Her bir üründen toplamda ne kadar para kazandığımızı bulacağız
-- ilk olarak order details tablosundan her bir üründen kazancımızı hesapladık

-- Ürünlerin hepsi satılırsa edilecek kazanç
--select productID,Quantity, UnitPrice,(Quantity*UnitPrice) as total from [Order Details]
-- order ıd sini aldık

--select ProductName, COUNT(Orders.OrderId) as numberOfOrders from Orders
--left join [Order Details] od on od.OrderID = Orders.OrderID
--left join Products p on p.ProductID =od.ProductID
--group by ProductName

select Products.ProductName, sum([Order Details].UnitPrice*[Order Details].Quantity) from Products
inner join [Order Details]  on [Order Details].ProductID=Products.ProductID
inner join Orders  on Orders.OrderID=[Order Details].OrderID
group by Products.ProductName

select * from [Order Details] where [Order Details].ProductID=1

select COUNT(OrderID) as urunAdedi,ProductID from [Order Details]
group by ProductID order by ProductID asc
