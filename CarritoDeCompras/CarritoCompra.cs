using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{


    class CarritoCompra
    {

        private List<Camisa> Camisas = new List<Camisa>();



        public void AgregarCamisa()
        {
            Camisas.Add(new Camisa());

        }

        public void EliminarCamisa()
        {
            if (Camisas.Count > 0)
                Camisas.RemoveAt(Camisas.Count - 1);

        }
        public int CantidadCamisas()
        {
            var cantidad = Camisas.Count();
            return cantidad;
        }

        public double PrecioCamisa()
        {

            if (CantidadCamisas() > 0)
                return Camisa.Precio;
            return 0.0;
        }

        public double Descuento()
        {
            int cantidad = CantidadCamisas();
            return Camisa.Descuento(cantidad);
        }
        public double PrecioTotal()
        {
            int cantidad = CantidadCamisas();
            return Camisa.PrecioTotal(cantidad);
        }
        public double PrecioTotalConDescuento()
        {
            int cantidad = CantidadCamisas();
            return Camisa.PrecioTotalConDescuento(cantidad);
        }


    }

}
