
namespace ProductManagement
{
    partial class frmProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.inputStock = new System.Windows.Forms.TextBox();
            this.inputTotal = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 84);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Khmer OS Freehand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(261, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(280, 54);
            this.title.TabIndex = 1;
            this.title.Text = "ការគ្រប់គ្រងផលិតផល";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(12, 108);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(167, 36);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "លេខកូដផលិតផលៈ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 36);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ឈ្មោះផលិតផលៈ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(15, 206);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 36);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "តម្លៃផលិតផលៈ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 306);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(127, 36);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "ថ្ងៃផុតកំណត់ៈ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(12, 256);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(124, 36);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "ចំនួនក្នុងស្តុកៈ";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(12, 351);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 36);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "តម្លៃសរុបក្នុងស្តុកៈ";
            // 
            // inputDate
            // 
            this.inputDate.CalendarFont = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDate.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDate.Location = new System.Drawing.Point(196, 300);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(390, 44);
            this.inputDate.TabIndex = 2;
            // 
            // inputCode
            // 
            this.inputCode.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCode.Location = new System.Drawing.Point(196, 100);
            this.inputCode.Name = "inputCode";
            this.inputCode.ReadOnly = true;
            this.inputCode.Size = new System.Drawing.Size(390, 44);
            this.inputCode.TabIndex = 3;
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.Location = new System.Drawing.Point(196, 150);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(390, 44);
            this.inputName.TabIndex = 1;
            // 
            // inputPrice
            // 
            this.inputPrice.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPrice.Location = new System.Drawing.Point(196, 198);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(390, 44);
            this.inputPrice.TabIndex = 2;
            // 
            // inputStock
            // 
            this.inputStock.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputStock.Location = new System.Drawing.Point(196, 250);
            this.inputStock.Name = "inputStock";
            this.inputStock.Size = new System.Drawing.Size(390, 44);
            this.inputStock.TabIndex = 3;
            // 
            // inputTotal
            // 
            this.inputTotal.Font = new System.Drawing.Font("Khmer OS Freehand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTotal.Location = new System.Drawing.Point(196, 348);
            this.inputTotal.Name = "inputTotal";
            this.inputTotal.ReadOnly = true;
            this.inputTotal.Size = new System.Drawing.Size(390, 44);
            this.inputTotal.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(592, 98);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(196, 44);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(592, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(592, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(592, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(592, 298);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(196, 44);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Products";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(592, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(196, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Khmer OS Freehand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(372, 400);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(82, 37);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(460, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 38);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "|>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Location = new System.Drawing.Point(548, 400);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(82, 38);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "|>>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(284, 400);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(82, 38);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<|";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnFirst.Location = new System.Drawing.Point(196, 400);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(82, 38);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<|";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.inputStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.inputTotal);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.Text = "NewProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.TextBox inputStock;
        private System.Windows.Forms.TextBox inputTotal;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
    }
}

