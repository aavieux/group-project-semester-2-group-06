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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.employee_lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnShift = new System.Windows.Forms.Button();
            this.dtDateShift = new System.Windows.Forms.DateTimePicker();
            this.cbEmployeesShifts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(626, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 69);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // employee_lbl
            // 
            this.employee_lbl.AutoSize = true;
            this.employee_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_lbl.Location = new System.Drawing.Point(23, 50);
            this.employee_lbl.Name = "employee_lbl";
            this.employee_lbl.Size = new System.Drawing.Size(201, 35);
            this.employee_lbl.TabIndex = 18;
            this.employee_lbl.Text = "Select Employee:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(23, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 35);
            this.label14.TabIndex = 17;
            this.label14.Text = "Date:";
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShift.Location = new System.Drawing.Point(32, 344);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(733, 46);
            this.btnShift.TabIndex = 15;
            this.btnShift.Text = "Assign Task";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // dtDateShift
            // 
            this.dtDateShift.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateShift.Location = new System.Drawing.Point(261, 205);
            this.dtDateShift.Name = "dtDateShift";
            this.dtDateShift.Size = new System.Drawing.Size(233, 41);
            this.dtDateShift.TabIndex = 14;
            // 
            // cbEmployeesShifts
            // 
            this.cbEmployeesShifts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEmployeesShifts.FormattingEnabled = true;
            this.cbEmployeesShifts.Location = new System.Drawing.Point(261, 50);
            this.cbEmployeesShifts.Name = "cbEmployeesShifts";
            this.cbEmployeesShifts.Size = new System.Drawing.Size(233, 43);
            this.cbEmployeesShifts.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Task Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(261, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(233, 90);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(626, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 33);
            this.progressBar1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(626, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 35);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select status:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completed",
            "Working on",
            "In process"});
            this.comboBox1.Location = new System.Drawing.Point(627, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_lbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.dtDateShift);
            this.Controls.Add(this.cbEmployeesShifts);
            this.Controls.Add(this.btnClose);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ProgressBar progressBar1;
        private BindingSource bindingSource1;
        private Label label2;
        private ComboBox comboBox1;
    }
}