namespace calculator
{
    partial class Form1
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
            textInput1 = new TextBox();
            textInput2 = new TextBox();
            txtResult = new RichTextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnMod = new Button();
            btnClear = new Button();
            button7 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textInput1
            // 
            textInput1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textInput1.ForeColor = Color.DarkGray;
            textInput1.Location = new Point(57, 140);
            textInput1.Name = "textInput1";
            textInput1.PlaceholderText = "Input";
            textInput1.Size = new Size(356, 39);
            textInput1.TabIndex = 1;
            textInput1.Text = "Input";
            textInput1.TextChanged += textInput1_TextChanged;
            textInput1.Enter += textInput1_Enter;
            textInput1.Leave += textInput1_Leave;
            // 
            // textInput2
            // 
            textInput2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textInput2.ForeColor = Color.Silver;
            textInput2.Location = new Point(57, 189);
            textInput2.Name = "textInput2";
            textInput2.Size = new Size(356, 39);
            textInput2.TabIndex = 2;
            textInput2.Text = "Input";
            textInput2.TextChanged += textInput2_TextChanged;
            textInput2.Enter += textInput2_Enter;
            textInput2.Leave += textInput2_Leave;
            // 
            // txtResult
            // 
            txtResult.AccessibleDescription = "";
            txtResult.AccessibleName = "";
            txtResult.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.Silver;
            txtResult.Location = new Point(57, 38);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(356, 96);
            txtResult.TabIndex = 3;
            txtResult.Tag = "Answer";
            txtResult.Text = "Answer";
            txtResult.TextChanged += txtResult_TextChanged;
            txtResult.Enter += txtResult_Enter;
            txtResult.Leave += txtResult_Leave;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(83, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(201, 236);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 50);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(315, 236);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 50);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(83, 304);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 45);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(201, 304);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 45);
            btnMod.TabIndex = 8;
            btnMod.Text = "MOD";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(315, 307);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 45);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(64, 355);
            button7.Name = "button7";
            button7.Size = new Size(344, 77);
            button7.TabIndex = 10;
            button7.Text = "=";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtResult);
            groupBox1.Controls.Add(textInput1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(textInput2);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnMod);
            groupBox1.Controls.Add(btnSubtract);
            groupBox1.Controls.Add(btnDivide);
            groupBox1.Controls.Add(btnMultiply);
            groupBox1.Location = new Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 443);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 11;
            label2.Text = "CALCULATOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(594, 462);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textInput1;
        private TextBox textInput2;
        private RichTextBox txtResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        public Button btnMod;
        private Button btnClear;
        private Button button7;
        private GroupBox groupBox1;
        private Label label2;
    }
}
