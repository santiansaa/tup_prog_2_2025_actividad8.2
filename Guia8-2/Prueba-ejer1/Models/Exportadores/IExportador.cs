namespace Prueba_ejer1.Models.Exportadores
{
    public interface IExportador
    {
        string Exportar(Multa multa);
        bool Importar(string data, Multa multa);
    }
}