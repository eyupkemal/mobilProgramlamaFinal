using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            int ihtimal = 0;
            int S1_Puan = 0;
            int S2_1Puan = 0;
            int S2_2Puan = 0;
            int S2_3Puan = 0;
            int S2_4Puan = 0;
            int S3_Puan = 0;

            InitializeComponent();

            //Cevap 1 ile ilgili işlemler
            LabelCevap_1.Text = Class1.Cevap_1;
            if (Class1.Cevap_1 == "SBT251-Mobil Programlama")
            {
                LabelCevap_1_Control.TextColor = Color.Green;
                LabelCevap_1_Control.Text = "Doğru";

                LabelCevap_1_Puan.TextColor = Color.Green;
                S1_Puan = 20;
            }
            else
            {
                LabelCevap_1_Control.TextColor = Color.Red;
                LabelCevap_1_Control.Text = "Yanlış";

                LabelCevap_1_Puan.TextColor = Color.Red;
                S1_Puan = 0;
            }

            //Cevap 2 ile ilgili işlemler
            if (Class1.Cevap_2_1 == "Anlamıyorum")
            {
                S2_1Puan = -30;
            }
            else
            {
                S2_1Puan = 0;
            }

            if (Class1.Cevap_2_2 == "biraz")
            {
                S2_2Puan = 30;
            }
            else
            {
                S2_2Puan = 0;
            }

            if (Class1.Cevap_2_3 == "orta")
            {
                S2_3Puan = 30;
            }
            else
            {
                S2_3Puan = 0;
            }

            if (Class1.Cevap_2_4 == "çok")
            {
                S2_4Puan = -30;
            }
            else
            {
                S2_4Puan = 0;
            }

            LabelCevap_2_1.Text = Class1.Cevap_2_1;
            LabelCevap_2_2.Text = Class1.Cevap_2_2;
            LabelCevap_2_3.Text = Class1.Cevap_2_3;
            LabelCevap_2_4.Text = Class1.Cevap_2_4;


            //Cevap 3 ile ilgili işlemler
            LabelCevap_3.Text = Class1.Cevap_3;
            if (Class1.Cevap_3 == "mobil")
            {
                LabelCevap_3_Control.TextColor = Color.Green;
                LabelCevap_3_Control.Text = "Doğru";

                LabelCevap_3_Puan.TextColor = Color.Green;
                S3_Puan = 20;
            }
            else
            {
                LabelCevap_3_Control.TextColor = Color.Red;
                LabelCevap_3_Control.Text = "Yanlış";

                LabelCevap_3_Puan.TextColor = Color.Red;
                S3_Puan = 0;
            }

            //Puan Hesabı

            LabelCevap_1_Puan.Text = S1_Puan.ToString();
            LabelCevap_2_Puan.Text = (S2_1Puan + S2_2Puan + S2_3Puan + S2_4Puan).ToString();
            LabelCevap_3_Puan.Text = S3_Puan.ToString();

            if (S2_1Puan + S2_2Puan + S2_3Puan + S2_4Puan > 0)
            {
                LabelCevap_2_Puan.TextColor = Color.Green;
            }
            else
            {
                LabelCevap_2_Puan.TextColor = Color.Red;
            }


            //İhtimal hesabı
            ihtimal = S1_Puan + S2_1Puan + S2_2Puan + S2_3Puan + S2_4Puan + S3_Puan;

            if (ihtimal >= 60)
            {
                Label_ihtimal_Rakamla.TextColor = Color.Green;
                Label_ihtimal_Yazıyla.TextColor = Color.Green;
                Label_ihtimal_Yazıyla.Text = "Tebrikler, sanırım geçtiniz :)";
            }
            else
            {
                Label_ihtimal_Rakamla.TextColor = Color.Red;
                Label_ihtimal_Yazıyla.TextColor = Color.Red;
                Label_ihtimal_Yazıyla.Text = "Üzgünüm ki seneye de beraberiz ):";
            }
            Label_ihtimal_Rakamla.Text = ihtimal.ToString();

        }

    }
}