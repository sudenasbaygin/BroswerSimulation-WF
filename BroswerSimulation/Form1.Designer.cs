namespace BroswerSimulation
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            downloadButton = new Button();
            visitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(33, 106);
            label1.Name = "label1";
            label1.Size = new Size(309, 68);
            label1.TabIndex = 0;
            label1.Text = "Enter the website name to visit:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(33, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(450, 52);
            label2.Name = "label2";
            label2.Size = new Size(366, 38);
            label2.TabIndex = 2;
            label2.Text = "Download Manager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(450, 106);
            label3.Name = "label3";
            label3.Size = new Size(320, 68);
            label3.TabIndex = 3;
            label3.Text = "Enter the file name to download:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 52);
            label4.Name = "label4";
            label4.Size = new Size(160, 38);
            label4.TabIndex = 5;
            label4.Text = "Broswer";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(450, 205);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(366, 46);
            progressBar1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 268);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(722, 147);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(94, 29);
            downloadButton.TabIndex = 8;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // visitButton
            // 
            visitButton.Location = new Point(310, 147);
            visitButton.Name = "visitButton";
            visitButton.Size = new Size(94, 29);
            visitButton.TabIndex = 9;
            visitButton.Text = "Visit";
            visitButton.UseVisualStyleBackColor = true;
            visitButton.Click += visitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 378);
            Controls.Add(visitButton);
            Controls.Add(downloadButton);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ProgressBar progressBar1;
        private Label label5;
        private Button downloadButton;
        private Button visitButton;
    }
}
