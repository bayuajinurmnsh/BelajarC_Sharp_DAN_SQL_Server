using System;

namespace StudyCase
{
    class PesawatTempur : Pesawat
    {
        public void TerbangTinggi()
        {
            Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} Akan meledakkan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }
}