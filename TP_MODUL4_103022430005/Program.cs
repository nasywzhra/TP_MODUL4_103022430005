using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.Write("Masukkan kelurahan: ");
        string kel = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kp.GetKodePos(kel));

        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}

class KodePos
{
    private Dictionary<string, string> kodePos = new Dictionary<string, string>()
    {
        {"Batununggal","40266"},
        {"Kujangsari","40287"},
        {"Mengger","40267"},
        {"Wates","40256"},
        {"Cijaura","40287"},
        {"Jatisari","40286"},
        {"Margasari","40286"},
        {"Sekejati","40286"},
        {"Kebonwaru","40272"},
        {"Maleer","40274"},
        {"Samoja","40273"}
    };

    public string GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class DoorMachine
{
    enum State { TERKUNCI, TERBUKA }

    private State currentState = State.TERKUNCI;

    public void BukaPintu()
    {
        if (currentState == State.TERKUNCI)
        {
            currentState = State.TERBUKA;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.TERBUKA)
        {
            currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }
    }
}