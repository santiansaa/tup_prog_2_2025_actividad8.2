

using System.Text.RegularExpressions;

namespace Prueba_ejer1.Models.Exportadores;

public class XMLExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return $@"<Multa><Patente>{m.Patente}</Patente><Vencimiento>{m.Vencimiento}</Vencimiento><Importe>{m.Importe:f2}</Importe></Multa>";
    }

    public bool Importar(string data, Multa m)
    {
        Regex regex = new Regex(@"<Patente>([a-z]{3}\d{3})</Patente><Vencimiento>(\d{2}/\d{2}/\d{4})</Vencimiento><Importe>(\d+,\d*)</Importe>", RegexOptions.IgnoreCase);
        Match match = regex.Match(data);
        if (match.Success)
        {
            string patente = match.Groups[1].Value.ToUpper();
            DateTime fecha = Convert.ToDateTime(match.Groups[2].Value);
            DateOnly vencimiento = new DateOnly(fecha.Year, fecha.Month, fecha.Day);
            double importe = Convert.ToDouble(match.Groups[3].Value);
            m.Patente = patente; m.Importe = importe; m.Vencimiento = vencimiento;
            return true;
        }
        return false;
    }
}
