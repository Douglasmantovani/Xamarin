using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        JogoRepository _jogo = new JogoRepository();

        [HttpGet]
        public IActionResult ListarJogos()
        {
            try
            {
                return Ok(_jogo.ListarJogos());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
