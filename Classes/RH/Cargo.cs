using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsDesktopDomain
{
    public class Cargo
    {
        public Cargo(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public static List<Cargo> CargoList { get; set; }

        static Cargo()
        {
            Cargo.CargoList = new List<Cargo>();
            Cargo.CargoList.Add(new Cargo(1, "Desenvolvedor Junior"));
            Cargo.CargoList.Add(new Cargo(2, "Desenvolvedor Pleno"));
            Cargo.CargoList.Add(new Cargo(3, "Desenvolvedor Sênior"));
            Cargo.CargoList.Add(new Cargo(4, "DevOps"));

        }
    }
}
