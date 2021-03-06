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
    public partial class MenuForm : Form
    {
        List<dataBarang> Barang = new List<dataBarang>();

        string jenisBarang;
        int minHarga;
        int maxHarga;

        private void filterProses(string jenisBarang, int minHarga, int maxHarga)
        {
            flowlayoutpanelMenu.Controls.Clear();

            foreach (var data in this.Barang)
            {
                if (data.getJenisBarang.ToLower() == jenisBarang)
                {
                    if (data.getHarga >= minHarga && data.getHarga <= maxHarga)
                    {
                        flowlayoutpanelMenu.Controls.Add(buatList(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisBarang));
                    }

                    else if (minHarga == 0)
                    {
                        flowlayoutpanelMenu.Controls.Add(buatList(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisBarang));
                    }
                }
                else if (jenisBarang == null)
                {
                    if (data.getHarga >= minHarga && data.getHarga <= maxHarga)
                    {
                        flowlayoutpanelMenu.Controls.Add(buatList(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisBarang));
                    }
                    else if (minHarga == 0)
                    {
                        flowlayoutpanelMenu.Controls.Add(buatList(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisBarang));
                    }
                }
            }
        }



        public MenuForm()
        {
            InitializeComponent();
            list();
            filterProses(this.jenisBarang, this.minHarga, this.maxHarga);
        }
      
        public void list()
        {
            this.Barang.Add(new dataBarang("Handphone",250000,1,"Elektronik"));
            this.Barang.Add(new dataBarang("Soto", 110000, 2, "Makanan"));
            this.Barang.Add(new dataBarang("Kulkas", 300000, 3, "Elektronik"));
            this.Barang.Add(new dataBarang("Bomber", 250000, 4, "Baju"));
            this.Barang.Add(new dataBarang("Nasi Goreng Saldin", 250000, 5, "Makanan"));
            this.Barang.Add(new dataBarang("Kaos Sangsang", 120000, 6, "Baju"));

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel buatList(string nama, int harga, int id, string jenisBarang)
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

        private void comboBoxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox value = (ComboBox)sender;
            value.DropDownStyle = ComboBoxStyle.DropDownList;
            this.jenisBarang = value.SelectedItem.ToString().ToLower();
    
        }

        private void comboBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox value = (ComboBox)sender;
            value.DropDownStyle = ComboBoxStyle.DropDownList;
            ambilHarga(value.SelectedItem.ToString().ToLower());

           
        }

        private void ambilHarga(string value)
        {
            if(value == "100rb - 200rb")
            {
                this.minHarga = 100000;
                this.maxHarga = 200000;
            }else if(value == "200rb - 500rb")
            {
                this.minHarga = 200000;
                this.maxHarga = 500000;
            }else if(value == "500rb - 1jt")
            {
                this.minHarga = 500000;
                this.maxHarga = 1000000;
            }
         
        }

        private void flowlayoutpanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://Www.tokopedia.com");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            filterProses(this.jenisBarang, this.minHarga, this.maxHarga);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }
    }

    class dataBarang
    {
        public dataBarang(string nama, int harga, int id, string jenis)
        {
            getNamaBarang = nama;
            getHarga = harga;
            getIdBarang = id;
            getJenisBarang = jenis;
        }

        public string getNamaBarang
        {
            get; set;
        }
        public int getHarga
        {
            get; set;
        }
        public int getIdBarang
        {
            get; set;
        }

        public string getJenisBarang
        {
            get; set;
        }
    }

}
