// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ayah
    {
        public int number { get; set; }
        public string text { get; set; }
        public int numberInSurah { get; set; }
        public int juz { get; set; }
        public int manzil { get; set; }
        public int page { get; set; }
        public int ruku { get; set; }
        public int hizbQuarter { get; set; }
        public bool sajda { get; set; }
    }

    public class Data
    {
        public int number { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public string englishNameTranslation { get; set; }
        public string revelationType { get; set; }
        public int numberOfAyahs { get; set; }
        public List<Ayah> ayahs { get; set; }
        public Edition edition { get; set; }
    }

    public class Edition
    {
        public string identifier { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public string format { get; set; }
        public string type { get; set; }
        public string direction { get; set; }
    }

    public class Root
    {
        public int code { get; set; }
        public string status { get; set; }
        public Data data { get; set; }
    }

