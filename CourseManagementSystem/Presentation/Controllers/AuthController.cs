using CourseManagementSystem.Application.Features.Students.Commands.RegisterStudent;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementSystem.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("register-student")]
        public async Task<IActionResult> RegisterStudent([FromBody] RegisterStudentCommand command)
        {
            var studentId = await _mediator.Send(command);
            return Ok();
        }
    }
}
