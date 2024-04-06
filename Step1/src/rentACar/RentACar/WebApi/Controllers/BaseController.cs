using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BaseController:ControllerBase
    {
        private IMediator? _mediator;

        protected IMediator? Mediator => _mediator??= HttpContext.RequestServices.GetService<IMediator>();

    }
}

/* public class BaseController : ControllerBase: Bu satırda BaseController adında bir sınıf tanımlanıyor.
Bu sınıf, ASP.NET Core uygulamalarında diğer controller sınıflarının temelini oluşturur. ControllerBase sınıfı,
ASP.NET Core’un temel controller sınıfıdır ve HTTP isteklerini işlemek için kullanılır.*/

/*private IMediator? _mediator;: Bu satırda _mediator adında bir özel (private) alan (field) tanımlanıyor.
_mediator değişkeni, mediator pattern tasarım deseni için kullanılır. Mediator, nesneler arasındaki iletişimi kolaylaştırmak için kullanılır.
Bu örnekte, _mediator alanı muhtemelen uygulamanın içindeki farklı bileşenler arasında iletişim kurmak için kullanılıyor.*/

/*protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();: Bu satırda Mediator adında
bir property (özellik) tanımlanıyor. Bu özellik, _mediator alanını döndürür. Eğer _mediator henüz atanmamışsa,
HttpContext.RequestServices.GetService<IMediator>() ifadesi ile bir IMediator nesnesi alınır ve _mediator alanına atanır.
Bu yapı, lazy initialization (geç başlatma) prensibini kullanır.*/
