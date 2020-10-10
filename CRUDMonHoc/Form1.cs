﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CRUDMonHoc
{
    public partial class Form1 : Form
    {
        Monhoc mh = new Monhoc();
        public Form1()
        {
            
           
            InitializeComponent();
           
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {

            //tableData.AutoGenerateColumns = false;
            using (MonhocEntities db = new MonhocEntities())
            {
                tableData.DataSource = db.Monhocs.ToList();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new New().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Edit().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}