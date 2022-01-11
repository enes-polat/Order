Projede database oluşturmak için 'ECommerce.Web.API' projesinin içinde 'appsettings.json' dosyasını açınız.
'ConnectionStrings' içindeki 'Server Name' alanını kendi bilgisayırınızın 'Server Name' ile değiştirin.
 Menüden 'Tool > NuGet Package Manager > Package Manager' Console girin
Default project olarak 'ECommerce.Data' projesini seçin
' update-database ' komutunu yazıp enter'e basınız.

Oluşan ECommerce adındaki dataBase nin içinde product, customer ve customerAddres tablolarında birer adet kayıt oluşacaktır.
Migration ile oluşturulan Id'si 1 olan Product ile işlem yapılır, 1 değerinden farklı değer girilirse yeni Product oluşturur.
Migration ile oluşturulan Id'si 1 olan Customer ile işlem yapılır, 1 değerinden farklı değer girilirse yeni Customer oluşturur.
Migration ile oluşturulan Id'si 1 olan CustomerAddress ile işlem yapılır, 1 değerinden farklı değer girilirse yeni CustomerAddress oluşturur.

Projede n-tier architecture, .netCore 5.0, EFCore 5.0.12, generic repository, serilog, automapper, fluentValidation, xUnitTest ve docker teknoloji ve yaklaşımları kullanılmıştır.
