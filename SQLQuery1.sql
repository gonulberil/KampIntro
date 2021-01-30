Select * from Customers
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers
Select* from Customers where City='Berlin'
Select* from Products
Select* from Products where categoryId=1 or categoryId=3
Select* from Products where categoryId=1 and UnitPrice>=10
Select* from Products order by UnitPrice desc
Select count(*) adet from Products where CategoryID=2 
Select categoryId,count(*) adet from Products group by CategoryID
Select  categoryId,count(*) from Products where UnitPrice>20 
group by CategoryID having count(*)<10

Select * from Products inner join 