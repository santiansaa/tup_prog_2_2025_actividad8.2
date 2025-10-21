

using System.Globalization;

namespace Prueba_ejer1.Models.Exportadores;

public class CampoFijoExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return $@"{m.Patente}   {m.Vencimiento}   {m.Importe:f2}";
    }

    public bool Importar(string data, Multa m)
    {
        try
        {
            string patente = data.Substring(0, 9);

            string day = data.Substring(9, 2);
            string month = data.Substring(12, 2);
            string year = data.Substring(15, 4);
            string fechaStr = $"{day}/{month}/{year}";

            string importeStr = data.Substring(19);
            DateTime fecha = DateTime.ParseExact(fechaStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateOnly vencimiento = new DateOnly(fecha.Year, fecha.Month, fecha.Day);
            double importe = Convert.ToDouble(importeStr.Replace(',', '.'), CultureInfo.InvariantCulture);

            m.Patente = patente;
            m.Vencimiento = vencimiento;
            m.Importe = importe;

            return true;
        }
        catch
        {
            return false;
        }

    }
}
