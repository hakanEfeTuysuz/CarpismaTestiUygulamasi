/*******************************************************************************
                                SAKARYA ÜNİVERSİTESİ
                       BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                           NESNEYE DAYALI PROGRAMLAMA DERSİ


          ÖDEV NUMARASI      : 2
          ÖĞRENCİ ADI-SOYADI : HAKAN EFE TÜYSÜZ
          ÖĞRENCİ NUMARASI   : B231210098
          DERS GRUBU         : A
          DERS HOCASI ADI    : CEMİL ÖZ


 *********************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NesneyeDayalıProgramlamaOdev2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Burada ComboBox tan seçilen elemana göre çizimler ve çarpışmalar yapılıyor
            string secilenEleman = comboBox1.SelectedItem.ToString();
            switch (secilenEleman)                  
            {
                case "Nokta-Dörtgen":
                    pictureBox1.Invalidate(); //PictureBox temizleniyor
                    pictureBox1.Refresh();

                    //Nokta ve Dörtgen sınıfından nesneler türetiliyor
                    Nokta n=new Nokta();    
                    Dortgen d1 = new Dortgen();

                    // Noktanın ve Dörtgenin verileri textBox a yazdırılıyor
                    textBox1.Text = "Noktanın verileri (x,y) : (" + n.x + "," + n.y+")";
                    textBox2.Text="Dörtgenin verileri (x,y,h,d) :("+d1.x+","+d1.y+","+d1.yukseklik+","+d1.genişlik+","+")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    if (n.x>=d1.x && n.x <= d1.x + d1.genişlik && n.y >= d1.y && n.y <= d1.y + d1.yukseklik)   
                    {
                        textBox3.Text=("Nokta ve Dörtgen Çarpıştı!");
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = ("Nokta ve Dörtgen Çarpışmadı!");
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    n.Ciz(pictureBox1);
                    d1.Ciz(pictureBox1);
                    break;

                case "Nokta-Çember":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Nokta ve Çember sınıfından nesneler türetiliyor
                    Nokta n2 = new Nokta();
                    Cember c = new Cember();

                    int yaricap = c.cap / 2;
                    int merkezx = c.x + yaricap;
                    int merkezy=c.y + yaricap;

                    // Noktanın ve Çemberin verileri textBox a yazdırılıyor
                    textBox1.Text = "Noktanın verileri (x,y) : (" + n2.x + "," + n2.y + ")";
                    textBox2.Text="çemberin verileri (x,y,r) : ("+merkezx+","+merkezy+","+yaricap+")";


                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    double uzaklik = Math.Sqrt(Math.Pow(n2.x - merkezx, 2) + Math.Pow(n2.y - merkezy, 2));
                    if (uzaklik <= yaricap)
                    {
                        textBox3.Text = "Nokta ve Çember Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = ("Nokta ve Dörtgen Çarpışmadı!");
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    n2.Ciz(pictureBox1 );
                    c.Ciz(pictureBox1 );
                    break;

                case "Dörtgen-Dörtgen":
                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Dörtgen sınıfından nesneler türetiliyor
                    Dortgen d2 = new Dortgen();
                    Dortgen d3 = new Dortgen();

                    // Dörtgenlerin verileri textBox a yazdırılıyor
                    textBox1.Text = " 1.Dörtgenin verileri (x,y,h,d) :(" + d2.x + "," + d2.y + "," + d2.yukseklik + "," + d2.genişlik + "," + ")";
                    textBox2.Text = "2.Dörtgenin verileri (x,y,h,d) :(" + d3.x + "," + d3.y + "," + d3.yukseklik + "," + d3.genişlik + "," + ")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    if (Math.Abs((d2.x + d2.genişlik / 2) - (d3.x + d3.genişlik / 2)) < (d2.genişlik / 2 + d3.genişlik / 2) &&
                    Math.Abs((d2.y + d2.yukseklik / 2) - (d3.y + d3.yukseklik / 2)) < (d2.yukseklik / 2 + d3.yukseklik / 2))
                    {
                        textBox3.Text = "Dörtgen ve Dörtgen Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = ("Dörtgen ve Dörtgen Çarpışmadı!");
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    d2.Ciz(pictureBox1);
                    d3.Ciz(pictureBox1);

                    break;

                case "Dörtgen-Çember":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Dörtgen ve Çember sınıfından nesneler türetiliyor
                    Dortgen d4 = new Dortgen();
                    Cember c1 = new Cember();

                    int yariCap = c1.cap / 2;
                    int merkezX = c1.x + yariCap;
                    int merkezY= c1.y + yariCap;

                    // Dörtgen ve Çemberin verileri textBox a yazdırılıyor
                    textBox1.Text = "Dörtgenin verileri (x,y,h,d) :(" + d4.x + "," + d4.y + "," + d4.yukseklik + "," + d4.genişlik + "," + ")";
                    textBox2.Text = "çemberin verileri (x,y,r) : (" + merkezX + "," + merkezY + "," + yariCap + ")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    if (Math.Abs((d4.x+d4.genişlik/2)-merkezX)<d4.genişlik/2+yariCap&&
                        Math.Abs(merkezY - (d4.y + d4.yukseklik / 2)) < d4.yukseklik / 2 + yariCap)
                    {
                        textBox3.Text = "Dörtgen ve Çember Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = ("Dörtgen ve Çember Çarpışmadı!");
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    d4.Ciz(pictureBox1);
                    c1.Ciz(pictureBox1);
                    break;

                case "Çember-Çember":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Çember sınıfından nesneler türetiliyor
                    Cember c2 = new Cember();
                    Cember c3 = new Cember();

                    int merkezX1 = c2.x + c2.cap / 2;
                    int merkezY1 = c2.y + c2.cap / 2;
                    int yariCap1 = c2.cap / 2;

                    int merkezX2 = c3.x + c3.cap / 2;
                    int merkezY2 = c3.y + c3.cap / 2;
                    int yariCap2 = c3.cap / 2;
         
                    double mesafe = Math.Sqrt(Math.Pow(merkezX2 - merkezX1, 2) + Math.Pow(merkezY2 - merkezY1, 2));
                
                    int toplamYariCap = yariCap1 + yariCap2;

                    //Çemberlerin verileri textBox a yazdırılıyor
                    textBox1.Text = " 1. çemberin verileri (x,y,r) : (" + merkezX1 + "," + merkezY1 + "," + yariCap1 + ")";
                    textBox2.Text = " 2. çemberin verileri (x,y,r) : (" + merkezX2 + "," + merkezY2 + "," + yariCap2 + ")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    if (mesafe <= toplamYariCap)
                    {                      
                        textBox3.Text = "Çemberler çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {             
                        textBox3.Text = "Çemberler çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    c2.Ciz(pictureBox1);
                    c3.Ciz(pictureBox1);
                    break;

                case "Nokta-Küre":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Nokta ve Küre sınıfından nesneler türetiliyor
                    Nokta n4 = new Nokta();
                    Kure k1 = new Kure();
                    int k1YariCap = k1.cap / 2;

                    // Noktanın ve Kürenin verileri textBox a yazdırılıyor
                    textBox1.Text = "Noktanın verileri (x,y,z) : (" + n4.x + "," + n4.y + "," + n4.z + ")";
                    textBox2.Text = "Kürenin verileri (x,y,z,r) : (" + k1.x + "," + k1.y + "," + k1.z + "," + k1YariCap + ")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    // NOT: 3 boyutlu cisimlerin çarpışmalarını 2 boyutlu bir bilgisayar ekranından yapıldığı için çarpışma tam olarak bazen belli olmuyor
                    double uzaklik2 = Math.Sqrt(Math.Pow(n4.x - k1.x, 2) + Math.Pow(n4.y - k1.y, 2) + Math.Pow(n4.z - k1.z, 2));
                    if (uzaklik2 <= k1YariCap)
                    {
                        textBox3.Text = "Nokta ve Küre Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = "Nokta ve Küre Çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    k1.Ciz(pictureBox1);
                    n4.Ciz(pictureBox1);

                    break;


                case "Nokta-Dikdörtgen Prizma":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Nokta ve Prizma sınıfından nesneler türetiliyor
                    Nokta n5 = new Nokta();
                    Prizma p1 = new Prizma();

                    int pMerkezX = p1.x + p1.genişlik / 2;
                    int pMerkezY = p1.y + p1.yukseklik / 2;
                    int pMerkezZ = p1.z + p1.derinlik/ 2;

                    // Noktanın ve Prizmanın verileri textBox a yazdırılıyor
                    textBox1.Text = "Noktanın verileri (x,y,z) : (" + n5.x + "," + n5.y +","+n5.z +")";
                    textBox2.Text="Dikdörtgen Prizmasının verileri (x,y,z,h,d,u) : ("+pMerkezX+","+pMerkezY+","+pMerkezZ+","+p1.yukseklik+","+p1.genişlik+","+p1.derinlik+")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    // NOT: 3 boyutlu cisimlerin çarpışmalarını 2 boyutlu bir bilgisayardan yapıldığı için çarpışma tam olarak bazen belli olmuyor
                    if (n5.x>=p1.x&&n5.x<=p1.x+p1.genişlik&&
                        n5.y>=p1.y&&n5.y<=p1.y+p1.yukseklik&&
                        n5.x>=p1.x+p1.derinlik&&n5.x<=p1.x+p1.derinlik+p1.genişlik&&
                        n5.y >= p1.y + p1.derinlik && n5.y <= p1.y + p1.derinlik + p1.yukseklik)
                    {
                        textBox3.Text = "Nokta ve Dikdörtgen Prizma Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = "Nokta ve Dikdörtgen Prizma Çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    n5.Ciz(pictureBox1 );
                    p1.Ciz(pictureBox1 );
                    break;

                case "Silindir-Silindir":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Silindir sınıfından nesneler türetiliyor
                    Silindir s1 = new Silindir();
                    Silindir s2 = new Silindir();

                    int sYariCap = s1.cap / 2;
                    int sMerkezx = s1.x + sYariCap;
                    int sMerkezy = s1.y + s1.yukseklik / 2;
                    int sMerkezz = s1.z;

                    int sYariCap2 = s2.cap / 2;
                    int sMerkezx2 = s2.x + sYariCap2;
                    int sMerkezy2 = s2.y + s2.yukseklik / 2;
                    int sMerkezz2 = s2.z;

                    int merkezlerArasiMesafeKaresi = (sMerkezx2 - sMerkezx) * (sMerkezx2 - sMerkezx) +
                                                      (sMerkezy2 - sMerkezy) * (sMerkezy2 - sMerkezy) +
                                                      (sMerkezz2 - sMerkezz) * (sMerkezz2 - sMerkezz);
                    int maxMesafeKaresi = (sYariCap2 + sYariCap) * (sYariCap2 + sYariCap);

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    // NOT: 3 boyutlu cisimlerin çarpışmalarını 2 boyutlu bir bilgisayardan yapıldığı için çarpışma tam olarak bazen belli olmuyor
                    if (merkezlerArasiMesafeKaresi <= maxMesafeKaresi)
                    {
                        textBox3.Text = "Silindir ve Silindir Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = "Silindir ve Silindir Çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    // Silindirlerin verileri textBox a yazdırılıyor
                    textBox1.Text = "1. Silindirin verileri (x,y,z,h,r) :(" + sMerkezx + "," + sMerkezy + "," + sMerkezz + "," + s1.yukseklik + "," + sYariCap2 + ")";
                    textBox2.Text = "2. Silindirin verileri (x,y,z,h,r) :(" + sMerkezx2 + "," + sMerkezy2 + "," + sMerkezz2 + "," + s2.yukseklik + "," + sYariCap + ")";

                    //Cisimler çiziliyor
                    s1.Ciz(pictureBox1);
                    s2.Ciz(pictureBox1);

                    break;

                case "Dikdörtgen Prizma-Dikdörtgen Prizma":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Prizma sınıfından nesneler türetiliyor
                    Prizma p2 = new Prizma();
                    Prizma p3 = new Prizma();

                    int merkezxP = p2.x + p2.genişlik / 2;
                    int merkezyP = p2.y + p2.yukseklik / 2;
                    int merkezzP = p2.z + p2.derinlik / 2;

                    int merkezxP2 = p3.x + p3.genişlik / 2;
                    int merkezyP2 = p3.y + p3.yukseklik / 2;
                    int merkezzP2 = p3.z + p3.derinlik / 2;

                    // Prizmaların verileri textBox a yazdırılıyor
                    textBox1.Text = " 1. Dikdörtgen Prizmasının verileri (x,y,z,h,d,u) : (" + merkezxP + "," + merkezyP + "," + merkezzP + "," + p2.yukseklik + "," + p2.genişlik + "," + p2.derinlik + ")";
                    textBox2.Text = " 2. Dikdörtgen Prizmasının verileri (x,y,z,h,d,u) : (" + merkezxP2 + "," + merkezyP2 + "," + merkezzP2 + "," + p3.yukseklik + "," + p3.genişlik + "," + p3.derinlik + ")";

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    // NOT: 3 boyutlu cisimlerin çarpışmalarını 2 boyutlu bir bilgisayardan yapıldığı için çarpışma tam olarak bazen belli olmuyor
                    if (Math.Abs(merkezxP - merkezxP2) < (p2.genişlik + p3.genişlik) / 2 &&
                        Math.Abs(merkezyP - merkezyP2) < (p2.yukseklik + p3.yukseklik) / 2 &&
                        Math.Abs(merkezzP - merkezzP2) < (p2.derinlik + p3.derinlik) / 2)
                    {
                        textBox3.Text = "Dikdörtgen Prizma ve Dikdörtgen Prizma Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = "Dikdörtgen Prizma ve Dikdörtgen Prizma Çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    p2.Ciz(pictureBox1);
                    p3.Ciz(pictureBox1);

                    break;

                case "Yüzey-Silindir":

                    //PictureBox temizleniyor
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    //Yüzey ve Silindir sınıfından nesneler türetiliyor
                    Yüzey y1 = new Yüzey();
                    Silindir s3 = new Silindir();

                    int merkezxYüzey=(y1.x+y1.genişlik)/2;
                    int merkezyYüzey = (y1.y + y1.yukseklik) / 2;
                    int merkezzYüzey = (y1.z + y1.derinlik) / 2;

                    int yaricapS = s3.cap / 2;
                    int merkezxSilindir = s3.x + s3.genişlik / 2 + yaricapS;
                    int merkezySilindir = s3.y + s3.genişlik / 2 + yaricapS;
                    int merkezzSilindir = s3.z + s3.genişlik / 2;

                    // Yüzey ve Silindirin verileri textBox a yazdırılıyor
                    textBox1.Text="Yüzeyin verileri (x,y,z,h,d,u) ,  ("+merkezxYüzey+","+merkezyYüzey+","+merkezzYüzey+","+y1.yukseklik+","+y1.genişlik+","+y1.derinlik+")";
                    textBox2.Text = "2. Silindirin verileri (x,y,z,h,r) :(" + merkezxSilindir + "," + merkezySilindir + "," + merkezzSilindir + "," + s3.yukseklik + "," + yaricapS + ")";

                    int mesafeKare = (merkezxSilindir - merkezxYüzey) * (merkezxSilindir - merkezxYüzey) +
                 (merkezySilindir - merkezyYüzey) * (merkezySilindir - merkezyYüzey) +
                 (merkezzSilindir - merkezzYüzey) * (merkezzSilindir - merkezzYüzey);

                    // Burada çarpışma için matematiksel verilerle çarpışma kontrol ediliyor
                    // NOT: 3 boyutlu cisimlerin çarpışmalarını 2 boyutlu bir bilgisayardan yapıldığı için çarpışma tam olarak bazen belli olmuyor
                    int minMesafe = (s3.cap / 2);
                    if (mesafeKare <= minMesafe * minMesafe)
                    {
                        textBox3.Text = "Yüzey ve Silindir Çarpıştı!";
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.Text = "Yüzey ve Silindir Çarpışmadı.";
                        textBox3.BackColor = Color.Green;
                    }

                    //Cisimler çiziliyor
                    y1.Ciz(pictureBox1);
                    s3.Ciz(pictureBox1);

                    break;
            }
        }
    }
}
