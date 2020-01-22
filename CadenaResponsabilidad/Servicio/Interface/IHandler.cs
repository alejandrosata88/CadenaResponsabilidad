namespace CadenaResponsabilidad.Servicio.Interface
{
    public interface IHandler
    {
        IHandler Siguiente(IHandler hanler);

        string VerificarAutorizacion(int _iMonto);
    }
}
