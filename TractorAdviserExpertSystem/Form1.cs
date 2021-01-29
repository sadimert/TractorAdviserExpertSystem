using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TractorAdviserExpertSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            int kural = 0;
            string drivingLcience = " ";
            string usageArea = " ";
            int many;
            string abs = " ";
            string tractionControl = " ";
            string Kabin = " ";
            string field = " ";
            switch (Ehliyet.SelectedIndex)
            {
                case 0:
                    drivingLcience = "F";
                    break;
                case 1:
                    drivingLcience = "G";
                    break;
                case 2:
                    drivingLcience = "B";
                    break;
                case 3:
                    drivingLcience = "A";
                    break;
                case 4:
                    drivingLcience = "Yok";
                    break;
            }

            switch (KullanımAlanı.SelectedIndex)
            {
                case 0:
                    usageArea = "Tarla";
                    break;
                case 1:
                    usageArea = "Bahçe";
                    break;
                case 2:
                    usageArea = "Çiftlik";
                    break;
                case 3:
                    usageArea = "Yük Taşıma ";
                    break;
            }
            many = Int32.Parse(Bütçe.Text);
            
          switch (ABS.SelectedIndex)
     
            {
                case 0:
                    abs = "var";
                    break;
                case 1:
                    abs = "yok";
                    break;
            }
            switch (ÇekişKontrol.SelectedIndex)
            {
                case 0:
                    tractionControl = "var";
                    break;
                case 1:
                    tractionControl = "yok";
                    break;
            }
            if (KabinYok.Checked)
                Kabin = "KabinYok";
            else if (Tente.Checked)
                Kabin = "Tente";
            else if (Kabinli.Checked)
                Kabin = "Kabinli";



            switch (arazi.SelectedIndex)
            {
                case 0:
                    field = "<1000";
                    break;
                case 1:
                    field = "1000-20000";
                    break;
                case 2:
                    field = "20000-50000";
                    break;
                case 3:
                    field = "50000-100000";
                    break;
                case 4:
                    field = ">100000";
                    break;
            }

            if (drivingLcience == "Yok")
            {
                sonuç.Text = "Ehliyet Yok O Halde Traktör = yok.";
                kural++;
            }

            else if (many >= 65000 && abs == "var" && tractionControl == "var" && Kabin == "kabinli" && field == ">100000")
            {
                sonuç.Text = "O Halde Çift Çeker Kabinli Traktör  = belki alınabilir";
                kural++;
                if (usageArea == "Tarla")
                {
                    sonuç.Text = "O Halde tam otomatik destekli ince lastik traktör  = belki alınabilir";
                    kural++;
                    if (many >= 65100)
                    {
                        sonuç.Text = "O Halde Traktör = New Holland TD 75 \n";
                        kural++;
                    }
                }
                if (usageArea == "Tarla" && many >= 65800)
                {
                    sonuç.Text = "O Halde tam otomatik destekli kalın lastik traktör = belki alınabilir";
                    kural++;
                    if (many >= 139600)
                    {
                        sonuç.Text = "O Halde Traktör = Tümosan 8075 s\n";
                        kural++;
                    }
                    else if (many >= 122000)
                    {
                        sonuç.Text = "O Halde Traktör = New Holland TD 95 \n";
                        kural++;
                    }
                    else if (many >= 91600)
                    {
                        sonuç.Text = "O Halde Traktör = CASE JX90 PRO 4WD KABİN KLİMALI\n";
                        kural++;
                    }
                    else if (many >= 82466)
                    {
                        sonuç.Text = "O Halde Traktör = CASE JX90\n";
                        kural++;
                    }
                    else if (many >= 79600)
                    {
                        sonuç.Text = "O Halde Traktör = CASE JX75 \n";
                        kural++;
                    }
                    else if (many >= 72800)
                    {
                        sonuç.Text = "O Halde Traktör = Tümosan 7056\n";
                        kural++;
                    }
                    else if (many >= 67160)
                    {
                        sonuç.Text = "O Halde Traktör = Landini Powerfarm 110 \n";
                        kural++;
                    }
                    else if (many >= 56800)
                    {
                        sonuç.Text = "O Halde Traktör =  Kubota M6040 \n";
                        kural++;
                    }
                }
                if (usageArea == "Çiftlik" && many >= 57000)
                {
                    sonuç.Text = "O Halde tam otomatik Traktör= belki alınabilir";
                    kural++;
                    if (many >= 90760)
                    {
                        sonuç.Text = "O Halde Traktör = New Holland TD 60\n";
                        kural++;
                    }
                    else if (many >= 90200)
                    {
                        sonuç.Text = "O Halde Traktör = Tümosan 8175 \n";
                        kural++;
                    }
                    else if (many >= 84448)
                    {
                        sonuç.Text = "O Halde Traktör = JOHNDEERE 6115D \n";
                        kural++;
                    }
                    else if (many >= 71600)
                    {
                        sonuç.Text = "O Halde Traktör = JOHNDEERE 6517\n";
                        kural++;
                    }
                    else if (many >= 57000)
                    {
                        sonuç.Text = "O Halde Traktör = LANDİNİ REX 100 GE\n";
                        kural++;
                    }
                }
                if (usageArea == "Bahçe" && many >= 63435)
                {
                    sonuç.Text = "O Halde tam otomatik Traktör= belki alınabilir = belki alınabilir";
                    kural++;
                    if (many >= 135600)
                    {
                        sonuç.Text = "O Halde Traktör = LANDİNİ REX 100 GE\n";
                        kural++;
                    }
                    else if (many >= 128060)
                    {
                        sonuç.Text = "O Halde Traktör = Türk Fiat 70-56\n";
                        kural++;
                    }
                    else if (many >= 117355)
                    {
                        sonuç.Text = "O Halde Traktör = New Holland T5689\n";
                        kural++;
                    }
                    else if (many >= 90600)
                    {
                        sonuç.Text = "O Halde Traktör = Case Jx 65\n";
                        kural++;
                    }
                    else if (many >= 65160)
                    {
                        sonuç.Text = "O Halde Traktör = Jhon Deree 7595 \n";
                        kural++;
                    }
                    else if (many >= 63435)
                    {
                        sonuç.Text = "O Halde Traktör = Türk Fiat 80-66\n";
                        kural++;
                    }

                }
            }
            else if (drivingLcience == "A" && many >= 41900 && abs == "var" && Kabin == "Kabinli" || field == "50000-100000")
            {
                sonuç.Text = "O Halde Kabinli güçlü Traktör = belki alınabilir";
                kural++;
                if (usageArea == "Tarla" && many >= 41900)
                {
                    sonuç.Text = "O Halde Tarla için güçlü Traktör = belki alınabilir";
                    kural++;
                    if (many >= 49200)
                    {
                        sonuç.Text = "O Halde Traktör = Başak 2056\n";
                        kural++;
                    }
                    else if (many >= 45500)
                    {
                        sonuç.Text = "O Halde Traktör  = Başak 2060 pro\n";
                        kural++;
                    }
                    else if (many >= 41900)
                    {
                        sonuç.Text = "O Halde Traktör = Case jx 75\n";
                        kural++;
                    }


                }
                if (usageArea == "Yük Taşıma" && many >= 48500)
                {
                    sonuç.Text = "O Halde çift çeker güçlü traktör = belki alınabilir";
                    kural++;
                    if (many >= 48500)
                    {
                        sonuç.Text = "O Halde Traktör = Deutz DT90\n";
                        kural++;
                    }
                }
                if (usageArea == "Tarla" && many >= 44800)
                {
                    sonuç.Text = "O Halde kabinsiz çift çeker Traktör = belki alınabilir";
                    kural++;
                    sonuç.Text = "O Halde Traktör = DEUTZ FAHR 6140\n";
                }
                if (usageArea == "bozuk" && many >= 50400)
                {
                    sonuç.Text = "O Halde Traktör = DEUTZ Agrotron 100\n";
                    kural++;
                }
            }
            else if (drivingLcience == "D" && many >= 24499 && abs == "var" && Kabin == "Tente" || field == "20000-50000")
            {
                sonuç.Text = "O Halde Tek çeker traktör = belki alınabilir";
                kural++;
                if (usageArea == "Bahçe")
                {
                    sonuç.Text = "O Halde Tek Çeker Bahçe Traktörü = belki alınabilir";
                    kural++;
                    if (many >= 33599)
                    {
                        sonuç.Text = "O Halde Traktör = Erkunt Bereket 65\n";
                        kural++;
                    }
                    else if (many >= 30500)
                    {
                        sonuç.Text = "O Halde Traktör = Erkunt Haşmet 90 07\n";
                        kural++;
                    }
                    else if (many >= 27400)
                    {
                        sonuç.Text = "O Halde Traktör = Erkunt Servet 70\n";
                        kural++;
                    }
                    else if (many >= 24499)
                    {
                        sonuç.Text = "O Halde Traktör = New Holland Td 60\n";
                        kural++;
                    }
                }
                if (usageArea == "Yük Taşıma" && many >= 39400)
                {
                    sonuç.Text = "O Halde çift çeker güçlü traktör = belki alınabilir";
                    kural++;
                    sonuç.Text = "O Halde Traktör = Erkunt Kudret 85 \n";
                }
                if (usageArea == "Bahçe" && many >= 34700)
                {
                    sonuç.Text = "O Halde Tek çeker bahçe Traktörü = belki alınabilir";
                    kural++;
                    if (many >= 34700)
                    {
                        sonuç.Text = "O Halde Traktör = Erkunt Kısmet 55\n";
                        kural++;
                    }
                    else if (many >= 31599)
                    {
                        sonuç.Text = "O Halde Traktör = Massey Ferguson 3095D \n";
                        kural++;
                    }


                }
                if (usageArea == "Tarla" && many >= 37596 && Kabin == "Tente")
                {
                    sonuç.Text = "O Halde çift çeker tenteli traktör = belki alınabilir";
                    kural++;
                    if (many >= 52000)
                    {
                        sonuç.Text = "O halde Traktör = Ford 3600";
                        kural++;
                    }
                    else if (many >= 50400)
                    {
                        sonuç.Text = "O halde Traktör = Ford 5000 super";
                        kural++;
                    }
                    else if (many >= 47196)
                    {
                        sonuç.Text = "O halde Traktör = Ford 5000";
                        kural++;
                    }
                    else if (many >= 37596)
                    {
                        sonuç.Text = "O Halde Traktör = Ford 6600\n";
                        kural++;
                    }
                }
                if (usageArea == "Bahçe" && many >= 38900)
                {
                    sonuç.Text = "O Halde bahçe traktörü = belki alınabilir";
                    kural++;
                    if (many >= 39400)
                    {
                        sonuç.Text = "O Halde Traktör = Styer 70 f\n";
                        kural++;
                    }
                    else if (many >= 38900)
                    {
                        sonuç.Text = "O Halde Traktör = Fiat 640 \n";
                        kural++;
                    }

                }
            }
            else if ((drivingLcience == "B" || drivingLcience == "A") && ((many >= 10858) && (Kabin == "Kabin Yok" || field == "1000-20000")))
            {
                sonuç.Text = "O Halde kabinsiz traktör  = belki alınabilir";
                kural++;

                if (usageArea == "Çiftlik" && many >= 10858)
                {
                    sonuç.Text = "O Halde kabinsiz traktör = belki alınabilir";
                    kural++;
                    if ((many >= 18999) && abs == "var")
                    {
                        sonuç.Text = "O Halde Traktör = MC CORMICK B MAX 105  \n";
                        kural++;
                    }
                    else if (many >= 10858)
                    {
                        sonuç.Text = "O Halde Traktör = MC CORMICK B MAX 65 \n";
                        kural++;
                    }


                }
                if (usageArea == "Tarla" && many >= 17450)
                {
                    sonuç.Text = "O Halde tek çeker traktör = belki alınabilir";
                    kural++;
                    sonuç.Text = "O Halde Traktör = Ford 3000 \n";
                }
                if (usageArea == "Yük Taşıma" && many >= 16600)
                {
                    if (many >= 18750)
                    {
                        sonuç.Text = "O Halde Traktör = Tümosan 6060\n";
                        kural++;
                    }
                    else if (many >= 16600)
                    {
                        sonuç.Text = "O Halde Traktör = Türk Fiat 70 86\n";
                        kural++;
                    }

                }
                if (usageArea == "Bahçe" && many >= 23999)
                {
                    sonuç.Text = "O Halde Bahçe Traktörü = belki alınabilir";
                    kural++;
                    sonuç.Text = "O Halde Traktör  = CASE IH JX70 PLUS\n";
                }
            }
            else if (((drivingLcience == "G" || drivingLcience == "B") || (drivingLcience == "D")) && (many >= 3650))
            {
                sonuç.Text = "O Halde Bahçe Traktörü = belki alınabilir";
                kural++;
                if (many >= 3650)
                {
                    sonuç.Text = "O Halde Traktör = Kubota L3200\n";
                    kural++;
                }
                if (many >= 4444 && usageArea == "Tarla")
                {
                    sonuç.Text = "O Halde Tarla için güçlü traktör = belki alınabilir";
                    kural++;
                    if (many >= 14999)
                    {
                        sonuç.Text = "O Halde Traktör = Kubota MK5000\n";
                        kural++;
                    }
                    else if (abs == "var" && many >= 7750)
                    {
                        sonuç.Text = "O Halde Traktör = Uzel 240\n";
                        kural++;
                    }
                    else if (many >= 6600)
                    {
                        sonuç.Text = "O Halde Traktör = Uzel 340\n";
                        kural++;
                    }
                    else if (many >= 4750)
                    {
                        sonuç.Text = "O Halde Traktör = Zetor 8441\n";
                        kural++;
                    }
                    else if (many >= 4444)
                    {
                        sonuç.Text = "O Halde Traktör = Zetor  115\n";
                        kural++;
                    }
                }
                if (many >= 12400 && usageArea == "Bahçe")
                {
                    sonuç.Text = "O Halde Bahçe traktörü = belki alınabilir";
                    kural++;
                    if (abs == "var" && many >= 19900)
                    {
                        sonuç.Text = "O Halde Traktör  = LS Plus 80\n";
                        kural++;
                    }
                    else if (abs == "var" && many >= 15999)
                    {
                        sonuç.Text = "O Halde Traktör = LS 75\n";
                        kural++;
                    }
                    else if (many >= 12400)
                    {
                        sonuç.Text = "O Halde Traktör = Universal 683\n";
                        kural++;
                    }
                }
                if (many >= 14199 && usageArea == "Tarla")
                {
                    sonuç.Text = "O Halde tarla için tek çeker Traktör = belki alınabilir";
                    kural++;
                    sonuç.Text = "O Halde Traktör = Universal 533 \n";
                }

            }
            else if (drivingLcience == "F" || drivingLcience == "G" || drivingLcience == "B" || drivingLcience == "B" && many >= 3000)
            {
                sonuç.Text = "O Halde Kalın lastik traktör = belki alınabilir";
                kural++;
                if (drivingLcience == "M" && field == "<10000")
                {
                    sonuç.Text = "O Halde Traktör = Ford 5000\n";
                    kural++;
                }
            }
            else
                sonuç.Text = "O Halde  Traktör = bulunamadı";
            KuralGöster.Text = "Bulunan kural sayısı: " + kural.ToString();

        }

        private void Tente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
