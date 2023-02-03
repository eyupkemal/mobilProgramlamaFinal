using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Boolean s1_cevap = false;
        Boolean s2_cevap = false;
        Boolean s3_cevap = false;
        public Page1()
        {
            InitializeComponent();
            Class1.Cevap_1 = "";
            Class1.Cevap_2_1 = "";
            Class1.Cevap_2_2 = "";
            Class1.Cevap_2_3 = "";
            Class1.Cevap_2_4 = "";
            Class1.Cevap_3 = "";

        }
        void Soru_1_RadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            //Label_Soru_1.Text = $"Seçiminiz: {button.Content}";
            Class1.Cevap_1 = $"{button.Content}";
            s1_cevap = true;
            LabelTestiTamamladınızKontrol();
        }

        void CheckBoxChanged_1(object sender, CheckedChangedEventArgs e)
        {
            s2_cevap = true;
            LabelTestiTamamladınızKontrol();
            if (e.Value)
            {
                Class1.Cevap_2_1 = Label_Anlamıyorum.Text;
            }
            else
            {
                Class1.Cevap_2_1 = "";
            }

        }
        void CheckBoxChanged_2(object sender, CheckedChangedEventArgs e)
        {
            s2_cevap = true;
            LabelTestiTamamladınızKontrol();
            if (e.Value)
            {
                Class1.Cevap_2_2 = Label_Çok_Şey_Öğrendim.Text;
            }
            else
            {
                Class1.Cevap_2_2 = "";
            }
        }
        void CheckBoxChanged_3(object sender, CheckedChangedEventArgs e)
        {
            s2_cevap = true;
            LabelTestiTamamladınızKontrol();
            if (e.Value)
            {
                Class1.Cevap_2_3 = Label_Kolay.Text;
            }
            else
            {
                Class1.Cevap_2_3 = "";
            }
        }
        void CheckBoxChanged_4(object sender, CheckedChangedEventArgs e)
        {
            s2_cevap = true;
            LabelTestiTamamladınızKontrol();
            if (e.Value)
            {
                Class1.Cevap_2_4 = Label_Zor.Text;
            }
            else
            {
                Class1.Cevap_2_4 = "";
            }
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry.Text != "Kelimeyi buraya yazınız")
            {
                s3_cevap = true;
            }

            LabelTestiTamamladınızKontrol();
            Class1.Cevap_3 = entry.Text;

        }

        void LabelTestiTamamladınızKontrol()
        {
            if (s1_cevap == true && s2_cevap == true && s3_cevap == true)
            {
                LabelTestiTamamladınız.Text = "Tebrikler Testi Tamamladınız!";
            }
        }




    }
}