using Microsoft.AspNetCore.Mvc;

namespace modul9_1302220144.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mhs = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Fauzan Majid", "1302220144",new List<string>
            {
                "Konstruksi Perangkat Lunak",
                "Basis Data"
            },2022),
            new Mahasiswa("Muhammad Daffa Fadillah", "1302223124",new List<string>{
                "Dasar Jaringan Komputer",
                "Pemrograman Berorientasi Objek",
            },2022),
            new Mahasiswa("Arinza Aurelvia", "1302220022",new List<string>
            {
                "Konstruksi Perangkat Lunak",
                "Basis Data"
            },2022),
            new Mahasiswa("⁠Muhammad Hashfi Hadyan", "1302220079",new List<string>
            {
                "Pengalaman Pengguna",
                "Proyek Tingkat II"
            },2022),
            new Mahasiswa("Soraya Haidar Salma", "1302223006",new List<string>
            {
                "Konstruksi Perangkat Lunak",
                "Proyek Tingkat II"
            },2022),
            new Mahasiswa("Maulana Farras", "103022390001",new List<string>
            {
                "Pengalaman Pengguna",
                "Proyek Tingkat II"
            },2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newvalue)
        {
            mhs.Add(newvalue);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}
