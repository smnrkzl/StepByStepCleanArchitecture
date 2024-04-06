# StepByStepCleanArchitecture
Bu adımda senkron ve asenkron işlemler gerçekleştirildi.

Senkron Yapı:
   - Senkron işlemler, adım adım ve sıralı olarak çalışan işlemlerdir. Bir işlem tamamlanmadan diğeri başlamaz. Yani, bir işlem bitmeden diğer 
     işlemler bekler.
   - Senkron yapılar, işlem sırasında bir sonraki adımın tamamlanmasını bekler ve bu süreçte iş parçacıkları (thread'ler) bloke olabilir.
   - Senkron yapılar genellikle basit ve doğrusal işlemlerde kullanılır. Örneğin, dosya okuma/yazma işlemleri, veritabanı sorguları gibi işlemler 
     senkron olarak gerçekleştirilebilir.


Asenkron Yapı:
  - Asenkron işlemler, işlemlerin aynı anda veya paralel olarak çalışmasını sağlar. Bir işlem tamamlanmadan diğer işlemler devam edebilir.
  - Asenkron yapılar, işlem sırasında diğer işlerin tamamlanmasını beklemeksizin işlem yapılmasını sağlar. Bu sayede performansı artırır ve 
    bloklamaları önler.
  - Asenkron yapılar genellikle ağ çağrıları, uzun süren işlemler, arka planda çalışan işlemler gibi durumlarda kullanılır. Bu sayede uygulama daha 
    duyarlı ve verimli hale gelir.


“async” ve “await” Nedir?:
  - “async” Anahtar Kelimesi: Bir metotun asenkron olduğunu belirtmek için kullanılır. Bir metotun “async” olarak işaretlenmesi, bu metotun içinde 
     “await” anahtar kelimesinin kullanılabileceği anlamına gelir.
  - “await” Anahtar Kelimesi: Bir asenkron metot içinde uzun süren bir işlemi işaret eder ve bu işlemin sonuçlanmasını bekler. “await” 
    kullanıldığında, iş parçacığı bu işlemi beklerken başka işlerle meşgul olabilir.

Aşağıda temel bir “async” metotun nasıl tanımlandığını ve “await” ile nasıl kullanıldığını gösteren bir örnek bulunmaktadır: 

  public async Task<string> AsenkronIslemAsync()
  {
    // Uzun süren işlemi temsil edelim
    await Task.Delay(2000); // 2 saniye boyunca bekliyoruz
    return "İşlem tamamlandı!";
   }

Yukarıdaki örnekte, “AsenkronIslemAsync” adında bir asenkron metot tanımlanmıştır. “await” ifadesi, “Task.Delay” metodu tarafından döndürülen işlemi bekler. Bu işlem, belirtilen süre boyunca iş parçacığını bloke etmeden uyur. Sonuç olarak, ana uygulama akışı bu süre boyunca tıkanmaz.

Asenkron metotları çağırmak için “await” kullanabilirsiniz. Örneğin:

   string sonuc = await AsenkronIslemAsync();
   Console.WriteLine(sonuc);

Bu kod, “AsenkronIslemAsync” metodu tamamlandığında “sonuc” değişkenine sonucu atar ve sonucu ekrana yazdırır. “Asenkron” ve “await” kullanımı, özellikle ağ çağrıları, dosya işlemleri ve diğer uzun süren işlemleri yönetmek için oldukça yaygın olarak kullanılır. Bu yapılar sayesinde uygulamanız daha hızlı ve daha duyarlı hale gelir.
   
