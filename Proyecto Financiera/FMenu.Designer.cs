namespace Proyecto_Financiera
{
    partial class FMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.LblFecha = new System.Windows.Forms.Label();
            this.Lblhora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnprestamoss = new System.Windows.Forms.Button();
            this.Btnlogo = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.Btnclientes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LblFecha.Location = new System.Drawing.Point(544, 598);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(516, 40);
            this.LblFecha.TabIndex = 53;
            this.LblFecha.Text = "Miercoles, 10  noviembre  2017";
            // 
            // Lblhora
            // 
            this.Lblhora.AutoSize = true;
            this.Lblhora.BackColor = System.Drawing.Color.Transparent;
            this.Lblhora.Font = new System.Drawing.Font("Century Gothic", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lblhora.Location = new System.Drawing.Point(427, 483);
            this.Lblhora.Name = "Lblhora";
            this.Lblhora.Size = new System.Drawing.Size(467, 129);
            this.Lblhora.TabIndex = 52;
            this.Lblhora.Text = "10:59:58";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Usuario";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnprestamoss);
            this.MenuVertical.Controls.Add(this.Btnlogo);
            this.MenuVertical.Controls.Add(this.label5);
            this.MenuVertical.Controls.Add(this.pictureBox5);
            this.MenuVertical.Controls.Add(this.BtnEmpleado);
            this.MenuVertical.Controls.Add(this.Btnclientes);
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 54;
            // 
            // btnprestamoss
            // 
            this.btnprestamoss.FlatAppearance.BorderSize = 0;
            this.btnprestamoss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprestamoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprestamoss.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprestamoss.ForeColor = System.Drawing.Color.White;
            this.btnprestamoss.Image = ((System.Drawing.Image)(resources.GetObject("btnprestamoss.Image")));
            this.btnprestamoss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprestamoss.Location = new System.Drawing.Point(0, 259);
            this.btnprestamoss.Name = "btnprestamoss";
            this.btnprestamoss.Size = new System.Drawing.Size(250, 40);
            this.btnprestamoss.TabIndex = 100;
            this.btnprestamoss.Text = "Prestamos";
            this.btnprestamoss.UseVisualStyleBackColor = true;
            this.btnprestamoss.Click += new System.EventHandler(this.btnprestamos);
            // 
            // Btnlogo
            // 
            this.Btnlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.Btnlogo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnlogo.FlatAppearance.BorderSize = 0;
            this.Btnlogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Btnlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogo.ForeColor = System.Drawing.Color.White;
            this.Btnlogo.Image = ((System.Drawing.Image)(resources.GetObject("Btnlogo.Image")));
            this.Btnlogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnlogo.Location = new System.Drawing.Point(-13, 0);
            this.Btnlogo.Name = "Btnlogo";
            this.Btnlogo.Size = new System.Drawing.Size(263, 75);
            this.Btnlogo.TabIndex = 98;
            this.Btnlogo.Text = "RT-Financiera";
            this.Btnlogo.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 572);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleado.Image")));
            this.BtnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleado.Location = new System.Drawing.Point(0, 167);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(250, 40);
            this.BtnEmpleado.TabIndex = 6;
            this.BtnEmpleado.Text = "Empleados";
            this.BtnEmpleado.UseVisualStyleBackColor = true;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // Btnclientes
            // 
            this.Btnclientes.FlatAppearance.BorderSize = 0;
            this.Btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnclientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclientes.ForeColor = System.Drawing.Color.White;
            this.Btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("Btnclientes.Image")));
            this.Btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnclientes.Location = new System.Drawing.Point(0, 213);
            this.Btnclientes.Name = "Btnclientes";
            this.Btnclientes.Size = new System.Drawing.Size(250, 40);
            this.Btnclientes.TabIndex = 3;
            this.Btnclientes.Text = "Clientes";
            this.Btnclientes.UseVisualStyleBackColor = true;
            this.Btnclientes.Click += new System.EventHandler(this.Btnclientes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = global::Proyecto_Financiera.Properties.Resources.ConTitulo;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(514, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(559, 455);
            this.metroPanel1.TabIndex = 55;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.Lblhora);
            this.Controls.Add(this.MenuVertical);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMenu";
            this.ShowIcon = false;
            this.Text = "FMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMenu_FormClosed);
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label Lblhora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button Btnlogo;
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button Btnclientes;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnprestamoss;
    }
}