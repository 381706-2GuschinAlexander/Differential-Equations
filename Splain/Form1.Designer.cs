namespace DEeq {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // placeholderToolStripMenuItem
      // 
      this.placeholderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.clearToolStripMenuItem});
      this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
      this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.placeholderToolStripMenuItem.Text = "Menu";
      // 
      // generateToolStripMenuItem
      // 
      this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
      this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.generateToolStripMenuItem.Text = "Generate";
      this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(308, 49);
      this.chart1.Name = "chart1";
      this.chart1.Size = new System.Drawing.Size(902, 501);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(75, 49);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(83, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(75, 78);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(83, 20);
      this.textBox3.TabIndex = 4;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(75, 104);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(83, 20);
      this.textBox5.TabIndex = 6;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(75, 130);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(83, 20);
      this.textBox7.TabIndex = 8;
      this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 18;
      this.label1.Text = "left border";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "rigth border";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(12, 13);
      this.label3.TabIndex = 20;
      this.label3.Text = "x";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(15, 130);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(12, 13);
      this.label15.TabIndex = 32;
      this.label15.Text = "y";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(75, 156);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(83, 20);
      this.textBox2.TabIndex = 33;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(75, 208);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(83, 20);
      this.textBox4.TabIndex = 34;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(14, 13);
      this.label4.TabIndex = 35;
      this.label4.Text = "y\'";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 208);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 13);
      this.label5.TabIndex = 36;
      this.label5.Text = "interval";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(75, 182);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(83, 20);
      this.textBox6.TabIndex = 37;
      this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(15, 182);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 38;
      this.label6.Text = "var a";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1231, 571);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox7);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label6;
  }
}

