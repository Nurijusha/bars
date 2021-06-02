namespace Sportsman.Data.Dto
{
    public class SportDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SportDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}