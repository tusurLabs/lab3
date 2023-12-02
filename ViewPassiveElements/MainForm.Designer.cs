namespace ViewPassiveElements
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
            ElementsDataGridView = new DataGridView();
            ElementName = new DataGridViewTextBoxColumn();
            ActiveResistor = new DataGridViewTextBoxColumn();
            ReactiveResistor = new DataGridViewTextBoxColumn();
            Add_Btn = new Button();
            Find_Btn = new Button();
            Remove_Btn = new Button();
            Open_Btn = new Button();
            Save_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ElementsDataGridView
            // 
            ElementsDataGridView.AllowUserToAddRows = false;
            ElementsDataGridView.AllowUserToDeleteRows = false;
            ElementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ElementName, ActiveResistor, ReactiveResistor });
            ElementsDataGridView.Location = new Point(12, 12);
            ElementsDataGridView.Name = "ElementsDataGridView";
            ElementsDataGridView.ReadOnly = true;
            ElementsDataGridView.RowHeadersWidth = 51;
            ElementsDataGridView.RowTemplate.Height = 29;
            ElementsDataGridView.Size = new Size(680, 188);
            ElementsDataGridView.TabIndex = 0;
            // 
            // ElementName
            // 
            ElementName.HeaderText = "Название";
            ElementName.MinimumWidth = 6;
            ElementName.Name = "ElementName";
            ElementName.ReadOnly = true;
            ElementName.Width = 125;
            // 
            // ActiveResistor
            // 
            ActiveResistor.HeaderText = "Активное сопротивление";
            ActiveResistor.MinimumWidth = 6;
            ActiveResistor.Name = "ActiveResistor";
            ActiveResistor.ReadOnly = true;
            ActiveResistor.Width = 250;
            // 
            // ReactiveResistor
            // 
            ReactiveResistor.HeaderText = "Реактивное сопротивление";
            ReactiveResistor.MinimumWidth = 6;
            ReactiveResistor.Name = "ReactiveResistor";
            ReactiveResistor.ReadOnly = true;
            ReactiveResistor.Width = 250;
            // 
            // Add_Btn
            // 
            Add_Btn.BackgroundImage = (Image)resources.GetObject("Add_Btn.BackgroundImage");
            Add_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Btn.Location = new Point(12, 218);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(32, 32);
            Add_Btn.TabIndex = 1;
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // Find_Btn
            // 
            Find_Btn.BackgroundImage = (Image)resources.GetObject("Find_Btn.BackgroundImage");
            Find_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Find_Btn.Location = new Point(53, 218);
            Find_Btn.Name = "Find_Btn";
            Find_Btn.Size = new Size(32, 32);
            Find_Btn.TabIndex = 2;
            Find_Btn.UseVisualStyleBackColor = true;
            Find_Btn.Click += Find_Btn_Click;
            // 
            // Remove_Btn
            // 
            Remove_Btn.BackgroundImage = (Image)resources.GetObject("Remove_Btn.BackgroundImage");
            Remove_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Remove_Btn.Location = new Point(102, 218);
            Remove_Btn.Name = "Remove_Btn";
            Remove_Btn.Size = new Size(32, 32);
            Remove_Btn.TabIndex = 3;
            Remove_Btn.UseVisualStyleBackColor = true;
            Remove_Btn.Click += Remove_Btn_Click;
            // 
            // Open_Btn
            // 
            Open_Btn.BackgroundImage = (Image)resources.GetObject("Open_Btn.BackgroundImage");
            Open_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Open_Btn.Location = new Point(660, 218);
            Open_Btn.Name = "Open_Btn";
            Open_Btn.Size = new Size(32, 32);
            Open_Btn.TabIndex = 4;
            Open_Btn.UseVisualStyleBackColor = true;
            Open_Btn.Click += Open_Btn_Click;
            // 
            // Save_Btn
            // 
            Save_Btn.BackgroundImage = (Image)resources.GetObject("Save_Btn.BackgroundImage");
            Save_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Save_Btn.Location = new Point(622, 218);
            Save_Btn.Name = "Save_Btn";
            Save_Btn.Size = new Size(32, 32);
            Save_Btn.TabIndex = 5;
            Save_Btn.UseVisualStyleBackColor = true;
            Save_Btn.Click += Save_Btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 261);
            Controls.Add(Save_Btn);
            Controls.Add(Open_Btn);
            Controls.Add(Remove_Btn);
            Controls.Add(Find_Btn);
            Controls.Add(Add_Btn);
            Controls.Add(ElementsDataGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ElementsDataGridView;
        private DataGridViewTextBoxColumn ElementName;
        private DataGridViewTextBoxColumn ActiveResistor;
        private DataGridViewTextBoxColumn ReactiveResistor;
        private Button Add_Btn;
        private Button Find_Btn;
        private Button Remove_Btn;
        private Button Open_Btn;
        private Button Save_Btn;
    }
}