namespace ViewPassiveElements
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            Type_Lbl = new Label();
            Name_Lbl = new Label();
            ActiveResistor_Lbl = new Label();
            Name_Tb = new TextBox();
            ActiveResistor_Tb = new TextBox();
            Frequncy_Tb = new TextBox();
            Frequncy_Lbl = new Label();
            ActiveValue_Tb = new TextBox();
            ActiveValue_Lbl = new Label();
            Type_Cb = new ComboBox();
            Add_Btn = new Button();
            Random_Btn = new Button();
            SuspendLayout();
            // 
            // Type_Lbl
            // 
            Type_Lbl.AutoSize = true;
            Type_Lbl.Location = new Point(80, 7);
            Type_Lbl.Name = "Type_Lbl";
            Type_Lbl.Size = new Size(27, 15);
            Type_Lbl.TabIndex = 0;
            Type_Lbl.Text = "Тип";
            // 
            // Name_Lbl
            // 
            Name_Lbl.AutoSize = true;
            Name_Lbl.Location = new Point(62, 47);
            Name_Lbl.Name = "Name_Lbl";
            Name_Lbl.Size = new Size(59, 15);
            Name_Lbl.TabIndex = 1;
            Name_Lbl.Text = "Название";
            // 
            // ActiveResistor_Lbl
            // 
            ActiveResistor_Lbl.AutoSize = true;
            ActiveResistor_Lbl.Location = new Point(14, 94);
            ActiveResistor_Lbl.Name = "ActiveResistor_Lbl";
            ActiveResistor_Lbl.Size = new Size(146, 15);
            ActiveResistor_Lbl.TabIndex = 2;
            ActiveResistor_Lbl.Text = "Активное сопративление";
            // 
            // Name_Tb
            // 
            Name_Tb.Location = new Point(10, 64);
            Name_Tb.Margin = new Padding(3, 2, 3, 2);
            Name_Tb.Name = "Name_Tb";
            Name_Tb.Size = new Size(171, 23);
            Name_Tb.TabIndex = 3;
            // 
            // ActiveResistor_Tb
            // 
            ActiveResistor_Tb.Location = new Point(10, 112);
            ActiveResistor_Tb.Margin = new Padding(3, 2, 3, 2);
            ActiveResistor_Tb.Name = "ActiveResistor_Tb";
            ActiveResistor_Tb.Size = new Size(171, 23);
            ActiveResistor_Tb.TabIndex = 4;
            // 
            // Frequncy_Tb
            // 
            Frequncy_Tb.Location = new Point(10, 154);
            Frequncy_Tb.Margin = new Padding(3, 2, 3, 2);
            Frequncy_Tb.Name = "Frequncy_Tb";
            Frequncy_Tb.Size = new Size(171, 23);
            Frequncy_Tb.TabIndex = 5;
            // 
            // Frequncy_Lbl
            // 
            Frequncy_Lbl.AutoSize = true;
            Frequncy_Lbl.Location = new Point(68, 136);
            Frequncy_Lbl.Name = "Frequncy_Lbl";
            Frequncy_Lbl.Size = new Size(50, 15);
            Frequncy_Lbl.TabIndex = 6;
            Frequncy_Lbl.Text = "Частота";
            // 
            // ActiveValue_Tb
            // 
            ActiveValue_Tb.Location = new Point(10, 198);
            ActiveValue_Tb.Margin = new Padding(3, 2, 3, 2);
            ActiveValue_Tb.Name = "ActiveValue_Tb";
            ActiveValue_Tb.Size = new Size(171, 23);
            ActiveValue_Tb.TabIndex = 7;
            // 
            // ActiveValue_Lbl
            // 
            ActiveValue_Lbl.AutoSize = true;
            ActiveValue_Lbl.Location = new Point(33, 180);
            ActiveValue_Lbl.Name = "ActiveValue_Lbl";
            ActiveValue_Lbl.Size = new Size(0, 15);
            ActiveValue_Lbl.TabIndex = 8;
            // 
            // Type_Cb
            // 
            Type_Cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Type_Cb.FormattingEnabled = true;
            Type_Cb.Items.AddRange(new object[] { "Резистор", "Конденсатор", "Индуктивность" });
            Type_Cb.Location = new Point(10, 24);
            Type_Cb.Margin = new Padding(3, 2, 3, 2);
            Type_Cb.Name = "Type_Cb";
            Type_Cb.Size = new Size(171, 23);
            Type_Cb.TabIndex = 9;
            Type_Cb.SelectedIndexChanged += Type_Cb_SelectedIndexChanged;
            // 
            // Add_Btn
            // 
            Add_Btn.BackgroundImage = (Image)resources.GetObject("Add_Btn.BackgroundImage");
            Add_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Btn.Location = new Point(206, 24);
            Add_Btn.Margin = new Padding(3, 2, 3, 2);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(28, 24);
            Add_Btn.TabIndex = 10;
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // Random_Btn
            // 
            Random_Btn.BackgroundImage = (Image)resources.GetObject("Random_Btn.BackgroundImage");
            Random_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Random_Btn.Location = new Point(206, 60);
            Random_Btn.Margin = new Padding(3, 2, 3, 2);
            Random_Btn.Name = "Random_Btn";
            Random_Btn.Size = new Size(28, 24);
            Random_Btn.TabIndex = 11;
            Random_Btn.UseVisualStyleBackColor = true;
            Random_Btn.Click += Random_Btn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 229);
            Controls.Add(Random_Btn);
            Controls.Add(Add_Btn);
            Controls.Add(Type_Cb);
            Controls.Add(ActiveValue_Lbl);
            Controls.Add(ActiveValue_Tb);
            Controls.Add(Frequncy_Lbl);
            Controls.Add(Frequncy_Tb);
            Controls.Add(ActiveResistor_Tb);
            Controls.Add(Name_Tb);
            Controls.Add(ActiveResistor_Lbl);
            Controls.Add(Name_Lbl);
            Controls.Add(Type_Lbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddForm";
            Text = "Добавить элемент";
            FormClosed += AddForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Type_Lbl;
        private Label Name_Lbl;
        private Label ActiveResistor_Lbl;
        private TextBox Name_Tb;
        private TextBox ActiveResistor_Tb;
        private TextBox Frequncy_Tb;
        private Label Frequncy_Lbl;
        private TextBox ActiveValue_Tb;
        private Label ActiveValue_Lbl;
        private ComboBox Type_Cb;
        private Button Add_Btn;
        private Button Random_Btn;
    }
}