namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(116, 217);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(97, 34);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 88);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount Percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 126);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Discount Amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 164);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(188, 42);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(150, 23);
            txtSubtotal.TabIndex = 4;
            txtSubtotal.TextChanged += textBox1_TextChanged;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(188, 80);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.Size = new Size(150, 23);
            txtDiscountPercent.TabIndex = 5;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(188, 118);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(150, 23);
            txtDiscountAmount.TabIndex = 6;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(188, 156);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 23);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            txtTotal.TextChanged += textBox4_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(219, 217);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(388, 280);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Button btnExit;
    }
}
