using Microsoft.AspNetCore.Mvc;
namespace DockerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class testController
    {
        public testController()
        {
        }

        [HttpGet]
        public string test()
        {
            return "test_111";
        }
    }
}