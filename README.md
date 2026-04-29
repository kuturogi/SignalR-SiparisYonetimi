#  SignalR
Bu proje My Yazılım Akademi Bünyesinde Murat Yücedağ Eğitmenliği tarafından  Udemy üzerinde yayınlnamış SignalR Projesidir.
 ASP.NET Core 8.0 Web API ve MVC kullanılarak geliştirdiğim proje, tüm CRUD işlemlerini API üzerinden gerçekleştirir ve bu işlemler MVC tarafında consume edilir. Dinamik veritabanı yönetimi için Entity Framework Code First kullanılmıştır.
Onion Architecture mimari yapısı ve Repository design pattern ,CQRS ,Mediator kullanılarak projede uygulanarak kodun daha modüler ve sürdürülebilir olmasına öncelik verilmiştir.


# Projeye Genel Bakış

- 🖱️ Admin Paneli: CRUD işlemlerine sahip olan admin paneli, Adminin  rezervasyonları onaylama veya iptal etme,rezervasyon istatistik ,bildirim kısımlarını SignalR ile anlık olarak çekme aktif ve pasif yapabilme,mail gönderebilme ayarlar ,hakkımda,kategoriler vb. kolayca girebilecekleri ve güncelleyebilecekleri bir ortam sağlar.
- 👤 Kullanıcı Arayüzü: Şık ve duyarlı bir tasarım, ziyaretçilere yemek sipariş etmek, admin ile mesajlaşmak,rezervasyon oluşturmak,be özel mesaj göndermek için  için gerekli işlemleri etkileyici bir şekilde sunuyor.


# Projenin Amacı
Müşteriler web üzerinden yemek sipariş verebilir,sipariş özetini görebilir.
Rezervasyon oluşturabilir ve Bize ulaşın alanı ile mesaj yollayabilir, SignalR sayesinde admin ile anlık mesajlaşabilir.
 Adminle SignalR ile anlık olarak Rezervasyonları,Bildirimleri,İstatislikleri görebilir,ve müşteriyle mesajlaşabilir..
 Diğer sayfalarla alakalı crud işlemleri gerçekleştirebillir.



# Kullanılan Teknolojiler ve Uygulamalar

- 🤖 .NET Core 8.0 MVC ve API - ✅
- 🖼️ CQRS, Mediator ve Repository tasarım desenleri - ✅
- 🎡 Onion Architecture ile katmanlı mimari - ✅
-👨🏻💻 Dinamik Admin Paneli - ✅
- ☑️ Auto Mapper -(nesne eşlemesi (object-to-object mapping) işlemini kolaylaştırmak için kullanılan bir kütüphanedir) ✅
- 🔐 Identity -(NET Core tabanlı web uygulamalarında kullanıcı kimlik doğrulama ve yetkilendirme işlemlerini sağlayan bir çerçevedir) ✅
- 📡 SignalR -(gerçek zamanlı web uygulamaları geliştirmek için kullanılan bir ASP.NET Core kütüphanesidir) ✅
- 🗃️  Microsoft SQL Server (MSSQL) Veritabanı->Veritabanı yönetimi ve depolama için kullanıldı. ✅
- 🎨 HTML-CSS-Bootstrap (Arayüz tasarımı için) - ✅
- 🖌️ JS - ✅
- ⌨️ LINQ - ✅
- 📃 MailKit- ✅
- 🛠️ Projede ek olarak;
- ♦️ Real-Time Mesajlaşma✅
- ♦️ Real-Time İstatistik✅
- ♦️ Real-Time Bildirim✅
- ♦️ Ajax ile hızlı ve etkileşimli kullanıcı deneyimi(sepete ürün eklerken,admine mesaj yollarken kullanıldı.)✅
- ♦️ Basket ve Rezervasyon İşlemleri✅
- ♦️ Mail Gönderme İşlemleri bulunmaktadır.✅
