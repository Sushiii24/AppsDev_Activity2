namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.wishList = new System.Windows.Forms.ListBox();
            this.sort = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WISH LIST GENERATOR";
            // 
            // wishList
            // 
            this.wishList.DisplayMember = "5";
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(18, 122);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(233, 147);
            this.wishList.TabIndex = 1;
            this.wishList.ValueMember = "5";
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(258, 122);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 2;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(257, 151);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(75, 23);
            this.fill.TabIndex = 3;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(257, 180);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(257, 209);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 5;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(258, 238);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(18, 300);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(54, 13);
            this.selection.TabIndex = 7;
            this.selection.Text = "Selection:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(18, 326);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(38, 13);
            this.count.TabIndex = 8;
            this.count.Text = "Count:";
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(75, 292);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 9;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(75, 319);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(100, 20);
            this.countOutputBox.TabIndex = 10;
            this.countOutputBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 440);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.count);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.close);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox countOutputBox;
    }
}

