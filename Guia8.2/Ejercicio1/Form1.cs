using Ejercicio1.Models;
using Ejercicio1.Models.Exportadores;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<IExportable> exportableslist = new List<IExportable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(exportableslist.ToArray());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                IExportable nuevo = null;
                string patente = tbPatente.Text;
                DateOnly vencimiento = new DateOnly(dtpVencimiento.Value.Year, dtpVencimiento.Value.Month, dtpVencimiento.Value.Day);
                double importe = Convert.ToDouble(tbImporte.Text);
                nuevo = new Multa(patente, importe, vencimiento);
                exportableslist.Sort();
                int idx = exportableslist.BinarySearch(nuevo);
                if (idx >= 0)
                {
                    Multa? multa = exportableslist[idx] as Multa;
                    multa.Importe += importe;
                    if (multa.Vencimiento < ((Multa)nuevo).Vencimiento)
                    {
                        multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                    }
                    btnActualizar.PerformClick();
                }
                else
                {
                    exportableslist.Add(nuevo);
                }
                lsbVer.Items.Add(nuevo);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbImporte.Clear();
            tbPatente.Clear();
        }





        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(txt)|*.txt|(xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;

                IExportador exportador = (new ExportadorFactory()).GetInstance(tipo);

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    //descarto la cabecera
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        IExportable nuevo = new Multa();

                        if (nuevo.Importar(linea, exportador) == true)
                        {
                            int idx = exportableslist.BinarySearch(nuevo);
                            if (idx >= 0)
                            {
                                Multa multa = exportableslist[idx] as Multa;
                                multa.Importe += ((Multa)nuevo).Importe;
                                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                            }
                            else
                                exportableslist.Add(nuevo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();
                }
            }
            btnActualizar.PerformClick();
        }

        private void lsbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Multa selected = listBox1.SelectedItem as Multa;
            if (selected != null)
            {
                tbPatente.Text = selected.Patente;
                dtpVencimiento.Value = selected.Vencimiento.ToDateTime(new TimeOnly(0, 0));
                tbImporte.Text = selected.Importe.ToString("f2");
            }
        }
    }

}

   
    
