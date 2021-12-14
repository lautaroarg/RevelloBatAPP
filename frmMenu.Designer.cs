
namespace RevelloAPP
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBaterias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 121);
            this.panel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minimizar);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1337, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 121);
            this.panel3.TabIndex = 2;
            // 
            // minimizar
            // 
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(0, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(47, 44);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 676);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.btnBaterias);
            this.panel4.Controls.Add(this.btnReportes);
            this.panel4.Controls.Add(this.btnCompras);
            this.panel4.Controls.Add(this.btnVentas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1456, 662);
            this.panel4.TabIndex = 42;
            // 
            // btnBaterias
            // 
            this.btnBaterias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaterias.BackColor = System.Drawing.Color.Black;
            this.btnBaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaterias.BorderRadius = 7;
            this.btnBaterias.ButtonText = "BATERIAS";
            this.btnBaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaterias.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaterias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaterias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaterias.Iconimage")));
            this.btnBaterias.Iconimage_right = null;
            this.btnBaterias.Iconimage_right_Selected = null;
            this.btnBaterias.Iconimage_Selected = null;
            this.btnBaterias.IconMarginLeft = 0;
            this.btnBaterias.IconMarginRight = 0;
            this.btnBaterias.IconRightVisible = true;
            this.btnBaterias.IconRightZoom = 0D;
            this.btnBaterias.IconVisible = true;
            this.btnBaterias.IconZoom = 90D;
            this.btnBaterias.IsTab = false;
            this.btnBaterias.Location = new System.Drawing.Point(278, 140);
            this.btnBaterias.Name = "btnBaterias";
            this.btnBaterias.Normalcolor = System.Drawing.Color.Black;
            this.btnBaterias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaterias.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaterias.selected = false;
            this.btnBaterias.Size = new System.Drawing.Size(314, 133);
            this.btnBaterias.TabIndex = 38;
            this.btnBaterias.Text = "BATERIAS";
            this.btnBaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaterias.Textcolor = System.Drawing.Color.Yellow;
            this.btnBaterias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaterias.Click += new System.EventHandler(this.btnBaterias_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportes.BackColor = System.Drawing.Color.Black;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 7;
            this.btnReportes.ButtonText = "REPORTE";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 90D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(843, 381);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Black;
            this.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(314, 133);
            this.btnReportes.TabIndex = 41;
            this.btnReportes.Text = "REPORTE";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportes.Textcolor = System.Drawing.Color.Yellow;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompras.BackColor = System.Drawing.Color.Black;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 7;
            this.btnCompras.ButtonText = "COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = null;
            this.btnCompras.Iconimage_right_Selected = null;
            this.btnCompras.Iconimage_Selected = null;
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 90D;
            this.btnCompras.IsTab = false;
            this.btnCompras.Location = new System.Drawing.Point(843, 140);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Black;
            this.btnCompras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(314, 133);
            this.btnCompras.TabIndex = 39;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompras.Textcolor = System.Drawing.Color.Yellow;
            this.btnCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVentas.BackColor = System.Drawing.Color.Black;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 7;
            this.btnVentas.ButtonText = "VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 90D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(278, 381);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Black;
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(314, 133);
            this.btnVentas.TabIndex = 40;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Textcolor = System.Drawing.Color.Yellow;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1456, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaterias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}