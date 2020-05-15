namespace CSFD
{
    partial class MovieForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.actorList = new System.Windows.Forms.ListBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.genreList = new System.Windows.Forms.ListBox();
            this.relatedMovList = new System.Windows.Forms.ListBox();
            this.winFormMPlayerControl1 = new LibMPlayerWinform.WinFormMPlayerControl();
            this.addBox = new System.Windows.Forms.ComboBox();
            this.genreButton = new System.Windows.Forms.RadioButton();
            this.relatedButton = new System.Windows.Forms.RadioButton();
            this.actorButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.editLink = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(202, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            this.nameBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nameBox_MouseDoubleClick);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 56);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(202, 162);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            this.descriptionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descriptionBox_KeyDown);
            // 
            // actorList
            // 
            this.actorList.FormattingEnabled = true;
            this.actorList.Location = new System.Drawing.Point(12, 224);
            this.actorList.Name = "actorList";
            this.actorList.Size = new System.Drawing.Size(202, 82);
            this.actorList.TabIndex = 2;
            this.actorList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.actorList_MouseDoubleClick);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(239, 15);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(55, 13);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel1";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.Location = new System.Drawing.Point(12, 312);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(202, 82);
            this.genreList.TabIndex = 4;
            // 
            // relatedMovList
            // 
            this.relatedMovList.FormattingEnabled = true;
            this.relatedMovList.Location = new System.Drawing.Point(242, 312);
            this.relatedMovList.Name = "relatedMovList";
            this.relatedMovList.Size = new System.Drawing.Size(202, 82);
            this.relatedMovList.TabIndex = 5;
            this.relatedMovList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.relatedMovList_MouseDoubleClick);
            // 
            // winFormMPlayerControl1
            // 
            this.winFormMPlayerControl1.Location = new System.Drawing.Point(348, 12);
            this.winFormMPlayerControl1.MPlayerPath = null;
            this.winFormMPlayerControl1.Name = "winFormMPlayerControl1";
            this.winFormMPlayerControl1.Size = new System.Drawing.Size(440, 294);
            this.winFormMPlayerControl1.TabIndex = 6;
            this.winFormMPlayerControl1.VideoPath = null;
            // 
            // addBox
            // 
            this.addBox.FormattingEnabled = true;
            this.addBox.Location = new System.Drawing.Point(462, 332);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(121, 21);
            this.addBox.TabIndex = 7;
            // 
            // genreButton
            // 
            this.genreButton.AutoSize = true;
            this.genreButton.Location = new System.Drawing.Point(600, 312);
            this.genreButton.Name = "genreButton";
            this.genreButton.Size = new System.Drawing.Size(52, 17);
            this.genreButton.TabIndex = 8;
            this.genreButton.TabStop = true;
            this.genreButton.Text = "Žánry";
            this.genreButton.UseVisualStyleBackColor = true;
            this.genreButton.CheckedChanged += new System.EventHandler(this.genreButton_CheckedChanged);
            // 
            // relatedButton
            // 
            this.relatedButton.AutoSize = true;
            this.relatedButton.Location = new System.Drawing.Point(600, 336);
            this.relatedButton.Name = "relatedButton";
            this.relatedButton.Size = new System.Drawing.Size(145, 17);
            this.relatedButton.TabIndex = 9;
            this.relatedButton.TabStop = true;
            this.relatedButton.Text = "Podobné filmy / další díly";
            this.relatedButton.UseVisualStyleBackColor = true;
            this.relatedButton.CheckedChanged += new System.EventHandler(this.relatedButton_CheckedChanged);
            // 
            // actorButton
            // 
            this.actorButton.AutoSize = true;
            this.actorButton.Location = new System.Drawing.Point(600, 360);
            this.actorButton.Name = "actorButton";
            this.actorButton.Size = new System.Drawing.Size(50, 17);
            this.actorButton.TabIndex = 10;
            this.actorButton.TabStop = true;
            this.actorButton.Text = "Herci";
            this.actorButton.UseVisualStyleBackColor = true;
            this.actorButton.CheckedChanged += new System.EventHandler(this.actorButton_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(600, 395);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(656, 395);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(23, 23);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(522, 283);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editLink
            // 
            this.editLink.Location = new System.Drawing.Point(242, 41);
            this.editLink.Name = "editLink";
            this.editLink.Size = new System.Drawing.Size(52, 23);
            this.editLink.TabIndex = 14;
            this.editLink.Text = "edit";
            this.editLink.UseVisualStyleBackColor = true;
            this.editLink.Click += new System.EventHandler(this.editLink_Click);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(239, 255);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 15;
            this.ratingLabel.Text = "Rating:";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(329, 255);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(13, 13);
            this.rating.TabIndex = 16;
            this.rating.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(287, 253);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.editLink);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.actorButton);
            this.Controls.Add(this.relatedButton);
            this.Controls.Add(this.genreButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.winFormMPlayerControl1);
            this.Controls.Add(this.relatedMovList);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.actorList);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ListBox actorList;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ListBox genreList;
        private System.Windows.Forms.ListBox relatedMovList;
        private LibMPlayerWinform.WinFormMPlayerControl winFormMPlayerControl1;
        private System.Windows.Forms.ComboBox addBox;
        private System.Windows.Forms.RadioButton genreButton;
        private System.Windows.Forms.RadioButton relatedButton;
        private System.Windows.Forms.RadioButton actorButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button editLink;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}