using System.Collections.Generic;

namespace Kit_Up.Models
{
    public static class Veritabani
    {
        public static List<Urun> _Liste;

        static Veritabani()
        {
            _Liste = new List<Urun>()
            {
                new Urun(){ UrunId=1, UrunImg="/Content/assets/books/kahin-ve-anka.png", UrunAdi="Armoni Elementleri: Kahin ve Anka ", UrunYazar="Buse Pendaz", UrunAciklama="Kahin, Nemesis’e adım attığı andan itibaren kötülük onun peşini bırakmamıştı. Kendini sürekli yeni bir tehlikenin içinde buluyordu. Yanında onu korumaya ant içmiş Descartes varken, ne kadar güvendeydi? O, sevdikleri için canından bile vazgeçebilecekken sevdikleri onun için her şeyi yapar mıydı? Karanlık gecelerde, yanında emin adımlarla yürüyen yoldaşlarıyla her seferinde yeni bir maceraya adım atan Melany’yi ne gibi zorluklar bekliyordu? Kahinin dünyaya gelmesiyle kötülük de yeniden ortaya çıkmıştı. Büyücüler ve element kullanıcıları arasındaki savaşsa çok yakındı. Kristaller gerçeği göstermişti. Kötülük ortadan kaldırılmalıydı yoksa felaket yaşanacaktı. Alınacak intikamlar, yapılacak büyüler, kurtarılacak kişiler ve verilecek kayıplar vardı. Peki aşk, insanın canını ne kadar yakardı?Melany, kaderine yön verebilecek miydi? Yoksa yaşadığı her şey, kaderinin bir parçası mıydı?Her ne şekilde olursa olsun: Bu bir elveda değil, bir başlangıçtı.", UrunStok=5, UrunFiyat=34.30, UrunKategori="Fantastik", UrunSatistami=true },
                new Urun(){ UrunId=2, UrunImg="/Content/assets/books/1984.png", UrunAdi="1984 ", UrunYazar="George Orwell", UrunAciklama="Distopya olarak nitelendirilen George Orwell’ın bu şahane eseri, geçmişin aslında ne kadar da gelecekten izler taşıdığını ortaya koyuyor. 1948’de kaleme aldığı bu eser ile Orwell, günümüz modern dünyasına bir protesto bırakıyor. Her ne kadar kitabında 1984 yılını tasvir etse de kitabın derinliklerinde bugünden izler de bulabilmeniz mümkün. Bu durumda elbette ki George Orwell’ın ileri görüşlülüğü etkili.", UrunFiyat=12.60, UrunStok=5, UrunKategori="Dünya Roman", UrunSatistami=true },
                new Urun(){ UrunId=3, UrunImg="/Content/assets/books/gün-olur-asra-bedel.png", UrunAdi="Gün Olur Asra Bedel ", UrunYazar="Cengiz Aytmatov", UrunAciklama="Cengiz Aytmatov'un bütün dünyada geniş yankılar uyandıran bu romanı, yürek paralayan, tüyler ürperten bir haykırıştır. Fakat umutsuz bir çırpınış değil, tutsaklığa, baskılara ve sürgünlere karşı umudu hep diri tutan bir meydan okuyuştur. Yedigey Cangeldi, cepheden döndükten sonra Kazak bozkırlarında küçük bir tren aktarma istasyonunda çalışmaya başlar. Burada şahit olduğu ve uzak geçmişinden hatırladığı olaylar, aslında yekpare bir coğrafyaya kâbûs gibi çöken bir siyasî rejimin gümbür gümbür çöküşünün sebepleridir. Aytmatov, insanı yok sayan ve onu makineleştirmek isteyen sistemin aslında niçin çökmeye mahkûm olduğunu bu romanında da gösteriyor. Yedigey, ölen emektar arkadaşı Kazangap'ın cenazesini mezarına götürürken, kendisinin ve milletinin geçmişini, acı-tatlı, düşündürücü yanlarıyla bir bir gözlerinin önünden geçirir. O gün, “asra bedel bir gün olur” onun için. Geçmişi, bugünü ve yarını büyük ustalıkla bir arada sunan Aytmatov, “Demiurg” uzay araştırmaları programı neticesinde keşfedilen bir uygarlığın, insanlarla iletişim kurma çabalarının yerküredeki yansımalarını gösterirken, adeta bizleri aynada kendimizle yüzleşmeye davet eder. Kazangap'ın götürüldüğü Ana-Beyit mezarlığı adını, Nayman Ana adlı efsanevî bir kadının orada gömülü olmasından alır. Aytmatov; Nayman Ana'nın hikâyesini verirken, dünyaya “mankurt” kavramını hediye eder. Bu garip, bu korkutucu kelime hangi anlama mı geliyor? İnsanın, yani bütün geçmişini her an beraberinde taşıyan varlığın yerini, hafızası ve hatıraları olmayan, ruhunu kaybetmiş, içi komutlarla doldurulmuş biyolojik bir makinenin aldığını düşünün.", UrunStok=5, UrunFiyat=18.90, UrunKategori="Dünya Roman", UrunSatistami=true },
            };

        }

        public static List<Urun> Liste
        {
            get { return _Liste; }
        }

    }
}