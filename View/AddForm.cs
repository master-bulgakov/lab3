#define Debug
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using Model;

namespace View
{
    /// <summary>
    ///  Класс, описывающий добавление 
    ///  элемента электрической схемы.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Коллекция, хранящая информацию об 
        /// объектах электрической схемы. 
        /// </summary>
        private readonly List<Element> _elements;

        /// <summary>
        /// Делегат обновления данных в ElementDataGridView.
        /// </summary>
        private readonly UpdateInformation _updateMainInformation;

        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        /// <param name="elements">Объект, хранящий 
        /// информацию об элементах электрической схемы.</param>
        /// <param name="updateMainInformation">Делегат обновления 
        /// информации.</param>
        public AddForm(List<Element> elements,
            UpdateInformation updateMainInformation)
        {
            InitializeComponent();
            _elements = elements;
            _updateMainInformation = updateMainInformation;
            ElementNameComboBox.SelectedIndex = 0;
#if Release
            this.RandomValueButton.Visible = false;
#elif Debug
            this.RandomValueButton.Visible = true;
#endif
        }

        /// <summary>
        /// Событие выбора элемента электрической схемы по названию.
        /// </summary>
        private void ElementNameComboBox_SelectedIndexChanged(object
            sender, EventArgs e)
        {
            Item1TextBox.Text = string.Empty;
            Item2TextBox.Text = string.Empty;

            switch (ElementNameComboBox.SelectedIndex)
            {
                case 0:
                    Item1Label.Visible = true;
                    Item2Label.Visible = false;

                    Item1Label.Text = "Сопротивление, Ом";

                    Item1TextBox.Visible = true;
                    Item2TextBox.Visible = false;

                    break;
                case 1:
                    Item1Label.Visible = true;
                    Item2Label.Visible = true;

                    Item1Label.Text = "Угловая частота, рад/с";
                    Item2Label.Text = "Ёмкость, Ф";

                    Item1TextBox.Visible = true;
                    Item2TextBox.Visible = true;

                    break;
                case 2:
                    Item1Label.Visible = true;
                    Item2Label.Visible = true;

                    Item1Label.Text = "Угловая частота, рад/с";
                    Item2Label.Text = "Индуктивность, Гн";

                    Item1TextBox.Visible = true;
                    Item2TextBox.Visible = true;

                    break;
            }
        }

        /// <summary>
        /// Событие при загрузке формы AddForm.
        /// </summary>
        private void AddForm_Load(object sender, EventArgs e)
        {
            ElementNameComboBox_SelectedIndexChanged(sender, e);

            Item1TextBox.KeyPress += ValidateField.ValidateFields;
            Item2TextBox.KeyPress += ValidateField.ValidateFields;
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (_elements.Count > 0)
                _updateMainInformation();
        }

        /// <summary>
        /// Событие при нажатии на кнопку OK
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                switch (ElementNameComboBox.SelectedIndex)
                {
                    case 0:
                        if (Item1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "сопротивление резистора.\n";
                        }
                        if (message == string.Empty)
                        {
                            ElementBase resistor = new Resistor(Convert
                                .ToDouble(Item1TextBox.Text));
                            AddElement(resistor);
                        }
                        break;
                    case 1:
                        if (Item1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "угловую частоту конденсатора.\n";
                        }
                        if (Item2TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "ёмкость конденсатора.\n";
                        }
                        if (message == string.Empty)
                        {
                            ElementBase capacitor =
                                new Capacitor(Convert
                                .ToDouble(Item1TextBox.Text),
                                Convert.ToDouble(Item2TextBox.Text));
                            AddElement(capacitor);
                        }
                        break;
                    case 2:
                        if (Item1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "угловую частоту катушки.\n";
                        }
                        if (Item2TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "индуктивность катушки.\n";
                        }
                        if (message == string.Empty)
                        {
                            ElementBase inductance =
                                new Inductance(Convert
                                .ToDouble(Item1TextBox.Text),
                                Convert.ToDouble(Item2TextBox.Text));
                            AddElement(inductance);
                        }
                        break;
                }
                if (message != string.Empty)
                {
                    MessageBox.Show(message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод добавления данных в коллекцию.
        /// </summary>
        /// <param name="elementBase">Объект, который описывает 
        /// добавляемый элемент электрической схемы.</param>
        private void AddElement(ElementBase elementBase)
        {
            _elements.Add(new Element
            {
                ElementName = ElementNameComboBox.SelectedItem.ToString(),
                ElementResistance = elementBase.ElementResistance
            });
        }

        /// <summary>
        /// Событие при нажатии на кнопку случайное значение.
        /// </summary>
        private void RandomValueButton_Click(object sender, EventArgs e)
        {
            Random randomValue = new Random();
            int numberComboBox = randomValue.Next(0, 3);
            ElementNameComboBox.SelectedIndex = numberComboBox;
            Thread.Sleep(15);
            switch (ElementNameComboBox.SelectedIndex)
            {
                case 0:
                    Item1TextBox.Text = randomValue.Next(1, 1500)
                        .ToString();
                    break;
                case 1:
                    Item1TextBox.Text = randomValue.Next(1, 500)
                        .ToString();
                    Item2TextBox.Text = randomValue.Next(1, 100)
                        .ToString();
                    break;
                case 2:
                    Item1TextBox.Text = randomValue.Next(1, 100)
                        .ToString();
                    Item2TextBox.Text = randomValue.Next(1, 100)
                        .ToString();
                    break;
            }
        }
    }
}
