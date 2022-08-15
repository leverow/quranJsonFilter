using System.Net;
using Newtonsoft.Json;

var number = int.Parse(Console.ReadLine());

var jsonString = string.Empty;
using (WebClient wc = new WebClient())
{
   jsonString = wc.DownloadString($@"http://api.alquran.cloud/v1/surah/{number:D3}/en.asad");
}
Root root = JsonConvert.DeserializeObject<Root>(jsonString);
Console.WriteLine($"Name of surah: {root.data.englishName}");
var ayahs = root.data.ayahs;
List<string> AyahsStringList = new List<string>();
foreach( var ayah in ayahs)
{
    Console.WriteLine($"{ayah.text}");
	AyahsStringList.Add(ayah.text);
}
string StringAyahs = string.Join(" ", AyahsStringList);