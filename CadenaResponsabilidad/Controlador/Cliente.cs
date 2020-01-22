using CadenaResponsabilidad.Servicio.Implementacion;
using System;

namespace CadenaResponsabilidad.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cMonto = string.Empty,cMensaje=string.Empty;
            int iMonto = 0;
            var Coordinador = new Coordinador();
            var Gerente = new Gerente();
            var Subdirector = new Subdirector();
            var Director = new Director();

            Coordinador.Siguiente(Gerente);
            Gerente.Siguiente(Subdirector);
            Subdirector.Siguiente(Director);

            Console.WriteLine("Para salir ingrese 'x'\nIngrese el monto a validar\n");
            while (cMonto!="x")
            {
                cMonto = Console.ReadLine();
                if (cMonto != "x")
                {
                    Int32.TryParse(cMonto, out iMonto);
                    cMensaje = Coordinador.VerificarAutorizacion(iMonto);
                    Console.WriteLine(cMensaje);
                }
            }
        }
    }
}
