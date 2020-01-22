using CadenaResponsabilidad.Servicio.Interface;

namespace CadenaResponsabilidad.Servicio.Implementacion
{
    class Coordinador: Manejador
    {
        public override string VerificarAutorizacion(int _iMonto)
        {
            string cMensaje = string.Empty;
            if (_iMonto <= 5000)
                cMensaje ="Compra de aires acondicionados 'AUTORIZADA' por el Coordinador";
            else
                cMensaje= base.VerificarAutorizacion(_iMonto);
            return cMensaje;
        }
    }
}
