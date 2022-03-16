


// öğrenci tanımlama ve ekrana yazdırma
Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Hakkı";
ogrenci.Soyisim = "Ayman";
ogrenci.OgrenciNo = 123;
ogrenci.Sinif = 4;
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();



// Öğrenci parametrelerini belirleyen sınıf
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif;
        set 
        {
            if(value <1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!");
                sinif = 1;
            }
            else 
            {
                sinif = value;
            }
            
        }  
    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci()
    {}
    

    // Öğrenci Bilgilerini Ekrana yazan fonksiyon
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("******* Öğrenci Bilgileri *******");
        Console.WriteLine("Öğrenci Adı:   {0}",this.isim);
        Console.WriteLine("Öğrenci Adı:   {0}",this.soyisim);
        Console.WriteLine("Öğrenci Adı:   {0}",this.ogrenciNo);
        Console.WriteLine("Öğrenci Adı:   {0}",this.sinif);
    }

    // SInıfı yükselten fonksiyon
    public void SinifAtlat()
    {
        this.sinif = this.sinif+1;
    }
    // SInıfı Düşüren fonksiyon
    public void SinifDusur()
    {
        this.sinif = this.sinif+1;
    }
}