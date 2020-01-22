using CadenaResponsabilidad.Servicio.Interface;

namespace CadenaResponsabilidad.Servicio.Implementacion
{
    class Director : Manejador
    {
        public override string VerificarAutorizacion(int _iMonto)
        {
            string cMensaje = string.Empty;
            if (_iMonto > 15000 && _iMonto <= 50000)
                cMensaje = "Compra de aires acondicionados 'AUTORIZADA' por el director";
            else
                cMensaje = "Compra de aires acondicionados 'RECHAZADA' por el director";
            return cMensaje;
        }
    }
}
