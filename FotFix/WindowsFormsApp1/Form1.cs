using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] haftalar = { "1.hafta","2.hafta","3.hafta","4.hafta","5.hafta","6.hafta","7.hafta", "8.hafta", "9.hafta", "10.hafta", "11.hafta", "12.hafta", "13.hafta", "14.hafta", "15.hafta", "16.hafta", "17.hafta", "18.hafta", "19.hafta"};
            foreach (var hafta in haftalar)
            {
                comboBox1.Items.Add(hafta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem!=null)
            {
                if (comboBox1.SelectedIndex==0)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Kasımpaşa", "Fenerbahçe", "Fatihkaragümrük", "Çaykurrizespor", "Beşiktaş", "Gaziantep", "Trabzonspor", "Göztepe", "Yenimalatyaspor", "Galatasaray", "Antalyaspor", "Giresunspor", "Sivasspor", "Hatayspor", "Konyaspor", "Kayserispor", "Adanademirspor", "Altay", "Başakşehir", "Alanyaspor" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Çaykurrizespor", "Yenimalatyaspor", "Göztepe", "Kasımpaşa", "Beşiktaş", "Sivasspor", "Gaziantep", "Fatihkaragümrük", "Fenerbahçe", "Galatasaray", "Giresunspor", "Konyaspor", "Trabzonspor", "Hatayspor", "Kayserispor", "Antalyaspor", "Başakşehir", "Adanademirspor", "Alanyaspor", "Altay" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Yenimalatyaspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex==2)
                {
                        PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                        Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                        string[] takımlar = { "Galatasaray", "Göztepe", "Çaykurrizespor", "Gaziantep", "Kayserispor", "Giresunspor", "Sivasspor", "Alanyaspor", "Konyaspor", "Beşiktaş", "Yenimalatyaspor", "Başakşehir", "Adanademirspor", "Trabzonspor", "Antalyaspor", "Fenerbahçe", "Fatihkaragümrük", "Altay", "Kasımpaşa", "Hatayspor" };
                        Random rnd = new Random();
                        int sayi = rnd.Next(takımlar.Count());
                        for (int i = 0; i < 20; i++)
                        {
                            if (i == sayi)
                            {
                                if (i == 0)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                                }
                                else if (i == 1)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                                }
                                else if (i == 2)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                                }
                                else if (i == 3)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                                }
                                else if (i == 4)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                                }
                                else if (i == 5)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                                }
                                else if (i == 6)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                                }
                                else if (i == 7)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                                }
                                else if (i == 8)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                                }
                                else if (i == 9)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                                }
                                else if (i == 10)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                                }
                                else if (i == 11)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                                }
                                else if (i == 12)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                                }
                                else if (i == 13)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                                }
                                else if (i == 14)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                                }
                                else if (i == 15)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                                }
                                else if (i == 16)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                                }
                                else if (i == 17)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                                }
                                else if (i == 18)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                                }
                                else if (i == 19)
                                {
                                    pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                                }
                                lbl[i].Text = takımlar[sayi];

                            }
                        }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Giresunspor", "Kayserispor", "Beşiktaş", "Adanademirspor", "Alanyaspor", "Kasımpaşa", "Fenerbahçe", "Başakşehir", "Hatayspor", "Sivasspor", "Trabzonspor", "Yenimalatyaspor", "Göztepe", "Antalyaspor", "Galatasaray", "Konyaspor", "Gaziantep", "Altay", "Çaykurrizespor", "Fatihkaragümrük" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Kasımpaşa", "Giresunspor", "Kayserispor", "Galatasaray", "Konyaspor", "Antalyaspor", "Beşiktaş", "Altay", "Başakşehir", "Göztepe", "Yenimalatyaspor", "Alanyaspor", "Trabzonspor", "Fenerbahçe", "Adanademirspor", "Çaykurrizespor", "Fatihkaragümrük", "Gaziantep", "Hatayspor", "Sivasspor" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Galatasaray", "Kasımpaşa", "Gaziantep", "Çaykurrizespor", "Kayserispor", "Giresunspor", "Sivasspor", "Beşiktaş", "Alanyaspor","Konyaspor", "Başakşehir", "Yenimalatyaspor", "Trabzonspor", "Adanademirspor", "Fenerbahçe", "Antalyaspor", "Altay", "Fatihkaragümrük", "Hatayspor", "Göztepe" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Göztepe", "Konyaspor", "Kasımpaşa", "Antalyaspor", "Kayserispor", "Hatayspor", "Fenerbahçe", "Adanademirspor", "Çaykurrizespor", "Gaziantep", "Altay", "Alanyaspor", "Yenimalatyaspor", "Galatasaray", "Beşiktaş", "Başakşehir", "Sivasspor", "Trabzonspor", "Giresunspor", "Fatihkaragümrük" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Yenimalatyaspor", "Giresunspor", "Fenerbahçe", "Antalyaspor", "Kasımpaşa", "Konyaspor", "Göztepe", "Kayserispor", "Adanademirspor", "Galatasaray", "Hatayspor", "Sivasspor", "Altay", "Beşiktaş", "Alanyaspor", "Çaykurrizespor", "Trabzonspor", "Gaziantep", "Başakşehir", "Fatihkaragümrük" };
                    Random rnd = new Random();                                                                                                                                                                                                                                               
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Çaykurrizespor", "Fatihkaragümrük", "Sivasspor", "Antalyaspor", "Gaziantep", "Fenerbahçe", "Konyaspor", "Yenimalatyaspor", "Kayserispor", "Göztepe", "Kasımpaşa", "Giresunspor", "Adanademirspor", "Beşiktaş", "Galatasaray", "Başakşehir", "Trabzonspor", "Giresunspor", "Hatayspor", "Altay" };
                    Random rnd = new Random();                                                                                                                                  
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Galatasaray", "Çaykurrizespor", "Konyaspor", "Fatihkaragümrük", "Alanyaspor", "Başakşehir", "Trabzonspor", "Göztepe", "Antalyaspor", "Beşiktaş", "Giresunspor", "Sivasspor", "Kasımpaşa","Yenimalatyaspor" , "Kayserispor", "Fenerbahçe", "Altay","Adanademirspor", "Hatayspor", "Gaziantep" };
                    Random rnd = new Random(); 
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Fenerbahçe", "Kasımpaşa", "Altay", "Kayserispor", "Çaykurrizespor", "Antalyaspor", "Sivasspor", "Konyaspor", "Gaziantep", "Galatasaray", "Göztepe", "Yenimalatyaspor", "Trabzonspor", "Alanyaspor", "Başakşehir", "Altay", "Beşiktaş", "Fatihkaragümrük", "Hatayspor", "Giresunspor" };
                    Random rnd = new Random();                                                                                                                       
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 11)
                { 
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Galatasaray", "Başakşehir", "Hatayspor", "Çaykurrizespor", "Altay", "Trabzonspor", "Konyaspor","Beşiktaş", "Kayserispor", "Sivasspor", "Alanyaspor", "Göztepe", "Kasımpaşa", "Giresunspor", "Yenimalatyaspor", "Fenerbahçe", "Antalyaspor", "Fatihkaragümrük", "Adanademirspor", "Gaziantep" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
  
                else if (comboBox1.SelectedIndex == 12)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Hatayspor", "Yenimalatyaspor", "Sivasspor", "Kasımpaşa", "Çaykurrizespor", "Konyaspor", "Alanyaspor", "Gaziantep", "Göztepe", "Fenerbahçe", "Giresunspor", "Fatihkaragümrük", "Başakşehir", "Antalyaspor", "Trabzonspor", "Galatasaray", "Beşiktaş", "Kayserispor", "Adanademirspor", "Altay" };
                    Random rnd = new Random(); 
                    int sayi = rnd.Next(takımlar.Count());                                                                                           
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Fenerbahçe", "Altay", "Yenimalatyaspor", "Sivasspor", "Fatihkaragümrük", "Göztepe", "Galatasaray", "Alanyaspor", "Konyaspor", "Gaziantep", "Antalyaspor", "Trabzonspor", "Adanademirspor", "Başakşehir", "Kasımpaşa", "Beşiktaş", "Kayserispor", "Çaykurrizespor", "Hatayspor", "Giresunspor" };
                    Random rnd = new Random(); 
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Alanyaspor", "Antalyaspor", "Çaykurrizespor", "Kasımpaşa", "Hatayspor", "Göztepe", "Galatasaray", "Adanademirspor", "Gaziantep", "Kayserispor", "Sivasspor", "Fenerbahçe", "Beşiktaş", "Yenimalatyaspor", "Başakşehir", "Konyaspor", "Trabzonspor", "Fatihkaragümrük", "Giresunspor", "Altay" };
                    Random rnd = new Random(); 
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Trabzonspor", "Adanademirspor", "Hatayspor", "Başakşehir", "Galatasaray", "Altay", "Giresunspor", "Fatihkaragümrük", "Fenerbahçe", "Çaykurrizespor", "Alanyaspor", "Sivasspor", "Kayserispor", "Antalyaspor", "Konyaspor", "Yenimalatyaspor", "Göztepe", "Gaziantep", "Kasımpaşa", "Beşiktaş" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 16)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Adanademirspor", "Giresunspor", "Antalyaspor", "Trabzonspor", "Sivasspor", "Galatasaray", "Fatihkaragümrük", "Konyaspor", "Çaykurrizespor", "Göztepe", "Başakşehir", "Kasımpaşa", "Yenimalatyaspor", "Alanyaspor", "Gaziantep", "Fenerbahçe", "Altay", "Hatayspor", "Beşiktaş", "Kayserispor" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 17)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Göztepe", "Fatihkaragümrük", "Çaykurrizespor", "Yenimalatyaspor", "Konyaspor", "Antalyaspor", "Kasımpaşa", "Sivasspor", "Trabzonspor", "Hatayspor", "Fenerbahçe", "Beşiktaş", "Kayserispor", "Gaziantep", "Alanyaspor", "Adanademirspor", "Galatasaray", "Başakşehir", "Giresunspor", "Altay" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 18)
                {
                    PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                    Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
                    string[] takımlar = { "Fatihkaragümrük", "Fenerbahçe", "Yenimalatyaspor", "Kayserispor", "Gaziantep", "Alanyaspor", "Altay", "Trabzonspor", "Sivasspor", "Çaykurrizespor", "Başakşehir", "Giresunspor", "Hatayspor", "Konyaspor", "Adanademirspor", "Galatasaray", "Beşiktaş", "Göztepe", "Antalyaspor", "Kasımpaşa" };
                    Random rnd = new Random();
                    int sayi = rnd.Next(takımlar.Count());
                    for (int i = 0; i < 20; i++)
                    {
                        if (i == sayi)
                        {
                            if (i == 0)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/FatihKaragumruk.png";
                            }
                            else if (i == 1)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Fenerbahçe.png";
                            }
                            else if (i == 2)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/YeniMalatyaspor.png";
                            }
                            else if (i == 3)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kayserispor.png";
                            }
                            else if (i == 4)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Gaziantep.png";
                            }
                            else if (i == 5)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Alanyaspor.png";
                            }
                            else if (i == 6)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Altay.png";
                            }
                            else if (i == 7)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Trabzonspor.png";
                            }
                            else if (i == 8)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Sivasspor.png";
                            }
                            else if (i == 9)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/ÇaykurRizespor.png";
                            }
                            else if (i == 10)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Başakşehir.png";
                            }
                            else if (i == 11)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Giresunspor.png";
                            }
                            else if (i == 12)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Hatayspor.png";
                            }
                            else if (i == 13)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Konyaspor.png";
                            }
                            else if (i == 14)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Adanademirspor.png";
                            }
                            else if (i == 15)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Galatasaray.png";
                            }
                            else if (i == 16)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Beşiktaş.png";
                            }
                            else if (i == 17)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Göztepe.png";
                            }
                            else if (i == 18)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Antalyaspor.png";
                            }
                            else if (i == 19)
                            {
                                pcr[i].ImageLocation = "C:/Users/Mertcan/Documents/Visual Studio 2019/Projeler/FotFix/WindowsFormsApp1/Pictures/Kasımpasa.png";
                            }
                            lbl[i].Text = takımlar[sayi];

                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox[] pcr = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
            Label[] lbl = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
            
            for (int i = 0; i < 20; i++)
            {
            if (pcr[i].Image!=null && lbl[i].Text!="")
            {
                pcr[i].Image = null;
                lbl[i].Text = "";
            }
                
            }
        }
    }
}
