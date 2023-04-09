using tpmodul8_1302213133;

CovidConfig con = new CovidConfig();
con.UbahSatuan();

Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + con.config.satuan_suhu);
string suhuBadan = Console.ReadLine();
int suhu = (int)Convert.ToInt32(suhuBadan);

Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
string inputHari = Console.ReadLine();
int hari = (int)Convert.ToInt32(inputHari);

if (con.config.satuan_suhu == "celcius")
{
    if (suhu > 37.5)
    {
        if (hari > con.config.batas_hari_demam)
        {
            Console.WriteLine(con.config.pesan_ditolak);
        }
        else
        {
            Console.WriteLine(con.config.pesan_diterima);
        }
    }
    else
    {
        Console.WriteLine(con.config.pesan_diterima);
    }
}
else if (con.config.satuan_suhu == "fahrenheit")
{
    if (suhu > 99.5)
    {
        if (hari > con.config.batas_hari_demam)
        {
            Console.WriteLine(con.config.pesan_ditolak);
        }
        else
        {
            Console.WriteLine(con.config.pesan_diterima);
        }
    }
    else
    {
        Console.WriteLine(con.config.pesan_diterima);
    }
}