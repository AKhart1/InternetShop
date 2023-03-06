namespace internetShop.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public int available { get; set; }
        public int categoryID { get; set; }
        public virtual Categories? Categories { get; set; }
    }
}
