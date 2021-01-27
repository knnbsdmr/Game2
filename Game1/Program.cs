using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() 
            {Adi = "kenan", SoyAdi = "demir", TcNo = "123", DogumTarixi = "15 kasım 1993"};
            Player player2 = new Player() 
            { Adi = "ahmet", SoyAdi = "erkin", TcNo = "12441", DogumTarixi = "1 aralık 2001" };
            Console.WriteLine(player1.SoyAdi);
            Console.WriteLine(player2.Adi);

            EgovPlayerInfo egovplayerinfo2 = new EgovPlayerInfo()
            { Adi = "hakan", SoyAdi = "öztürk", TcNo = "6762", DogumTarixi = "5 haziran 1994", ID = 123};
            EgovPlayerInfo egovPlayerInfo1 = new EgovPlayerInfo
            { Adi = "furkan", SoyAdi = "atılgan", TcNo = "646464", DogumTarixi = "9 nisan 1999"};
            Console.WriteLine(egovplayerinfo2.TcNo);
            Console.WriteLine(egovPlayerInfo1.Adi);

            Oyun oyun1 = new Oyun()
            {OyunAdi = "Fifa-2021", OyunPrice = "70 $"};
            Oyun oyun2 = new Oyun() { OyunAdi = "League of Legends", OyunPrice = "5 TL" };
            Console.WriteLine(oyun1.OyunPrice);
            Console.WriteLine(oyun2.OyunAdi);

            IKompaniya kompaniyaManager1 = new KompaniyaManager();
            kompaniyaManager1.Newkompaniya(oyun1);
            kompaniyaManager1.DeleteKompaniya(oyun1);
            kompaniyaManager1.UpdateKompaniya(oyun2);
            Console.WriteLine(  "'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");

            IPlayManager playManager = new PlayerManager() { };
            playManager.DeletePlayerManager(player1);
            playManager.NewPlayerManager(player2);
            playManager.UpdatePlayerManager(player1);

            SatisManager satismanager = new SatisManager();
            satismanager.satisManager(player2, oyun2);
            satismanager.satisManager(player1, oyun1);

            OyuncuDogrulama oyuncuDogrulama = new OyuncuDogrulama();
            oyuncuDogrulama.oyuncuDogrulama(player1, egovPlayerInfo1);
        }
    }
}
