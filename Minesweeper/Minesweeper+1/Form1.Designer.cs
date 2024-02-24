namespace Minesweeper_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            matrixPanel = new Panel();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            scorelbl = new Label();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timerlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // matrixPanel
            // 
            matrixPanel.BorderStyle = BorderStyle.FixedSingle;
            matrixPanel.Location = new Point(41, 60);
            matrixPanel.Name = "matrixPanel";
            matrixPanel.Size = new Size(500, 500);
            matrixPanel.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pngwing.png");
            imageList1.Images.SetKeyName(1, "bomb.png");
            imageList1.Images.SetKeyName(2, "no bomb.png");
            imageList1.Images.SetKeyName(3, "pngwing.com.png");
            imageList1.Images.SetKeyName(4, "num1.png");
            imageList1.Images.SetKeyName(5, "num2.png");
            imageList1.Images.SetKeyName(6, "num3.png");
            imageList1.Images.SetKeyName(7, "num4.png");
            imageList1.Images.SetKeyName(8, "num5.png");
            imageList1.Images.SetKeyName(9, "num6.png");
            imageList1.Images.SetKeyName(10, "num7.png");
            imageList1.Images.SetKeyName(11, "num8.png");
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(scorelbl);
            panel1.Location = new Point(366, 566);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 43);
            panel1.TabIndex = 1;
            // 
            // scorelbl
            // 
            scorelbl.AutoSize = true;
            scorelbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scorelbl.ForeColor = Color.Snow;
            scorelbl.Location = new Point(3, 0);
            scorelbl.Name = "scorelbl";
            scorelbl.Size = new Size(33, 37);
            scorelbl.TabIndex = 0;
            scorelbl.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 566);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 0;
            label1.Text = "Score";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 566);
            button1.Name = "button1";
            button1.Size = new Size(139, 43);
            button1.TabIndex = 1;
            button1.Text = "RESTART";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerlbl
            // 
            timerlbl.AutoSize = true;
            timerlbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerlbl.Location = new Point(230, 9);
            timerlbl.Name = "timerlbl";
            timerlbl.Size = new Size(130, 37);
            timerlbl.TabIndex = 2;
            timerlbl.Text = "Time: 0 s";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 635);
            Controls.Add(timerlbl);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(matrixPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel matrixPanel;
        private ImageList imageList1;
        private Panel panel1;
        private Label scorelbl;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label timerlbl;
    }
}
