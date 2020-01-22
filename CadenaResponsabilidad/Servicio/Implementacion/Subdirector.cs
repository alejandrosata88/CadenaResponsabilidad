
using CadenaResponsabilidad.Servicio.Interface;

namespace CadenaResponsabilidad.Servicio.Implementacion
{
    class Subdirector : Manejador
    {
        public override string VerificarAutorizacion(int _iMonto)
        {
            string cMensaje = string.Empty;
            if (_iMonto > 10000 && _iMonto <= 15000)
                cMensaje = "Compra de aires acondicionados 'AUTORIZADA' por el subdirector";
            else
                cMensaje = base.VerificarAutorizacion(_iMonto);
            return cMensaje;
        }
    }
}
