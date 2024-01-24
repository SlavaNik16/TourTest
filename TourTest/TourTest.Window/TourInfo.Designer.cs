namespace TourTest.Window
{
    partial class TourInfo
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIsActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(176, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(142, 36);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TourTest.Window.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(44, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(191, 298);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(127, 55);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // labelIsActual
            // 
            this.labelIsActual.AutoSize = true;
            this.labelIsActual.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsActual.ForeColor = System.Drawing.Color.Green;
            this.labelIsActual.Location = new System.Drawing.Point(28, 375);
            this.labelIsActual.Name = "labelIsActual";
            this.labelIsActual.Size = new System.Drawing.Size(126, 33);
            this.labelIsActual.TabIndex = 3;
            this.labelIsActual.Text = "Актуален";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(326, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Билетов: ";
            // 
            // labelTicketCount
            // 
            this.labelTicketCount.AutoSize = true;
            this.labelTicketCount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTicketCount.Location = new System.Drawing.Point(444, 375);
            this.labelTicketCount.Name = "labelTicketCount";
            this.labelTicketCount.Size = new System.Drawing.Size(57, 33);
            this.labelTicketCount.TabIndex = 5;
            this.labelTicketCount.Text = "100";
            // 
            // TourInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTicketCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIsActual);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Name = "TourInfo";
            this.Size = new System.Drawing.Size(526, 428);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIsActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTicketCount;
    }
}
