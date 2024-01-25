namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            treeView1 = new TreeView();
            tabPage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Stock Symbol (i.e. IBM)";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Stock Symbol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 8;
            label2.Text = "Alphavantage API Key";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 124);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "API Key value";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(220, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(418, 355);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(treeView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(410, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Balance Sheet";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 35);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Tree View";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(53, 53);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(304, 238);
            treeView1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chart1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(410, 327);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Simple Moving Average";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(38, 88);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(342, 220);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Performance Display";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private TreeView treeView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}