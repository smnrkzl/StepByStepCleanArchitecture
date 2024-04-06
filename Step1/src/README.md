# StepByStepCleanArchitecture
Bu adımda Clean Architecture yapısına ait katmanlar oluşturuldu ve CQRS yapısı projeye implementasyonu yapıldı.

1.Domain Katmanı:
   - Temel iş mantığını ve domain modellerini içerir.
   - Genellikle veritabanı veya dış dünya bağımlılıklarından arındırılmıştır.
   - Temel domain modelleri, değer nesneleri, kurallar ve iş süreçleri burada tanımlanır.
   - Örnek olarak, bir e-ticaret uygulamasında Product ve Order gibi temel domain modelleri burada yer alabilir.


2.Persistence (Veritabanı Erişim) Katmanı:
   - Veritabanı işlemlerini yönetir ve veritabanı ile iletişimi sağlar.
   - ORM (Object-Relational Mapping) araçlarını kullanarak veritabanı işlemlerini gerçekleştirir.
   - Veritabanı tablolarıyla domain modelleri arasında dönüşümleri sağlar.
   - Veritabanı bağlantıları, sorguları ve işlemleri bu katmanda yer alır.


3.Application Katmanı:
   - Uygulama mantığını içerir ve iş süreçlerini yönetir.
   - Kullanıcı isteklerini alır, işler ve uygun iş mantığını uygular.
   - Domain katmanı ile etkileşim kurarak iş mantığını gerçekleştirir.
   - Servis sınıflarını kullanarak iş mantığını modüler hale getirir.


4.Web API (Sunum) Katmanı:
   - Kullanıcı arayüzüne odaklanır ve dış dünya ile iletişimi sağlar.
   - HTTP isteklerini alır, işler ve uygun servis katmanı ile etkileşim kurar.
   - RESTful API'lar veya GraphQL gibi servisler sağlayarak dış dünyaya hizmet verir.
   - Kullanıcı isteklerine cevaplar üretir ve geri gönderir.


5.Infrastructure (Altyapı) Katmanı:
   - Dış dünya ile etkileşimi yönetir ve altyapısal görevleri gerçekleştirir.
   - Veritabanı bağlantıları, harici servis entegrasyonları, loglama, caching gibi altyapısal konular burada yer alır.
   - Dependency Injection, konfigürasyon yönetimi ve diğer altyapısal detaylar bu katmanda ele alınır.



CQRS (Command Query Responsibility Segregation), bir yazılım mimarisi desenidir ve genellikle .NET uygulamalarında kullanılır. Bu desen, veri okuma (query) işlemlerini ve veri yazma (command) işlemlerini farklı model ve işlemlerle ele almayı önerir. İşte CQRS yapısının temel prensipleri ve neden kullanıldığına dair açıklamalar:

1.Komut ve Sorgu Ayrımı (Command Query Separation):
   - Veri yazma (komut) işlemleri ve veri okuma (sorgu) işlemleri farklı model ve işlemlerle ele alınır.
   - Komutlar (commands), veri değişikliği yapmak için kullanılırken; sorgular (queries), veriyi okumak için kullanılır.


2.Farklı Model ve İşlemler:
   - Komutlar ve sorgular için farklı model ve işlemler kullanılır.
   - Komutlar genellikle iş mantığını ve veri değişikliğini içeren karmaşık operasyonları gerçekleştirirken; sorgular basit veri okuma işlemlerini
    gerçekleştirir.

3.Loosely Coupled (Gevşek Bağlılık):
   - CQRS, komut ve sorgu işlemlerini ayrı ayrı ele alarak bileşenler arasındaki bağımlılığı azaltır.
   - Bu sayede uygulama daha modüler hale gelir ve geliştirme süreçleri kolaylaşır.
