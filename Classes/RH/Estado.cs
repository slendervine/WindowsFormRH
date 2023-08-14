using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsDesktopDomain
{
    public class Estado
    {
        public Estado(int id, string sigla)
        {
            this.Id = id;
            this.Sigla = sigla;
        }

        public int Id { get; set; }
        public string Sigla { get; set; }
        public static List<Estado> EstadoList { get; set; }

        static Estado()
        {
            Estado.EstadoList = new List<Estado>();
            Estado.EstadoList.Add(new Estado(1, "RS"));
            Estado.EstadoList.Add(new Estado(2, "SC"));
            Estado.EstadoList.Add(new Estado(3, "MG"));
            Estado.EstadoList.Add(new Estado(4, "SP"));
        }

    }
}
