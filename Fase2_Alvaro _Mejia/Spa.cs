using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2_Alvaro__Mejia
{
    class Spa
    {

        public string identificacion { get; set; }

        public string nomPro { get; set; }

        public string nomMas { get; set; }

        public int estrato { get; set; }

        public string tipser { get; set; }

        // Método para calcular

        int costo;
        double descuento;
        double total;

        private void setCosto()
        {
            
            switch (tipser)
            {
                case "45000":
                    costo = 45000;
                    break;

                case "80000":
                    costo = 80000;

                    break;

                case "100000":
                    costo = 100000;

                    break;
            }



        }
        public int getCosto()
        {
            setCosto();
            return costo;
        }

        private void setDescuento()
        {
            if(estrato == 1 || estrato == 2)
            {
                descuento = costo * 0.15;
            }
            else if(estrato ==3 || estrato == 4)
            {
                descuento = costo * 0.10;
            }
            else
            {
                descuento = costo * 0.05;
            }
        }
        public double getDescuento()
        {
            setDescuento();
            return descuento;
        }

       
        private void setTotal()
        {
            total = costo - descuento;
        }
        public double getTotal()
        {
            setTotal();
            return total;
        }
        

    }
}
