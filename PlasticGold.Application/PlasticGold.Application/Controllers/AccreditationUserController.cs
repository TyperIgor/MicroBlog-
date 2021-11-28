using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PlasticGold.Services.Common.Enum;
using PlasticGold.Application.Messages;
using PlasticGold.Application.Services.Interfaces;

namespace PlasticGold.Application.Controllers
{
    [ApiController]
    [Route("api/v1/accreditation")]
    [Produces("application/json")]
    public class AccreditationUserController : Controller
    {
        private readonly IAppManagerUserAcess _appManagerUserAcess;

        public AccreditationUserController(IAppManagerUserAcess appManagerUserAcess)
        {
            _appManagerUserAcess = appManagerUserAcess;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Just check if it is working");
        }

        [HttpPost]
        [Route("/userverification")]
        public async Task<ActionResult<UserResponse>> PostUserCheck([FromBody] UserEmailRequest email)
        {
            if (email == null)
                return BadRequest();

            var mapperEmailRequest = email.Email;

            var result = await _appManagerUserAcess.UserServicesVerification(mapperEmailRequest);

            return Ok(result);
        }

        [HttpPost]
        [Route("/userregistration")]
        public async Task<IActionResult> Post([FromBody] UserRequest request)
        {
            if (request == null)
                return BadRequest();

            //var result = await _appManagerUserAcess.UserServicesAccreditation();
            return NotFound("Not functional Yet");
        }
    }
}
