namespace TourTest.Window
{
    partial class TourForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAllTourSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCountOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butOrder = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.checkBoxIsActual = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 182);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(1431, 695);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAllTourSum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelCountOrders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butOrder);
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Controls.Add(this.checkBoxIsActual);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 182);
            this.panel1.TabIndex = 3;
            // 
            // labelAllTourSum
            // 
            this.labelAllTourSum.AutoSize = true;
            this.labelAllTourSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllTourSum.Location = new System.Drawing.Point(213, 136);
            this.labelAllTourSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllTourSum.Name = "labelAllTourSum";
            this.labelAllTourSum.Size = new System.Drawing.Size(29, 33);
            this.labelAllTourSum.TabIndex = 11;
            this.labelAllTourSum.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Общая сумма: ";
            // 
            // labelCountOrders
            // 
            this.labelCountOrders.AutoSize = true;
            this.labelCountOrders.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountOrders.Location = new System.Drawing.Point(1300, 34);
            this.labelCountOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountOrders.Name = "labelCountOrders";
            this.labelCountOrders.Size = new System.Drawing.Size(29, 33);
            this.labelCountOrders.TabIndex = 9;
            this.labelCountOrders.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1180, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кол-во: ";
            // 
            // butOrder
            // 
            this.butOrder.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOrder.Location = new System.Drawing.Point(934, 22);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(238, 52);
            this.butOrder.TabIndex = 7;
            this.butOrder.Text = "Заказы";
            this.butOrder.UseVisualStyleBackColor = true;
            this.butOrder.Visible = false;
            this.butOrder.Click += new System.EventHandler(this.butOrder_Click);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.Location = new System.Drawing.Point(1119, 117);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(238, 52);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // checkBoxIsActual
            // 
            this.checkBoxIsActual.AutoSize = true;
            this.checkBoxIsActual.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.checkBoxIsActual.Location = new System.Drawing.Point(482, 132);
            this.checkBoxIsActual.Name = "checkBoxIsActual";
            this.checkBoxIsActual.Size = new System.Drawing.Size(331, 37);
            this.checkBoxIsActual.TabIndex = 5;
            this.checkBoxIsActual.Text = "Только актуальные туры";
            this.checkBoxIsActual.UseVisualStyleBackColor = true;
            this.checkBoxIsActual.CheckedChanged += new System.EventHandler(this.checkBoxIsActual_CheckedChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Все туры"});
            this.comboBoxType.Location = new System.Drawing.Point(482, 75);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(421, 41);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите тип:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(630, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(272, 40);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст для поиска:";
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 877);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TourForm";
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxIsActual;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label labelCountOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAllTourSum;
    }
}

