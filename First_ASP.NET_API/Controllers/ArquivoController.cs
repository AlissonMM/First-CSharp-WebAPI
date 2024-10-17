using First_ASP.NET_API.Model;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace First_ASP.NET_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivoController : ControllerBase
    {
        [HttpGet("lerArquivo")]
        public IActionResult LerArquivo()
        {
            // Defina o caminho absoluto manualmente
            var caminhoArquivo = @"C:\Users\aliss\source\repos\First_ASP.NET_API\First_ASP.NET_API\bin\Debug\net8.0\Arquivos\resumoHobbit.txt";

            var (sucesso, linhasArquivo, quantidadeLinhas) = GerenciaArquivo.LerArquivo(caminhoArquivo);

            if (sucesso)
            {
                // Formatação da resposta corrigida
                var resposta = $"Quantidade de linhas do arquivo: {quantidadeLinhas}\n" +
                               $"Arquivo: {string.Join("\n", linhasArquivo)}";

                return Ok(resposta); // Removido o ponto e vírgula incorreto
            }
            else
            {
                return BadRequest("Erro ao ler o arquivo.");
            }
        }
    }
}
