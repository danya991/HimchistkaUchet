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
    public partial class MainForm : Form
{
        public string CurrentUserRole { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CurrentUserRole = "Администратор";   // значение по умолчанию
            ApplyRolePermissions();
        }

    private void ApplyRolePermissions()
    {
        bool isAdmin = CurrentUserRole == "Администратор";

        // Пункты меню, доступные только администратору
        miEditOrder.Enabled = isAdmin;
        miDeleteOrder.Enabled = isAdmin;
        miUsers.Enabled = isAdmin;

        // Информация в статус-строке
        lblUserInfo.Text = "Пользователь: " + (isAdmin ? "admin" : "operator");
        lblRole.Text = "Роль: " + CurrentUserRole;
    }
        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void miEditOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void miDeleteOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция удаления будет реализована позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miServices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник типов услуг будет реализован позже.",
                "Заглушка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm usersForm = new UserManagementForm();
            usersForm.ShowDialog();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("АС «Химчистка-Учёт»\nРазработчики: Козулин Данила Михайлович, Лабутин Андрей Сергеевич\nВерсия 0.1 (интерфейс)",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
