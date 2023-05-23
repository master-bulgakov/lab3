using System;

namespace View
{
    [Serializable]
    /// <summary>
    /// Класс с информацией об
    /// элементах электрической схемы.
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Свойство, описывающее название 
        /// элемента электрической схемы.
        /// </summary>
        public string ElementName { get; set; }

        /// <summary>
        /// Свойство, описывающее сопротивление элемента.
        /// </summary>
        public double? ElementResistance { get; set; }
    }
}