using System;

class Mahasiswa {
    public string NIM;
    public string Nama;
    public int Nilai;
}

class Program {
    static void Main(string[] args) {
        Mahasiswa[] arrMhs = new Mahasiswa[3];

        // Input data mahasiswa
        for (int i = 0; i < arrMhs.Length; i++) {
            arrMhs[i] = new Mahasiswa();

            Console.WriteLine("Data Mahasiswa ke-" + (i + 1));
            Console.Write("NIM\t: ");
            arrMhs[i].NIM = Console.ReadLine();
            Console.Write("Nama\t: ");
            arrMhs[i].Nama = Console.ReadLine();
            Console.Write("Nilai\t: ");
            arrMhs[i].Nilai = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        // Cari nilai tertinggi
        int maxNilai = 0;
        string maxNIM = "", maxNama = "";

        for (int i = 0; i < arrMhs.Length; i++) {
            if (arrMhs[i].Nilai > maxNilai) {
                maxNilai = arrMhs[i].Nilai;
                maxNIM = arrMhs[i].NIM;
                maxNama = arrMhs[i].Nama;
            }
        }

        // Output nilai tertinggi
        Console.WriteLine("Mahasiswa dengan nilai tertinggi:");
        Console.WriteLine("NIM\t: " + maxNIM);
        Console.WriteLine("Nama\t: " + maxNama);
        Console.WriteLine("Nilai\t: " + maxNilai);

        Console.ReadLine();
    }
}
