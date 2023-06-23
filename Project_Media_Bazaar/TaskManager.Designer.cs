namespace Project_Media_Bazaar
{
    partial class TaskManager
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
            components = new System.ComponentModel.Container();
            btnClose = new Button();
            employee_lbl = new Label();
            label14 = new Label();
            btnShift = new Button();
            dtDateShift = new DateTimePicker();
            cbEmployeesShifts = new ComboBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(576, 11);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 26);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // employee_lbl
            // 
            employee_lbl.AutoSize = true;
            employee_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            employee_lbl.Location = new Point(20, 38);
            employee_lbl.Name = "employee_lbl";
            employee_lbl.Size = new Size(159, 28);
            employee_lbl.TabIndex = 18;
            employee_lbl.Text = "Select Employee:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(20, 158);
            label14.Name = "label14";
            label14.Size = new Size(57, 28);
            label14.TabIndex = 17;
            label14.Text = "Date:";
            // 
            // btnShift
            // 
            btnShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShift.Location = new Point(28, 258);
            btnShift.Margin = new Padding(3, 2, 3, 2);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(641, 42);
            btnShift.TabIndex = 15;
            btnShift.Text = "Assign Task";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnShift_Click;
            // 
            // dtDateShift
            // 
            dtDateShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateShift.Location = new Point(228, 154);
            dtDateShift.Margin = new Padding(3, 2, 3, 2);
            dtDateShift.Name = "dtDateShift";
            dtDateShift.Size = new Size(204, 34);
            dtDateShift.TabIndex = 14;
            // 
            // cbEmployeesShifts
            // 
            cbEmployeesShifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmployeesShifts.FormattingEnabled = true;
            cbEmployeesShifts.Location = new Point(228, 38);
            cbEmployeesShifts.Margin = new Padding(3, 2, 3, 2);
            cbEmployeesShifts.Name = "cbEmployeesShifts";
            cbEmployeesShifts.Size = new Size(204, 36);
            cbEmployeesShifts.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 88);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 19;
            label1.Text = "Task Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(228, 74);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(204, 68);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(548, 81);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 22;
            label2.Text = "Select status:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Completed", "Working on", "In process" });
            comboBox1.Location = new Point(549, 115);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 23;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(employee_lbl);
            Controls.Add(label14);
            Controls.Add(btnShift);
            Controls.Add(dtDateShift);
            Controls.Add(cbEmployeesShifts);
            Controls.Add(btnClose);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaskManager";
            Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label employee_lbl;
        private Label label14;
        private Button btnShift;
        private DateTimePicker dtDateShift;
        private ComboBox cbEmployeesShifts;
        private Label label1;
        private RichTextBox richTextBox1;
        private BindingSource bindingSource1;
        private Label label2;
        private ComboBox comboBox1;
    }
}