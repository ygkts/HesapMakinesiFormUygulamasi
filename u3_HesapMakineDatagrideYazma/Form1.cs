using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u3_HesapMakineDatagrideYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Islem> islemList = new List<Islem>();
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem();
            try
            {
                islem.Sayi1 = Convert.ToInt16(txtS1.Text);
                islem.IslemTipi = comboBoxIslemTipi.SelectedItem.ToString();
                islem.Sayi2 = Convert.ToInt16(txtS2.Text);

                if (comboBoxIslemTipi.SelectedIndex == 0)
                {
                    txtSonuc.Text = islem.GetToplam().ToString();
                }
                else if (comboBoxIslemTipi.SelectedIndex == 1)
                {
                    txtSonuc.Text = islem.GetCikarim().ToString();
                }
                else if (comboBoxIslemTipi.SelectedIndex == 2)
                {
                    txtSonuc.Text = islem.GetCarpim().ToString();
                }
                else if (comboBoxIslemTipi.SelectedIndex == 3)
                {
                    txtSonuc.Text = islem.GetBolum().ToString();
                }
                else if (comboBoxIslemTipi.SelectedIndex == 4)
                {
                    txtSonuc.Text = islem.GetKarekok().ToString();
                }
                
                islem.Sonuc = Convert.ToDouble(txtSonuc.Text);
                islemList.Add(islem);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = islemList;
            }
            catch (Exception)
            {
                if (comboBoxIslemTipi.SelectedValue==null)
                {
                    MessageBox.Show("İşlem Tipi Seçin...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Değer giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void comboBoxIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxIslemTipi.SelectedIndex == 0)
            {
                txtS2.Enabled = true;
                txtS2.Text = "";
            }
            else if (comboBoxIslemTipi.SelectedIndex == 1)
            {
                txtS2.Enabled = true;
                txtS2.Text = "";
            }
            else if (comboBoxIslemTipi.SelectedIndex == 2)
            {
                txtS2.Enabled = true;
                txtS2.Text = "";
            }
            else if (comboBoxIslemTipi.SelectedIndex == 3)
            {
                txtS2.Enabled = true;
                txtS2.Text = "";
            }
            else if (comboBoxIslemTipi.SelectedIndex == 4)
            {
                txtS2.Enabled = false;
                txtS2.Text = "0";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // txtS1.Text = "0";
            //txtS2.Text = "0";
        }
    }
}
