
namespace araldor.ZetaAccountant.WebApp;

public class WebAppAuthorizationAttribute: System.Attribute
{
    private readonly IHttpContextAccessor _contextAccessor;

    public WebAppAuthorizationAttribute(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;

        // Verifica la presenza del token nella richiesta
        if (_contextAccessor.HttpContext.Request.Headers.ContainsKey("jwt"))
        {

        }
    }

}

