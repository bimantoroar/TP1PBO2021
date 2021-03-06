using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class DetailBarang : Form
    {
        List<dataBarang> Barang = new List<dataBarang>();
        public DetailBarang(int id)
        {
            InitializeComponent();
            list();
            foreach (var data in this.Barang)
            {
                if (data.getIdBarang == id)
                {
                    flowlayoutpanelMenu.Controls.Add(detailList(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisBarang));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowlayoutpanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new MenuForm();
            Menu.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        private void lblCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://Www.tokopedia.com");
        }

        private void DetailBarang_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKembali_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new MenuForm();
            Menu.Show();
        }
        public void list()
        {
            this.Barang.Add(new dataBarang("Handphone", 250000, 1, "Elektronik"));
            this.Barang.Add(new dataBarang("Soto", 110000, 2, "Makanan"));
            this.Barang.Add(new dataBarang("Kulkas", 300000, 3, "Elektronik"));
            this.Barang.Add(new dataBarang("Bomber", 250000, 4, "Baju"));
            this.Barang.Add(new dataBarang("Nasi Goreng Saldin", 250000, 5, "Makanan"));
            this.Barang.Add(new dataBarang("Kaos Sangsang", 120000, 6, "Baju"));

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private Panel detailList(string nama, int harga, int id, string jenisBarang)
        {
            Panel panelBarang = new Panel();
            Label lblNamaBarang = new Label();
            Label lblHarga = new Label();
            Button btnBeli = new Button();


            panelBarang.BackColor = System.Drawing.Color.MistyRose;
            panelBarang.Controls.Add(lblHarga);
            panelBarang.Controls.Add(btnBeli);
            panelBarang.Controls.Add(lblNamaBarang);
            panelBarang.Location = new System.Drawing.Point(3, 3);
            panelBarang.Name = "panelBarang";
            panelBarang.Size = new System.Drawing.Size(238, 250);
            panelBarang.TabIndex = 0;

            lblHarga.AutoSize = false;
            lblHarga.Location = new System.Drawing.Point(70, 171);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new System.Drawing.Size(96, 20);
            lblHarga.TabIndex = 1;
            lblHarga.Text = harga.ToString();

            btnBeli.Location = new System.Drawing.Point(74, 205);
            btnBeli.Name = id.ToString();
            btnBeli.Size = new System.Drawing.Size(92, 31);
            btnBeli.TabIndex = 1;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += new EventHandler((object sender, EventArgs e) =>
            {
                this.Hide();
                Form detail = new DetailBarang(id);
                detail.Show();

            });

            lblNamaBarang.AutoSize = false;
            lblNamaBarang.Location = new System.Drawing.Point(70, 142);
            lblNamaBarang.Name = "lblNamaBarang";
            lblNamaBarang.Size = new System.Drawing.Size(107, 20);
            lblNamaBarang.TabIndex = 0;
            lblNamaBarang.Text = nama;

            return panelBarang;
        }
    }

}
