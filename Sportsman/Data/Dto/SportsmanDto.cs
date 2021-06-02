using System;

namespace Sportsman.Data.Dto
{
    /// <summary>
    /// Спортсмен.
    /// </summary>
    public class SportsmanDto
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
        /// Возраст - ата рождения!
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Опыт
        /// </summary>
        public double Experience { get; set; }

        /// <summary>
        /// Идентификатор вида спорта.
        /// </summary>
        public int? TeamId { get; set; }

        /// <summary>
        /// Команда.
        /// </summary>
        public string TeamName { get; set; }
        public string Career { get; set; }
        public string PersonalAchievements { get; set; }
    }
}
