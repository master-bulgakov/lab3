using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс проверяющий вводимые в TextBox значения.
    /// </summary>
    public static class ValidateField
    {
        /// <summary>
        /// Метод разрешающий ввод только чисел формата double.
        /// </summary>
        public static void ValidateFields(object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                         && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
            if ((sender as TextBox).Text.Length == 0)
                if (e.KeyChar == ',')
                    e.Handled = true;
        }
    }
}
