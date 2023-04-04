Bu projede Temel MVC ve API için CRUD işlemleri yapılmıştır.

Not:Tablolar ilişkili olduğundan dolayı Kullanıcı kaydı yapmak için öncelikle veritabanından tarnier,course ve salon tablolarını doldurmanız gerekmektedir,
Aksi takdirde kullnıcı kaydı yapılmaz sadece kullanıcı için mvc controller ve api controller oluşturulmuştur.

Veritabanı bağlantısı Entity Framework CodeFirst ile yapıldığından GYM.DataAccessLayer,GYM.DataAccessLayer.Asyn içerisinde bulunan GymDbContext içerisindeki "Data Source" kısmına kendi veritabnı isminiz girip package manager console üzerinden update-database komutunu çalıştırdığınızda sql tabloları otomatik olarak veri tabanında oluşturulaaktır.
Katmanlı mimari kullanılmayan projelerde  GymDbContext model klasörü içerisinde yer almaktadır.


MVC ve API teknolojilerinde ayrıca katmanlı mimari ve asenkron programlama kullanılmış olup 6 proje oluşturulmuştur.
1. Proje sadece ASP.NET CORE MVC
2. Proje sadece ASP.NET CORE WEB API
3. Proje ASP.NET CORE MVC KATMANLI MIMARI
4. Proje ASP.NET CORE WEB API KATMANLI MIMARI
5. Proje ASP.NET CORE MVC KATMANLI MIMARI ASENKRON PROGRAMLAMA
6. Proje ASP.NET CORE WEB API KATMANLI MIMARI ASENKRON PROGRAMLAMA

Bu proje zaman bulundukça yeni teknolojilerin sırayla eklenmesi ile gücellenecektir.
