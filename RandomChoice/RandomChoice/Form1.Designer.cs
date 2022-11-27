namespace RandomChoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChoicecomboBox = new System.Windows.Forms.ComboBox();
            this.ChoicelistBox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.StringBox = new System.Windows.Forms.TextBox();
            this.DELButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoicecomboBox
            // 
            resources.ApplyResources(this.ChoicecomboBox, "ChoicecomboBox");
            this.ChoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoicecomboBox.FormattingEnabled = true;
            this.ChoicecomboBox.Items.AddRange(new object[] {
            resources.GetString("ChoicecomboBox.Items"),
            resources.GetString("ChoicecomboBox.Items1"),
            resources.GetString("ChoicecomboBox.Items2"),
            resources.GetString("ChoicecomboBox.Items3")});
            this.ChoicecomboBox.Name = "ChoicecomboBox";
            this.ChoicecomboBox.Sorted = true;
            this.toolTip1.SetToolTip(this.ChoicecomboBox, resources.GetString("ChoicecomboBox.ToolTip"));
            // 
            // ChoicelistBox
            // 
            resources.ApplyResources(this.ChoicelistBox, "ChoicelistBox");
            this.ChoicelistBox.FormattingEnabled = true;
            this.ChoicelistBox.Items.AddRange(new object[] {
            resources.GetString("ChoicelistBox.Items"),
            resources.GetString("ChoicelistBox.Items1"),
            resources.GetString("ChoicelistBox.Items2"),
            resources.GetString("ChoicelistBox.Items3")});
            this.ChoicelistBox.Name = "ChoicelistBox";
            this.toolTip1.SetToolTip(this.ChoicelistBox, resources.GetString("ChoicelistBox.ToolTip"));
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.toolTip1.SetToolTip(this.StartButton, resources.GetString("StartButton.ToolTip"));
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.toolTip1.SetToolTip(this.AddButton, resources.GetString("AddButton.ToolTip"));
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StringBox
            // 
            resources.ApplyResources(this.StringBox, "StringBox");
            this.StringBox.Name = "StringBox";
            this.toolTip1.SetToolTip(this.StringBox, resources.GetString("StringBox.ToolTip"));
            // 
            // DELButton
            // 
            resources.ApplyResources(this.DELButton, "DELButton");
            this.DELButton.Name = "DELButton";
            this.toolTip1.SetToolTip(this.DELButton, resources.GetString("DELButton.ToolTip"));
            this.DELButton.UseVisualStyleBackColor = true;
            this.DELButton.Click += new System.EventHandler(this.DELButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.ProgressBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // Status
            // 
            this.Status.AutoToolTip = true;
            this.Status.Name = "Status";
            resources.ApplyResources(this.Status, "Status");
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoToolTip = true;
            this.ProgressBar.Name = "ProgressBar";
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            // 
            // Form1
            // 
            this.AcceptButton = this.StartButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DELButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChoicelistBox);
            this.Controls.Add(this.ChoicecomboBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChoicecomboBox;
        private ListBox ChoicelistBox;
        private Button StartButton;
        private ToolTip toolTip1;
        private Button AddButton;
        private TextBox StringBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Status;
        private ToolStripProgressBar ProgressBar;
        private Button DELButton;
    }
}