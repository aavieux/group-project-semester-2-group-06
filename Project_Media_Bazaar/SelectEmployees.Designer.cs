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
            selectEmployees_clb = new CheckedListBox();
            select_btn = new Button();
            remove_btn = new Button();
            selectedEmployees_clb = new CheckedListBox();
            SuspendLayout();
            // 
            // selectEmployees_clb
            // 
            selectEmployees_clb.FormattingEnabled = true;
            selectEmployees_clb.Location = new Point(12, 26);
            selectEmployees_clb.Name = "selectEmployees_clb";
            selectEmployees_clb.Size = new Size(378, 364);
            selectEmployees_clb.TabIndex = 0;
            // 
            // select_btn
            // 
            select_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            select_btn.Location = new Point(12, 396);
            select_btn.Name = "select_btn";
            select_btn.Size = new Size(378, 40);
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
            remove_btn.Size = new Size(392, 40);
            remove_btn.TabIndex = 3;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = true;
            remove_btn.Click += remove_btn_Click;
            // 
            // selectedEmployees_clb
            // 
            selectedEmployees_clb.FormattingEnabled = true;
            selectedEmployees_clb.Location = new Point(396, 26);
            selectedEmployees_clb.Name = "selectedEmployees_clb";
            selectedEmployees_clb.Size = new Size(392, 364);
            selectedEmployees_clb.TabIndex = 4;
            // 
            // SelectEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(selectedEmployees_clb);
            Controls.Add(remove_btn);
            Controls.Add(select_btn);
            Controls.Add(selectEmployees_clb);
            Name = "SelectEmployees";
            Text = "SelectEmployees";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox selectEmployees_clb;
        private Button select_btn;
        private Button remove_btn;
        private CheckedListBox selectedEmployees_clb;
    }
}