using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class SubClaseColectivo : SubClaseCarro
    {
        private ColorPlaca;
        private Tiposervicio;

        public SubClaseCarro (string ColorPlaca, string Tiposervicio)
        {
            this.ColorPlaca = ColorPlaca;
            this.Tiposervicio = Tiposervicio;
        }
         public string getColorPlaca()
        {
            return ColorPlaca ;
        }
        public string setColorPlaca(string ColorPlaca  )
        {
            this.ColorPlaca = ColorPlaca  ;
        }

         public string getTiposervicio()
        {
            return Tiposervicio;
        }
        public string setTiposervicio(string Tiposervicio )
        {
            this.Tiposervicio = Tiposervicio ;
        }

        
         public string get()
        {
            return ;
        }
        public string set(string  )
        {
            this. =  ;
        }
    }
}
