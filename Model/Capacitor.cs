using System;

namespace Model
{
    /// <summary>
    /// Класс описывающий параметры конденсатора. 
    /// </summary>
    public class Capacitor : ElementBase
    {
        /// <summary>
        /// Константа хранящая значение 
        /// минимальной угловой частоты конденсатора.
        /// </summary>
        public const int minimalAngularFrequency = 0;

        /// <summary>
        /// Константа хранящая значение 
        /// максимальной угловой частоты конденсатора.
        /// </summary>
        public const int maximumAngularFrequency = 500;

        /// <summary>
        /// Константа хранящая значение 
        /// минимальной ёмкости конденсатора.
        /// </summary>
        public const int minimalCapacity = 0;

        /// <summary>
        /// Константа хранящая значение 
        /// максимальной ёмкости конденсатора.
        /// </summary>
        public const int maximumCapacity = 100;

        /// <summary>
        /// Конструктор класса Capacitor.
        /// </summary>
        /// <param name="angularFrequency">Поле описывающее
        /// значение угловой частоты конденсатора.</param>
        /// <param name="capacity">Поле описывающее
        /// значение ёмкости конденсатора.</param>
        public Capacitor(double angularFrequency,
            double capacity)
        {
            AngularFrequency = angularFrequency;
            Capacity = capacity;
        }

        /// <summary>
        /// Поле описывающее значение угловой 
        /// частоты конденсатора.
        /// </summary>
        private double _angularFrequency;

        /// <summary>
        /// Свойство описывающее значение 
        /// площади угловой частоты конденсатора.
        /// </summary>
        private protected double AngularFrequency
        {
            get => _angularFrequency;
            set => _angularFrequency = CheckField(value,
                "угловая частота",
                minimalAngularFrequency,
                maximumAngularFrequency);
        }

        /// <summary>
        /// Поле описывающее значение
        /// ёмкости конденсатора.
        /// </summary>
        private double _capacity;

        /// <summary>
        /// Свойство описывающее значение
        /// ёмкости конденсатора.
        /// </summary>
        private protected double Capacity
        {
            get => _capacity;
            set => _capacity = CheckField(value, "ёмкость",
                minimalCapacity, maximumCapacity);
        }

        /// <summary>
        /// Свойство хранящее название 
        /// элемента электрической схемы (Конденсатор).
        /// </summary>
        public override string ElementPassiveName =>
            "Конденсатор";

        /// <summary>
        /// Свойство хранящее сопротивление 
        /// пассивного элемента электрической схемы.
        /// </summary>
        public override double ElementResistance =>
            Math.Pow((Capacity * AngularFrequency), -1);
    }
}