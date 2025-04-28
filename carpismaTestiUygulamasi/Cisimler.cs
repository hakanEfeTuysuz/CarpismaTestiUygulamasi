using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayalıProgramlamaOdev2
{
    public class Cisimler   // Burada cimlerin genel özellikleri tanımlanıyor
    {
        public int x;
        public int y;
        public int z;
        public int yukseklik;
        public int genişlik;
        public int derinlik;
        public int cap;
    }
    class Nokta : Cisimler  // Burada Nokta sınıfı cisimlerden kalıtılıyor
    {
        public Nokta()      // Noktanın alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());  
            x = random.Next(10, 401);
            y = random.Next(10, 301);
            z = random.Next(10, 301);
        }
        public void Ciz(PictureBox pictureBox)    // Noktanın çizimi için fonksiyon tanımlanıyor
        {
            Graphics graphics = pictureBox.CreateGraphics(); 
            Pen kalem = new Pen(Color.Black);

            graphics.DrawEllipse(kalem, x, y, 2, 2);

        }
    }

    class Dortgen : Cisimler   // Burada Dörtgen sınıfı cisimlerden kalıtılıyor
    {
         public Dortgen()    // Dörtgenin alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());  
            x = random.Next(10, 401);
                y = random.Next(10, 301);
                yukseklik = random.Next(10, 301);
                genişlik = random.Next(10, 301);
          }
         public void Ciz(PictureBox pictureBox)
         {
                Graphics graphics = pictureBox.CreateGraphics();     // Dörtgenin çizimi için fonksiyon tanımlanıyor
                Pen kalem = new Pen(Color.Red);

                graphics.DrawRectangle(kalem, x, y, genişlik, yukseklik);
         }

    }
    
    class Cember : Cisimler     // Burada Çember sınıfı cisimlerden kalıtılıyor
    {
        public Cember()     // Çemberin alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());   
            x = random.Next(1, 301);
            y = random.Next(1, 201);
            cap = random.Next(10, 301);
        }
        public void Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();    // Çemberin çizimi için fonksiyon tanımlanıyor
            Pen kalem = new Pen(Color.DarkBlue);

            graphics.DrawEllipse(kalem, x, y, cap, cap);
        }
    }
   
    class Prizma : Cisimler     // Burada Prizma sınıfı cisimlerden kalıtılıyor
    {
        public Prizma()    // Prizmanın alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());   
            x = random.Next(1, 301);
            y = random.Next(1, 301);
            z = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genişlik = random.Next(1, 201);
            derinlik = random.Next(1, 201);
        }
        public void Ciz(PictureBox pictureBox)      // Prizmanın çizimi için fonksiyon tanımlanıyor
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Red);

            //üst yüzey
            graphics.DrawRectangle(kalem, x + derinlik, y + derinlik, genişlik, yukseklik);

            //alt yüzey
            graphics.DrawRectangle(kalem, x, y, genişlik, yukseklik);

            //yan yüzeyler
            graphics.DrawLine(kalem,x,y,x+derinlik,y+derinlik);
            graphics.DrawLine(kalem,x+genişlik,y,x+genişlik+derinlik,y+derinlik);
            graphics.DrawLine(kalem,x,y+yukseklik,x+derinlik,y+yukseklik+derinlik);
            graphics.DrawLine(kalem,x+genişlik,y+yukseklik,x+genişlik+derinlik,y+yukseklik+derinlik);
        }
    }
    
    class Kure : Cisimler     // Burada Küre sınıfı cisimlerden kalıtılıyor
    {
        public Kure()      // Kürenin alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            x = random.Next(1, 301);
            y = random.Next(1, 301);
            z = random.Next(1, 301);
            cap = random.Next(1, 301);
        }
        public void Ciz(PictureBox pictureBox)    // Kürenin çizimi için fonksiyon tanımlanıyor
        {
            Graphics graphics = pictureBox.CreateGraphics();

            graphics.FillEllipse(Brushes.DarkGreen, x, y, cap, cap);
        }
    }
   
    class Silindir : Cisimler      // Burada Silindir sınıfı cisimlerden kalıtılıyor
    {
        public Silindir()     // Silindirin alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            x = random.Next(1, 201);
            y = random.Next(1, 201);
            z = random.Next(1, 201);
            cap = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genişlik = random.Next(1, 101);
        }
        public void Ciz(PictureBox pictureBox)      // Silindirin çizimi için fonksiyon tanımlanıyor
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.DarkCyan);

            //Alt yüzey çember
            graphics.DrawEllipse(kalem, x, y, cap, cap);
            //Üst yüzey çember
            graphics.DrawEllipse(kalem, x, y + yukseklik, cap, cap);
            //Kenarlar
            graphics.DrawLine(kalem, x, y + cap / 2, x, y + yukseklik + cap / 2);
            graphics.DrawLine(kalem, x + cap, y + cap / 2, x + cap, y + yukseklik + cap / 2);
        }
    }
   
    class Yüzey : Cisimler    // Burada Yüzey sınıfı cisimlerden kalıtılıyor
    {
        public Yüzey()     // Yüzeyin alacağı veriler kurucu fonksiyon ile rastgele olarak belirleniyor
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            x = random.Next(1, 301);
            y = random.Next(1, 301);
            z = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genişlik = 1;
            derinlik = random.Next(1, 201);
        }
        public void Ciz(PictureBox pictureBox)      // Yüzeyin çizimi için fonksiyon tanımlanıyor
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Red);

            //üst yüzey
            graphics.DrawRectangle(kalem, x + derinlik, y + derinlik, genişlik, yukseklik);

            //alt yüzey
            graphics.DrawRectangle(kalem, x, y, genişlik, yukseklik);

            //yan yüzeyler
            graphics.DrawLine(kalem, x, y, x + derinlik, y + derinlik);
            graphics.DrawLine(kalem, x + genişlik, y, x + genişlik + derinlik, y + derinlik);
            graphics.DrawLine(kalem, x, y + yukseklik, x + derinlik, y + yukseklik + derinlik);
            graphics.DrawLine(kalem, x + genişlik, y + yukseklik, x + genişlik + derinlik, y + yukseklik + derinlik);
        }
    }
    
}
