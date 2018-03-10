using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kdz
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает сообщение об ошибке
        /// </summary>
        /// <param name="errorMessage"></param>
        public void SetError(string errorMessage)
        {
            this.labelErrorMessage.Text = errorMessage;
        }
    }
}
