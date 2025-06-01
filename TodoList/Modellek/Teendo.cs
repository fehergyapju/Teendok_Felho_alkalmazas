namespace TodoList.Modellek
{
    public class Teendo
    {
        public Guid Id { get; set; } = Guid.NewGuid(); //Egy egyedi azonosító, ami mindig random generálódik, ha létrejön egy teendő

        public string Leiras { get; set; }

        public DateTime Idopont { get; set; }

        public bool Megcsinaltae { get; set; }
    }
}
