// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using static KodeBuah;

public class KodeBuah
{
    public enum enum_NamaBuah // Method Untuk Nama Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung,
        Kurma, Durian, Anggur, Melon, Semangka 
    }

    static string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

    static string getKodeBuah (enum_NamaBuah buah)
    {
        return kodeBuah[(int)buah];
    }
}

public class PosisiKarakterGame
{
    public enum enumState_Posisi
    {
        Jongkok, Berdiri, Tengkurap, Terbang
    }

    public enum enumState_Tekan
    {
        TombolW, TombolS, TombolX
    }

    public class Transition 
    {
        public enumState_Posisi currentState;
        public enumState_Posisi finalState;
        public enumState_Tekan trigger;

        public Transition(enumState_Posisi currentState, enumState_Posisi finalState, enumState_Tekan trigger)
        {
            this.currentState = currentState;
            this.finalState = finalState;
            this.trigger = trigger;
        }


    }

    Transition[] Transisi =
    {
        new Transition(enumState_Posisi currentState, enumState_Posisi finalState, enumState_Tekan trigger)
    };
 
            public static void Main(string[] args)
            {
                // Asumsi State Awal adalah Berdiri
                PosisiKarakterGame.enumState_Posisi posisi = PosisiKarakterGame.enumState_Posisi.Berdiri;
                Console.WriteLine("Input Tombol! ");
                string input = Console.ReadLine();

                while (input != "DONE")
                {
                    switch (posisi)
                    {
                        case PosisiKarakterGame.enumState_Posisi.Jongkok:
                            if (input == "TombolS")
                            {
                                posisi = PosisiKarakterGame.enumState_Posisi.Tengkurap;
                                Console.WriteLine("tombol arah bawah ditekan");
                            }
                            break;

                        case PosisiKarakterGame.enumState_Posisi.Tengkurap:
                            if (input == "TombolW")
                            {
                                posisi = PosisiKarakterGame.enumState_Posisi.Jongkok;
                                Console.WriteLine("tombol arah atas ditekan");
                            }
                            break;
                    }
                }
                Console.WriteLine(enum_NamaBuah.Apel);
                input = Console.ReadLine();
            }
        }
        Console.WriteLine(enum_NamaBuah.Apel);
        input = Console.ReadLine();
    }
}

