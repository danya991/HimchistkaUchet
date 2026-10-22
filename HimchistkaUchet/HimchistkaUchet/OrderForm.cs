using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HimchistkaUchet
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Заглушка: просто выведем сообщение
            MessageBox.Show("Расчёт будет реализован позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранение заказа будет реализовано позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать квитанции будет реализована позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма добавления клиента будет реализована позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
