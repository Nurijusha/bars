using System.Collections.Generic;

namespace Sportsman.Data.Models
{
    public class Team
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

        public virtual ICollection<Sportsman> Sportsmans { get; set; }
    }
}
