
namespace Cine_Vista
{
    partial class Reservacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.txt_metodo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbl_asientos = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pelicula = new System.Windows.Forms.ComboBox();
            this.txt_cine = new System.Windows.Forms.ComboBox();
            this.txt_cliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_asientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID FACTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "METODO DE PAGO:";
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(242, 9);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(342, 26);
            this.txt_factura.TabIndex = 3;
            // 
            // txt_metodo
            // 
            this.txt_metodo.Location = new System.Drawing.Point(242, 57);
            this.txt_metodo.Name = "txt_metodo";
            this.txt_metodo.Size = new System.Drawing.Size(410, 26);
            this.txt_metodo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1101, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbl_asientos
            // 
            this.tbl_asientos.AllowUserToAddRows = false;
            this.tbl_asientos.AllowUserToDeleteRows = false;
            this.tbl_asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_asientos.Location = new System.Drawing.Point(16, 289);
            this.tbl_asientos.Name = "tbl_asientos";
            this.tbl_asientos.ReadOnly = true;
            this.tbl_asientos.RowHeadersWidth = 62;
            this.tbl_asientos.RowTemplate.Height = 28;
            this.tbl_asientos.Size = new System.Drawing.Size(636, 367);
            this.tbl_asientos.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(723, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(636, 367);
            this.dataGridView2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(590, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID PELICULA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID CINE:";
            // 
            // txt_pelicula
            // 
            this.txt_pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_pelicula.FormattingEnabled = true;
            this.txt_pelicula.Location = new System.Drawing.Point(242, 187);
            this.txt_pelicula.Name = "txt_pelicula";
            this.txt_pelicula.Size = new System.Drawing.Size(410, 28);
            this.txt_pelicula.TabIndex = 16;
            // 
            // txt_cine
            // 
            this.txt_cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_cine.FormattingEnabled = true;
            this.txt_cine.Location = new System.Drawing.Point(242, 153);
            this.txt_cine.Name = "txt_cine";
            this.txt_cine.Size = new System.Drawing.Size(410, 28);
            this.txt_cine.TabIndex = 17;
            // 
            // txt_cliente
            // 
            this.txt_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_cliente.FormattingEnabled = true;
            this.txt_cliente.Location = new System.Drawing.Point(892, 6);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(410, 28);
            this.txt_cliente.TabIndex = 18;
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 745);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_cine);
            this.Controls.Add(this.txt_pelicula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbl_asientos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_metodo);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reservacion";
            this.Text = "Reservacion";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_asientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.TextBox txt_metodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tbl_asientos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_pelicula;
        private System.Windows.Forms.ComboBox txt_cine;
        private System.Windows.Forms.ComboBox txt_cliente;
    }
}