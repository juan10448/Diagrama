using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class SubClaseCarro : SubClaseTerrestre
    {
        private string NombreCarro;
        private string TipoCarro;
        private string Tamaño;

        public SubClaseCarro (string NombreCarro, string TipoCarro, string Tamaño)
        {
            this.NombreCarro = NombreCarro;
            this.TipoCarro = TipoCarro;
            this.Tamaño = Tamaño;
        }
        public string getNombreCarro()
        {
            return NombreCarro;
        }
        public string setNombreCarroo(string NombreCarro )
        {
            this.NombreCarro = NombreCarro ;
        }
        public string getTipoCarro()
        {
            return ;
        }
        public string setTipoCarro(string TipoCarro )
        {
            this.TipoCarro = TipoCarro ;
        }
         public string getTamaño()
        {
            return Tamaño;  
        }
        public string setTamaño(string Tamaño )
        {
            this.Tamaño = Tamaño ;
        }








    }
}
