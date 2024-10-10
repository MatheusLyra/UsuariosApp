using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Infra.Security.Settings
{
    /// <summary>
    /// Classe para configurar os parâmetros para geração do TOKEN
    /// </summary>
    public class JwtTokenSettings
    {
        /// <summary>
        /// Chave secreta para criptografia e assinatura dos TOKENS JWT
        /// </summary>
        public static string SecretKey => "F5C1DF88-F772-4427-A799-224193C2B01A";

        /// <summary>
        /// Tempo de expiração do TOKEN JWT em horas
        /// </summary>
        public static int ExpirationInHours => 1;
    }
}



