namespace WpfApp1
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Authors { get; set; }
        public int Pages { get; set; }
        public string Category { get; set; }
        public int State { get; set; }
        public string StatusName => GetStatusName();

        public Book(int id, string name, string authors, int pages, string category, int state)
        {
            Id = id;
            Name = name;
            Authors = authors;
            Pages = pages;
            Category = category;
            State = state;
        }

        private string GetStatusName()
        {
            return State switch
            {
                1 => "В фонде",
                2 => "Выдана",
                3 => "На реставрации",
                _ => "Неизвестно"
            };
        }
    }
}