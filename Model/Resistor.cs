namespace Model
{
    /// <summary>
    /// Класс описывающий параметры резистора.
    /// </summary>
    public class Resistor : ElementBase
    {
        /// <summary>
        /// Константа хранящая минимальное значение 
        /// сопротивления резистора.
        /// по умолчанию 0
        /// </summary>
        public const int minimalResistance = 0;

        /// <summary>
        /// Константа хранящая максимальное значение 
        /// сопротивления резистора.
        /// по умолчанию 1500
        /// </summary>
        public const int maximumResistance = 1500;

        /// <summary>
        /// Конструктор класса Resistor.
        /// </summary>
        /// <param name="resistance">Поле описывающее 
        /// значение сопротивления резистора.</param>
        public Resistor(double resistance)
        {
            Resistance = resistance;
        }

        /// <summary>
        /// Поле описывающее значение 
        /// сопротивления резистора.
        /// </summary>
        private double _resistance;

        /// <summary>
        /// Свойство описывающее значение 
        /// сопротивления резистора.
        /// </summary>
        private protected double Resistance
        {
            get => _resistance;
            set => _resistance = CheckField(value, "сопротивление",
                minimalResistance, maximumResistance);
        }

        /// <summary>
        /// Свойство хранящее название элемента 
        /// электрической схемы (Резистор).
        /// </summary>
        public override string ElementPassiveName => "Резистор";

        /// <summary>
        /// Свойство хранящее сопротивление пассивного
        /// элемента электрической схемы.
        /// </summary>
        public override double ElementResistance => _resistance;
    }
}