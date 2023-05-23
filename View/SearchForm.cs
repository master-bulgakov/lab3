using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс с описанием формы поиска элемента электрической схемы. 
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Делегат для передачи информации на главную форму.
        /// </summary>
        private readonly SearchDelegate _searchDelegate = null;

        /// <summary>
        /// Конструктор класса SearchForm.
        /// </summary>
        /// <param name="searchDelegate">Делегат поиска 
        /// элементов электрической схемы.</param>
        public SearchForm(SearchDelegate searchDelegate)
        {
            InitializeComponent();
            _searchDelegate = searchDelegate;
            ResistanceTextBox.KeyPress += ValidateField.ValidateFields;
            ElementNameComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие при смене названия элемента электрической схемы.
        /// </summary>
        private void ElementNameComboBox_SelectedIndexChanged(object
            sender, EventArgs e)
        {
            ResistanceTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Событие при нажатии на кнопку поиск
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Hide();
            Element element = new Element
            {
                ElementName = ElementNameComboBox.Text.ToString()
            };
            if (!string.IsNullOrEmpty(ResistanceTextBox.Text))
                element.ElementResistance = Convert
                        .ToDouble(ResistanceTextBox.Text);
            else
                element.ElementResistance = null;
            _searchDelegate(element);
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitFindButton_Click(object sender, EventArgs e)
        {
            Hide();
            Element element = new Element
            {
                ElementName = "",
                ElementResistance = null
            };
            _searchDelegate(element);
        }
    }
}