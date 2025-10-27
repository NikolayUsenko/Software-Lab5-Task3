using System.Windows.Forms;

namespace Software_Lab5_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ќсновна¤ функци¤
        private void Calculate(ToolStripTextBox TextBox1, ToolStripTextBox TextBox2, ToolStripTextBox TextBox3, ToolStripComboBox ComboBox1, ToolStripComboBox ComboBox2)
        {
            try
            {
                double x = Convert.ToDouble(TextBox1.Text);
                double y = Convert.ToDouble(TextBox2.Text);
                double z = Convert.ToDouble(TextBox3.Text);
                int a = Convert.ToInt32(ComboBox1.SelectedItem);
                int b = Convert.ToInt32(ComboBox2.SelectedItem);
                double result = 0;
                result = ((a * x) / Math.Abs(z)) + b * y + ((Math.Sin(z)) / (Math.Sqrt(Math.Abs(x * x - y))));
                this.Text = Convert.ToString($"–езультат: {result}");
            }
            catch (Exception)
            {
                Text = "ќшибка";
            }
        }

        #endregion

        #region ќбработчики событый

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 2;
            toolStripComboBox2.SelectedIndex = 2;
            toolStripComboBox3.SelectedIndex = 2;
            toolStripComboBox4.SelectedIndex = 2;
        }
        private void ChangeForMenu(object sender, EventArgs e)
        {
            Calculate(toolStripTextBox1, toolStripTextBox2, toolStripTextBox3, toolStripComboBox1, toolStripComboBox2);
        }

        private void ChangeForContextMenu(object sender, EventArgs e)
        {
            Calculate(toolStripTextBox4, toolStripTextBox5, toolStripTextBox6, toolStripComboBox3, toolStripComboBox4);
        }

        #endregion

    }
}
