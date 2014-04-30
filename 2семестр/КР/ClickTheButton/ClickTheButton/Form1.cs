using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTheButton
{
    /// <summary>
    /// Класс, в котором кнопка будет "убегать" от курсора мыши
    /// </summary>
    public partial class Form1 : Form
    { 
        /// <summary>
        /// форма, в которой мы будем работать
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который заканчиват работу программы (при нажатии на кнопку)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод, который меняет локацию кнопки при наведении курсора 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1MouseEnter(object sender, EventArgs e)
        {
            if (button1.Left < 400)
            {
                button1.Left += 35;
            }
            else
            {
                button1.Left -= 150;
                button1.Top = 10;
            }
            if (button1.Top < 400)
            {
                button1.Top += 40;
            }
            else
            {
                button1.Top -= 150;
                button1.Left = 10;
            }
        }       
    }
}
