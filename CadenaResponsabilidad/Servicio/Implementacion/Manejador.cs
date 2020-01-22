namespace CadenaResponsabilidad.Servicio.Interface
{
    public abstract class Manejador: IHandler
    {
        private IHandler _siguienteHandler;

        public IHandler Siguiente(IHandler _IHandler)
        {
            this._siguienteHandler = _IHandler;
            return _IHandler;
        }

        public virtual string VerificarAutorizacion(int _iMonto)
        {
            string cMensaje = string.Empty;
            if(this._siguienteHandler!=null)
            {
                cMensaje = this._siguienteHandler.VerificarAutorizacion(_iMonto);
            }
            else
            {
                cMensaje = null;
            }
            return cMensaje;
        }     
    }
}
