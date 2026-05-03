class Item
{
    public string judul;
    public int tahun;

    public Item(string judul, int tahun)
    {
        this.judul = judul;
        this.tahun = tahun;
    }
    public virtual void cekDeskripsi()
    {
        Console.WriteLine($"Deskripsi = judul : {judul}, tahun : {tahun}");
    }
    public void infoItem()
    {
        Console.WriteLine($"Judulnya ini adalah {judul}, diterbitkan pada tahun {tahun}");
    }
}

class Buku : Item
{
    public string penulis;

    public Buku(string penulis, string judul, int tahun) : base(judul, tahun)
    {
        this.penulis = penulis;
    }
    
    public void cekPenulis()
    {
        Console.WriteLine($"Penulis buku = {penulis}");
    }

    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul buku ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ditulis oleh {penulis}");
    }
}

class Majalah : Item
{
    public int edisi;

    public Majalah(int edisi, string judul, int tahun) : base(judul,tahun)
    {
        this.edisi = edisi;
    }
    public void infoEdisi()
    {
        Console.WriteLine($"Edisi majalah = {edisi}");
    }
    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul majalah ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ini merupakan edisi ke-{edisi}");
    }
}

class Novel : Buku
{
    public Novel(string penulis, string judul, int tahun) : base(penulis, judul, tahun)
    {
        this.penulis = penulis;
        this.judul = judul;
        this.tahun = tahun;
    }
    public void cekSinopsis()
    {
        Console.WriteLine("Sinopsisnya adalah bla bla bla (baca sendiri dah gede)");
    }

    public void tampilkanIlustrasi()
    {
        Console.WriteLine("enih ilustrasinya");
    }
    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul novel ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ditulis oleh {penulis}");
    }
}
class Komik : Buku
{
    public Komik(string penulis, string judul, int tahun) : base(penulis, judul, tahun)
    {
        this.penulis = penulis;
        this.judul = judul;
        this.tahun = tahun;
    }
    public void cekSinopsis()
    {
        Console.WriteLine("Sinopsisnya adalah bla bla bla (baca sendiri dah gede)");
    }

    public void tampilkanIlustrasi()
    {
        Console.WriteLine("enih ilustrasinya");
    }
    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul buku ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ditulis oleh {penulis}");
    }
}

class MajalahAnak : Majalah
{
    public MajalahAnak(int edisi, string judul, int tahun) : base(edisi, judul, tahun)
    {
        this.edisi = edisi;
        this.judul= judul;
        this.tahun= tahun;
    }

    public void kategoriAnak()
    {
        Console.WriteLine("Anak umur 40 tahun");
    }
    public void topikTeknologi()
    {
        Console.WriteLine("Teknologi kominfo hehe");
    }
    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul majalah ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ini merupakan edisi ke-{edisi}");
    }
}

class MajalahTeknologi : Majalah
{
    public MajalahTeknologi(int edisi, string judul, int tahun) : base(edisi, judul, tahun)
    {
        this.edisi = edisi;
        this.judul = judul;
        this.tahun = tahun;
    }
    public void kategoriAnak()
    {
        Console.WriteLine("Anak umur 40 tahun");
    }
    public void topikTeknologi()
    {
        Console.WriteLine("Teknologi kominfo hehe");
    }
    public override void cekDeskripsi()
    {
        Console.WriteLine($"Judul majalah ini adalah {judul}, diterbitkan pada tahun {tahun}, dan ini merupakan edisi ke-{edisi}");
    }
}

class Perpustakaan
{
    public List<Item> listItemm = new List<Item>();
    public void tambahItem(Item item)
    {
        listItemm.Add(item);
    }
    public void daftarItem()
    {
        foreach (Item item in listItemm)
        {
            item.cekDeskripsi();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perpustakaan per = new Perpustakaan();
        Buku book = new Buku("J.K Rowling", "Harry Potter", 1997);
        Novel no = new Novel("Pidi Baiq", "Dilan 1990", 2014);
        Komik ko = new Komik("Eiichiro Oda", "One Piece", 1997);
        Majalah ma = new Majalah(1, "Vogue", 1982);
        MajalahAnak man = new MajalahAnak(5, "Siksa Kubur", 2016);
        MajalahTeknologi mat = new MajalahTeknologi(1, "Cara mengaplikasikan hand scanner dari yt", 2023);

        per.tambahItem(book);
        per.tambahItem(no);
        per.tambahItem(ko);
        per.tambahItem(ma);
        per.tambahItem(man);
        per.tambahItem(mat);

        per.daftarItem();

        //Buat menjawab demonstrasikan polymorphism itu sudah dilakukan dengan cara meanmbahkan override (overriding) dan itu sudah saya lakukan di kode atas

        //Method Khusus
        Console.WriteLine("Method Khusus");
        Console.WriteLine("");
        Console.WriteLine("<-- NOVEL -->");
        no.cekSinopsis();
        no.tampilkanIlustrasi();
        Console.WriteLine("");
        Console.WriteLine("<-- KOMIK -->");
        ko.cekSinopsis();
        ko.tampilkanIlustrasi();
        Console.WriteLine("");
        Console.WriteLine("<-- Majalah Anak -->");
        man.kategoriAnak();
        man.topikTeknologi();
        Console.WriteLine("");
        Console.WriteLine("<-- Majalah Teknologi -->");
        mat.kategoriAnak();
        mat.topikTeknologi();


    }
}

