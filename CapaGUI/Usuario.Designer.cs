namespace CapaGUI
{
    partial class Usuario
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
            this.PanelForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnAsesorias = new System.Windows.Forms.Button();
            this.btnAccidente = new System.Windows.Forms.Button();
            this.lblmensajeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.label2);
            this.PanelForm.Controls.Add(this.pictureBox3);
            this.PanelForm.Location = new System.Drawing.Point(224, 54);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(847, 501);
            this.PanelForm.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "GESTIÓN Y SEGURIDAD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaGUI.Properties.Resources.PREVAC;
            this.pictureBox3.Location = new System.Drawing.Point(326, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(75)))));
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(224, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(847, 59);
            this.panelSuperior.TabIndex = 105;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaGUI.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(742, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 105;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CapaGUI.Properties.Resources.cancel;
            this.btnCerrar.Location = new System.Drawing.Point(789, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 104;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(75)))));
            this.panelLateral.Controls.Add(this.btnAsesorias);
            this.panelLateral.Controls.Add(this.btnAccidente);
            this.panelLateral.Controls.Add(this.lblmensajeUsuario);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(224, 555);
            this.panelLateral.TabIndex = 104;
            this.panelLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLateral_MouseDown);
            // 
            // btnAsesorias
            // 
            this.btnAsesorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsesorias.FlatAppearance.BorderSize = 0;
            this.btnAsesorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsesorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsesorias.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAsesorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsesorias.Location = new System.Drawing.Point(-6, 172);
            this.btnAsesorias.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsesorias.Name = "btnAsesorias";
            this.btnAsesorias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsesorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAsesorias.Size = new System.Drawing.Size(230, 45);
            this.btnAsesorias.TabIndex = 26;
            this.btnAsesorias.Text = "Asesorias";
            this.btnAsesorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsesorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsesorias.UseVisualStyleBackColor = true;
            // 
            // btnAccidente
            // 
            this.btnAccidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccidente.FlatAppearance.BorderSize = 0;
            this.btnAccidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccidente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccidente.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAccidente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccidente.Location = new System.Drawing.Point(-6, 127);
            this.btnAccidente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccidente.Name = "btnAccidente";
            this.btnAccidente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccidente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAccidente.Size = new System.Drawing.Size(230, 45);
            this.btnAccidente.TabIndex = 25;
            this.btnAccidente.Text = "Reporte Accidente";
            this.btnAccidente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccidente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccidente.UseMnemonic = false;
            this.btnAccidente.UseVisualStyleBackColor = false;
            this.btnAccidente.Click += new System.EventHandler(this.btnAccidente_Click);
            // 
            // lblmensajeUsuario
            // 
            this.lblmensajeUsuario.AutoSize = true;
            this.lblmensajeUsuario.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblmensajeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblmensajeUsuario.Location = new System.Drawing.Point(12, 21);
            this.lblmensajeUsuario.Name = "lblmensajeUsuario";
            this.lblmensajeUsuario.Size = new System.Drawing.Size(0, 22);
            this.lblmensajeUsuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 555);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelLateral;
        internal System.Windows.Forms.Button btnAsesorias;
        private System.Windows.Forms.Label lblmensajeUsuario;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnAccidente;
    }
}