using Model;

namespace ViewPassiveElements
{
    public partial class AddForm : Form
    {
        MainForm _mainForm;
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
#if !DEBUG
            Random_Btn.Visible = false;
#endif
            ActiveValue_Lbl.Visible = false;
            ActiveValue_Tb.Visible = false;
            Frequncy_Lbl.Visible = false;
            Frequncy_Tb.Visible = false;
        }
        private void Type_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_Cb.SelectedIndex == 1 || Type_Cb.SelectedIndex == 2)
            {
                ActiveValue_Lbl.Visible = true;
                ActiveValue_Tb.Visible = true;

                Frequncy_Lbl.Visible = true;
                Frequncy_Tb.Visible = true;
                if (Type_Cb.SelectedIndex == 1)
                    ActiveValue_Lbl.Text = "Емкость конденсатора";
                else
                    ActiveValue_Lbl.Text = "Индуктивность";
            }
            else
            {
                ActiveValue_Lbl.Visible = false;
                ActiveValue_Tb.Visible = false;

                Frequncy_Lbl.Visible = false;
                Frequncy_Tb.Visible = false;
            }
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_Tb.Text))
            {
                MessageBox.Show("Введите название");
            }
            else
            {
                if (Type_Cb.SelectedIndex == 0)
                {
                    try
                    {
                        Resistor resistor = new Resistor();
                        resistor.Name = Name_Tb.Text;
                        resistor.ActiveResistance = double.Parse(ActiveResistor_Tb.Text);
                        _mainForm.elements.Add(resistor);
                        Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (Type_Cb.SelectedIndex == 1)
                {
                    try
                    {
                        Capacitor capacitor = new Capacitor();
                        capacitor.Name = Name_Tb.Text;
                        capacitor.ActiveResistance = double.Parse(ActiveResistor_Tb.Text);
                        capacitor.Frequency = double.Parse(Frequncy_Tb.Text);
                        //capacitor.ReactiveResistance = double.Parse(ActiveValue_Tb.Text, System.Globalization.CultureInfo.InvariantCulture);
                        double x = 0.0;
                        if (double.TryParse(ActiveValue_Tb.Text, out x))
                        {
                            capacitor.Copacity = x;
                        }
                        _mainForm.elements.Add(capacitor);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (Type_Cb.SelectedIndex == 2)
                {
                    try
                    {
                        Inductance inductance = new Inductance();
                        inductance.Name = Name_Tb.Text;
                        inductance.ActiveResistance = double.Parse(ActiveResistor_Tb.Text);
                        inductance.Frequency = double.Parse(Frequncy_Tb.Text);
                        //inductance.ReactiveResistance = double.Parse(ActiveValue_Tb.Text.Replace(",", "."));
                        double x = 0.0;
                        if(double.TryParse(ActiveValue_Tb.Text, out x))
                        {
                            inductance.InductanceValue = x;
                        }
                        _mainForm.elements.Add(inductance);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void Random_Btn_Click(object sender, EventArgs e)
        {
            Random _random = new Random();
            int type = _random.Next(0, 3);
            Type_Cb.SelectedIndex = type;
            if (type == 0)
            {
                Name_Tb.Text = GetName();
                ActiveResistor_Tb.Text = _random.Next(1, 300).ToString();
            }
            else if (type == 1 || type == 2)
            {
                Name_Tb.Text = GetName();
                ActiveResistor_Tb.Text = _random.Next(1, 300).ToString();
                Frequncy_Tb.Text = _random.Next(1, 10000).ToString();
                double x = (_random.NextDouble() * 10);
                ActiveValue_Tb.Text = x.ToString();
                if (type == 1)
                    ActiveValue_Lbl.Text = "Емкость конденсатора";
                else
                    ActiveValue_Lbl.Text = "Индуктивность";
            }
        }
        private string GetName()
        {
            Random _random = new Random();
            if (Type_Cb.SelectedIndex == 0)
            {
                return $"R{_random.Next(1, 120)}";
            }
            else if (Type_Cb.SelectedIndex == 1)
            {
                return $"C{_random.Next(1, 120)}";
            }
            else
            {
                return $"L{_random.Next(1, 120)}";
            }
        }
        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.UpdateUi();
        }
    }
}
