namespace First_ASP.NET_API.Model
{
    public class GerenciaArquivo
    {
        public static (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminhoArquivo)
        {

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                return(true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }

        }


    }
}
