namespace Sportsman.Data.Dto
{
    public class TeamDto
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Спорт
        /// </summary>
        public string Sport { get; set; }
    }
}
