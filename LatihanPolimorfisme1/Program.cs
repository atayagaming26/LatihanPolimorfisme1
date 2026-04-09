ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(80);
imageProcessor.Resize(150);
imageProcessor.Resize(100);

imageProcessor.Resize(10, 10);
imageProcessor.Resize(2, 10);

imageProcessor.Resize("A4");

class ImageProcessor
{
    public void Resize(int persentase)
    {
        if (persentase <= 0)
        {
            Console.WriteLine("error. persentase tidak boleh nol(0) atau negatif");
        }
        if (persentase < 100)
        {
            Console.WriteLine($"mengecilkan gambar menjadi {persentase}");
        }
        else if (persentase > 100)
        {
            Console.WriteLine($"Memperbesar gambar menjadi {persentase}");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%). Tidak ada perubahan");
        }
    }
    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {lebar}px X {tinggi}px ");
    }
    public void Resize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukuran_kertas}");
    }
}