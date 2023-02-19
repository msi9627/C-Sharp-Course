using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        private void btSaveNewEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPosition.SelectedIndex == 0)
                {
                    Employee newEmp = new Employee(
                    tbName.Text,
                    (double)spinnerSalary.Value,
                    Int32.Parse(cbDay.Text),
                    Int32.Parse(cbMonth.Text),
                   (int)spinnerYear.Value
                );
                    employees.Add(newEmp);
                    MessageBox.Show("Сотрудник успешно добавлен", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbPosition.SelectedIndex == 1)
                {
                    Manager newManager = new Manager(
                    tbName.Text,
                    (double)spinnerSalary.Value,
                    Int32.Parse(cbDay.Text),
                    Int32.Parse(cbMonth.Text),
                    (int)spinnerYear.Value,
                    (double)spinnerBonus.Value
                );
                    employees.Add(newManager);
                    MessageBox.Show("Менеджер успешно добавлен", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
            catch
            {
                MessageBox.Show("Пожалуйста, проверьте формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btShowAll_Click(object sender, EventArgs e)
        {
            tbListAll.Clear();
            foreach (Employee emp in employees)
            {
                tbListAll.Text += "• " + emp.ToString() + "\r\n";
            }
        }

        private void cbEmpInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int empIndex = cbEmpInfo.SelectedIndex;
            tbNewName.Text = employees[empIndex].getName();
            spinnerNewSalary.Value = (decimal)employees[empIndex].getSalary();
            cbNewDay.Text = employees[empIndex].getDateOfEmp().Day.ToString();
            cbNewMonth.Text = employees[empIndex].getDateOfEmp().Month.ToString();
            spinnerNewYear.Value = employees[empIndex].getDateOfEmp().Year;

            tbNewName.Enabled = true;
            spinnerNewSalary.Enabled = true;
            cbNewDay.Enabled = true;
            cbNewMonth.Enabled = true;
            spinnerNewYear.Enabled = true;
        }

        private void tabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 2:
                    cbEmpInfo.Items.Clear();
                    foreach (Employee emp in employees)
                    {
                        cbEmpInfo.Items.Add(emp.getInfo());
                    }
                    break;
                case 3:
                    cbEmpRemove.Items.Clear();
                    foreach (Employee emp in employees)
                    {
                        cbEmpRemove.Items.Add(emp.ToString());
                    }
                    break;
                case 4:
                    tbAfterIncreasing.Clear();
                    foreach (Employee emp in employees)
                    {
                        tbAfterIncreasing.Text += "• " + emp.getInfo() + "\r\n";
                    }
                    break;
                case 5:
                    tbSortedByExp.Clear();
                    foreach (Employee emp in employees)
                    {
                        tbSortedByExp.Text += "• " + emp.getInfo() + "\r\n";
                    }
                    break;
            }
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            int empIndex = cbEmpInfo.SelectedIndex;
            try
            {
                employees[empIndex].setName(tbNewName.Text);
                employees[empIndex].setSalary((double)spinnerNewSalary.Value);
                employees[empIndex].setDateOfEmp(
                    Convert.ToInt32(cbNewDay.SelectedItem),
                    Convert.ToInt32(cbNewMonth.SelectedItem),
                    Convert.ToInt32(spinnerNewYear.Value)
                );
                MessageBox.Show("Данные успешно обновлены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Пожалуйста, проверьте формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRemoveEmp_Click(object sender, EventArgs e)
        {
            int empIndex = cbEmpRemove.SelectedIndex;
            if (empIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить данные об этом сотруднике?", "Удаление информации", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        employees.Remove(employees[empIndex]);
                        MessageBox.Show("Данные успешно удалены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
                MessageBox.Show("Пожалуйста, выберите значение из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btSaveIncreasing_Click(object sender, EventArgs e)
        {
            int percent = Convert.ToInt32(spinnerPercents.Value);
            tbAfterIncreasing.Clear();
            foreach (Employee emp in employees)
            {
                emp.increaseSalary(percent);
                tbAfterIncreasing.Text += "• " + emp.getInfo() + "\r\n";
            }
            MessageBox.Show("Данные успешно обновлены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSortByExp_Click(object sender, EventArgs e)
        {
            tbSortedByExp.Clear();
            List<Employee> employeesSorted = employees.OrderBy(o => o.getWorkExperience()).ToList();
            foreach (Employee emp in employeesSorted)
            {
                tbSortedByExp.Text += "• " + emp.getInfo() + "\r\n";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedIndex == 1) spinnerBonus.Enabled = true;
            else spinnerBonus.Enabled = false;
        }
    }
}
