using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedomost
{
    public partial class Vedomost : Form
    {
        public Vedomost()
        {
            InitializeComponent();

            //Создание колонок dataGridView1

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.HeaderText = "Имя Фамилия";
            Name.Width = 150;
            dataGridView1.Columns.Add(Name);

            DataGridViewTextBoxColumn maths = new DataGridViewTextBoxColumn();
            maths.Name = "maths";
            maths.HeaderText = "Математика";
            maths.Width = 100;
            dataGridView1.Columns.Add(maths);

            DataGridViewTextBoxColumn physics = new DataGridViewTextBoxColumn();
            physics.Name = "maths";
            physics.HeaderText = "Физика";
            physics.Width = 100;
            dataGridView1.Columns.Add(physics);

            DataGridViewTextBoxColumn pe = new DataGridViewTextBoxColumn();
            pe.Name = "pe";
            pe.HeaderText = "Физкультура";
            pe.Width = 100;
            dataGridView1.Columns.Add(pe);

            /////////////////////////////

            //Создание колонок dataGridView2

            DataGridViewTextBoxColumn NameDG2 = new DataGridViewTextBoxColumn();
            NameDG2.Name = "NameDG2";
            NameDG2.HeaderText = "Имя Фамилия";
            NameDG2.Width = 150;
            dataGridView2.Columns.Add(NameDG2);

            DataGridViewTextBoxColumn NA = new DataGridViewTextBoxColumn();
            NA.Name = " NA";
            NA.HeaderText = "Н/А";
            NA.Width = 50;
            dataGridView2.Columns.Add(NA);

            DataGridViewTextBoxColumn two = new DataGridViewTextBoxColumn();
            two.Name = "two";
            two.HeaderText = " 2";
            two.Width = 50;
            dataGridView2.Columns.Add(two);

            DataGridViewTextBoxColumn three = new DataGridViewTextBoxColumn();
            three.Name = "three";
            three.HeaderText = " 3";
            three.Width = 50;
            dataGridView2.Columns.Add(three);

            DataGridViewTextBoxColumn four = new DataGridViewTextBoxColumn();
            four.Name = "four";
            four.HeaderText = " 4";
            four.Width = 50;
            dataGridView2.Columns.Add(four);

            DataGridViewTextBoxColumn five = new DataGridViewTextBoxColumn();
            five.Name = "five";
            five.HeaderText = " 5";
            five.Width = 50;
            dataGridView2.Columns.Add(five);

            DataGridViewTextBoxColumn aver = new DataGridViewTextBoxColumn();
            aver.Name = "aver";
            aver.HeaderText = " Сред. знач.";
            aver.Width = 150;
            dataGridView2.Columns.Add(aver);



        }

        private void Vedomost_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 21; i++) {
                comboBoxNumStud.Items.Add(i);
            }
        }

        private void comboBoxNumStud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Создание строк

            int numLins = Convert.ToInt32(comboBoxNumStud.Text) + 1;

            //Создание строк Если ещё пустая
            if (dataGridView1.RowCount == 0)
            {

                for (int i = 1; i < numLins; i++)
                {
                    if (dataGridView1.RowCount > 19)
                        break;
                    else
                        dataGridView1.Rows.Add();
                }
            }
            //Создание строк Если уже есть и нужно добавить
            else
            {

                for (int i = 0; i <= numLins - dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.RowCount > 19)
                        break;
                    else
                        dataGridView1.Rows.Add();
                }
            }




        }


        //Создаём строки в DG2 по DG1
        private void button1_Click(object sender, EventArgs e)
        {
            int numLins = Convert.ToInt32(comboBoxNumStud.Text) + 1;

            if (dataGridView2.RowCount == 0)

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView2.Rows.Add();
                }

            else
            {
                
                for (int i = 0; i < numLins - dataGridView1.RowCount ; i++)
                {
                    dataGridView2.Rows.Add();
                }
            }

    
        }
    }
}
