namespace Heap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEntry = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.showHeap = new System.Windows.Forms.TextBox();
            this.queueBox = new System.Windows.Forms.TextBox();
            this.queueAdd = new System.Windows.Forms.Button();
            this.textQueue = new System.Windows.Forms.TextBox();
            this.queueRemove = new System.Windows.Forms.Button();
            this.peekQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prioBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEntry
            // 
            this.textEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEntry.Location = new System.Drawing.Point(65, 197);
            this.textEntry.Name = "textEntry";
            this.textEntry.Size = new System.Drawing.Size(100, 20);
            this.textEntry.TabIndex = 0;
            this.textEntry.TextChanged += new System.EventHandler(this.textEntry_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(171, 194);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBtn.Location = new System.Drawing.Point(252, 194);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click_1);
            // 
            // showHeap
            // 
            this.showHeap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showHeap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showHeap.Location = new System.Drawing.Point(12, 171);
            this.showHeap.Name = "showHeap";
            this.showHeap.ReadOnly = true;
            this.showHeap.Size = new System.Drawing.Size(696, 20);
            this.showHeap.TabIndex = 3;
            // 
            // queueBox
            // 
            this.queueBox.Location = new System.Drawing.Point(65, 49);
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(100, 20);
            this.queueBox.TabIndex = 4;
            // 
            // queueAdd
            // 
            this.queueAdd.Location = new System.Drawing.Point(171, 49);
            this.queueAdd.Name = "queueAdd";
            this.queueAdd.Size = new System.Drawing.Size(75, 23);
            this.queueAdd.TabIndex = 5;
            this.queueAdd.Text = "Enqueue";
            this.queueAdd.UseVisualStyleBackColor = true;
            this.queueAdd.Click += new System.EventHandler(this.queueAdd_Click);
            // 
            // textQueue
            // 
            this.textQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQueue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textQueue.Location = new System.Drawing.Point(12, 23);
            this.textQueue.Name = "textQueue";
            this.textQueue.ReadOnly = true;
            this.textQueue.Size = new System.Drawing.Size(696, 20);
            this.textQueue.TabIndex = 6;
            // 
            // queueRemove
            // 
            this.queueRemove.Location = new System.Drawing.Point(252, 49);
            this.queueRemove.Name = "queueRemove";
            this.queueRemove.Size = new System.Drawing.Size(75, 23);
            this.queueRemove.TabIndex = 7;
            this.queueRemove.Text = "Dequeue";
            this.queueRemove.UseVisualStyleBackColor = true;
            this.queueRemove.Click += new System.EventHandler(this.queueRemove_Click);
            // 
            // peekQueue
            // 
            this.peekQueue.Location = new System.Drawing.Point(333, 49);
            this.peekQueue.Name = "peekQueue";
            this.peekQueue.Size = new System.Drawing.Size(75, 23);
            this.peekQueue.TabIndex = 8;
            this.peekQueue.Text = "Peek?";
            this.peekQueue.UseVisualStyleBackColor = true;
            this.peekQueue.Click += new System.EventHandler(this.peekQueue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Min Heap";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Queue";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Priority:";
            // 
            // prioBox
            // 
            this.prioBox.Location = new System.Drawing.Point(65, 75);
            this.prioBox.Name = "prioBox";
            this.prioBox.Size = new System.Drawing.Size(100, 20);
            this.prioBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prioBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peekQueue);
            this.Controls.Add(this.queueRemove);
            this.Controls.Add(this.textQueue);
            this.Controls.Add(this.queueAdd);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.showHeap);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEntry;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox showHeap;
        private System.Windows.Forms.TextBox queueBox;
        private System.Windows.Forms.Button queueAdd;
        private System.Windows.Forms.TextBox textQueue;
        private System.Windows.Forms.Button queueRemove;
        private System.Windows.Forms.Button peekQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prioBox;
    }
}

