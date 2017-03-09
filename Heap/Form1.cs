using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heap
{
    public partial class Form1 : Form
    {
        MinHeap<int> _heap = new MinHeap<int>();
        PriorityQueue<int, int> _quHeap = new PriorityQueue<int,int>();
        int _prio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void textEntry_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int _entry = Convert.ToInt32(textEntry.Text);
                _heap.Add(_entry);
                textEntry.Text = "";
                showHeap.Text = _heap.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number.");
            }


        }

        private void removeBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int _entry = Convert.ToInt32(textEntry.Text);
                bool _remove =_heap.Remove(_entry);
                if (_remove == false)
                    MessageBox.Show("Number not found.");
                textEntry.Text = "";
                showHeap.Text = _heap.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number.");
            }
        }

        //Låter användare sätta prio om så önskas, ifall inget skickas in blir Prio-värdet ett högre än vad som lades in förra gången.
        private void queueAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int _entry = Convert.ToInt32(queueBox.Text);
                try
                {
                    _prio = Convert.ToInt32(prioBox.Text);
                }
                catch
                {
                    _prio++;
                }
                _quHeap.Enqueue(_entry,_prio);
                queueBox.Text = "";
                prioBox.Text = "";
                textQueue.Text = _quHeap.ToString();


            }
            catch
            {
                MessageBox.Show("Enter a number.");
            }
        }

        private void queueRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _quHeap.Dequeue();
                textQueue.Text = _quHeap.ToString();
            }
            catch
            {
                MessageBox.Show("Queue empty!");
            }
        }

        //Vet egentligen inte varför denna funktion behövs när vi har en lista som visar vad som är nästa?
        private void peekQueue_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = _quHeap.Peek();
                MessageBox.Show("Next in queue is: " + tmp);
            }
            catch
            {
                MessageBox.Show("Queue empty!");
            }
        }
    }
}
