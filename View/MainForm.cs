using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Делегат для обновления данных 
    /// в MainDataGridView.
    /// </summary>
    public delegate void UpdateInformation();

    /// <summary>
    /// Делегат для поиска элемента электрической схемы.
    /// </summary>
    /// <param name="element">Объект хранящий 
    /// информации об искомом элементе.</param>
    public delegate void SearchDelegate(Element element);

    /// <summary>
    /// Класс для описания элементов электрической схемы
    /// и действий над ними.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _updateInformation = UpdateDataGridViewInformation;
        }

        /// <summary>
        /// Коллекция элементов с информацией 
        /// об элементах электрической схемы.
        /// </summary>
        private readonly List<Element> _elements = new List<Element>();

        /// <summary>
        /// Делегат обновления информации.
        /// </summary>
        private readonly UpdateInformation
            _updateInformation = null;

        /// <summary>
        /// Объект, описывающий удаляемый элемент. 
        /// </summary>
        private readonly Element _delElement = new Element();

        /// <summary>
        /// Поле, которое хранит путь к загружаемому и сохраняемому файлу. 
        /// </summary>
        private string _pathSaveLoad;

        /// <summary>
        /// Метод обновления информации в ElementDataGridView.
        /// </summary>
        internal void UpdateDataGridViewInformation()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.SuspendBinding();
            bindingSource.DataSource = _elements;
            bindingSource.ResumeBinding();

            ElementDataGridView.DataSource = bindingSource;

            ElementDataGridView.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            ElementDataGridView.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            ElementDataGridView.Columns[1].DefaultCellStyle
                .Format = string.Format("0.#############");

            ElementDataGridView.Columns[0].HeaderText =
                "Название элемента электрической схемы";
            ElementDataGridView.Columns[1].HeaderText =
                "Сопротивление элемента электрической схемы";
        }

        /// <summary>
        /// Событие при нажатии на кнопку добавить.
        /// </summary>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(_elements, _updateInformation);
            addForm.ShowDialog();
            UpdateDataGridViewInformation();
            addForm.Dispose();
        }

        /// <summary>
        /// Событие удаления элемента электрической схемы.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            if (ElementDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow instance in
                             this.ElementDataGridView.SelectedRows)
                {
                    _delElement.ElementName =
                        ElementDataGridView[0, instance.Index]
                        .Value.ToString();
                    _delElement.ElementResistance = Convert.ToDouble
                        (ElementDataGridView[1, instance.Index].Value);
                }

                foreach (var item in _elements)
                {
                    if ((item.ElementName == _delElement.ElementName)
                        && (item.ElementResistance == _delElement
                        .ElementResistance))
                    {
                        _elements.Remove(item);
                        break;
                    }
                }
                UpdateDataGridViewInformation();
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку сохранить.
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            if (_pathSaveLoad != null)
            {
                saveDialog.InitialDirectory = _pathSaveLoad;
            }
            else
            {
                saveDialog.InitialDirectory = Application.StartupPath;
            }
            saveDialog.Filter = "Element *.ele|*.ele";
            saveDialog.FilterIndex = 1;

            List<Element> saveList = new List<Element>();
            foreach (var item in _elements)
            {
                saveList.Add(item);
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _pathSaveLoad = saveDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(
                    saveDialog.FileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, saveList);
                }
            }
            saveDialog.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку загрузить.
        /// </summary>
        private void LoadToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (_pathSaveLoad != null)
            {
                openDialog.InitialDirectory = _pathSaveLoad;
            }
            else
            {
                openDialog.InitialDirectory = Application.StartupPath;
            }
            openDialog.Filter = "Element *.ele|*.ele";
            openDialog.FilterIndex = 1;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _pathSaveLoad = openDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(
                    openDialog.FileName, FileMode.OpenOrCreate))
                {
                    try
                    {
                        List<Element> openlList =
                            (List<Element>)binaryFormatter
                            .Deserialize(fileStream);
                        if (_elements.Count > 0)
                        {
                            _elements.Clear();
                        }
                        foreach (var item in openlList)
                        {
                            _elements.Add(item);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось загрузить файл." +
                            "Возможно файл повреждён.\n");
                    }
                }
                UpdateDataGridViewInformation();
            }
            openDialog.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку найти.
        /// </summary>
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(new 
                SearchDelegate(SearchElement));
            searchForm.ShowDialog();
            searchForm.Dispose();
        }

        /// <summary>
        /// Метод поиска элементов электрической схемы.
        /// </summary>
        /// <param name="element">Объект хранящий информацию
        /// об элементе.</param>
        private void SearchElement(Element element)
        {
            for (int i = 0; i < ElementDataGridView.RowCount; i++)
            {
                ElementDataGridView.Rows[i].DefaultCellStyle
                    .BackColor = System.Drawing.Color.White;
            }

            if (element.ElementResistance != null)
            {
                for (int i = 0; i < ElementDataGridView.RowCount; i++)
                {
                    if ((ElementDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == element.ElementName
                        .ToString() && 
                        Math.Abs((double)ElementDataGridView
                            .Rows[i].Cells[1].Value - (double)element.ElementResistance)<=1e-8 
                        )
                    {
                        ElementDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.GreenYellow;
                    }
                    else
                    {
                        ElementDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.White;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ElementDataGridView.RowCount; i++)
                {

                    if ((ElementDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == element.ElementName
                        .ToString())
                    {
                        ElementDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.GreenYellow;
                    }
                    else
                    {
                        ElementDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }
    }
}