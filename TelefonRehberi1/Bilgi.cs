using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi1
{
    internal class Bilgi
    {

        public static string Constr = "Data Source=DESKTOP-0238RR6\\MSSQLSERVER12;Initial Catalog=Rehber;User ID=zeynep;Password=zeynep20;";



        public static int KisiID = 0;
        public static void KisiKayit(int KisiID, string KisiAdi, string KisiSoyadi, string TelefonNo, string EPosta, string Adres, string TCKimlikNo, DateTime DogumTarihi)

        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand com = new SqlCommand("if not exists( select * from Kisi Where KisiID=@KisiID) Insert into Kisi (KisiAdi, KisiSoyadi, TelefonNo, EPosta, Adres, TCKimlikNo,DogumTarihi) values (@KisiAdi, @KisiSoyadi, @TelefonNo, @EPosta, @Adres, @TCKimlikNo, @DogumTarihi) else Update Kisi set KisiAdi=@KisiAdi, KisiSoyadi=@KisiSoyadi, TelefonNo=@TelefonNo, EPosta=@EPosta, Adres=@Adres, TCKimlikNo=@TCKimlikNo,DogumTarihi=@DogumTarihi Where KisiID=@KisiID", con);
            com.Parameters.AddWithValue("@KisiID", KisiID);
            com.Parameters.AddWithValue("@KisiAdi", KisiAdi);
            com.Parameters.AddWithValue("@KisiSoyadi", KisiSoyadi);
            com.Parameters.AddWithValue("@TelefonNo", TelefonNo);
            com.Parameters.AddWithValue("@EPosta", EPosta);
            com.Parameters.AddWithValue("@Adres", Adres);
            com.Parameters.AddWithValue("@TCKimlikNo", TCKimlikNo);
            com.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();




        }
        public static void DatabaseYedek()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand com = new SqlCommand(@"Backup database Rehber to disk='C:\Rehber.bak' with format", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


    }

        public static DataSet KisiListesiAl(string veri)
        {
         
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(Constr);
            SqlDataAdapter da = new SqlDataAdapter("select KisiID as [ID], KisiAdi as [ADI], KisiSoyadi as [SOYADI], TelefonNo as [TELEFON], EPosta as [E-POSTA], Adres as [ADRES], TCKimlikNo as [T.C. KİMLİK NO], DogumTarihi as [DOĞUM TARİHİ] from Kisi order by KisiAdi asc", connection);
            da.Fill(ds);
            return ds;
        }

        private static string Baslik()
        {
            return "          versiyon:" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private static void KisiListesiAl1()
        {
            throw new NotImplementedException();
        }

        private static void KisiKayit1(int v1, string v2, Func<string> toUpper, string text1, string v3, string v4, string text2, DateTime value)
        {
            throw new NotImplementedException();
        }

        private static void KayitSil2(int kisiID)
        {
            throw new NotImplementedException();
        }

        public static DataSet KisiAraAdaGore(string veri)
        {
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(Constr);
            SqlDataAdapter da = new SqlDataAdapter("select KisiID as [ID], KisiAdi as [ADI], KisiSoyadi as [SOYADI], TelefonNo as [TELEFON], EPosta as [E-POSTA], Adres as [ADRES], TCKimlikNo as [T.C. KİMLİK NO], DogumTarihi as [DOĞUM TARİHİ] from Kisi Where KisiAdi like '%'+@Veri+'%' order by KisiAdi asc", connection);
            da.SelectCommand.Parameters.AddWithValue("@Veri", veri.ToUpper());
            da.Fill(ds);
            return ds;
        }

        public static DataSet KisiAraSoyadaGore(string veri)
        {
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(Constr);
            SqlDataAdapter da = new SqlDataAdapter("select KisiID as [ID], KisiAdi as [ADI], KisiSoyadi as [SOYADI], TelefonNo as [TELEFON], EPosta as [E-POSTA], Adres as [ADRES], TCKimlikNo as [T.C. KİMLİK NO], DogumTarihi as [DOĞUM TARİHİ] from Kisi Where KisiSoyadi like '%'+@Veri+'%' order by KisiSoyadi asc", connection);
            da.SelectCommand.Parameters.AddWithValue("@Veri", veri.ToUpper());
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return ds;
        }

        private static void KayitSil1(int KisiID, SqlConnection con)
        {
            SqlConnection connection = new SqlConnection(Constr);
            SqlCommand com = new SqlCommand("delete from Kisi Where KisiID=@KisiID", con);
            com.Parameters.AddWithValue("@KisiID", KisiID);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        internal static void KayitSil(int kisiID)
        {
            throw new NotImplementedException();
        }

    }
    }