using Microsoft.AspNetCore.Mvc;

namespace First_ASP.NET_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        //define um endpoint de método GET
        [HttpGet("ObterDataHoraAtual")]

        // O tipo de retorno IActionResult
        // permite flexibilidade ao
        // retornar diferentes tipos de respostas HTTP.
        public IActionResult ObterDataHora() {

            //Objeto anonimo direto
            var obj = new
            {
                //Obtem a data e horas atuais do sistema
                Data = DateTime.Now.ToLongDateString(),

                // retorna apenas a hora em um formato simplificado.
                Hora = DateTime.Now.ToShortTimeString(),
            };

            //usado para gerar uma resposta HTTP 200 OK.
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            string mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(mensagem);
        }
    }
}
