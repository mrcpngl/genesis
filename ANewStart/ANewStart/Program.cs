using System;

namespace ANewStart
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARTIDAN ÖĞRENDİĞİM BİLGİLER...
            #region STRING INTERPOLATION
            /*
             * C# 6.0 String Interpolation
             */
            //int id = 12;
            //string name = "mehmet";
            //string surname = "cpngl";
            //string summary = $"Müşteri ID: {id}, Müşteri Adı: {name}, Müşteri Soyadı:{surname}";
            //Console.WriteLine(summary);

            #endregion
            //SWITCH
            #region SWITCH YAPISI
            #region SWITCH EXPRESSIONS C# 8.0
            //string mesaj = DateTime.Now.DayOfWeek switch
            //{
            //    DayOfWeek.Monday => "Bugün Pazartesi",
            //    DayOfWeek.Tuesday => "Bugün Pazartesi",
            //    DayOfWeek.Wednesday => "Bugün Pazartesi",
            //    DayOfWeek.Thursday => "Bugün Pazartesi",
            //    DayOfWeek.Friday => "Bugün Pazartesi",
            //    DayOfWeek.Saturday => "Bugün Pazartesi",
            //    DayOfWeek.Sunday => "Bugün Pazartesi",
            //    _ => "HİÇBİRİ"

            //};
            //Console.WriteLine(mesaj);

            //int i = 10;
            //string isim = i switch
            //{
            //    5 => "Mouse",
            //    7 => "Keyboard",
            //    10 => "Motherboard",
            //    _ => "UNREACHABLE"
            //};
            //Console.WriteLine(i + " " + isim);
            #endregion
            #region SWITCH EXPRESSIONS with WHEN condition.
            //int i = 7;
            //string isim = i switch
            //{
            //    5 when 3 == 3 => "Mouse",
            //    var x when x == 7 && x % 2 == 1 => "Keyboard",
            //    10 => "Motherboard",
            //    var t => "NONE OF THEM" // default değer. Hiçbirinin olmadığı durumda default tanımlamasına karşılık gelecektir.
            //};
            //Console.WriteLine(i + " " + isim);
            #endregion
            #region SWITCH EXPRESSIONS - Tuple Pattern
            //string adi = "Ahmet";
            //int yas = 31;

            //string mesaj = "";
            //switch (adi, yas)
            //{
            //    case ("Ahmet", 31):
            //        mesaj = "Hayırlı Nöbetler BABAYİĞİT";
            //        break;
            //    case ("Ali", 62):
            //        mesaj = "Hayırlı işler REİS";
            //        break;
            //    case ("Çağatay", 24):
            //        mesaj = "Dükkanın hayırlı olsun reis";
            //        break;
            //    default:
            //        mesaj = "Bu bir default mesajdır.";
            //        break;

            //}
            //Console.WriteLine(mesaj);
            #endregion
            #region SWITCH EXPRESSIONS - Tuple Pattern | Shortcut
            //string adi = "ahmet";
            //int yas = 31;

            //string mesaj = (adi.ToUpper(), yas) switch
            //{
            //    ("Mehmet", 24) => mesaj = "Hoş Geldin Mehmet",
            //    ("AHMET", 31) => mesaj = "Hoş Geldin Ahmet",
            //    ("Ali", 62) => mesaj = "Hoş Geldin Ali",
            //    ("Tosun", 24) => mesaj = "Hoş Geldin Tosun",
            //    (_, _) => "HOŞ GELDİN YABANCI!"

            //};
            //Console.WriteLine(mesaj.ToUpper());

            //int s1 = 10, s2 = 20;
            //string mesaj = (s1, s2) switch
            //{
            //    (5,10) => "5 ile 10 değerleri geldi.",
            //    (10,20) => "10 ile 20 değerleri geldi",
            //    (_,_) => "Hiçbiri"
            //};

            // TUPLE + WHEN 

            //int s1 = 5, s2 = 10;
            //string mesaj = (s1, s2) switch
            //{
            //    (5, 10) when (false) => "5 ile 10 değerleri geldi.",
            //    var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 değerleri geldi",
            //    (_, _) => "Hiçbiri"
            //};

            //Console.WriteLine(mesaj);
            #endregion
            #region SWITCH EXPRESSIONS - Positional Patterns
            //OOP'de daha çok göreceğiz. Deconstruct özelliği olan nesneleri kıyaslamak veya değersel karşılaştırma için kullanılır. Bunuda WHEN şartı ile kullanabiliyoruz.
            #endregion
            #region SWITCH EXPRESSIONS - Property Patterns
            // Buda OOP'de daha detaylı anlatılacak ama yine de bilgi verecek olursak; nesnenin propertylerine girerek belirli durumları hızlı bir şekilde kontrol etmemizi sağlayan ve bunu farklı değerler için birden fazla kez tekrarlı bir şekilde yapmamıza olanak sağlayan bir gelişimdir.
            // Bunda da WHEN şartı kullanılabiliyor. (bunlardaki WHEN şartının diğerlerinden hiçbir farkı yok.)
            #endregion
            #endregion
            //IF YAPISI
            #region IF YAPISI
            #region IF BASLANGIC
            //bool maritalStatus = true;
            //if (maritalStatus == true)
            //{
            //    Console.WriteLine("I hope you live together till the end of your life...");
            //}

            //Kritik 1: IF yapısında else kullanmamıza gerek yoktur. Şart sağlıyorsa şart bloğunu yazdırır, şartı sağlamıyorsa direk parantezlerden çıkar ve yoluna devam eder...

            //Kritik 2: BOOLEAN değerleri kıyaslerken İLLA karşılaştırma operatörü kullanmaya gerek yoktur..!
            //bool maritalStatus2 = true;
            //if (maritalStatus2)
            //{
            //    Console.WriteLine("I hope you live together till the end of your life...");
            //}
            //Başına (!) Ünlem koyarsak ise maritalStatus true değilse anlamında kullanıyoruz.
            #endregion
            #region IF - ELSE YAPISI
            //Örn; EĞER ŞART doğru ise sağdan git, değilse soldan git. Yani yön veriyoruz. 
            //int i = 6;
            //if (i > 5)
            //{
            //    Console.WriteLine("i, 5'ten büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("i, 5'ten küçüktür.");
            //}
            // KRİTİK 1: Her iki durumda da çalışacak bir kod yazacaksak, if-else bloğunun dışına yazmamız yeterli olacaktır.
            #endregion
            #region IF - ELSE IF YAPISI
            //int sayi = 30;
            //if (sayi > 5 && sayi <= 10 )
            //{
            //    Console.WriteLine(sayi * 5);
            //}
            //else if (sayi > 10 && sayi <= 20)
            //{
            //    Console.WriteLine(sayi * 10);
            //}
            //else if (sayi > 20 && sayi <= 30)
            //{
            //    Console.WriteLine(sayi * 20);
            //}


            //KRİTİK 1: Eğer yaptığımız işlemde aynı şartı sağlayan birden fazla şey varsa, else if ile çalışmak doğru olmayacaktır çünkü sadece bir kod bloğunu çalıştıracaktır...
            // BİRDEN FAZLA ŞARTIN DOĞRU olduğu durumda sadece IF yapısı ile çalışmak daha doğru olacaktır. Çünkü her bir if kendi bloğunda öter... 100 tane IF yapısı da olsa hepsine bakacaktır. ama ELSE IF yapısında öyle olmuyor.
            #endregion
            #region Scopesuz IF YAPISI
            //int i = 100;
            //if (i == 100) // SCOPESUZ IF YAPISI sadece tek satırlık işlemlerde uygulanır, eğer birden fazla satır olacaksa mutlaka {} süslü parentezler açılmalıdır aksi takdirde 2. satırı if bloğu dışında sayacaktır...
            //    Console.WriteLine("i değeri 100");

            #endregion
            #region IF ELSE - ORNEK - 1

            //Klavyeden girilen 2 ürünün fiyatı girildiğinde toplam fiyat 200TL'den fazla ise, 2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yaz.
            //Console.Write("Lütfen 1. ürünün fiyatını giriniz: ");
            //int urun1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. ürünün fiyatını giriniz: ");
            //int urun2 = int.Parse(Console.ReadLine());
            //if (urun1 + urun2 >= 200)
            //{
            //    Console.WriteLine(urun1 + (urun2 * 75 / 100));
            //}
            //else 
            //{
            //    Console.WriteLine("Ödenecek TUTAR: {0}", urun1 + urun2);
            //}



            #endregion
            #region IF ELSE - ORNEK - 2
            // Belirlenen kullanıcı adı ve şifre doğru girildiğinde "GİRİŞ BAŞARILI", yanlış girildiğinde ise "GİRDİĞİNİZ BİLGİLER HATALI" uyarısını veren uygulamayı yaz.

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string kAdi = Console.ReadLine();
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string kSifre = Console.ReadLine();
            ////----------------------------------- IF YAPISI İLE KONTROL.
            ////if (kAdi == "mehmet" && kSifre == "123")
            ////    Console.WriteLine("Giriş Başarılı...");
            ////else
            ////    Console.WriteLine("Giriş Başarısız, girdiğiniz bilgiler hatalı...");
            //// ------------------------------- SWITCH YAPISI İLE KONTROL
            //string mesaj = (kAdi, kSifre) switch
            //{
            //    ("mehmet", "123") => "Giriş Başarılı...",
            //    (_, _) => "Giriş Başarısız, girdiğiniz bilgiler yanlış"
            //};
            //Console.WriteLine(mesaj);
            // -------------------------------Ternary operatörü ile...
            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string kAdi = Console.ReadLine();
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string kSifre = Console.ReadLine();
            //string sonuc = kAdi == "mehmet" && kSifre == "123" ? "Giriş Başarılı" : "Giriş başarısız";
            //Console.WriteLine(sonuc);



            #endregion
            #region IF ELSE - ORNEK - 3
            //Kullanıcıdan alınan 2 sayının ve yapılacak işlemin türünün (toplama,çıkarma,bölme,çarpma) seçilmesiyle sonucu hesaplayan prog. yaz.

            //1. KRİTİK
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yapılacak işlemi seçiniz: \n1)Topla\n2)Çıkar\n3)Çarp\n4)Böl\nLütfen seçeneği RAKAM olarak giriniz");
            //int secim = int.Parse(Console.ReadLine());
            //if (secim == 1)
            //    Console.WriteLine(sayi1 + sayi2);
            //else if (secim == 2)
            //    Console.WriteLine(sayi1 - sayi2);
            //else if (secim == 3)
            //    Console.WriteLine(sayi1 * sayi2);
            //else if (secim == 4)
            //    Console.WriteLine(sayi1 / sayi2);

            //2. KRİTİK
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yapılacak işlemi seçiniz: \n1)Topla\n2)Çıkar\n3)Çarp\n4)Böl\nLütfen seçeneği RAKAM olarak giriniz");
            //int secim = int.Parse(Console.ReadLine());
            //int sonuc = secim switch
            //{
            //    1 => sayi1 + sayi2,
            //    2 => sayi1 - sayi2,
            //    3 => sayi1 * sayi2,
            //    4 => sayi1 / sayi2,
            //    _ => 0
            //};
            //Console.WriteLine(sonuc);


            #endregion
            #endregion
            //PATTERN MATCHING
            #region PATTERNS
            #region Type Pattern
            /*
             * Object içerisindeki bir tipin belirlenmesinde kullanılan "is" operatörünün desenleştirilmiş halidir.
             * "is" ile belirlenen türün direkt dönüşümünü sağlar.
             */

            #region TYPE PATTERN OLMADAN DÖNÜŞÜM
            //object x = 125;
            //if (x is string)
            //{
            //    string xx = x as string;
            //    Console.WriteLine($"x değişkeni string tipindedir.");
            //}
            //else if (x is int)
            //{
            //    int xx = (int)x;
            //    Console.WriteLine($"x değişkeni int tipindedir.");
            //}
            #endregion
            #region TYPE PATTERN İLE DÖNÜŞÜM
            //object x = 125;
            //if (x is string xx)
            //    Console.WriteLine($"x değişkeni string tipindedir.");
            //else if (x is int xy)
            //    Console.WriteLine($"x değişkeni int tipindedir.");

            #endregion
            #region TYPE PATTERN - KRITIK
            //object x = "mehmet";
            //if (x is string a) // (x is string) = eski kullanım: Yeni kullanım; (x is string degisken_ismi)
            //{
            //    //eskiden yapılan;
            //    string _x = (string)x;
            //    Console.WriteLine(a);
            //    //Yeni yapılanda scope içinde cast yapmamıza vs gerek kalmıyor direk if parantezleri içinde bir değişken tanımlayabiliyoruz.
            //}

            ////bunu yapınca hata vermeyecektir

            //a = "deneqewhqw";

            //Console.WriteLine(a); //A'ya burada ulaşabiliyoruz ama içi dolu mu boş mu olacak belli olmadığı için hata veriyor. 



            #endregion

            #endregion
            #region Constant Pattern
            /*
             * Elimizdeki veriyi sabit bir değer ile karşılaştırabilmemizi sağlayan bir desendir.
             * Örn; "x == 5" kullanımını "x is 5" gibi bir şekilde kullanmamızı sağlar.
             */

            //object x = 123;

            //if (x is 123) // değersel bazda bir kontrol.
            //{
            //    Console.WriteLine($"Cevap {x}");
            //}
            //if (x is int) // türsel bazda bir kontrol.
            //{
            //    Console.WriteLine($"{x}, int türlü değişkendir.");
            //}

            ////direk olarak şöyle bir şekilde de kontrol yapabiliriz;
            //Console.WriteLine(x is int);

            #region Constant Pattern - KRITIK
            /*
             * "is" operatörü bir değişkenin türünü sormamızı/belirlememizi sağlayan bir operatördür. Ve bu operatörün kullanıldığı değişkenlerin türü illa bir "REFERANS" türlü olması lazım değildir.
             * İstersek değer türlü değişkenlerde de "is" operatörü kullanabiliriz. Ve hatta primitive türlerde bile kullanabiliriz.
             */

            //int a = 5;
            //Console.WriteLine(a is int);
            //Console.WriteLine(a is bool); // Buradakiler "is" operatörünün zaten varolan kendi fıtratındaki işlemdir.
            //Console.WriteLine(a is string);

            //Console.WriteLine(a is 5); //işte buna "CONSTANT PATTERN" diyoruz C# 7.0 ile birlikte gelmiştir. Değişkenin değerinini sanki "==" operatörüymüşcesine yapmamızı sağlayan bir desendir.
            #endregion

            #endregion
            #region Var Pattern
            /*
             * Eldeki veriyi 'var' değişkeni ile elde etmemizi sağlamaktadır.
             */
            //object x = "Türkiye";
            //if (x is var a) //"x"in türü ne olursa olsun sen o türde "a" değişkenine çıkar.
            //{
            //    Console.WriteLine(a);
            //}

            #region Var Pattern - Kritik 1
            //object dnm = "deneme"; //birden fazla ihtimal varsa onları dışarı çıkarabiliyoruz "var pattern" ile "type pattern'in" gelişmişi diyebiliriz.
            //if (x is var mnd) // buradaki "var" keywordünün türü runtime'de belirlenecektir. string ise string olacak int ise int olacak. 
            //{

            //}
            #endregion
            #region Var Pattern - Kritik 2
            /*
             *'var' keyword: derleme zamanında(compile time) türü belirler
             *Var Pattern'deki 'var' çalışma zamanında(runtime) türünü belirler.
             *Dynamic keywordü'de runtime'de türünü belirler ancak var pattern'de bunu kullanamayız. Çünkü var pattern sadece 'var'a özeldir.
             */

            #endregion




            #endregion
            #region Recursive Pattern - C# 7.0 ile geldi.
            /*
             * - Bu desen switch - case yapılanması üzerinde birçok yenilik getirmektedir.
             * - switch bloğunda referans türlü değişkenlerde kontrol edilebilmektedir.
             * - Ayrıca switch bloğuna when komutu ile çeşitli şart/koşul niteliği kazandırılmıştır(yapmıştık)
             * switch(.........) - Bu kısma referans türlü değişken koyabiliyoruz.
             * {
             * 
             * }
             * 
             * -Recursive Pattern, tür kontrolü yaptığı için TYPE PATTERN'ı kapsamaktadır.
             * -Case null komutu ile ilgili türün/referansın null olup olmamasını kontrol edebilmesinden dolayı; CONSTANT PATTERN'i kapsamaktadır.
             */

            #endregion
            #region Type ve Var Pattern Üzerine Kritik
            /*
             * Patternler %100 "AKIŞ KONTROL MEKANİZMALARINA" ait bir şey değildir.
             */
            //object x = "mehmet";
            //if (x is string a)
            //{

            //}
            //if (x is var b)
            //{

            //}

            //örneğin burası. Burada hem sonucu "result"a aldık ve bir değişken tanımladık.
            //bool sonuc = x is string s;
            //Console.WriteLine(s); //O'nun null olma ihtimalinden dolayı burada kullanamıyoruz. Hata veriyor. O yüzden if içinde kullanmak daha mantıklı.
            //bool sonuc2 = x is var v;
            //Console.WriteLine(sonuc2); //var runtime'de türünü belirleyeceğinden dolayı burada hata vermez. var; her türü karşılayabileceği için null gelme ihtimali olmayacak ve hata vermeyecektir.



            #endregion
            #region Pattern Matching - Enhancements - C# 9.0 ile geldi.
            //4 tane pattern var ve bunlar geliştirilmiş pattern yapılanmalarıdır.
            #region Simple Type Pattern
            /*
             * - Normal Type Pattern'in daha da geliştirilmiş halidir.
             * - Bir değişken içerisindeki değerin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlar.
             * - C# 9.0'dan önce, Type Pattern ile yapılan tür bildirimlerinin yanına değişken adı tanımlanması yahut discard ifadesinin kullanılması zaruriydi. c# 9.0 ile bu gereksiz zorunluluk ortadan kaldırılmış ve  direkt olarak tür kontrol işlemine odaklanılması sağlanmıştır.
             */



            #endregion
            #region Relational Pattern
            /*
             * İlişkisel, kıyaslamayı yapabildiğimiz bir pattern.
             * getirdiği özellikler; Desenlerde <, >, <=  ve >= operatörleri kullanabilmekte ve belirli karşılaştırmalar hızlıca gerçekleşebilmektedir.
             */
            // ------------- KRİTİK - ÖNEMLİ -----------------
            /*
             * Normalde switch sadece eşitliğe bakarken, C# 9.0 ile gelen relational pattern ile karşılaştırma operatörlerinide kapsıyor.
             */

            //ÖRNEK

            //int number = 111;
            //string result = number switch
            //{
            //    < 50 => "50'den küçük",
            //    > 50 => "50'den büyük",
            //    _ => "Hiçbiri"
            //};
            //int number2 = 222;
            //string result2 = number2 switch
            //{
            //    < 100 => "100'den küçük",
            //    >= 101 => "101'e eşit veya 101'den büyük",
            //    100 => "100'e eşit."  //direk sayıyı yazınca o sayıyı alır.

            //};

            #endregion
            #region Logical Pattern
            /*
             * and, or ve not gibi mantıksal operatörler kullanılabilmektedir.
             */
            //ÖRNEK

            //int number = 60;
            //string result = number switch
            //{
            //    > 10 and < 50 => "10'dan büyük, 50'den küçük",
            //    > 50 or <100 and 60 => "50'den büyük veya 100'den küçük ve 60'a eşit",
            //    not 51 => "51 değil"
            //};

            #endregion
            #region Not Pattern
            //string ornek1 = "deneme";
            //string result = ornek1 switch
            //{
            //    "Teknoloji" => "Bilgisayar alabilirsin.",
            //    not "Teknoloji" => "Teknoloji değil."
            //};
            //Console.WriteLine(result);
            #endregion

            #endregion


            #endregion
            //Hata Türleri
            #region Hata Türleri
            #region RunTime (Calisma Zamani) Hataları - Try-Catch
            #region Try-Catch İsleyisi
            /*
           * try
           * {
           * Olası çalışma zamanı hatalarını verebilecek kodları buraya yazıyoruz...
           * Örn; sayısal bir değer girmemizi isterse ve biz de buna string; lfadasd gibi bi değer verirsek bizi catch bloğuna yönlendirecek
           * }
           * catch
           * {
           * try içerisinde olası hata söz konusuysa, kodun akışı (try)blouğundan kesilecek ve akış catch bloğundan devam edecektir.
           * Burada şöyle diyeceğiz; "Lütfen sayısal bir değer giriniz.."
           * }
           */
            #endregion
            #region Try-Catch Yapılanması
            //try
            //{
            //    Console.WriteLine("Lütfen birinci sayiyi giriniz: ");
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen ikinci sayiyi giriniz: ");
            //    int s2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("TOPLAM : " + (s1 + s2));
            //}
            //catch 
            //{
            //    Console.WriteLine("Lütfen sadece sayısal veriler giriniz...");
            //}
            #endregion
            #region Try-Catch - Kritik
            /*
             * Try-Catch maliyetli bir yapıdır o yüzden try içine yazdığımız kodları ne kadar azaltırsak kârdır.
             * Örneğin, patlayacak kısım sadece "int s1" değişkeni ise sadece onun orada kalması daha mantıklı console.writeline ile bir işimiz yok. Onu try blouğunun dışına alabiliriz. Ancak yapı bozuluyor, her şey karışıyor, algoritması oturmuyorsa try bloğunda çalışabiliriz.
             * ÖNERİLEN: TRY bloğu içindeki kodları minimuma indir...
             */
            //Console.WriteLine("Lütfen birinci sayiyi giriniz: ");
            //try
            //{
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen ikinci sayiyi giriniz: ");
            //    int s2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("TOPLAM : " + (s1 + s2));
            //}
            //catch
            //{
            //    Console.WriteLine("Lütfen sadece sayısal veriler giriniz...");
            //}

            #endregion
            #region Try-Catch - Hata Parametreleri
            //Çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametrelerdir...
            //int s1 = 0, s2 = 10;
            //int sonuc = s2 / s1; // burada divideByZeroException hata çıkacaktır. (
            //object x = null; 
            //x.ToString();  Burada da null reference exception hatası verecektir.

            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int sonuc = s2 / s1;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata Mesajı: " + ex.Message);
            //}

            /*
             * Exception: Bizlere fırlatılan hatayla ilgili tüm bilgileri getirecek olan bir "üst türdür." Yani tüm 
              hataları  karşılayabilen bir türdür, orn; nullreferencexception olsun DivideByZeroException gibi 
              hataların hepsini yakalar. 
              oradaki "ex" parametresi üzerinden alınan hataya dair bilgiler edinebilmekte ve gerekli loglama
              vs.gibi operasyonları gerçekleştirebilmekteyiz... 
            * Ayrıca, "ex" parametresi catch bloğuna yazılmak zorunda değildir. Ama tanımlanma yapılırsa hataya dair bilgi alabiliriz, yapılmazsa ise catch çalışacak ama bilgi alamayacağız.
             */
            #endregion
            #region Try-Catch - Exception dışında başka tür ile Hata Yakalama
            //try
            //{
            //int s1 = 0, s2 = 10;
            //int sonuc = s2 / s1;

            //int.Parse("qwewqewqewq"); -- Bu kod DivideByZeroException'ın içinde kapsanan bir hata olmadığı için program patlayacaktır.
            //}
            /* catch (DivideByZeroException ex) */// Eğer parametre "Exception" değil özelleştirilmiş bir hataya indirgenmişse, böyle bir durumda sadece ilgili türe ait hataları yakalayabilecek.
                                                  //{
                                                  //    Console.WriteLine("Mesaj: " + ex.Message); // Bunun çözümü ise; birden fazla "catch" bloğu kullanmaktır.
                                                  //}
            #endregion
            #region Try-Catch - Birden fazla Catch bloğu
            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int sonuc = s2 / s1;

            //    int.Parse("qwewqewqewq");

            //}
            //catch (DivideByZeroException dex) //DivideByZeroException hatası alındığında bu hatayı karşılayacak olan catch haline getirilmiş oldu.
            //{
            //    Console.WriteLine("Mesaj: " + dex.Message);
            //}
            //catch (FormatException fex) // FormatException hatasını karşılayacak olan catch bloğu.
            //{
            //    Console.WriteLine("Mesaj: " + fex.Message);
            //}
            //catch (Exception ex) // üsttekiler dışında herhangi bir hata alırsa bu karşılayacak.
            //{
            //    Console.WriteLine("Mesaj: " + ex.Message);
            //}
            #endregion
            #region Try-Catch - Finally bloğu
            //finally bloğu, try catch yapılanmasında hata alınsada, alınmasada her iki durumda da çalıştırılması gereken kodları yazdığımız bloktur.
            //try
            //{
            //    // hata verecek kodlar buraya.
            //}
            //catch (Exception)
            //{
            //    //hata alındıktan sonra yapılacak işlemler buraya.
            //}
            //finally
            //{
            //    //Her iki durumda da çalışmasını istediğim kodlar buraya.
            //}
            #endregion
            #region Try-Catch  - When yapısı ile Hata Filtreleme (C# 6.0)
            // try catch bloğuna when keywordü ile şart koyabiliyoruz.
            //string x = "a";
            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int sonuc = s2 / s1;
            //}
            //catch (DivideByZeroException dex) when (x == "a") // her iki şartta uymak zorunda dividebyzero uymazsa, when uyarsa bile girmeyecektir. when'i (and) mantığıyla düşüneceğiz.
            //{
            //    Console.WriteLine("Hata Mesajı: " + dex.Message);
            //}
            //catch (DivideByZeroException dex) when (x == "b")
            //{
            //    Console.WriteLine("Hata Mesajı: " + dex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Şartlar uymadı, hata mesajı: " + ex.Message);
            //}
            #endregion
            #endregion
            #endregion
            //Loops
            #region Döngüler (Loops)
            #region For Döngüsü Ornek 1
            //int toplam = 0;
            //for (int i = 1; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);
            #endregion
            #region For Döngüsü Ornek 2
            //Klavyeden girilen sayının faktöriyelini hesaplayan programı yap.
            //int carp = 1;
            //Console.Write("Lütfen faktöriyelini hesaplamak istediğiniz bir sayı giriniz: ");
            //int s1 = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= s1; i++)
            //{
            //    carp *= i;
            //}
            //Console.WriteLine(carp);

            //2. Çözüm
            //int carp2 = 1;
            //string sonuc = "";
            //Console.Write("Çözüm 2 : Lütfen faktöriyelini hesaplamak istediğiniz bir sayı giriniz: ");
            //int s2 = int.Parse(Console.ReadLine());
            //for (int i = s2; i > 0; i--)
            //{
            //    carp2 *= i;
            //    sonuc += i + (i == 1 ? " = " : " x ");
            //}
            //Console.WriteLine(sonuc + carp2);
            #endregion
            #region While Döngüsü
            //Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayac hazırla.
            //Console.Write("Bir sayı giriniz: ");

            //int s1 = int.Parse(Console.ReadLine());
            //while (s1 >= 0)
            //{
            //    Console.WriteLine(s1);
            //    s1--;
            //}
            //0'dan 100'e kadar tek sayıların toplamı.
            //int i = 0;
            //int sonuc = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sonuc += i++;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sonuc);

            //Klavyeden girilen sayının faktöriyelini hesaplayalım.
            //Console.Write("Lütfen bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int toplam = 1;
            //while (sayi > 0)
            //{
            //    toplam *= sayi--;

            //}
            //Console.WriteLine(toplam);

            //O anki tarihin saniye değeri eğer 5'in katıysa; tarihi gösteren uygulamayı yaz.

            //while (true)
            //{
            //    if (DateTime.Now.Second % 5 == 0)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //    }
            //}

            #endregion

            #endregion
            //Manevratik Komutlar
            #region Manevratik Komutlar
            /*
             * Ne işe yarar? Kodu durdurmak, devamını okumamak, var olan bir döngüden çıkış yapmak yahut komple metou sonlandırmak yani kodu yönlendirmek için kullanılan komutlardır.
             */
            #region Break Komutu
            /*
             * Break komutunun kullanıldığı alanlar;
             * | Switch - Case |
             * | Döngüler |
             * Başka yerde kullanılamaz..!
             * 
             * Ne işe yarar? Kullanıldığı yapıdan çıkış yapılmasını sağlayan bir keyworddür.
             * 
             */

            //ÖRNEK 1

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j <2; j++)
            //    {
            //        if (j == 1)
            //            break;
            //        Console.WriteLine($"i: {i} j: {j} ");
            //    }
            //}

            //ÖRNEK 2

            //Kullanıcıdan "t" harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yaz.
            //string girilenDeger = "";
            //int toplam = 0;
            //do
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    girilenDeger = Console.ReadLine();
            //    if (girilenDeger == "t")
            //    {
            //        Console.WriteLine($"Toplam: {toplam}");
            //        break;
            //    }
            //    else
            //    {
            //        toplam += int.Parse(girilenDeger);
            //    }

            //} while (true);





            #endregion
            #region Continue Komutu
            /*
             * Sadece döngülerden erişilebilen ve döngülerde kullanılabilen bir keyworddür.
             * Yaptığı işlem: Döngüde bir sonraki tura geçilmesini sağlar.. Yani bir sonraki periyoda direkt olarak geçiş yapar.
             */

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //Kullanıcının girdiği sonsuz adet sayıdan pozitif olanlarını çarpan, ve 't' yazılıp enter yapıldığında ekrana yazdıran kodu yazalım.
            //string gelenDeger = "";
            //int sonuc = 1;
            //for(; ; )
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //     gelenDeger = Console.ReadLine();
            //    if (gelenDeger == "t")
            //    {
            //        Console.WriteLine($"Sonuç: {sonuc}");
            //        break;
            //    }
            //    int s1 = int.Parse(gelenDeger);
            //    if (s1 <= 0)
            //        continue;
            //    sonuc *= s1;
            //}

            //1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdır.
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //        continue;

            //    Console.WriteLine(i);
            //}

            #endregion
            #region Return Komutu
            /*
             * Her yerde (metot içerisinde) kullanılabilir, erişilebilir bir keyworddür. (mainde bir mettotur o yüzden main içinde de erişilebilir.
             * 
             * İki işlevi vardır;
             * 1-)Nere çağırılıyorsa çağrılsın bulunduğu metottan çıkış yapar. Yani metodu sonlandırır.
             * 2-)İleride göreceğimiz metotlar konusunda geriye değer döndürme sorumluluğunuda üstlenen bir metottur.
             */

            #endregion
            #region Goto Komutu
            /*
             * switch-case yapılanmasında dahili olarak kullanılan bu komut, metot içerisinde her yerde kullanılabilir.
             * Teknik olarak bilgisayarı vs yavaşlattığı için pek önerilmez, optimasyon sıkıntısı vardır.
             * "İyi bir c# programcısı, gerekmediği sürece "goto" anahtar sözcüğü kullanmamalıdır." Sefer Algan
             */

            //switch (10)
            //{
            //    case 5:
            //        Console.WriteLine("GOTO KOMUTU.");
            //        break;
            //    case 10:
            //        goto case 5;
            //}


            //böyle bir durumda; önerilen şey döngü kullanmaktır. Ama zaruri ise goto kullanılabilir

            //a:
            //    Console.WriteLine("Merhaba");
            //    Console.WriteLine("Dünya");
            //    goto a;


            #endregion


            #endregion
            //Ekstra Bilgiler
            #region Ekstra Bilgiler
            //İşlem yapmak istemediğimiz zaman bunları kullanabiliriz.
            //do;
            //while (true);

            //if (true)
            //{; }

            //if (true) ;

            //while (true) ;

            //for (; ; );


            #endregion
            //Diziler
            #region Diziler
            /*
             * Diziler referans türlü değişkenlerdir. (Yani nesnel yapılardır / özlerinde classtirlar.
             * RAM'de birden fazla değeri tek bir değişkende altında bir veri kümesi halinde tutabilirler.
             * RAM'de Heap'te tutulurlar.
             * Dizi içerisine her türlü değer konulabilir (Değer ve Referans Türlü)
             * Bir dizi sadece tek bir türde değer alabilir. (eğer integer ise hepsi integer olmak zorunda)
             * Farklı türleri bir arada barındırmak istiyorsak; "object" türüyle işlem yapabiliriz sonuçta yine tek bi türe denk gelmiş olacaktır.
             * Dizilere eklenen elemanlar "index" isimli numaralarla ardışık olarak sıralanırlar.
             * index 0'dan başlar n-1'e kadar gider. yani 10 elemanlı dizide; ilk koyduğumuz: 0.index son koyduğumuz 9.indextir.
             */

            #region Diziler - Kritik 1
            /*
             * Dizi içerisinde dönecek olan döngü kombinasyonunda dizinin elmeman sayısını manuel bir şekilde kullanmamalıyız. Bu sayısal değeri dizinin kendisinden almalıyız; yani, dizi elemanları sürekli azalıp artarsa bizim de sürekli hem döngüdeki sayıyı hem de diziye eklediğimiz sayıyı değiştirmek zorunda kalırız. Bunun için;
             * dizideki "Length" özelliğini kullanmalıyız. "Length: Dizinin kaç elemanlı olduğunu int olarak geri döndürür.
             */
            #endregion

            //string[] personeller = new string[11];
            //personeller[0] = "Mehmet";
            //personeller[1] = "Ahmet";
            //personeller[2] = "Hayrullah";
            //personeller[3] = "Taha";
            //personeller[4] = "Ataberk";
            //personeller[5] = "Falan";
            //personeller[6] = "Filan";
            //personeller[7] = "Ali";
            //personeller[8] = "Deneme";
            //personeller[9] = "Kral";
            //personeller[10] = "x7";

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(personeller[i++]);
            //} while (i < personeller.Length);

            #region Dizi Tanımlama Varyasyonları
            //1. Varyasyon
            //int[] yaslar = new int[3];
            //yaslar[2] = 25;
            //Console.WriteLine(yaslar[2]);

            //2.Varyasyon
            //int[] yaslar2 = { 35, 43, 23, 53 };
            //string[] isimler = { "mehmet", "ahmet", "ali" };

            //3.Varyasyon
            //string[] isimler2 = new string[] { "mehmet", "ali", "ahmet" }; 

            //4.Varyasyon
            //int[] yaslar2 = new int[3] { 15, 35, 24 };

            //5. Varyasyon - biraz daha önemli
            //int[] sayilar3 = new[] { 3, 4, 5, 6 };
            //var sayilar4 = new[] { 25, 34, 53, 42, 23 }; //türünü bildirmedik ama hepsi aynı olmak zorunda olduğu için otomatik olarak int[] dizisi olarak algıladı, bunun içine eğer string ifadeler yazsaydık string dizisi olacaktı.


            #endregion

            #endregion
            //Array Sınıfı
            #region Array Sınıfı
            #region Array hakkında bilgiler
            /*
            * Dizi olarak  tanımlanan değişkenler, Array sınıfından türetilmektedirler.
            * Dolayısıyla dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur.
            */
            //bunların ikiside aynı şey.. ama temel fark şu;

            //int[] yaslar1 = new int[3];  //kendi türünde tutulduğu için "indexer" operatörü kullanılabilir...
            //Array yaslar = new int[3]; // Array türünde referans ediliyorsa, "indexer" operatörü kullanılamaz...
            /*
             * -Üstteki format genellikle algoritmalarda tercih edilir çünkü indexer algoritmalarda çok kullanılır.
             * -Alttaki format genellikle dizinin üzerinden işlem yaparken tercih edilen formattır. Dizi hakkında bilgi edinirken vs kullanılır.
             * - Üstteki(int[]) şekilde çalışıldığında ilgili diziye verisel müdahaleler operatif gerçekleştirilirken;
             *  //Alttaki(Array) ise fonksiyonel çözümler getirilmektedir.
             * 
             */
            #endregion
            #region Array Türünden dizilere değer atama / okuma
            //1.Yöntem - Bu yöntem pek pratik değil.
            //int[] dizi = new int[2];
            //dizi[0] = 35;
            //dizi[1] = 30;  // bu operatörsel bir yaklaşım
            //Array dizi2 = dizi;

            //2. Yöntem - Bu da pek pratik olmayabilir.
            //Array dizi = new int[] { 3, 5, 4, 7 };

            //3. Yöntem - Bu daha pratik // bu fonksiyonel bir yaklaşımdır.
            //Array dizi = new int[3];
            //dizi.SetValue(30, 0);
            //dizi.SetValue(25, 1);
            //dizi.SetValue(20, 2);

            //object val = dizi.GetValue(0);
            //Console.WriteLine(val);

            #endregion
            #region Array Sınıfı - Methods / Metotlar
            #region Clear - Metodu
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            ////Clear Metodu - Dizinin içerisindeki tüm elemanlara dizinin türüne uygun "default" değerleri atayan bir fonksiyondur.
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));
            //Array.Clear(isimler, 1, 2);
            //Console.WriteLine("**************************");
            //for(int j  =0; j < isimler.Length; j++)
            //    Console.WriteLine(isimler.GetValue(j));
            #endregion
            #region Copy - Metodu
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            //string[] isimler2 = new string[5];
            //Array.Copy(isimler, 0, isimler2, 0, 5);
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler2[i]);

            #endregion
            #region IndexOf - Metodu
            //Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            //Arama neticesinde ilgili değer varsa, int olarak o değerin index numarasını döndürecektir. Yoksa, -1 değerini döndürür.
            //int index = Array.IndexOf(isimler, "Ahmet");
            //if (index != -1)
            //{
            //    Console.WriteLine(index);
            //}

            //int index2 = Array.IndexOf(isimler, "Hayrullah", 0, 4);
            #endregion
            #region Reverse - Metodu
            //Elimizdeki dizinin elemanlarını tersine sıralayan fonksiyondur.
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));
            //Array.Reverse(isimler);
            //Console.WriteLine("--------------------------------------");
            //for (int j = 0; j < isimler.Length; j++)
            //    Console.WriteLine(isimler.GetValue(j));
            #endregion
            #region Sort - Metodu
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));

            //Array.Sort(isimler);
            //Console.WriteLine("*************");

            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));

            #endregion

            #endregion
            #region Array Sınıfı - Properties / Ozellikler
            //Array isimler = new[] { "Mehmet", "Ahmet", "Taha", "Hayrullah", "Ataberk" };
            #region isReadOnly - Özelliği
            //Bir dizinin sadece okunabilir olup olmadığını, "bool" türünde bildiren bir özelliktir.
            //Console.WriteLine(isimler.IsReadOnly);

            #endregion
            #region IsFixedSize - Özelliği
            //Bir veri kümesinin eleman sayısının sabit olup olmamama durumunu IsFixedSize ile öğrenebiliriz. Tüm diziler için "IsFixedSize" true değerini döndürecektir çünkü dizilerde eleman sayısı sabittir. Ancak, ArrayList koleksiyonunda false dönmektedir.
            //Console.WriteLine(isimler.IsFixedSize);
            #endregion
            #region Length - Özelliği
            //Bir dizideki tüm eleman sayısını verir.
            //Console.WriteLine(isimler.Length);
            #endregion
            #region Rank - Özelliği
            //Console.WriteLine(isimler.Rank);
            #endregion
            #endregion

            #region Array Sınıfı - Create Instance Metodu - Önemli
            //int[] yaslar = new int[3];
            ////Normalde yukarıdaki gibi yapılan dizi tanımlaması, esasında arkaplanda Array sınıfının CreateInstance metodunu kullanmaktadır. Bizlerde bu metodu kullanarak fonksiyonel diziler oluşturabilmekteyiz.
            //Array yaslar2 = Array.CreateInstance(typeof(int), 3);

            //Array dizi = Array.CreateInstance(typeof(int), 5, 6, 7, 8, 9);  //Burada da çok boyutlu dizi oluşturabiliriz. Şekilde görüldüğü gibi...
            //Console.WriteLine(dizi.Rank);
            #endregion

            #endregion
            #region C# 8.0 Ranges and Indices
            /*
             * C# Diline; "System.Index", "System.Range", ".." (aralık operatörü) ve "^" (şapka) işaretini kazandırmıştır. 
             * Bu özellik ne getirdi? Veri kaynakları üzerinde gerekli manipilasyonu sağlayabilmek ve bunun yanında kaynak içerisindeki tüm veriler üzerinde yapılan genel sorgulamalar ve algoritmalardan kaçınmak, yani direkt olarak hedef veri(ler) odaklı çalışabilmek için yeni tipler ile operatörler geliştirilmiştir.
             */

            #region System.Index - Özelliği
            /*
             *  -Dizi ve Koleksiyon yapılarındaki "index" kavramının tip olarak belirlenmiş halidir.
             *  -Temel index değerini bir tür ile tutmakla beraber "^"-(tersine işareti) operatörüyle birlikte daha fazla anlam ifade etmekte ve dizinin index değerlerini tersine ifade edecek şekilde bir sorumluluk yüklemektedir.
             */

            //ÖRNEK - 1

            //string[] isimler = { "Hüseyin", "Hilmi", "Rıfkı", "Hatice", "Ayşe" };
            //Index index = 3; //Burada 0'dan ve soldan başlayıp sağa doğru gittiği için "Hatice" değerini alacaktır.
            //Index index2 = ^3; //Burada ise sağdan başlayıp sola doğru gittiği ve "1'den" başladığı için Rıfkı değerini alacaktır.
            //Console.WriteLine(isimler[index] + "\n" + isimler[index2]);

            //ÖRNEK - 2

            //int[] sayilar = { 100, 23, 25, 64, 75, 534, 23, 12, 5 };

            //Index index1 = 3;
            //Index index2 = ^9;

            //Console.WriteLine(sayilar[index1] + "\n" + sayilar[index2]);





            #endregion
            #region System.Range - Özelliği
            /*
             * Veri kümelerinde hangi değer aralıklarında çalışacağımızı belirleyebilmek için index üzerinden aralık vermemizi ve bunu " .. " operatörü ile vermemizi sağlayan bir yapılanmadır.
             * - Indexer[] operatörü içerisine tam sayı veya Index türü verilebildiği gibi Range türüde verilebilir.
             * - ".." operatörünün solundaki "Index(0,1,2,3,4) diye başlar" bazlıdır, sağındaki ise "Sıra" bazlıdır (1,2,3,4 diye başlar)
             * "index .. index => sayısal değerler alabildiği gibi, System.Index turunde tutulan değerleride alabilir
             * Geriye System.Range türünden yapı döndürür.
             */


            //int[] sayilar = { 100, 23, 25, 64, 75, 534, 23, 12, 5 };
            //Range range = 3..7; // bunu yazarak, 64 ile 23 arasında çalışma yapmak istediğimi belirttim.

            //var sayilar2 = sayilar[range];

            //Range range2 = ..; // sağında ve solunda bir şey yazmazsak tüm dizi gelecektir.  

            // sayilar dizisi ve range dizileri tamamen farklıdır bi nevi kopyalamış sayılıyoruz. Range'de işlem yaparsak sayilar dizisini etkilemeyecektir.

            //int[] sayilar = { 100, 754, 25, 64, 75, 534, 23, 12, 5 };
            //Range range = ^6..^2; //üstteki örneğin aynı çıktısını verecektir. 
            //var sayilar2 = sayilar[range];

            //int[] sayilar = { 100, 754, 25, 64, 75, 534, 23, 12, 5 };
            //Range range = sayilar[0]..sayilar[8]; //Index değeri almış hali

            //Index i1 = 3, i2 = 6;
            //Range rng2 = i1..i2; //ındex değeri almış hali v2

            //string[] isimler = new[] { "Mehmet", "Ahmet", "Ali", "Hüseyin", "Hasan", "Taha" };
            //string isim1 = isimler[isimler.Length -1];
            //string isim2 = isimler[^1]; //Bu ikiside aynı sonuca çıkartır..

            #endregion
            #endregion
            #region Çok Boyutlu Diziler (Multidimensional Arrays)
            /*
             * Çok boyutlu diziler; oyun programlamada veya yüksek istatiksel çalışmalarda kullanılan bir yapıdır.
             */

            //2 Boyutlu Dizi Örneklendirmesi
            //int[,] sayilar = new int[3,4];
            //sayilar[1, 2] = 5;
            //sayilar[2, 3] = 15;

            //Çok boyutlu Dizi örneklendirmesi
            //int[,,,] sayilar2 = new int[2, 3, 4, 5];
            //sayilar2[0, 0, 0, 1] = 15;

            //Farklı varyasyonda değer atama
            //int[,] sayilar = { { 3, 5, 7 }, { 5, 3, 1 }, { 1, 3, 5 } };
            #region Çok Boyutlu Dizilerde Değer Okuma
            //int[,] sayilar = new int[3,4];
            //sayilar[0, 0] = 1;
            //sayilar[0, 1] = 3;
            //sayilar[0, 2] = 5;
            //sayilar[0, 3] = 7;
            //sayilar[1, 0] = 3;
            //sayilar[1, 1] = 3;
            //sayilar[1, 2] = 64;
            //sayilar[1, 3] = 3;
            //sayilar[2, 0] = 3;
            //sayilar[2, 1] = 3;
            //sayilar[2, 2] = 233;
            //sayilar[2, 3] = 255;

            //Console.WriteLine(sayilar[1,2]);






            #endregion
            #region Dizinin Kaç Dereceli/Boyutlu olduğunu öğrenme
            //int[,,] sayilar = new int[2, 3, 4]; //3 boyutlu
            //Console.WriteLine(sayilar.Rank);  
            #endregion
            #region Çok Boyutlu Dizilerin Eleman sayısını hesaplama
            /*
             * İlgili dizinin toplam eleman sayısı tüm boyutların eleman sayılarının çarpımıyla elde edilir.
             * 2*3*4 = 24 ELEMANLI bir DİZİ.
             */
            //int[,,] sayilar = new int[2, 3, 4];
            //Console.WriteLine(sayilar.Length);
            #endregion
            #region Çok Boyutlu Dizilerin Belirli Eleman Sayısını Hesaplama
            //int[,,] sayilar = new int[2, 3, 4];

            //Console.WriteLine(sayilar.GetLength(0)); //2
            //Console.WriteLine(sayilar.GetLength(1)); //3
            //Console.WriteLine(sayilar.GetLength(2)); //4
            #endregion
            #region Çok Boyutlu Dizilerdeki Verileri İç İçe Döngülerle Ekrana Yazdırma
            //int[,,] sayilar = new int[2, 2, 4];
            //sayilar[0, 0, 0] = 1;
            //sayilar[0, 0, 1] = 2;
            //sayilar[0, 0, 2] = 3;
            //sayilar[0, 0, 3] = 4;
            //sayilar[0, 1, 0] = 5;
            //sayilar[0, 1, 1] = 6;
            //sayilar[0, 1, 2] = 7;
            //sayilar[0, 1, 3] = 8;
            //sayilar[1, 0, 0] = 9;
            //sayilar[1, 0, 1] = 10;
            //sayilar[1, 0, 2] = 11;
            //sayilar[1, 0, 3] = 12;
            //sayilar[1, 1, 0] = 13;
            //sayilar[1, 1, 1] = 14;
            //sayilar[1, 1, 2] = 15;
            //sayilar[1, 1, 3] = 16;

            //for (int x = 0; x < sayilar.GetLength(0); x++)
            //{
            //    for (int y = 0; y < sayilar.GetLength(1); y++)
            //    {
            //        for (int z = 0; z < sayilar.GetLength(2); z++)
            //        {
            //            Console.Write(sayilar[x, y, z] + "               ");
            //        }
            //        Console.WriteLine("");
            //    }
            //}

            #endregion




            #endregion
            #region Düzensiz Diziler / Jagged Arrays
            /*
             * Düzensiz Diziler; her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
             * Çok Boyutlu Dizilerden farkı; çok  boyutlu dizilerin sütun sayılarının sabit; düzensiz dizilerin ise sütun sayılarının değişken olmasıdır.
             */
            //int dizi türünde değerler tutacak bir dizi tanımlamış oluyoruz.
            //int[][] sayilar = new int[3][];
            //sayilar[0] = new int[3] { 3, 5, 7 };
            //sayilar[1] = new int[5] { 3, 5, 7, 9, 11 };
            //sayilar[2] = new int[10] { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            ////Düzensiz Diziler - Değer Atama/Okuma
            //Console.WriteLine(sayilar[0][0]);
            //sayilar[0][0] = 13;
            //Console.WriteLine(sayilar[0][0]);

            #region Düzensiz Dizilerin Eleman Sayısını Öğrenme
            //int[][] sayilar = new int[3][];
            //sayilar[0] = new int[3] { 3, 5, 7 };
            //sayilar[1] = new int[5] { 3, 5, 7, 9, 11 };
            //sayilar[2] = new int[10] { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            //Console.WriteLine(sayilar.Length); //3: Ana dizinin eleman sayısı //Düzensiz dizinin eleman sayısını getirir. AMA! bu bize toplam eleman sayısını vermez..! Çok boyutlu dizilerde olduğu gibi, başlı başına farklı bir dizi yapılanması değildir. Normal bir dizi yapılanmasıdır. Lakin içeriisnde dizi barındıran bir dizidir. Haliyle eleman sayısını döndürür.
            ////İçteki dizilerin eleman sayılarını totalde elde edebilmek için herbirini toplamamız gerekmektedir.

            //Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length); // Toplam eleman sayısı: 18

            #endregion
            #region Düzensiz Dizilerde İç İçe Döngülerle Çalışmak
            //int[][] sayilar = new int[3][];
            //sayilar[0] = new int[3] { 3, 5, 7 };
            //sayilar[1] = new int[5] { 3, 5, 7, 9, 11 };
            //sayilar[2] = new int[10] { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    for (int j = 0; j < sayilar[i].Length; j++)
            //    {
            //        Console.Write(sayilar[i][j] + "   -   ");
            //    }
            //    Console.WriteLine("");
            //}
            #endregion

            #endregion
        }
    }
}