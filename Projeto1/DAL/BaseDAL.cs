using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    static class BaseDAL
    {
        //Com isto concluímos que membros declarados como static são membros da classe e não membros de instância.
        public static string connStr { get; } = "SERVER=localhost; DATABASE=hotel; UID=root; PWD=; PORT=;";
    }
}
