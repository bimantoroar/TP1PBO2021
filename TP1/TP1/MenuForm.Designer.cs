
namespace TP1
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.comboBoxHarga = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowlayoutpanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.lblCatalog);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 115);
            this.panel1.TabIndex = 1;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(677, 39);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(92, 27);
            this.lblLogout.TabIndex = 8;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TP1.Properties.Resources.candy_shop_pngrepo_com;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(47, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 98);
            this.panel4.TabIndex = 7;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(278, 39);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(82, 27);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Home";
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalog.Location = new System.Drawing.Point(454, 40);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(159, 27);
            this.lblCatalog.TabIndex = 4;
            this.lblCatalog.Text = "Web Catalog";
            this.lblCatalog.Click += new System.EventHandler(this.lblCatalog_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNIM);
            this.panel3.Controls.Add(this.lblNama);
            this.panel3.Location = new System.Drawing.Point(803, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 114);
            this.panel3.TabIndex = 3;
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(55, 58);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(117, 27);
            this.lblNIM.TabIndex = 1;
            this.lblNIM.Text = "1900303";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(17, 27);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(178, 27);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Bimantoro AR";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.BackColor = System.Drawing.Color.Snow;
            this.comboBoxJenis.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.comboBoxJenis.Location = new System.Drawing.Point(35, 154);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(139, 26);
            this.comboBoxJenis.TabIndex = 2;
            this.comboBoxJenis.Text = "Jenis Barang";
            this.comboBoxJenis.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenis_SelectedIndexChanged);
            // 
            // comboBoxHarga
            // 
            this.comboBoxHarga.BackColor = System.Drawing.Color.Snow;
            this.comboBoxHarga.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHarga.FormattingEnabled = true;
            this.comboBoxHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.comboBoxHarga.Location = new System.Drawing.Point(35, 240);
            this.comboBoxHarga.Name = "comboBoxHarga";
            this.comboBoxHarga.Size = new System.Drawing.Size(139, 26);
            this.comboBoxHarga.TabIndex = 3;
            this.comboBoxHarga.Text = "Harga";
            this.comboBoxHarga.SelectedIndexChanged += new System.EventHandler(this.comboBoxHarga_SelectedIndexChanged);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Snow;
            this.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(45, 313);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(114, 42);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Semua Barang : ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // flowlayoutpanelMenu
            // 
            this.flowlayoutpanelMenu.AutoScroll = true;
            this.flowlayoutpanelMenu.BackColor = System.Drawing.Color.Snow;
            this.flowlayoutpanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayoutpanelMenu.Location = new System.Drawing.Point(217, 179);
            this.flowlayoutpanelMenu.Name = "flowlayoutpanelMenu";
            this.flowlayoutpanelMenu.Size = new System.Drawing.Size(815, 456);
            this.flowlayoutpanelMenu.TabIndex = 6;
            this.flowlayoutpanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowlayoutpanelMenu_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCari);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 635);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1032, 635);
            this.Controls.Add(this.flowlayoutpanelMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxHarga);
            this.Controls.Add(this.comboBoxJenis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.ComboBox comboBoxHarga;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowlayoutpanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLogout;
    }
}