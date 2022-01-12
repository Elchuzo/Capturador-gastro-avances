
namespace Capturador_gastro_avances
{
    partial class frmImagen
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
            this.lblBrillo = new System.Windows.Forms.Label();
            this.trkSaturacion = new System.Windows.Forms.TrackBar();
            this.trkContraste = new System.Windows.Forms.TrackBar();
            this.trkBrillo = new System.Windows.Forms.TrackBar();
            this.lblSaturacion = new System.Windows.Forms.Label();
            this.lblContraste = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.pnlShade = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkContraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrillo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrillo
            // 
            this.lblBrillo.AutoSize = true;
            this.lblBrillo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblBrillo.Location = new System.Drawing.Point(63, 59);
            this.lblBrillo.Name = "lblBrillo";
            this.lblBrillo.Size = new System.Drawing.Size(62, 30);
            this.lblBrillo.TabIndex = 6;
            this.lblBrillo.Text = "Brillo";
            // 
            // trkSaturacion
            // 
            this.trkSaturacion.Location = new System.Drawing.Point(68, 295);
            this.trkSaturacion.Maximum = 100;
            this.trkSaturacion.Minimum = -100;
            this.trkSaturacion.Name = "trkSaturacion";
            this.trkSaturacion.Size = new System.Drawing.Size(151, 45);
            this.trkSaturacion.TabIndex = 11;
            this.trkSaturacion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSaturacion.Scroll += new System.EventHandler(this.trkSaturacion_Scroll);
            // 
            // trkContraste
            // 
            this.trkContraste.Location = new System.Drawing.Point(65, 193);
            this.trkContraste.Maximum = 100;
            this.trkContraste.Minimum = -100;
            this.trkContraste.Name = "trkContraste";
            this.trkContraste.Size = new System.Drawing.Size(154, 45);
            this.trkContraste.TabIndex = 9;
            this.trkContraste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkContraste.Scroll += new System.EventHandler(this.trkContraste_Scroll);
            // 
            // trkBrillo
            // 
            this.trkBrillo.Location = new System.Drawing.Point(65, 102);
            this.trkBrillo.Maximum = 100;
            this.trkBrillo.Minimum = -100;
            this.trkBrillo.Name = "trkBrillo";
            this.trkBrillo.Size = new System.Drawing.Size(154, 45);
            this.trkBrillo.TabIndex = 7;
            this.trkBrillo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkBrillo.Scroll += new System.EventHandler(this.trkBrillo_Scroll);
            // 
            // lblSaturacion
            // 
            this.lblSaturacion.AutoSize = true;
            this.lblSaturacion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblSaturacion.Location = new System.Drawing.Point(63, 251);
            this.lblSaturacion.Name = "lblSaturacion";
            this.lblSaturacion.Size = new System.Drawing.Size(114, 30);
            this.lblSaturacion.TabIndex = 10;
            this.lblSaturacion.Text = "Saturación";
            // 
            // lblContraste
            // 
            this.lblContraste.AutoSize = true;
            this.lblContraste.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblContraste.Location = new System.Drawing.Point(63, 150);
            this.lblContraste.Name = "lblContraste";
            this.lblContraste.Size = new System.Drawing.Size(106, 30);
            this.lblContraste.TabIndex = 8;
            this.lblContraste.Text = "Contraste";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnRegresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnRegresar.IconSize = 30;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(65, 359);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Rotation = 0D;
            this.btnRegresar.Size = new System.Drawing.Size(176, 47);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Restablecer";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pnlShade
            // 
            this.pnlShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(115)))));
            this.pnlShade.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShade.Location = new System.Drawing.Point(0, 29);
            this.pnlShade.Name = "pnlShade";
            this.pnlShade.Size = new System.Drawing.Size(292, 10);
            this.pnlShade.TabIndex = 26;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(292, 29);
            this.pnlTop.TabIndex = 25;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(262, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(30, 29);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(292, 430);
            this.Controls.Add(this.pnlShade);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblBrillo);
            this.Controls.Add(this.trkSaturacion);
            this.Controls.Add(this.trkContraste);
            this.Controls.Add(this.trkBrillo);
            this.Controls.Add(this.lblSaturacion);
            this.Controls.Add(this.lblContraste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImagen";
            this.Text = "frmImagen";
            this.Load += new System.EventHandler(this.frmImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkContraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrillo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrillo;
        private System.Windows.Forms.TrackBar trkSaturacion;
        private System.Windows.Forms.TrackBar trkContraste;
        private System.Windows.Forms.TrackBar trkBrillo;
        private System.Windows.Forms.Label lblSaturacion;
        private System.Windows.Forms.Label lblContraste;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Panel pnlShade;
        private System.Windows.Forms.Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}