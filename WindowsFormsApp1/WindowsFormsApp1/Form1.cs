using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:1
** ÖĞRENCİ ADI............:Muhammed Emin AKBULUT
** ÖĞRENCİ NUMARASI.......:B151200023
** DERSİN ALINDIĞI GRUP...:A
****************************************************************************/

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] PizzaTur = { "Klasik", "Sucuksever", "Sosyal", "Süperos" }; //Bu satırda pizza türlerimizi ve değerlerini tanımladık.

        public class Malzemeler // Bu bloğun içinde malzemelerimizi,eklenecek malzemelerimizi,pizza içinde kullanılan malzemelerimizi tanımladık.
        {
          public double mozarella, 
                sucuk , 
                jambon ,
                sosis , 
                domates , 
                yesilbiber , 
                siyahzeytin , 
                misir , 
                mantar ;
        }
        double e_mozarella=0,
                e_sucuk=0,
                e_jambon=0,
                e_sosis=0,
                e_domates=0,
                e_yesilbiber=0,
                e_siyahzeytin=0,
                e_misir=0,
                e_mantar=0;
        double d_mozarella = 0,
                d_sucuk = 0,
                d_jambon = 0,
                d_sosis = 0,
                d_domates = 0,
                d_yesilbiber = 0,
                d_siyahzeytin = 0,
                d_misir = 0,
                d_mantar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Klasik") // Eğer pizza türleri içinden 'klasik' seçildiyse;
            {
                d_mozarella = 200*Convert.ToDouble(numericUpDown1.Value); //Her pizza türü için tanımladığımız malzemeler , mevcut malzemelerden düşülüyor.
                d_sucuk = 0; // 'Klasik' seçimi için yalnızca 'mozarella' malzemesinden eksilme yapılıyor. 
                d_jambon = 0;
                d_sosis = 0;
                d_domates = 0;
                d_yesilbiber = 0;
                d_siyahzeytin = 0;
                d_misir = 0;
                d_mantar = 0;
                if (d_mozarella>malzeme.mozarella) //Bu pizzanın yapılmasını engelleyecek tek durum olan mozarellanın 200gr'dan az olması ve bu satırda bu koşul sağlanırsa bir hata mesajı oluşturduk.
                {
                    MessageBox.Show("Malzeme Yetersiz", "Yetersiz Malzeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Pizzanın yapılmasını engelleyen bir durum olmazsa aşağıda gösterildiği gibi mevcut malzemelerden , pizza adedine göre işlem yapılarak eksilme yapılıyor.
                {
                    malzeme.mozarella = malzeme.mozarella - d_mozarella;
                    malzeme.sucuk = malzeme.sucuk - d_sucuk;
                    malzeme.jambon = malzeme.jambon - d_jambon;
                    malzeme.sosis = malzeme.sosis - d_sosis;
                    malzeme.domates = malzeme.domates - d_domates;
                    malzeme.yesilbiber = malzeme.yesilbiber - d_yesilbiber;
                    malzeme.siyahzeytin = malzeme.siyahzeytin - d_siyahzeytin;
                    malzeme.misir = malzeme.misir - d_misir;
                    malzeme.mantar = malzeme.mantar - d_mantar;
                }
               
            } 
            else if (comboBox1.Text == "Sucuksever")
            {
                d_mozarella = 200 * Convert.ToDouble(numericUpDown1.Value);
                d_sucuk = 150 * Convert.ToDouble(numericUpDown1.Value); //Bu pizza için mozarellanın yanında 'sucuk' da gerek şart. Dolayısıyla burda da bir değer ataması yaptık.
                d_jambon = 0;
                d_sosis = 0;
                d_domates = 0;
                d_yesilbiber = 0;
                d_siyahzeytin = 0;
                d_misir = 0;
                d_mantar = 0;
                if (d_mozarella > malzeme.mozarella || d_sucuk > malzeme.sucuk) //Bu pizzanın yapılmasını engelleyen 2 şart var. 2 şartı da tanımladık. Bu 2 şarttan biri gerçekleşirse hata mesajı yolluyoruz.
                {
                    MessageBox.Show("Malzeme Yetersiz", "Yetersiz Malzeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    malzeme.mozarella = malzeme.mozarella - d_mozarella; //2 şart sağlanmazsa pizza seçimi onaylanıyor ve gerekli malzemeler mevcut malzemeler listesinden düşülüyor.
                    malzeme.sucuk = malzeme.sucuk - d_sucuk;
                    malzeme.jambon = malzeme.jambon - d_jambon;
                    malzeme.sosis = malzeme.sosis - d_sosis;
                    malzeme.domates = malzeme.domates - d_domates;
                    malzeme.yesilbiber = malzeme.yesilbiber - d_yesilbiber;
                    malzeme.siyahzeytin = malzeme.siyahzeytin - d_siyahzeytin;
                    malzeme.misir = malzeme.misir - d_misir;
                    malzeme.mantar = malzeme.mantar - d_mantar;
                }
                
            }
            else if (comboBox1.Text == "Süperos")
            {
                d_mozarella = 200 * Convert.ToDouble(numericUpDown1.Value); //Bu pizza en çok malzemeye ihtiyaç duyduğumuz pizza ve 6 malzeme için gerek şart gramajlarını atıyoruz.
                d_sucuk = 75 * Convert.ToDouble(numericUpDown1.Value);
                d_jambon = 50 * Convert.ToDouble(numericUpDown1.Value);
                d_sosis = 75 * Convert.ToDouble(numericUpDown1.Value);
                d_domates = 40 * Convert.ToDouble(numericUpDown1.Value);
                d_yesilbiber = 0;
                d_siyahzeytin = 30 * Convert.ToDouble(numericUpDown1.Value);
                d_misir = 0;
                d_mantar = 0;
                if (d_mozarella > malzeme.mozarella || d_sucuk > malzeme.sucuk || d_jambon>malzeme.jambon||d_sosis>malzeme.sosis||d_domates>malzeme.domates||d_siyahzeytin>malzeme.siyahzeytin) //Pizzanın yapılmasına engel olan şartlar burda mevcut. Bu şartlardan 1'i gerçekleşirse sipariş onaylanmıyor.
                {
                    MessageBox.Show("Malzeme Yetersiz", "Yetersiz Malzeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    malzeme.mozarella = malzeme.mozarella - d_mozarella;
                    malzeme.sucuk = malzeme.sucuk - d_sucuk;
                    malzeme.jambon = malzeme.jambon - d_jambon;
                    malzeme.sosis = malzeme.sosis - d_sosis;
                    malzeme.domates = malzeme.domates - d_domates;
                    malzeme.yesilbiber = malzeme.yesilbiber - d_yesilbiber;
                    malzeme.siyahzeytin = malzeme.siyahzeytin - d_siyahzeytin;
                    malzeme.misir = malzeme.misir - d_misir;
                    malzeme.mantar = malzeme.mantar - d_mantar;
                }
                
            }
            else if (comboBox1.Text == "Sosyal")
            {
                d_mozarella = 200 * Convert.ToDouble(numericUpDown1.Value); //Bu pizza için yine 5 çeşit malzemeye ihtiyaç var ve bu ihtiyaçlar doğrultusunda gramaj değerleri atanıyor.
                d_sucuk = 75 * Convert.ToDouble(numericUpDown1.Value);
                d_jambon = 0;
                d_sosis = 0;
                d_domates = 0;
                d_yesilbiber = 50 * Convert.ToDouble(numericUpDown1.Value);
                d_siyahzeytin = 0;
                d_misir = 25 * Convert.ToDouble(numericUpDown1.Value);
                d_mantar = 60 * Convert.ToDouble(numericUpDown1.Value);
                if (d_mozarella > malzeme.mozarella || d_sucuk > malzeme.sucuk || d_yesilbiber > malzeme.yesilbiber || d_misir > malzeme.misir || d_mantar > malzeme.mantar ) //Pizzanın yapılmasını engelleyen şartlar burda tanımlanıyor ve 1'i gerçekleşiyorsa hata mesajı fırlatılıyor.
                {
                    MessageBox.Show("Malzeme Yetersiz", "Yetersiz Malzeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    malzeme.mozarella = malzeme.mozarella - d_mozarella;
                    malzeme.sucuk = malzeme.sucuk - d_sucuk;
                    malzeme.jambon = malzeme.jambon - d_jambon;
                    malzeme.sosis = malzeme.sosis - d_sosis;
                    malzeme.domates = malzeme.domates - d_domates;
                    malzeme.yesilbiber = malzeme.yesilbiber - d_yesilbiber;
                    malzeme.siyahzeytin = malzeme.siyahzeytin - d_siyahzeytin;
                    malzeme.misir = malzeme.misir - d_misir;
                    malzeme.mantar = malzeme.mantar - d_mantar;
                }
            }
            //MalzemeBilgi adında bir dizi oluşturduk ve indislere karşılık gelen malzemeleri atadık.
            MalzemeBilgi[0] = Convert.ToString(malzeme.mozarella);
            MalzemeBilgi[1] = Convert.ToString(malzeme.sucuk);
            MalzemeBilgi[2] = Convert.ToString(malzeme.jambon);
            MalzemeBilgi[3] = Convert.ToString(malzeme.sosis);
            MalzemeBilgi[4] = Convert.ToString(malzeme.domates);
            MalzemeBilgi[5] = Convert.ToString(malzeme.yesilbiber);
            MalzemeBilgi[6] = Convert.ToString(malzeme.siyahzeytin);
            MalzemeBilgi[7] = Convert.ToString(malzeme.misir);
            MalzemeBilgi[8] = Convert.ToString(malzeme.mantar);
            
            System.IO.File.WriteAllLines(Application.StartupPath + "\\malzemeler.txt", MalzemeBilgi);
            txtMalzemeOku();
            TxtMalzemeYaz();
        }

        Malzemeler malzeme = new Malzemeler(); //Referans dizisi...
        string[] MalzemeBilgi;
        private void txtMalzemeOku()
        {
            
            MalzemeBilgi = System.IO.File.ReadAllLines(Application.StartupPath + "\\malzemeler.txt"); //Malzemelerimizin mevcut değerlerini tuttuğumuz .txt dosyasından değer okutuyoruz.
            malzeme.mozarella = Convert.ToDouble(MalzemeBilgi[0]);
            malzeme.sucuk = Convert.ToDouble(MalzemeBilgi[1]);
            malzeme.jambon = Convert.ToDouble(MalzemeBilgi[2]);
            malzeme.sosis = Convert.ToDouble(MalzemeBilgi[3]);
            malzeme.domates = Convert.ToDouble(MalzemeBilgi[4]);
            malzeme.yesilbiber = Convert.ToDouble(MalzemeBilgi[5]);
            malzeme.siyahzeytin = Convert.ToDouble(MalzemeBilgi[6]);
            malzeme.misir = Convert.ToDouble(MalzemeBilgi[7]);
            malzeme.mantar = Convert.ToDouble(MalzemeBilgi[8]);
        }
        public void TxtMalzemeYaz() //Siparişler ve malzeme ekleme sonucu oluşan malzeme değerlerini bu blokta elde ediyoruz. 
        {
            label13.Text = malzeme.mozarella.ToString("N")+" gr";
            label14.Text = malzeme.sucuk.ToString("N")+" gr";
            label15.Text = malzeme.jambon.ToString("N")+" gr";
            label16.Text = malzeme.sosis.ToString("N")+" gr";
            label17.Text = malzeme.domates.ToString("N")+" gr";
            label18.Text = malzeme.yesilbiber.ToString("N")+" gr";
            label19.Text = malzeme.siyahzeytin.ToString("N")+" gr";
            label20.Text = malzeme.misir.ToString("N")+" gr";
            label21.Text = malzeme.mantar.ToString("N")+" gr";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(PizzaTur); //Elde ettiğimiz değerleri de burda okuyup yazdırıyoruz.
            txtMalzemeOku();
            TxtMalzemeYaz();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Malzeme ekleme butonu 
        { //Aşağıda 8 farklı malzeme için 8 adet adım bulunmakta. Bunlar olası bir hatayı yakalama amacıyla 'try-catch' ifadeleriyle bu kısmı oluşturdum.
            try
            {
                e_mozarella = Convert.ToDouble(textBox1.Text); //Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox1'e yazıldı.
                MalzemeBilgi[0] = Convert.ToString(malzeme.mozarella + e_mozarella); //Malzeme bilgisinin 0.indisindeki mevcut mozarella miktarına eklenecek miktar aktarıldı.
                
            }
            catch
            {

            }
            try
            {
                e_sucuk = Convert.ToDouble(textBox2.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox2'e yazıldı.
                MalzemeBilgi[1] = Convert.ToString(malzeme.sucuk + e_sucuk);//Malzeme bilgisinin 1.indisindeki mevcut sucuk miktarına eklenecek miktar aktarıldı.


            }
            catch
            {

            }
            try
            {
                e_jambon = Convert.ToDouble(textBox3.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox3'e yazıldı.
                MalzemeBilgi[2] = Convert.ToString(malzeme.jambon + e_jambon);//Malzeme bilgisinin 2.indisindeki mevcut jambon miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_sosis = Convert.ToDouble(textBox4.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox4'e yazıldı.
                MalzemeBilgi[3] = Convert.ToString(malzeme.sosis + e_sosis);//Malzeme bilgisinin 3.indisindeki mevcut sosis miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_domates = Convert.ToDouble(textBox5.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox5'e yazıldı.
                MalzemeBilgi[4] = Convert.ToString(malzeme.domates + e_domates);//Malzeme bilgisinin 4.indisindeki mevcut domates miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_yesilbiber = Convert.ToDouble(textBox6.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox6'e yazıldı.
                MalzemeBilgi[5] = Convert.ToString(malzeme.yesilbiber + e_yesilbiber);//Malzeme bilgisinin 5.indisindeki mevcut yeşil biber miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_siyahzeytin = Convert.ToDouble(textBox7.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox7'e yazıldı.
                MalzemeBilgi[6] = Convert.ToString(malzeme.siyahzeytin + e_siyahzeytin);//Malzeme bilgisinin 6.indisindeki mevcut siyah zeytin miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_misir = Convert.ToDouble(textBox8.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox8'e yazıldı.
                MalzemeBilgi[7] = Convert.ToString(malzeme.misir + e_misir);//Malzeme bilgisinin 7.indisindeki mevcut mısır miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            try
            {
                e_mantar = Convert.ToDouble(textBox9.Text);//Eklenecek malzeme değeri 'double' değere dönüştürülüp 'TextBox9'e yazıldı.
                MalzemeBilgi[8] = Convert.ToString(malzeme.mantar + e_mantar);//Malzeme bilgisinin 8.indisindeki mevcut mantar miktarına eklenecek miktar aktarıldı.

            }
            catch
            {

            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\malzemeler.txt", MalzemeBilgi);
            txtMalzemeOku();
            TxtMalzemeYaz();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
           
        }
    }
}
