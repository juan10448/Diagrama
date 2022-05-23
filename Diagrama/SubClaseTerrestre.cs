using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class SubClaseTerrestre : SuperClaseVehiculo
    {
        private string NombreTerrestre;
        private int NumeroLlantas;

        public SubClaseTerrestre (string NombreTerrestre, int NumeroLlantas)
        {
            this.NombreTerrestre = NombreTerrestre;
            this.NumeroLlantas = NumeroLlantas;
        }
        public string getNombreTerrestre()
        {
            return NombreTerrestre;
        }
        public void setNombreTerrestre(string NombreTerrestre)
        {
            this.NombreTerrestre = NombreTerrestre;
        }
        public int getNumeroLlantas()
        {
            return NumeroLlantas
        }
        public void setNumeroLlantas(int NumeroLlantas)
        {
            this.NumeroLlantas = NumeroLlantas;
        }
            


    }
}
