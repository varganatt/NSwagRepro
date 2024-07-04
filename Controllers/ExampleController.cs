using Microsoft.AspNetCore.Mvc;

namespace NSwagRepro.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    
    [HttpGet()]
    public NestedData Get()
    {
        return new NestedData();
    }
}
