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

        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] UserRequest request)
        //{
        //    if (request == null)
        //        return BadRequest();

        //    //var result = await _appManagerUserAcess.UserServicesAccreditation();

        //    return NotFound("Not functional Yet");
        //}

        [HttpPost]
        public async Task<ActionResult<UserResponse>> PostUserCheck([FromBody] string email)
        {
            if (email == null)
                return BadRequest();

            var mapperEmailRequest = new UserEmailRequest() { Email = email };

            var result = await _appManagerUserAcess.UserServicesVerification(mapperEmailRequest.Email);

            return Ok(result);
        }
    }
}
