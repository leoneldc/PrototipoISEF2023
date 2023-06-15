
namespace Vista_Seguridad
{
    partial class Menup
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(375, 134);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 134);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.SlateGray;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnVentas.Location = new System.Drawing.Point(0, 134);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(76, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(375, 60);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "CINE";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnseguridad);
            this.panelSideMenu.Controls.Add(this.btnVentas);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(375, 729);
            this.panelSideMenu.TabIndex = 46;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 254);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(76, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(375, 60);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "CERRAR SESIÓN";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnseguridad
            // 
            this.btnseguridad.BackColor = System.Drawing.Color.SlateGray;
            this.btnseguridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnseguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnseguridad.Location = new System.Drawing.Point(0, 194);
            this.btnseguridad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Padding = new System.Windows.Forms.Padding(76, 0, 0, 0);
            this.btnseguridad.Size = new System.Drawing.Size(375, 60);
            this.btnseguridad.TabIndex = 13;
            this.btnseguridad.Text = "SEGURIDAD";
            this.btnseguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.UseVisualStyleBackColor = false;
            this.btnseguridad.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Menup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 729);
            this.Controls.Add(this.panelSideMenu);
            this.IsMdiContainer = true;
            this.Name = "Menup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menup";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.Button btnVentas;
        public System.Windows.Forms.Button btnseguridad;
        public System.Windows.Forms.Button btnLogout;
    }
}