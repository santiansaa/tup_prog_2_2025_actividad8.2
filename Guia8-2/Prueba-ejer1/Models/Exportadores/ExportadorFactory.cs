namespace Prueba_ejer1.Models.Exportadores;

public class ExportadorFactory
{
    public IExportador GetInstance(int tipo)
    {
        if (tipo == 1)
        {
            return new CSVExportador();
        }
        else if (tipo == 2)
        {
            return new XMLExportador();
        }
        else if (tipo == 3)
        {
            return new CampoFijoExportador();
        }
        else if (tipo == 4)
        {
            return new JSONExportador();
        }
        return null;
    }
}
