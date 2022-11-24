using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiBa_Lib;
using MySql.Data.MySqlClient;

namespace DiBa_Lib
{
    public class Pengguna
    {
        #region data members
        private string nik;
        private string namaDepan;
        private string namaKeluarga;
        private string alamat;
        private string email;
        private string noTelp;
        private string password;
        private string pin;
        private DateTime tglBuat;
        private DateTime tglPerubahan;
        private Pangkat pangkat;
        #endregion

        #region constructors
        public Pengguna(string nik, string namaDepan, string namaKeluarga, string alamat, string email,
            string noTelp, string password, string pin, DateTime tglBuat, DateTime tglPerubahan, Pangkat pangkat)
        {
            this.Nik = nik;
            this.NamaDepan = namaDepan;
            this.NamaKeluarga = namaKeluarga;
            this.Alamat = alamat;
            this.Email = email;
            this.NoTelp = noTelp;
            this.Password = password;
            this.Pin = pin;
            this.TglBuat = tglBuat;
            this.TglPerubahan = tglPerubahan;
            this.Pangkat = pangkat;
        }

        public Pengguna()
        {
            Nik = "";
            NamaDepan = "";
            NamaKeluarga = "";
            Alamat = "";
            Email = "";
            NoTelp = "";
            Password = "";
            Pin = "";
            TglBuat = DateTime.Now;
            TglPerubahan = DateTime.Now;
            Pangkat = null;
        }
        #endregion

        #region properties
        public string Nik { get => nik; set => nik = value; }
        public string NamaDepan { get => namaDepan; set => namaDepan = value; }
        public string NamaKeluarga { get => namaKeluarga; set => namaKeluarga = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string NoTelp { get => noTelp; set => noTelp = value; }
        public string Password { get => password; set => password = value; }
        public string Pin { get => pin; set => pin = value; }
        public DateTime TglBuat { get => tglBuat; set => tglBuat = value; }
        public DateTime TglPerubahan { get => tglPerubahan; set => tglPerubahan = value; }
        public Pangkat Pangkat { get => pangkat; set => pangkat = value; }

        #endregion

        #region methods
        public static List<Pengguna> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select p.nik, p.nama_depan,p.nama_keluarga, p.alamat, p.email, p.no_telepon, p.password, " +
                "p.pin, p.tgl_buat, p.tgl_perubahan, pg.jenis_pangkat  from pengguna as p inner join pangkat as pg ";
            }
            else
            {
                sql = "select p.nik, p.nama_depan,p.nama_keluarga, p.alamat, p.email, p.no_telepon, p.password, " +
                "p.pin, p.tgl_buat, p.tgl_perubahan, pg.jenis_pangkat  from pengguna as p inner join pangkat as pg "
                + "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.ambilData(sql);

            //buat list untk menampung data 
            List<Pengguna> listPengguna = new List<Pengguna>();
            while (hasil.Read() == true)
            {
                Pangkat pg = new Pangkat(hasil.GetString(10), hasil.GetString(11));

                Pengguna p = new Pengguna(hasil.GetString(0), hasil.GetString(1), hasil.GetString(2),
                    hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7),
                    DateTime.Parse(hasil.GetValue(8).ToString()), DateTime.Parse(hasil.GetValue(9).ToString()), pg);
                listPengguna.Add(p);
            }
            return listPengguna;
        }

        public static void TambahData(Pengguna p)
        {
            string sql = "insert into pengguna(nik, nama_depan,nama_keluarga, alamat, email, no_telepon, password, " +
                "pin, tgl_buat, tgl_perubahan) " + "values ('" + p.Nik + "','" + p.NamaDepan.Replace("'", "\\'") + "','"
                + p.NamaKeluarga.Replace("'", "\\'") + "','" + p.Alamat + "','" + p.Email + "','" + p.NoTelp + "','"
                + p.Password + "','" + p.Pin + "','" + p.TglBuat + "','" + p.TglPerubahan + "')";
            Koneksi.executeDML(sql);
        }

        public static void UbahData(Pengguna p)
        {
            string sql = "update kategori set nama_depan='" + p.NamaDepan.Replace("'", "\\'") + "',nama_keluarga='" +
                "',alamat='" + p.Alamat + "',email='" + p.Email + "',no_telepon='" + p.NoTelp + "',password='" +
                p.Password + "',pin='" + p.Pin + "',tgl_buat='" + p.TglBuat + "',tgl_perubahan='" + p.TglPerubahan +
                "' where nik='" + p.Nik + "'";
            Koneksi.executeDML(sql);
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM pengguna " +
                         " WHERE nik = '" + this.Nik + "';";
            bool result = Koneksi.executeDML(sql);
            return result;
        }

        #endregion
    }
}
