
namespace Cine_Vista
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.tbl_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(196, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Tag = "idClientes";
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(78, 279);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(200, 26);
            this.txt_id.TabIndex = 2;
            this.txt_id.Tag = "idClientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Tag = "Nombre";
            this.label2.Text = "NOMBRE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(417, 276);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(397, 26);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.Tag = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Tag = "Nombre";
            this.label3.Text = "NIT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(939, 276);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(361, 26);
            this.txt_nit.TabIndex = 6;
            this.txt_nit.Tag = "Nit";
            // 
            // tbl_clientes
            // 
            this.tbl_clientes.AllowUserToAddRows = false;
            this.tbl_clientes.AllowUserToDeleteRows = false;
            this.tbl_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_clientes.Location = new System.Drawing.Point(16, 344);
            this.tbl_clientes.Name = "tbl_clientes";
            this.tbl_clientes.ReadOnly = true;
            this.tbl_clientes.RowHeadersWidth = 62;
            this.tbl_clientes.RowTemplate.Height = 28;
            this.tbl_clientes.Size = new System.Drawing.Size(1284, 393);
            this.tbl_clientes.TabIndex = 7;
            this.tbl_clientes.Tag = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 749);
            this.Controls.Add(this.tbl_clientes);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.DataGridView tbl_clientes;
    }
}