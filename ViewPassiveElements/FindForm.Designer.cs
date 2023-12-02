namespace ViewPassiveElements
{
    partial class FindForm
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
            ElementsDataGridView = new DataGridView();
            ElementName = new DataGridViewTextBoxColumn();
            ActiveResistor = new DataGridViewTextBoxColumn();
            ReactiveResistor = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ActiveResistorStart_Tb = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            Name_Tb = new TextBox();
            label7 = new Label();
            label4 = new Label();
            ReactiveResistorEnd_Tb = new TextBox();
            label5 = new Label();
            ReactiveResistorStart_Tb = new TextBox();
            label6 = new Label();
            label3 = new Label();
            ActiveResistorEnd_Tb = new TextBox();
            label2 = new Label();
            Refresh_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ElementsDataGridView
            // 
            ElementsDataGridView.AllowUserToAddRows = false;
            ElementsDataGridView.AllowUserToDeleteRows = false;
            ElementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ElementName, ActiveResistor, ReactiveResistor });
            ElementsDataGridView.Location = new Point(12, 11);
            ElementsDataGridView.Margin = new Padding(3, 2, 3, 2);
            ElementsDataGridView.Name = "ElementsDataGridView";
            ElementsDataGridView.ReadOnly = true;
            ElementsDataGridView.RowHeadersWidth = 51;
            ElementsDataGridView.RowTemplate.Height = 29;
            ElementsDataGridView.Size = new Size(694, 141);
            ElementsDataGridView.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Активное сопротивление";
            // 
            // ActiveResistorStart_Tb
            // 
            ActiveResistorStart_Tb.Location = new Point(25, 37);
            ActiveResistorStart_Tb.Name = "ActiveResistorStart_Tb";
            ActiveResistorStart_Tb.Size = new Size(100, 23);
            ActiveResistorStart_Tb.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Refresh_Btn);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Name_Tb);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ReactiveResistorEnd_Tb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ReactiveResistorStart_Tb);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ActiveResistorEnd_Tb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ActiveResistorStart_Tb);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 140);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры поиска";
            // 
            // button1
            // 
            button1.Location = new Point(295, 69);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 13;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Name_Tb
            // 
            Name_Tb.Location = new Point(295, 40);
            Name_Tb.Name = "Name_Tb";
            Name_Tb.Size = new Size(153, 23);
            Name_Tb.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 19);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 11;
            label7.Text = "Название элемента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 91);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 9;
            label4.Text = "по";
            // 
            // ReactiveResistorEnd_Tb
            // 
            ReactiveResistorEnd_Tb.Location = new Point(167, 88);
            ReactiveResistorEnd_Tb.Name = "ReactiveResistorEnd_Tb";
            ReactiveResistorEnd_Tb.Size = new Size(100, 23);
            ReactiveResistorEnd_Tb.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 91);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 7;
            label5.Text = "с";
            // 
            // ReactiveResistorStart_Tb
            // 
            ReactiveResistorStart_Tb.Location = new Point(25, 88);
            ReactiveResistorStart_Tb.Name = "ReactiveResistorStart_Tb";
            ReactiveResistorStart_Tb.Size = new Size(100, 23);
            ReactiveResistorStart_Tb.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 65);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 6;
            label6.Text = "Реактивное сопротивление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 40);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "по";
            // 
            // ActiveResistorEnd_Tb
            // 
            ActiveResistorEnd_Tb.Location = new Point(167, 37);
            ActiveResistorEnd_Tb.Name = "ActiveResistorEnd_Tb";
            ActiveResistorEnd_Tb.Size = new Size(100, 23);
            ActiveResistorEnd_Tb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 3;
            label2.Text = "с";
            // 
            // Refresh_Btn
            // 
            Refresh_Btn.Location = new Point(295, 98);
            Refresh_Btn.Name = "Refresh_Btn";
            Refresh_Btn.Size = new Size(153, 23);
            Refresh_Btn.TabIndex = 14;
            Refresh_Btn.Text = "Сбросить параметры";
            Refresh_Btn.UseVisualStyleBackColor = true;
            Refresh_Btn.Click += Refresh_Btn_Click;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 350);
            Controls.Add(groupBox1);
            Controls.Add(ElementsDataGridView);
            Name = "FindForm";
            Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView ElementsDataGridView;
        private DataGridViewTextBoxColumn ElementName;
        private DataGridViewTextBoxColumn ActiveResistor;
        private DataGridViewTextBoxColumn ReactiveResistor;
        private Label label1;
        private TextBox ActiveResistorStart_Tb;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox ActiveResistorEnd_Tb;
        private Label label2;
        private Button button1;
        private TextBox Name_Tb;
        private Label label7;
        private Label label4;
        private TextBox ReactiveResistorEnd_Tb;
        private Label label5;
        private TextBox ReactiveResistorStart_Tb;
        private Label label6;
        private Button Refresh_Btn;
    }
}