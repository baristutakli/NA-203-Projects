-- Select 
--SELECT * FROM Customers
--SELECT ContactName, CompanyName, City FROM Customers

-- WHERE
--SELECT * FROM Customers WHERE City ='London';

-- case insensitive Bütük küçük harf duyarsız
-- Id si 1 olanları getir
-- SELECT * FROM Products WHERE categoryId=1


-- Category id si 1 veya 3 olanları getirir
-- SELECT * FROM Products WHERE categoryId=1 or CategoryID =3;

-- And
--SELECT * FROM Products WHERE categoryId=1 and CategoryID >=10;

-- Önce kategori kimliğine göre daha sonra ise bu ürünleri ismine göre sıraladık
--SELECT * FROM Products ORDER BY CategoryID, ProductName

-- asc ascending = artan 

-- azalan ise desc
-- Örneğin e-ticaret sitende fiyatları azalan şekilde sıralarız
-- SELECT * FROM Products ORDER BY UnitPrice desc

-- KATEGORİ ID Sİ BİR OLAN ÜRÜNLERİ FİYATA GÖRE AZALARAK GETİRELİM
-- SELECT * FROM Products WHERE categoryId=1 ORDER BY UnitPrice desc;

-- Diyelim ki kullanıcı bir kategori seçti ve sonra artan azalanı seçti 
-- Yukarıdaki filtreleme işlemini yaparız

-- Seçilen tablodaki ürün sayısını bize getirir
-- SELECT count(*) from Products;
-- Örenğim: size kaç ürün kategori ettiğinizi sorduğunda bu şekilde filtreleyebilirsin

-- 2 numaralı kategoride bulunan ürünlerin sayısını verir.
-- SELECT count(*) FROM Products WHERE CategoryId =1;

-- Diyelim ki yönetim hangi kategorde kaç farklı ürün olduğunu sordu
-- Group by kullandığınız seçtiğiniz sutun sadece ve sadece groupby da yazdığınız alan olur
-- Bu yanlış olan  SELECT * FROM Products GROUP BY CategoryID

-- group by yaptığın zaman aslında arka tarafta her bir grup için tablo yapmış gibi düşünebilirsin
-- SELECT  categoryId,count(*) FROM Products GROUP BY CategoryId

-- Belli bir kategorideki urun sayısı belli bir değerden düşükse alacağız şimdi
-- having
-- hangi kategorilerde az ürün varsa oraları getir ve destekleyelim
-- Ürün sayısı 10 dan az olan kategorileri listele
-- SELECT  categoryId,count(*) FROM Products GROUP BY CategoryId having count(*)<10

-- Birim fiyatı 20 den fazla olan ürünleri kategori ıd ye göre grupla
-- onlardan da 10 dan az olanların sayısını getir
-- SELECT  categoryId,count(*) FROM Products WHERE UnitPrice>20 GROUP BY CategoryId having count(*)<10

-- Join  tabloları bir araya getirme işlemi
-- örneği kategori ıdsi ile kategori ismini birleştiririz
-- hem product hem  kategorilerin bir araya getirilmiş şekli

-- Burada biz diyoruz ki kategori ıd si ile product idsi aynı olan ürünlerin bilgilerini aldık
--SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--FROM Products JOIN Categories
--on Products.CategoryID = Categories.CategoryID
-- sonra foraech ile dönüp görüntüleyebiliriz
-- daha önce öğrendiklerini aynı sıra ile burada yazabilirsin Where Order gibi

---  DTO Data Transformation Object---
-- joinler yaptığımızda DTO lar çıkıyor


-- inner join -- sadece iki tabloda eşleşenleri getirir
-- eşleşmeyen data varsa onu getirmez
-- boşluk isimlendirme standartlarında doğru değil bundan dolayı 
-- köşeli parantez kullanırız
-- İki tabloyu join edeceksen iki tabloda bulunan ortak bir sutun olmalı
--SELECT * FROM Products p INNER JOIN [ORDER Details] od
--on p.ProductID = od.ProductId

-- Inner join sadece eşleşen kayıtları getir
-- Yönetim sana hiç satış yapılmayan ürünleri getir dedi
-- kalan ürünleri elden çıkarmak istiyor
-- left yaparsan Solda olup sağda olmayanları da getirir
-- Yani ürünler tablosunda var ama hiç satışı yok

--SELECT * FROM Products p LEFT JOIN [ORDER Details] od
-- on p.ProductID = od.ProductId

-- Bir diğer versiyonu hem eşleşenleri hem de eşleşmeyenleri getirmiş oluruz left ile
--SELECT * FROM Customers c left join Orders o
--on c.CustomerId = o.CustomerID
-- Yönetim dediki bizden bu aralar sistemimize kayıt olmuş ve bizden ürün almamış kişileri getir
-- onlara kampanya yapalım demiştir. Tam olarak solda olup sağda olmayanları bulmak için

--SELECT * FROM Customers c left join Orders o
--on c.CustomerId = o.CustomerID
--Where o.CustomerID is null
-- Ayrıştırmış olduk
-- null değerleri is ile kontrol ederiz

-- right join ise left in tam tersi
-- sağda olup sağda olmayan 


-- ikiden fazla tabloyu join etmek istersek
--  od order details kısaltması
--SELECT * FROM Products p LEFT JOIN [ORDER Details] od
--on p.ProductID = od.ProductId
--inner join Orders o 
--on o.OrderID = od.OrderID







