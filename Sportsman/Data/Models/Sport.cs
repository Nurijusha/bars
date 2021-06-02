namespace Sportsman.Data.Models
{
    public class Sport
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        public Sport(string name)
        {
            Name = name;
        }
    }
}