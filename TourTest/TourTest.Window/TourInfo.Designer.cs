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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelIsActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketCount = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.butEditPhoto = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBack.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(2, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(371, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIsActual
            // 
            this.labelIsActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIsActual.AutoSize = true;
            this.labelIsActual.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsActual.ForeColor = System.Drawing.Color.Green;
            this.labelIsActual.Location = new System.Drawing.Point(2, 0);
            this.labelIsActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsActual.Name = "labelIsActual";
            this.labelIsActual.Size = new System.Drawing.Size(84, 85);
            this.labelIsActual.TabIndex = 3;
            this.labelIsActual.Text = "Актуален";
            this.labelIsActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(242, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "Билетов: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTicketCount
            // 
            this.labelTicketCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTicketCount.AutoSize = true;
            this.labelTicketCount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTicketCount.Location = new System.Drawing.Point(330, 0);
            this.labelTicketCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicketCount.Name = "labelTicketCount";
            this.labelTicketCount.Size = new System.Drawing.Size(37, 85);
            this.labelTicketCount.TabIndex = 5;
            this.labelTicketCount.Text = "100";
            this.labelTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.Controls.Add(this.butEditPhoto);
            this.panelBack.Controls.Add(this.butEdit);
            this.panelBack.Controls.Add(this.tableLayoutPanel3);
            this.panelBack.Controls.Add(this.tableLayoutPanel2);
            this.panelBack.Controls.Add(this.tableLayoutPanel1);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(33, 32);
            this.panelBack.Margin = new System.Windows.Forms.Padding(2);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(375, 386);
            this.panelBack.TabIndex = 6;
            // 
            // butEditPhoto
            // 
            this.butEditPhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEditPhoto.Location = new System.Drawing.Point(255, 338);
            this.butEditPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.butEditPhoto.Name = "butEditPhoto";
            this.butEditPhoto.Size = new System.Drawing.Size(113, 36);
            this.butEditPhoto.TabIndex = 10;
            this.butEditPhoto.Text = "Обзор";
            this.butEditPhoto.UseVisualStyleBackColor = true;
            this.butEditPhoto.Click += new System.EventHandler(this.butEditPhoto_Click);
            // 
            // butEdit
            // 
            this.butEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEdit.Location = new System.Drawing.Point(9, 338);
            this.butEdit.Margin = new System.Windows.Forms.Padding(2);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(113, 36);
            this.butEdit.TabIndex = 9;
            this.butEdit.Text = "Изменить";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Controls.Add(this.labelIsActual, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTicketCount, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 243);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(375, 85);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelPrice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 179);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 64);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(2, 0);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(371, 64);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.81818F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 179);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image(*.jpg)|*.jpg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrder});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(142, 26);
            // 
            // addToOrder
            // 
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.Size = new System.Drawing.Size(155, 22);
            this.addToOrder.Text = "Добавить в заказ";
            this.addToOrder.Click += new System.EventHandler(this.addToOrder_Click);
            // 
            // TourInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.panelBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TourInfo";
            this.Padding = new System.Windows.Forms.Padding(33, 32, 33, 32);
            this.Size = new System.Drawing.Size(441, 450);
            this.panelBack.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIsActual;
        private System.Windows.Forms.Label labelTicketCount;
        private System.Windows.Forms.Button butEditPhoto;
        private System.Windows.Forms.Button butEdit;
        public System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToOrder;
    }
}
