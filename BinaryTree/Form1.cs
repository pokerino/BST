﻿using System;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BinarySearchTree<int> _tree;


        void PaintTree()
        {
            InOrderTxt.Text = _tree.Sorter();
            if (_tree == null) return;
            pictureBox1.Image = _tree.Draw();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _tree = new BinarySearchTree<int>(new BinarySearchTreeNode<int>(int.MinValue));
                PaintTree();
            }
            catch(NotImplementedException)
            {
                MessageBox.Show("Implementation saknas för BinarySearchTree!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                var val = int.Parse(inputTextBox.Text);
                if (_tree == null)
                    btnCreate_Click(btnCreate, new EventArgs());
                _tree.Insert(val);
                PaintTree();
                inputTextBox.SelectAll();
                this.Update();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var val = int.Parse(inputTextBox.Text);
                _tree.Remove(val);
                PaintTree();
                this.Update();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(btnAdd, new EventArgs());
            }
        }

        Random rnd = new Random();
        private void btnRnd_Click(object sender, EventArgs e)
        {
            var val = rnd.Next(1, 999);
            var counter = 0;
            if (_tree != null)
            {
                _tree.Find(val);
                while (_tree.Find(val) && counter++ < 999)
                    val = rnd.Next(1, 999);
            }
            inputTextBox.Text = val.ToString();
            btnAdd_Click(btnAdd, new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreate_Click(btnCreate, new EventArgs());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
