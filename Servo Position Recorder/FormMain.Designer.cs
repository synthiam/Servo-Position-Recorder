namespace Servo_Position_Recorder {
  partial class FormMain {
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.ucTabControl1 = new ARC.UCForms.UCTabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ucTabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 119);
      this.flowLayoutPanel1.TabIndex = 0;
      this.flowLayoutPanel1.WrapContents = false;
      // 
      // ucTabControl1
      // 
      this.ucTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
      this.ucTabControl1.BackColor = System.Drawing.Color.White;
      this.ucTabControl1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(170)))), ((int)(((byte)(234)))));
      this.ucTabControl1.ButtonSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
      this.ucTabControl1.ButtonTextColor = System.Drawing.Color.White;
      this.ucTabControl1.Controls.Add(this.tabPage1);
      this.ucTabControl1.Controls.Add(this.tabPage2);
      this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucTabControl1.ItemSize = new System.Drawing.Size(60, 50);
      this.ucTabControl1.Location = new System.Drawing.Point(0, 0);
      this.ucTabControl1.Margin = new System.Windows.Forms.Padding(0);
      this.ucTabControl1.MarginLeft = 0;
      this.ucTabControl1.MarginTop = 0;
      this.ucTabControl1.Multiline = true;
      this.ucTabControl1.Name = "ucTabControl1";
      this.ucTabControl1.Padding = new System.Drawing.Point(0, 0);
      this.ucTabControl1.SelectedIndex = 0;
      this.ucTabControl1.Size = new System.Drawing.Size(543, 223);
      this.ucTabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.flowLayoutPanel1);
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Location = new System.Drawing.Point(4, 54);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(535, 165);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Recordings";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnAdd);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(529, 40);
      this.panel1.TabIndex = 1;
      // 
      // btnAdd
      // 
      this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Location = new System.Drawing.Point(0, 0);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 40);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 54);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(515, 165);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Log";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 3);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(509, 159);
      this.textBox1.TabIndex = 0;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(543, 223);
      this.Controls.Add(this.ucTabControl1);
      this.Name = "FormMain";
      this.Text = "FormMain";
      this.ucTabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnAdd;
    private ARC.UCForms.UCTabControl ucTabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
  }
}