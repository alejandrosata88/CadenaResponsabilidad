using CadenaResponsabilidad.Servicio.Interface;

namespace CadenaResponsabilidad.Servicio.Implementacion
{
    class Gerente : Manejador
    {
        public override string VerificarAutorizacion(int _iMonto)
        {
            string cMensaje = string.Empty;
            if (_iMonto > 5000 && _iMonto <= 10000)
                cMensaje = "Compra de aires acondicionados 'AUTORIZADA' por el gerente";
            else
                cMensaje = base.VerificarAutorizacion(_iMonto);
            return cMensaje;
        }
    }
}
