using Prueba_ejer1.Models.Exportadores;

namespace Prueba_ejer1.Models
{
    public interface IExportable
    {
        public bool Importar(string data, IExportador exportador);
        public string Exportar(IExportador exportador);
    }
}