namespace POB2312
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
            label1 = new Label();
            tbFirst = new TextBox();
            label2 = new Label();
            tbSecond = new TextBox();
            btPlus = new Button();
            btMinus = new Button();
            btUmnogenie = new Button();
            btDelenie = new Button();
            lbResalt = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 0;
            label1.Text = "Введите первое число";
            label1.Click += label1_Click;
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(148, 68);
            tbFirst.Margin = new Padding(5);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(200, 33);
            tbFirst.TabIndex = 1;
            tbFirst.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 112);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 2;
            label2.Text = "Введите второе число";
            // 
            // tbSecond
            // 
            tbSecond.Location = new Point(149, 142);
            tbSecond.Margin = new Padding(5);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(200, 33);
            tbSecond.TabIndex = 3;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(148, 193);
            btPlus.Margin = new Padding(5);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(203, 38);
            btPlus.TabIndex = 4;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMinus
            // 
            btMinus.Location = new Point(148, 242);
            btMinus.Margin = new Padding(5);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(203, 38);
            btMinus.TabIndex = 5;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += btMinus_Click;
            // 
            // btUmnogenie
            // 
            btUmnogenie.Location = new Point(148, 290);
            btUmnogenie.Margin = new Padding(5);
            btUmnogenie.Name = "btUmnogenie";
            btUmnogenie.Size = new Size(203, 38);
            btUmnogenie.TabIndex = 6;
            btUmnogenie.Text = "*";
            btUmnogenie.UseVisualStyleBackColor = true;
            btUmnogenie.Click += btUmnogenie_Click;
            // 
            // btDelenie
            // 
            btDelenie.Location = new Point(148, 338);
            btDelenie.Margin = new Padding(5);
            btDelenie.Name = "btDelenie";
            btDelenie.Size = new Size(203, 38);
            btDelenie.TabIndex = 7;
            btDelenie.Text = "/";
            btDelenie.UseVisualStyleBackColor = true;
            btDelenie.Click += btDelenie_Click;
            // 
            // lbResalt
            // 
            lbResalt.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbResalt.ForeColor = Color.Red;
            lbResalt.Location = new Point(148, 382);
            lbResalt.Margin = new Padding(5, 0, 5, 0);
            lbResalt.Name = "lbResalt";
            lbResalt.Size = new Size(203, 38);
            lbResalt.TabIndex = 8;
            lbResalt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 624);
            Controls.Add(lbResalt);
            Controls.Add(btDelenie);
            Controls.Add(btUmnogenie);
            Controls.Add(btMinus);
            Controls.Add(btPlus);
            Controls.Add(tbSecond);
            Controls.Add(label2);
            Controls.Add(tbFirst);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Моя первая программа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFirst;
        private Label label2;
        private TextBox tbSecond;
        private Button btPlus;
        private Button btMinus;
        private Button btUmnogenie;
        private Button btDelenie;
        private Label lbResalt;
    }
}
