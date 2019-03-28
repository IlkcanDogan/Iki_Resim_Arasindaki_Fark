using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //Dizin işlemleri için referans

namespace ResimKarsilastirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Tanimlamalar
        static string resimAdi, resimAdi2;
        //karşılaştırılacak resimlerin isimleri

        Bitmap resim, resim2;
        //karşılaştırılacak resimler

        int sayac = 0, sayac2 = 0;
        // sayac aynı pikseller için, sayac2 farklı pikseller için

        bool bayrak = true;
        // eğer bayrak true ise resimler aynı, false ise farklı
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string img1_ref, img2_ref;
            resim = new Bitmap(resimAdi);
            resim2 = new Bitmap(resimAdi2);

            progressBar1.Maximum = resim.Width;
            //progressbarın maksimum değeri resim in genişliği

            progressBar1.Value = 0;
            //Her tıklamada progressbarı sıfırladım.



            //resimlerin genişlikleri Ve yükselikleri aynı ise karşılaştırmaya başla
            if (resim.Width == resim2.Width && resim.Height == resim2.Height)
            {
                for (int i = 0; i < resim.Width; i++)
                {
                    for (int j = 0; j < resim.Height; j++)
                    {
                        img1_ref = resim.GetPixel(i, j).ToString();
                        img2_ref = resim2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {// aynı olmayan pikselleri say
                            sayac2++;

                            bayrak = false;
                            break;
                        }
                        sayac++;
                    }
                    progressBar1.Value++;
                }

                if (bayrak == false)
                    MessageBox.Show("Resimler aynı değil, " + sayac2 + " adet farklı piksel var", "Farklı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(" Resimler aynı , " + sayac + " adet aynı piksel bulundu. " + sayac2 + " adet farklı piksel bulundu", "Aynı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sayac = 0; //sayacları sıfırladım.
                sayac2 = 0;

                bayrak = true; //bayrak değişkenini sıfırladım.
                
            }
            else
                MessageBox.Show("Resimler aynı boyutta değil!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            #region OpenFileDialog
            OpenFileDialog diyalog = new OpenFileDialog();
            //OpenFileDialog sınıfından nesne aldım

            diyalog.Title = "Birinci Resmi Seçiniz";
            //pencere başlığı belirledim

            diyalog.Filter = "Resimler | *.jpg; *.bmp; *.png; *.jpeg";
            //seçilebilecek dosyalar için filtre oluşturdum.
            #endregion
            if (diyalog.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = diyalog.FileName;
                //PictureBox a seçilen dosyanın dizinini attım.

                lbResim.Text = diyalog.SafeFileName;
                //lable a secilen dosyanın adını attım

                resimAdi = diyalog.FileName.ToString();
                //değişkene resim adını attım
               
            }
        }

        private void btnSec2_Click(object sender, EventArgs e)
        {
            #region OpenFileDialog2
            OpenFileDialog diyalog2 = new OpenFileDialog();
            //OpenFileDialog sınıfından nesne aldım

            diyalog2.Title = "İkinci Resmi Seçiniz";
            //pencere başlığı belirledim

            diyalog2.Filter = "Resimler | *.jpg; *.bmp; *.png; *.jpeg";
            //seçilebilecek dosyalar için filtre oluşturdum.
            #endregion

            if (diyalog2.ShowDialog() == DialogResult.OK)
            {
                pb2.ImageLocation = diyalog2.FileName;
                //PictureBox a seçilen dosyanın dizinini attım.

                lbResim2.Text = diyalog2.SafeFileName;
                //lable a secilen dosyanın adını attım

                resimAdi2 = diyalog2.FileName.ToString();
                //değişkene resim adını attım
            }
        }

    }
}
