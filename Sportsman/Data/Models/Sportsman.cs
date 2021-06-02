using System;

namespace Sportsman.Data.Models
{
    /// <summary>
    /// Спортсмены.
    /// </summary>
    public class Sportsman
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>

        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Опыт
        /// </summary>
  
        public double Experience { get; set; }

       
        public int? TeamId { get; set; }

  
        public virtual Team Team { get; set; }
        public string Career { get; set; }
        public string PersonalAchievements { get; set; }
    }
}
