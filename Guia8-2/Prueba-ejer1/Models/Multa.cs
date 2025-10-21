using Prueba_ejer1.Models.Exportadores;

namespace Prueba_ejer1.Models;

public class Multa:IExportador,IExportable

{
    public string Patente { get; set; }
    public double Importe { get; set; }
    public DateOnly Vencimiento { get; set; }
    public Multa(string patente, double importe, DateOnly V)
    {
        Patente = patente;
        Importe = importe;
        Vencimiento = V;
    }
    public Multa()
    {

    }

    public bool Importar(string data, IExportador exportador)
    {
        return exportador.Importar(data, this);
    }

    public string Exportar(IExportador exportador)
    {
        return exportador.Exportar(this);
    }

    public override string ToString()
    {
        return $"Patente: {Patente}, " +
            $"Importe: {Importe}, " +
            $"Vencimiento: {Vencimiento:dd/MM/yyyy}";
    }

    public int CompareTo(object obj)
    {
        Multa multa = obj as Multa;
        if (multa != null)
            return Patente.CompareTo(Importe);
        return -1;
    }

    string IExportador.Exportar(Multa multa)
    {
        throw new NotImplementedException();
    }

    bool IExportador.Importar(string data, Multa multa)
    {
        throw new NotImplementedException();
    }
}
