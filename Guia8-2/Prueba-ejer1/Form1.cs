using Prueba_ejer1.Models;
using Prueba_ejer1.Models.Exportadores;

namespace Prueba_ejer1
{
    public partial class Form1 : Form
    {
        List<IExportable> exportableslist = new List<IExportable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                IExportable nuevo = null;
                string patente = txtPatente.Text;
                DateOnly vencimiento = new DateOnly(dtpVencimiento.Value.Year, dtpVencimiento.Value.Month, dtpVencimiento.Value.Day);
                double importe = Convert.ToDouble(txtDni.Text);
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
            txtPatente.Clear();
            txtDni.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            lsbVer.Items.AddRange(exportableslist.ToArray());
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(txt)|*.txt|(xml)|*.xml";
            op.FilterIndex = 1;
            if (op.ShowDialog() == DialogResult.OK) 
            {
                int tipo = op.FilterIndex;
                string path = op.FileName;
               
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //
                ExportadorFactory factory = new ExportadorFactory();
                IExportador exportador = factory.GetInstance(tipo);

                sr.ReadLine();
                while (sr.EndOfStream) 
                {
                    string linea = sr.ReadLine();
                    IExportable nuevo = new Multa();

                    //
                    
                    nuevo.Importar(linea, exportador);
                    
                }
               
                fs.Close();
                sr.Close();
            }


        }
    }
}
