namespace Model
{
    /// <summary>
    /// Класс описывающий параметры катушки индуктивности. 
    /// </summary>
    public class Inductance : ElementBase
    {
        /// <summary>
        /// Константа хранящая значение минимальной 
        /// угловой частоты катушки.
        /// по умолчанию 0
        /// </summary>
        public const int minimalAngularFrequency = 0;

        /// <summary>
        /// Константа хранящая значение максимальной 
        /// угловой частоты катушки.
        /// по умолчанию 100
        /// </summary>
        public const int maximumAngularFrequency = 100;

        /// <summary>
        /// Константа хранящая минимальное значение 
        /// индуктивности катушки.
        /// по умолчанию 500
        /// </summary>
        public const int minimalInductivity = 0;

        /// <summary>
        /// Константа хранящая максимальное значение 
        /// индуктивности катушки.
        /// по умолчанию 100
        /// </summary>
        public const int maximumInductivity = 100;

        /// <summary>
        /// Конструктор класса Inductance.
        /// </summary>
        /// <param name="angularFrequency">Поле описывающее 
        /// значение угловой частоты катушки.</param>
        /// <param name="inductivity">Поле описывающее 
        /// значение индуктивности катушки.</param>
        public Inductance(double angularFrequency, double inductivity)
        {
            AngularFrequency = angularFrequency;
            Inductivity = inductivity;
        }

        /// <summary>
        /// Поле описывающее значение угловой частоты катушки.
        /// </summary>
        private double _angularFrequency;

        /// <summary>
        /// Свойство описывающее значение угловой частоты катушки.
        /// </summary>
        private protected double AngularFrequency
        {
            get => _angularFrequency;
            set => _angularFrequency = CheckField(value, "угловая частота",
                minimalAngularFrequency, maximumAngularFrequency);
        }

        /// <summary>
        /// Поле описывающее значение  
        /// индуктивности катушки.
        /// </summary>
        private double _inductivity;

        /// <summary>
        /// Свойство описывающее значение 
        /// индуктивности катушки.
        /// </summary>
        private protected double Inductivity
        {
            get => _inductivity;
            set => _inductivity = CheckField(value,
                "индуктивность",
                minimalInductivity, maximumInductivity);
        }

        /// <summary>
        /// Свойство хранящее название элемента 
        /// электрической схемы (Катушка индуктивности).
        /// </summary>
        public override string ElementPassiveName =>
            "Катушка индуктивности";

        /// <summary>
        /// Свойство хранящее сопротивление пассивного 
        /// элемента электрической схемы.
        /// </summary>
        public override double ElementResistance =>
            (Inductivity * AngularFrequency);
    }
}