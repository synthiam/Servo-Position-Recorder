namespace Servo_Position_Recorder {
  partial class UCRecord {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnPlay = new System.Windows.Forms.Button();
      this.btnRecord = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(0, 0);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(190, 35);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "label2";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
      // 
      // btnPlay
      // 
      this.btnPlay.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPlay.Location = new System.Drawing.Point(431, 0);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(75, 35);
      this.btnPlay.TabIndex = 2;
      this.btnPlay.Text = "Play";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // btnRecord
      // 
      this.btnRecord.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRecord.Location = new System.Drawing.Point(356, 0);
      this.btnRecord.Name = "btnRecord";
      this.btnRecord.Size = new System.Drawing.Size(75, 35);
      this.btnRecord.TabIndex = 3;
      this.btnRecord.Text = "Record";
      this.btnRecord.UseVisualStyleBackColor = true;
      this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Location = new System.Drawing.Point(281, 0);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 35);
      this.btnDelete.TabIndex = 4;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Right;
      this.label1.Location = new System.Drawing.Point(190, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 35);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // UCRecord
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnRecord);
      this.Controls.Add(this.btnPlay);
      this.Name = "UCRecord";
      this.Size = new System.Drawing.Size(506, 35);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.Button btnRecord;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label1;
  }
}
