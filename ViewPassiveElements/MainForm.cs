using Model;
using Newtonsoft.Json;

namespace ViewPassiveElements
{
    public partial class MainForm : Form
    {
        public List<IPassiveElement> elements = new List<IPassiveElement>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm addForm = new AddForm(this);
                addForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Find_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                FindForm find = new FindForm(elements);
                find.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            var deleteItem = ElementsDataGridView.CurrentCell;
            if (deleteItem != null)
                elements.RemoveAt(deleteItem.RowIndex);
            else
                MessageBox.Show("Выберите публикацию для удаления");
            UpdateUi();
        }
        public void UpdateUi()
        {
            ElementsDataGridView.RowCount = 0;
            foreach (var item in elements)
            {
                ElementsDataGridView.Rows.Add();
                ElementsDataGridView[0, ElementsDataGridView.RowCount - 1].Value = item.Name;
                ElementsDataGridView[1, ElementsDataGridView.RowCount - 1].Value = item.ActiveResistance;
                ElementsDataGridView[2, ElementsDataGridView.RowCount - 1].Value = item.ReactiveResistance;
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            string json = System.Text.Json.JsonSerializer.Serialize(elements); ;
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            File.WriteAllText(filename + ".lb", json);
        }
        private void Open_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); 
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            string text = File.ReadAllText(filename);
            try
            {
                var passiveElements = JsonConvert.DeserializeObject<List<PassiveElement>>(text);
                if (passiveElements is null)
                    MessageBox.Show("Файл пуст");
                else
                    elements.AddRange(passiveElements);
                UpdateUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
