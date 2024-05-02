namespace modul9_1302220144
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }
        
        public Mahasiswa(string nama, string nim,List<string> course,int year )
        {
            Nama = nama;
            NIM = nim;
            Course = course;
            Year = year;
        }
        
}
}
