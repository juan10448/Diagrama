using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class SuperClaseVehiculo
    {
        private string NombreVehiculo;
        private string TipoMotor;
        private int NumeroPersonas;


        public SuperClaseVehiculo(string NombreVehiculo, string TipoMotor, int NumeroPersonas)
        {
            this.NombreVehiculo = NombreVehiculo;
            this.TipoMotor = TipoMotor;
            this.NumeroPersonas = NumeroPersonas;
        }
        public string getNombreVehiculo()
        {
            return NombreVehiculo;
        }
        public void setNombreVehiculo(string NombreVehiculo)
        {
            this.NombreVehiculo = NombreVehiculo;
        }
        public string getTipoMotor()
        {
            return TipoMotor;
        }
        public void setTipoMotor (string TipoMotor )
        {
            this.TipoMotor = TipoMotor;
        }

        public int getNumeroPersonas(int NumeroPersonas)
        {
            return NumeroPersonas;
        }
        public void setNumeroPersonas(int NumeroPersonas)
        {
            this.NumeroPersonas = NumeroPersonas;
        }
    }
}
