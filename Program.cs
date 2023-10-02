namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****ATAMA VE İŞLEMLİ ATAMA OPERATÖRLERİ*****");
        // ATAMA VE İŞLEMLİ ATAMA OPERATÖRLERİ
        int x = 3;  // x değişkenine 3 dedim.
        int y = 3;  // y değişkenine 3 dedim.
        y = y+2;    // Normalde y değerini 2 arttırmak isteyince böyle yazıyordum.
        Console.WriteLine(y);
        y += 2;     // Yukarıdaki işlemin aynısı y değerini 2 arttırdım. ama y değişikenini 2 defa yazmadan . Bu işlemli atama oluyor.
        Console.WriteLine(y);
        y /= 1;     // Y sayısını 1 e bölmüş oldum. Bölmüş oldum.
        Console.WriteLine(y);
        x *=2;      // X sayısını 2 ile çarpmış oldum.
        Console.WriteLine(x);

        Console.WriteLine("*****MANTIKSAL OPERATÖRLER*****");
        // MANTIKSAL OPERATORLER
        // || (VEYA)  &&(VE) !(DEĞİL)
        bool isSucces  = true;
        bool isCompleted = false;
        if(isSucces && isCompleted)    // Biri ture biri false olduğundan çalıştırmadı. 
        Console.WriteLine("perfect");  

        if(isSucces || isCompleted)    // İçlerinden birisi true olduğundan çalıştı.
        Console.WriteLine("great");    

        if(isSucces && !isCompleted)  // issucces ve iscompleted'in değili(falsenin değili true), true ve true oldu çalıştı
        Console.WriteLine("fine");


        Console.WriteLine("*****İLİŞKİSEL OPERATÖRLER*****");
        // İLİŞKİSEL OPERATÖRLER
        // <, >, >=, <=, ==, !=

        int a =3;
        int b =4;
        bool sonuc = a<b;          // bool SADECE TRUE YADA FALSE CEVABI VERİYORDU 
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a >=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a !=b;
        Console.WriteLine(sonuc);

        Console.WriteLine("*****ARİTMETİK OPERATÖRLER*****");
        // ARİTMETİK OPERATÖRLER
        // /, *, -, +

        int sayı1 = 10;                // sayı1 e   10 dedik.
        int sayı2 = 5;                 // sayı2 ye  5  dedik.
        int sonuc1 = sayı1 / sayı2;    //sayı1 bölü sayı2 dedik.
        Console.WriteLine(sonuc1);     
        int sonuc2 = sayı1 * sayı2;    //sayı1 çarp sayı2 dedik.
        Console.WriteLine(sonuc2);
        int sonuc3 = sayı1 - sayı2;    //sayı1 çıkar sayı2 dedik.
        Console.WriteLine(sonuc3);
        int sonuc4 = sayı1 + sayı2;    //sayı1 topla sayı2 dedik.
        Console.WriteLine(sonuc4);
        int sonuc5 = sayı1 ++;         //sayı1 bir arttırdık.
        Console.WriteLine(sonuc5);

        // % mod alır (bölünce kalanı getiren ifade)
        int sonuc6 = 20%3;
        Console.WriteLine(sonuc6);    // burada mesela 2 kalıyor ekrana 2 yazdıracak.


        
    }
}
