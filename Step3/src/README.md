# StepByStepCleanArchitecture

.NET Framework içinde dinamik sorgular oluşturmak için System.Linq.IQueryable<T> arayüzünü ve bu arayüzü uygulayan türleri kullanabilirsiniz. Bu teknikleri, çalışma zamanında sorgunun şeklini değiştirmek istediğiniz durumlarda kullanabilirsiniz. Örneğin, kullanıcı girdisi veya çalışma zamanı durumu, sorgunun bir parçası olarak kullanmak istediğiniz sorgu yöntemlerini değiştirebilir. İşte bu konuda bazı teknikler:

1.Çalışma Zamanı Durumunu Sorgu İçinde Kullanma:
  -Expression (ifade) ağacı: Dil bağımsız ve veri kaynağı bağımsız bir ifade ağacı şeklinde mevcut sorgunun bileşenlerini temsil eder.
  -Provider (sağlayıcı): Bir LINQ sağlayıcısının örneği, mevcut sorguyu bir değer veya değer kümesine nasıl dönüştüreceğini bilir.
  -Expression ağaçları değiştirilemez; farklı bir sorgu için mevcut ifade ağacını ve dolayısıyla sorguyu değiştirmek istiyorsanız, mevcut ifade ağacını yeni bir ifade ağacına çevirmeniz gerekir.

2.Daha Fazla LINQ Yöntemi Kullanma:
  -LINQ sorgunuzun şeklini değiştirmek için daha fazla LINQ yöntemi çağırabilirsiniz. Örneğin, Where, OrderBy, GroupBy, Select gibi yöntemleri kullanarak sorgunuzu genişletebilir veya değiştirebilirsiniz.

3.LINQ Yöntemlerine Geçirilen İfade Ağacını Değiştirme:
  -LINQ yöntemlerine geçirilen ifade ağacını değiştirerek sorgunun şeklini değiştirebilirsiniz. Örneğin, Where, OrderBy, GroupBy gibi yöntemlere farklı ifade ağaçları geçirebilirsiniz.

4.Fabrika Yöntemleri Kullanarak Expression<TDelegate> İfade Ağacı Oluşturma:
  -Expression sınıfının fabrika yöntemlerini kullanarak dinamik sorgu ifade ağaçları oluşturabilirsiniz.
