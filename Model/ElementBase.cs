using System;

namespace Model
{
    /// <summary>
    /// Класс описывающий информацию о пассивном
    /// элементе электрической схемы.
    /// </summary>
    public abstract class ElementBase
    {
        /// <summary>
        /// Свойство описывающее название пассивного
        /// элемента электрической схемы.
        /// </summary>
        public abstract string ElementPassiveName { get; }

        /// <summary>
        /// Свойство описывающее комплексное 
        /// сопротивление элемента электрической схемы. 
        /// </summary>
        public abstract double ElementResistance { get; }

        /// <summary>
        /// Метод проверки введённого значения.
        /// </summary>
        /// <param name="fieldValue">Проверяемое значение.</param>
        /// <param name="parametrName">Название проверяемого 
        /// значения.</param>
        /// <param name="minimalValue">Минимальное значение 
        /// параметра (не входит в диапазон допустимых 
        /// значений).</param>
        /// <param name="maximumValue">Максимальное значение 
        /// параметра (не входит в диапазон допустимых 
        /// значений).</param>
        /// <returns>Результат проверки введённого 
        /// значения.</returns>
        public static double CheckField(double fieldValue,
            string parametrName,
            double minimalValue, double maximumValue)
        {
            if ((fieldValue > minimalValue)
                && (fieldValue < maximumValue))
            {
                return fieldValue;
            }
            else
            {
                throw new Exception($"Значение " +
                    $"{parametrName} должно " +
                    $"быть больше {minimalValue} и " +
                    $"меньше {maximumValue}.");
            }
        }
    }
}