using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
          CreatedBrandResponse response =  await Mediator.Send(createBrandCommand);
            return Ok(response);
        }
    }
}

/*
[Route("api/[controller]")]: Bu satır, bu controller sınıfının API rotasını belirtir. Yani bu controller,
/api/brands yolunu kullanarak erişilebilir. [controller] ifadesi, sınıf adının sonundaki “Controller” kelimesini 
çıkararak otomatik olarak yerine konur.

[ApiController]: Bu satır, bu sınıfın bir API controller olduğunu belirtir. Bu özellik, ASP.NET Core tarafından otomatik olarak bazı
özellikleri etkinleştirir. Örneğin, model bağlama (model binding) ve hata yönetimi gibi işlemleri kolaylaştırır.

public class BrandsController : BaseController: Bu satırda BrandsController adında bir sınıf tanımlanıyor. Bu sınıf, BaseController
sınıfından türetilmiştir. BaseController, temel controller işlevlerini içerir ve bu sınıfın ortak özelliklerini sağlar.

[HttpPost]: Bu satır, bu metotun HTTP POST isteklerini işleyeceğini belirtir. Yani bu metot, yeni bir marka oluşturmak için kullanılabilir.

public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand): Bu satırda Add adında bir asenkron metot tanımlanıyor.
Bu metot, CreateBrandCommand tipinde bir parametre alır. Bu parametre, HTTP isteği gövdesinden gelen veriyi temsil eder. Metot, 
bir IActionResult döndürür. Bu, HTTP isteğine yanıt olarak döndürülecek sonucu ifade eder.

CreatedBrandResponse response = await Mediator.Send(createBrandCommand);: Bu satırda Mediator aracılığıyla createBrandCommand komutunu
göndererek bir CreatedBrandResponse nesnesi alınır. Bu nesne, yeni oluşturulan markanın bilgilerini içerir.

return Ok(response);: Bu satır, HTTP isteğine başarılı bir yanıt döndürmek için kullanılır. Ok ifadesi, HTTP durum kodu 200 ile yanıt verir ve response nesnesini içerir.
*/
