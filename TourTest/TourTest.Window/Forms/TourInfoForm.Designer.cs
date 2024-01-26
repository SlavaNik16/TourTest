namespace TourTest.Window.Forms
{
    partial class TourInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxIsActual = new System.Windows.Forms.CheckBox();
            this.numericUpDownTicket = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(166, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(351, 40);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(166, 83);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(172, 40);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(23, 86);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(73, 33);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // checkBoxIsActual
            // 
            this.checkBoxIsActual.AutoSize = true;
            this.checkBoxIsActual.Checked = true;
            this.checkBoxIsActual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActual.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.checkBoxIsActual.Location = new System.Drawing.Point(365, 85);
            this.checkBoxIsActual.Name = "checkBoxIsActual";
            this.checkBoxIsActual.Size = new System.Drawing.Size(152, 37);
            this.checkBoxIsActual.TabIndex = 4;
            this.checkBoxIsActual.Text = "Актуален";
            this.checkBoxIsActual.UseVisualStyleBackColor = true;
            this.checkBoxIsActual.CheckedChanged += new System.EventHandler(this.checkBoxIsActual_CheckedChanged);
            // 
            // numericUpDownTicket
            // 
            this.numericUpDownTicket.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.numericUpDownTicket.Location = new System.Drawing.Point(241, 162);
            this.numericUpDownTicket.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownTicket.Name = "numericUpDownTicket";
            this.numericUpDownTicket.Size = new System.Drawing.Size(276, 40);
            this.numericUpDownTicket.TabIndex = 5;
            this.numericUpDownTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTicket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTicket.ValueChanged += new System.EventHandler(this.numericUpDownTicket_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во билетов";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(241, 234);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(276, 41);
            this.comboBoxCountry.TabIndex = 7;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Страна";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(365, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Location = new System.Drawing.Point(29, 318);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(152, 45);
            this.butAdd.TabIndex = 10;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.butDelete.Location = new System.Drawing.Point(198, 318);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(152, 45);
            this.butDelete.TabIndex = 11;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // TourInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 384);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownTicket);
            this.Controls.Add(this.checkBoxIsActual);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "TourInfoForm";
            this.Text = "Добавление тура";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxIsActual;
        private System.Windows.Forms.NumericUpDown numericUpDownTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
    }
}