using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Permissionamento.Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtService jwtService;

        public AuthController(JwtService jwtService)
        {
            this.jwtService = jwtService ?? throw new ArgumentNullException(nameof(jwtService));
        }
        [HttpGet()]
        public ActionResult<string> Get()
        {
            return jwtService.GerarToken(new string[] { "School_A", "school-D" });
        }
    }
}
