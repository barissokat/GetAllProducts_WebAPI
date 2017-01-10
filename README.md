# GetAllProduct_WebAPI

<h3>Bu proje ASP.NET MVC projelerinde Web API'nin nasıl kullanılabileceğine yönelik konunun kavranması amacıyla yapılmıştır.</h3>

## Özet

ASP.Net MVC projelerinde Web API uygulaması farklı şekillerde oluşturulabilir. Bunlardan biri her iki projeyi farklı projelerde oluşturmak, ikincisi her iki proje aynı proje içinde yani tek proje olarak oluşturmaktır. Bu proje için ortak tek proje yöntemi seçilmiştir. Bu projede bir modelde tutulan ürün listelerinin Web API yardımıyla listelenmesi konusu ele alınmıştır.

## Web API'nin Test Edilmesi

#### Tüm Ürünleri Listelemek

Ürün bilgilerinin kayıt altında tutulduğu projeden, Web API yardımıyla tüm ürünlerin çekilip liste halinde sayfaya yazdırılacağı düşünülmüştür. 

İlk olarak tüm ürünleri listeleyecek sayfa açılır.

![alt tag](https://github.com/bsokat/GetAllProducts_WebAPI/blob/master/Source/GetAllProducts1.png)

Daha sonra **Ürünleri Listele** butonuna basılarak tüm ürünlerin listelenmesi sağlanır.

![alt tag](https://github.com/bsokat/GetAllProducts_WebAPI/blob/master/Source/GetAllProducts1.png)

#### Girilen Id'ye Sahip Ürünü Getirme

Getirilmesi istenilen id'ye sahip ürünün, id girilmesiyle tüm ürünlerin bulunduğu projeden çekilerek sayfaya yazdırılacağı düşünülmüştür.

İlk olarak ürünün yazdırılacağı sayfa açılır sayfa açılır.

![alt tag](https://github.com/bsokat/GetAllProducts_WebAPI/blob/master/Source/GetWithId1.png)

Daha sonra istenilen **Id** textbox'a yazılarak **Ürünü Getir** butonuna basılarak, o Id'ye sahip ürünün sayfaya yazdırılması sağlanır.

![alt tag](https://github.com/bsokat/GetAllProducts_WebAPI/blob/master/Source/GetWithId2.png)

Eğer girilen Id'ye sahip ürün, tüm ürünler listesinde bulunmuyorsa, aşağıdaki ekran görüntüsü gibi hata mesajı sayfada gösterilir.

![alt tag](https://github.com/bsokat/GetAllProducts_WebAPI/blob/master/Source/GetWithId3.png)