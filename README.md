# StepByStepCleanArchitecture
StepByStepCleanArchitecture With .NET


Clean Architecture Nedir?

Clean Architecture, yazılım sistemlerinin farklı bileşenlerinin sorumluluklarını ayırarak daha bakımı kolay, test edilebilir ve ölçeklenebilir bir kod tabanı oluşturma amacına odaklanan bir yazılım tasarım prensibidir. Robert C. Martin tarafından 2017 yılında geliştirilen bu mimari, yazılım karmaşıklığını azaltmak ve daha sağlam ve sürdürülebilir sistemler oluşturmak için bir dizi kural ve ilke sunar.

Clean Architecture'ın Temel İlkeleri:
   1. Ayrımcılık (Separation of Concerns): Uygulamanın sorumlulukları, açıkça tanımlanmış sınırları olan ayrı katmanlara bölünür. Her katmanın kendine özgü bir görevi vardır ve diğer katmanlarla 
    minimum düzeyde bağlantı kurar.
   2. Bağımlılık Kuralı (Dependency Rule): Katmanlar arasındaki bağımlılıklar tek yönlü olmalıdır. Üst katmanlar alt katmanlara bağımlı olmalı, alt katmanlar ise üst katmanlara bağımlı 
    olmamalıdır. Bu, katmanların birbirinden bağımsız olarak geliştirilmesine ve test edilmesine olanak tanır.
   3.Soyutlama (Abstraction): Katmanlar arasındaki iletişim, soyut arayüzler aracılığıyla yapılmalıdır. Bu, somut uygulama ayrıntılarını gizler ve katmanların birbirinden bağımsız olarak 
    değiştirilmesine olanak tanır.
   4.İçten Dışa (Inside-Out): Uygulama, dış çerçevelere veya veritabanlarına değil, iç iş mantığına odaklanmalıdır. Dış unsurlar, soyut arayüzler aracılığıyla uygulamaya dahil edilir.


Clean Architecture Katmanları:
 Clean Architecture, uygulamayı dört ana katmana ayırır:
   1. Domain Katmanı (Core):
     -Uygulamanın temel iş mantığını ve domain modellerini içerir.
     -Domain nesnelerini (entity) ve kurallarını temsil eden modeller tanımlar.
     -Veritabanı, web çerçevesi veya diğer dış sistemlerden bağımsızdır.

   2. Application Katmanı:
     -Domain katmanında tanımlanan iş mantığını kullanır ve kullanıcı taleplerini karşılar.
     -Kullanıcı taleplerini işleme, domain katmanıyla etkileşim kurma ve sunum katmanına sonuçları iletme gibi sorumlulukları vardır.
     -Domain katmanına bağımlıdır.

   3. Infrastructure Katmanı:
     -Veri erişimi, mesajlaşma, dış sistemlerle entegrasyon gibi teknik detayları ele alır.
     -Veritabanları, web sunucuları, mesaj kuyrukları gibi altyapı bileşenlerini yönetir.
     -Domain ve application katmanlarına abstractions sunarak teknik detayları gizler.
     -Domain ve application katmanlarına bağımlı değildir.

  4. Presentation Katmanı:
    -Kullanıcı arayüzünü (web UI, mobil uygulama vb.) ele alır ve kullanıcı ile sistem arasındaki etkileşimi sağlar.
    -Kullanıcı arayüzü öğelerini oluşturma, kullanıcı girdilerini işleme ve application katmanıyla etkileşim kurma gibi sorumlulukları vardır.
    -Application katmanına bağımlıdır.


Clean Architecture'ın Faydaları:

   1.Bakımı Kolaylaştırır: Modüler yapısı sayesinde kodun anlaşılması, değiştirilmesi ve genişletilmesi kolaylaşır.
   2.Test Edilebilirliği Artırır: İş mantığı core katmanda izole edildiği için birim testleri daha kolay hale gelir.
   3.Esneklik Sağlar: Belirli teknolojilere bağımlı olmadığından farklı veritabanları, çerçeveler ve platformlarla entegrasyona izin verir.
   4.Tekrar Kullanılabilirliği Artırır: Core katmandaki bileşenler, benzer iş mantığı paylaşan farklı projelerde tekrar kullanılabilir.
