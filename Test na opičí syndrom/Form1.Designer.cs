namespace Test_na_opičí_syndrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Test = new Button();
            Otazka = new Label();
            ApplicationEnd = new Button();
            OdpovedA = new Button();
            OdpovedB = new Button();
            OdpovedC = new Button();
            OdpovedD = new Button();
            MonkeyImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MonkeyImage).BeginInit();
            SuspendLayout();
            // 
            // Test
            // 
            Test.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Test.BackColor = Color.Lime;
            Test.Location = new Point(1522, 756);
            Test.Margin = new Padding(3, 4, 3, 4);
            Test.MaximumSize = new Size(602, 110);
            Test.Name = "Test";
            Test.Size = new Size(602, 110);
            Test.TabIndex = 4;
            Test.Text = "Začít test";
            Test.UseVisualStyleBackColor = false;
            Test.Click += button2_Click_1;
            // 
            // Otazka
            // 
            Otazka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Otazka.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            Otazka.Location = new Point(299, 212);
            Otazka.Name = "Otazka";
            Otazka.Size = new Size(3110, 344);
            Otazka.TabIndex = 6;
            Otazka.Text = "Venku je zima a ty musíš jít ven, co si na sebe vezmeš abys měl co největší jistotu, že ti bude teplo?";
            Otazka.TextAlign = ContentAlignment.MiddleCenter;
            Otazka.Click += label1_Click;
            // 
            // ApplicationEnd
            // 
            ApplicationEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ApplicationEnd.BackColor = Color.LimeGreen;
            ApplicationEnd.Location = new Point(1522, 964);
            ApplicationEnd.Margin = new Padding(3, 4, 3, 4);
            ApplicationEnd.MaximumSize = new Size(602, 110);
            ApplicationEnd.Name = "ApplicationEnd";
            ApplicationEnd.Size = new Size(602, 110);
            ApplicationEnd.TabIndex = 8;
            ApplicationEnd.Text = "Ukončit program";
            ApplicationEnd.UseVisualStyleBackColor = false;
            ApplicationEnd.Click += ApplicationEnd_Click;
            // 
            // OdpovedA
            // 
            OdpovedA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OdpovedA.BackColor = Color.Lime;
            OdpovedA.Location = new Point(1522, 671);
            OdpovedA.Margin = new Padding(3, 4, 3, 4);
            OdpovedA.MaximumSize = new Size(602, 160);
            OdpovedA.Name = "OdpovedA";
            OdpovedA.Size = new Size(602, 160);
            OdpovedA.TabIndex = 9;
            OdpovedA.Text = "Župan";
            OdpovedA.UseVisualStyleBackColor = false;
            OdpovedA.Click += OdpovedA_Click;
            // 
            // OdpovedB
            // 
            OdpovedB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OdpovedB.BackColor = Color.Lime;
            OdpovedB.Location = new Point(1522, 849);
            OdpovedB.Margin = new Padding(3, 4, 3, 4);
            OdpovedB.MaximumSize = new Size(602, 160);
            OdpovedB.Name = "OdpovedB";
            OdpovedB.Size = new Size(602, 160);
            OdpovedB.TabIndex = 10;
            OdpovedB.Text = "Velmi roztrhanou a velmi děravou bundu";
            OdpovedB.UseVisualStyleBackColor = false;
            OdpovedB.Click += OdpovedB_Click;
            // 
            // OdpovedC
            // 
            OdpovedC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OdpovedC.BackColor = Color.Lime;
            OdpovedC.Location = new Point(1522, 1026);
            OdpovedC.Margin = new Padding(3, 4, 3, 4);
            OdpovedC.MaximumSize = new Size(602, 160);
            OdpovedC.Name = "OdpovedC";
            OdpovedC.Size = new Size(602, 160);
            OdpovedC.TabIndex = 11;
            OdpovedC.Text = "Doktorský plášť";
            OdpovedC.UseVisualStyleBackColor = false;
            OdpovedC.Click += OdpovedC_Click;
            // 
            // OdpovedD
            // 
            OdpovedD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OdpovedD.BackColor = Color.Lime;
            OdpovedD.Location = new Point(1522, 1202);
            OdpovedD.MaximumSize = new Size(602, 160);
            OdpovedD.Name = "OdpovedD";
            OdpovedD.Size = new Size(602, 160);
            OdpovedD.TabIndex = 12;
            OdpovedD.Text = "Pytel od brambor";
            OdpovedD.UseVisualStyleBackColor = false;
            OdpovedD.Click += OdpovedD_Click;
            // 
            // MonkeyImage
            // 
            MonkeyImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MonkeyImage.BackgroundImage = (Image)resources.GetObject("MonkeyImage.BackgroundImage");
            MonkeyImage.BackgroundImageLayout = ImageLayout.Stretch;
            MonkeyImage.Location = new Point(299, 671);
            MonkeyImage.Name = "MonkeyImage";
            MonkeyImage.Size = new Size(972, 691);
            MonkeyImage.TabIndex = 13;
            MonkeyImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(3622, 2049);
            Controls.Add(OdpovedD);
            Controls.Add(OdpovedC);
            Controls.Add(OdpovedB);
            Controls.Add(OdpovedA);
            Controls.Add(ApplicationEnd);
            Controls.Add(Otazka);
            Controls.Add(Test);
            Controls.Add(MonkeyImage);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test na Opičí syndrom";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MonkeyImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Test;
        private Label Otazka;
        private Button ApplicationEnd;
        private Button OdpovedA;
        private Button OdpovedB;
        private Button OdpovedC;
        private Button OdpovedD;
        private PictureBox MonkeyImage;
    }
}