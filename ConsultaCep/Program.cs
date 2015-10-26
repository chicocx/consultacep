using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria o objeto request à partir da URL. 		
            WebRequest request = WebRequest.Create("http://solutioin.com/toth/services/cepservice/consultarcep/74460180");
            // Se necessário, é possível setar as credenciais.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Obtém a resposta.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Mostra o status.
            Console.WriteLine(response.StatusDescription);
            // Obtém o Stream.
            Stream dataStream = response.GetResponseStream();
            // Abre o Stream para leitura.
            StreamReader reader = new StreamReader(dataStream);
            // Lê o conteúdo.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Fecha os streams e response.
            reader.Close();
            dataStream.Close();
            response.Close();

        }
    }
}
