using Model;

namespace ViewPassiveElements
{
    public partial class FindForm : Form
    {
        private readonly List<IPassiveElement> _passiveElements = new List<IPassiveElement>();
        public FindForm(List<IPassiveElement> passiveElements)
        {
            InitializeComponent();
            _passiveElements = passiveElements;
            UpdateUi(_passiveElements);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<IPassiveElement> elements = _passiveElements;
            if (!string.IsNullOrEmpty(Name_Tb.Text))
            {
                elements = elements.Where(p => p.Name.Contains(Name_Tb.Text)).ToList();
            }
            int min = 0, max = 0;
            if (int.TryParse(ActiveResistorStart_Tb.Text, out min))
            {
                elements = elements.Where(p => p.ActiveResistance >= min).ToList();
            }
            if (int.TryParse(ActiveResistorEnd_Tb.Text, out max))
            {
                elements = elements.Where(p => p.ActiveResistance <= max).ToList();
            }
            double start, end;
            if (double.TryParse(ReactiveResistorStart_Tb.Text, out start))
            {
                elements = elements.Where(p => p.ReactiveResistance >= start).ToList();
            }
            if (double.TryParse(ReactiveResistorEnd_Tb.Text, out end))
            {
                elements = elements.Where(p => p.ReactiveResistance <= end).ToList();
            }
            UpdateUi(elements);
        }
        public void UpdateUi(List<IPassiveElement> elements)
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
        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            UpdateUi(_passiveElements);
        }
    }
}
