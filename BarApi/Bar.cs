namespace BasicWebApi
{
    public class Bar
    {
        public Bar(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public string Address { get; set; }

        public string Barrio { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }



    }
}