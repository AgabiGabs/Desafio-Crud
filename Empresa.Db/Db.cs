using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    //Helper Para acesso a Dados
    public static class Db
    {
        public  static string Conexao
        {
            get { return @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = EmpresaTeste; Integrated Security = True;"; }
        }
    }
}
