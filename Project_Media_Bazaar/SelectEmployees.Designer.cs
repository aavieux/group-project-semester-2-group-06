namespace Project_Media_Bazaar
{
    partial class SelectEmployees
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
            select_btn = new Button();
            remove_btn = new Button();
            selectEmployees_clb = new ListBox();
            selectedEmployees_clb = new ListBox();
            selectFromEmployees_lbl = new Label();
            selectedEmployees_lbl = new Label();
            SuspendLayout();
            // 
            // select_btn
            // 
            select_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            select_btn.Location = new Point(12, 396);
            select_btn.Name = "select_btn";
            select_btn.Size = new Size(378, 53);
            select_btn.TabIndex = 2;
            select_btn.Text = "Select";
            select_btn.UseVisualStyleBackColor = true;
            select_btn.Click += select_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            remove_btn.Location = new Point(396, 396);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(392, 53);
            remove_btn.TabIndex = 3;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = true;
            remove_btn.Click += remove_btn_Click;
            // 
            // selectEmployees_clb
            // 
            selectEmployees_clb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectEmployees_clb.FormattingEnabled = true;
            selectEmployees_clb.ItemHeight = 21;
            selectEmployees_clb.Location = new Point(12, 47);
            selectEmployees_clb.Name = "selectEmployees_clb";
            selectEmployees_clb.SelectionMode = SelectionMode.MultiSimple;
            selectEmployees_clb.Size = new Size(378, 340);
            selectEmployees_clb.TabIndex = 5;
            // 
            // selectedEmployees_clb
            // 
            selectedEmployees_clb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployees_clb.FormattingEnabled = true;
            selectedEmployees_clb.ItemHeight = 21;
            selectedEmployees_clb.Location = new Point(396, 47);
            selectedEmployees_clb.Name = "selectedEmployees_clb";
            selectedEmployees_clb.SelectionMode = SelectionMode.MultiSimple;
            selectedEmployees_clb.Size = new Size(392, 340);
            selectedEmployees_clb.TabIndex = 6;
            // 
            // selectFromEmployees_lbl
            // 
            selectFromEmployees_lbl.AutoSize = true;
            selectFromEmployees_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectFromEmployees_lbl.Location = new Point(87, 16);
            selectFromEmployees_lbl.Name = "selectFromEmployees_lbl";
            selectFromEmployees_lbl.Size = new Size(214, 28);
            selectFromEmployees_lbl.TabIndex = 7;
            selectFromEmployees_lbl.Text = "Select From Employees";
            // 
            // selectedEmployees_lbl
            // 
            selectedEmployees_lbl.AutoSize = true;
            selectedEmployees_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployees_lbl.Location = new Point(508, 9);
            selectedEmployees_lbl.Name = "selectedEmployees_lbl";
            selectedEmployees_lbl.Size = new Size(185, 28);
            selectedEmployees_lbl.TabIndex = 8;
            selectedEmployees_lbl.Text = "Selected Employees";
            // 
            // SelectEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(selectedEmployees_lbl);
            Controls.Add(selectFromEmployees_lbl);
            Controls.Add(selectedEmployees_clb);
            Controls.Add(selectEmployees_clb);
            Controls.Add(remove_btn);
            Controls.Add(select_btn);
            Name = "SelectEmployees";
            Text = "SelectEmployees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button select_btn;
        private Button remove_btn;
        private ListBox selectEmployees_clb;
        private ListBox selectedEmployees_clb;
        private Label selectFromEmployees_lbl;
        private Label selectedEmployees_lbl;
    }
}