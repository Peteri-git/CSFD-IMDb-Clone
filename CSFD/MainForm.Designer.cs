namespace CSFD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FilteredList = new System.Windows.Forms.ListBox();
            this.Movies = new System.Windows.Forms.RadioButton();
            this.Shows = new System.Windows.Forms.RadioButton();
            this.Actors = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userButton = new System.Windows.Forms.RadioButton();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilteredList
            // 
            this.FilteredList.FormattingEnabled = true;
            this.FilteredList.Location = new System.Drawing.Point(12, 12);
            this.FilteredList.Name = "FilteredList";
            this.FilteredList.Size = new System.Drawing.Size(120, 225);
            this.FilteredList.TabIndex = 0;
            this.FilteredList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilteredList_MouseDoubleClick);
            // 
            // Movies
            // 
            this.Movies.AutoSize = true;
            this.Movies.Location = new System.Drawing.Point(139, 32);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(48, 17);
            this.Movies.TabIndex = 1;
            this.Movies.TabStop = true;
            this.Movies.Text = "Filmy";
            this.Movies.UseVisualStyleBackColor = true;
            this.Movies.CheckedChanged += new System.EventHandler(this.Movies_CheckedChanged);
            // 
            // Shows
            // 
            this.Shows.AutoSize = true;
            this.Shows.Location = new System.Drawing.Point(139, 56);
            this.Shows.Name = "Shows";
            this.Shows.Size = new System.Drawing.Size(56, 17);
            this.Shows.TabIndex = 2;
            this.Shows.TabStop = true;
            this.Shows.Text = "Seriály";
            this.Shows.UseVisualStyleBackColor = true;
            this.Shows.CheckedChanged += new System.EventHandler(this.Shows_CheckedChanged);
            // 
            // Actors
            // 
            this.Actors.AutoSize = true;
            this.Actors.Location = new System.Drawing.Point(139, 80);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(50, 17);
            this.Actors.TabIndex = 3;
            this.Actors.TabStop = true;
            this.Actors.Text = "Herci";
            this.Actors.UseVisualStyleBackColor = true;
            this.Actors.CheckedChanged += new System.EventHandler(this.Actors_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(682, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Přidat";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(566, 32);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(100, 20);
            this.addBox.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userButton
            // 
            this.userButton.AutoSize = true;
            this.userButton.Location = new System.Drawing.Point(139, 104);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(69, 17);
            this.userButton.TabIndex = 8;
            this.userButton.TabStop = true;
            this.userButton.Text = "Uživatelé";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.CheckedChanged += new System.EventHandler(this.userButton_CheckedChanged);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePasswordBtn.Location = new System.Drawing.Point(635, 393);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(153, 45);
            this.changePasswordBtn.TabIndex = 9;
            this.changePasswordBtn.Text = "Změnit heslo";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(566, 146);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ručně";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Z internetu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.Shows);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.FilteredList);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilteredList;
        private System.Windows.Forms.RadioButton Movies;
        private System.Windows.Forms.RadioButton Shows;
        private System.Windows.Forms.RadioButton Actors;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton userButton;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}