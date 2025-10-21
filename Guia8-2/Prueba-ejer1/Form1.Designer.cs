namespace Prueba_ejer1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPatente = new TextBox();
            txtDni = new TextBox();
            dtpVencimiento = new DateTimePicker();
            lsbVer = new ListBox();
            btnImportar = new Button();
            btnExportar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(360, 79);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(80, 41);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 58);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 105);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 157);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "Dni";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(166, 53);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(166, 157);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 5;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(166, 105);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(100, 23);
            dtpVencimiento.TabIndex = 6;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(75, 260);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(242, 139);
            lsbVer.TabIndex = 7;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(360, 260);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(80, 41);
            btnImportar.TabIndex = 8;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(360, 316);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(80, 41);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(360, 147);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(80, 41);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(lsbVer);
            Controls.Add(dtpVencimiento);
            Controls.Add(txtDni);
            Controls.Add(txtPatente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPatente;
        private TextBox txtDni;
        private DateTimePicker dtpVencimiento;
        private ListBox lsbVer;
        private Button btnImportar;
        private Button btnExportar;
        private Button btnActualizar;
    }
}
