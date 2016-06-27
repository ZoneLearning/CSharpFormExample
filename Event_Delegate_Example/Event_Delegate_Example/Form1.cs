﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Delegate_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txbName.Text;
            student.Surname = txbSurname.Text;
            student.Midterm = Convert.ToDouble(txbMidterm.Text);
            student.Final = Convert.ToDouble(txbFinal.Text);
            student.Pass += Student_Pass;
            student.Fail += Student_Fail;
            lbAllStudent.Items.Add(student);

        }

        private void Student_Fail(object sender, PassFailEventArgs e)
        {
            lbPassedStudent.Items.Remove(e.NameSurname);
            lbFailedStudent.Items.Add(e.NameSurname);
        }

        private void Student_Pass(object sender, PassFailEventArgs e)
        {
            lbFailedStudent.Items.Remove(e.NameSurname);
            lbPassedStudent.Items.Add(e.NameSurname);
        }
    }
}
