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
            textAutora = new Label();
            MonkeyImage2 = new PictureBox();
            NejlepsiBlazen = new PictureBox();
            NejlepsiBlazen2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MonkeyImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonkeyImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NejlepsiBlazen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NejlepsiBlazen2).BeginInit();
            SuspendLayout();
            // 
            // Test
            // 
            Test.Anchor = AnchorStyles.None;
            Test.BackColor = Color.Lime;
            Test.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Test.Location = new Point(445, 355);
            Test.Margin = new Padding(3, 4, 3, 4);
            Test.MaximumSize = new Size(602, 110);
            Test.Name = "Test";
            Test.Size = new Size(474, 110);
            Test.TabIndex = 4;
            Test.Text = "Začít test";
            Test.UseVisualStyleBackColor = false;
            Test.Click += button2_Click_1;
            // 
            // Otazka
            // 
            Otazka.Anchor = AnchorStyles.None;
            Otazka.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Otazka.Location = new Point(12, 108);
            Otazka.Name = "Otazka";
            Otazka.Size = new Size(1384, 193);
            Otazka.TabIndex = 6;
            Otazka.Text = "Venku je zima a ty musíš jít ven, co si na sebe vezmeš abys měl co největší jistotu, že ti bude teplo?";
            Otazka.TextAlign = ContentAlignment.MiddleCenter;
            Otazka.Click += label1_Click;
            // 
            // ApplicationEnd
            // 
            ApplicationEnd.Anchor = AnchorStyles.None;
            ApplicationEnd.BackColor = Color.LimeGreen;
            ApplicationEnd.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApplicationEnd.Location = new Point(445, 674);
            ApplicationEnd.Margin = new Padding(3, 4, 3, 4);
            ApplicationEnd.MaximumSize = new Size(602, 110);
            ApplicationEnd.Name = "ApplicationEnd";
            ApplicationEnd.Size = new Size(474, 110);
            ApplicationEnd.TabIndex = 8;
            ApplicationEnd.Text = "Ukončit program";
            ApplicationEnd.UseVisualStyleBackColor = false;
            ApplicationEnd.Click += ApplicationEnd_Click;
            // 
            // OdpovedA
            // 
            OdpovedA.Anchor = AnchorStyles.None;
            OdpovedA.BackColor = Color.Lime;
            OdpovedA.Font = new Font("Arial Narrow", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            OdpovedA.Location = new Point(445, 305);
            OdpovedA.Margin = new Padding(3, 4, 3, 4);
            OdpovedA.MaximumSize = new Size(602, 160);
            OdpovedA.Name = "OdpovedA";
            OdpovedA.Size = new Size(474, 160);
            OdpovedA.TabIndex = 9;
            OdpovedA.Text = "Župan";
            OdpovedA.UseVisualStyleBackColor = false;
            OdpovedA.Click += OdpovedA_Click;
            // 
            // OdpovedB
            // 
            OdpovedB.Anchor = AnchorStyles.None;
            OdpovedB.BackColor = Color.Lime;
            OdpovedB.Font = new Font("Arial Narrow", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            OdpovedB.Location = new Point(445, 473);
            OdpovedB.Margin = new Padding(3, 4, 3, 4);
            OdpovedB.MaximumSize = new Size(602, 160);
            OdpovedB.Name = "OdpovedB";
            OdpovedB.Size = new Size(474, 160);
            OdpovedB.TabIndex = 10;
            OdpovedB.Text = "Velmi roztrhanou a velmi děravou bundu";
            OdpovedB.UseVisualStyleBackColor = false;
            OdpovedB.Click += OdpovedB_Click;
            // 
            // OdpovedC
            // 
            OdpovedC.Anchor = AnchorStyles.None;
            OdpovedC.BackColor = Color.Lime;
            OdpovedC.Font = new Font("Arial Narrow", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            OdpovedC.Location = new Point(445, 641);
            OdpovedC.Margin = new Padding(3, 4, 3, 4);
            OdpovedC.MaximumSize = new Size(602, 160);
            OdpovedC.Name = "OdpovedC";
            OdpovedC.Size = new Size(474, 160);
            OdpovedC.TabIndex = 11;
            OdpovedC.Text = "Doktorský plášť";
            OdpovedC.UseVisualStyleBackColor = false;
            OdpovedC.Click += OdpovedC_Click;
            // 
            // OdpovedD
            // 
            OdpovedD.Anchor = AnchorStyles.None;
            OdpovedD.BackColor = Color.Lime;
            OdpovedD.Font = new Font("Arial Narrow", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            OdpovedD.Location = new Point(445, 808);
            OdpovedD.MaximumSize = new Size(602, 160);
            OdpovedD.Name = "OdpovedD";
            OdpovedD.Size = new Size(474, 160);
            OdpovedD.TabIndex = 12;
            OdpovedD.Text = "Pytel od brambor";
            OdpovedD.UseVisualStyleBackColor = false;
            OdpovedD.Click += OdpovedD_Click;
            // 
            // MonkeyImage
            // 
            MonkeyImage.Anchor = AnchorStyles.None;
            MonkeyImage.BackgroundImage = (Image)resources.GetObject("MonkeyImage.BackgroundImage");
            MonkeyImage.BackgroundImageLayout = ImageLayout.Stretch;
            MonkeyImage.Location = new Point(27, 310);
            MonkeyImage.Name = "MonkeyImage";
            MonkeyImage.Size = new Size(412, 475);
            MonkeyImage.TabIndex = 13;
            MonkeyImage.TabStop = false;
            // 
            // textAutora
            // 
            textAutora.Anchor = AnchorStyles.None;
            textAutora.Font = new Font("BernhardTango BT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textAutora.Location = new Point(860, 788);
            textAutora.Name = "textAutora";
            textAutora.Size = new Size(716, 69);
            textAutora.TabIndex = 14;
            textAutora.Text = "Autor programu: Vladimír Šamansky aka Dominik Rozporka";
            textAutora.Click += textAutora_Click;
            // 
            // MonkeyImage2
            // 
            MonkeyImage2.Anchor = AnchorStyles.None;
            MonkeyImage2.BackgroundImage = (Image)resources.GetObject("MonkeyImage2.BackgroundImage");
            MonkeyImage2.BackgroundImageLayout = ImageLayout.Stretch;
            MonkeyImage2.Location = new Point(925, 310);
            MonkeyImage2.Name = "MonkeyImage2";
            MonkeyImage2.Size = new Size(412, 475);
            MonkeyImage2.TabIndex = 15;
            MonkeyImage2.TabStop = false;
            // 
            // NejlepsiBlazen
            // 
            NejlepsiBlazen.Anchor = AnchorStyles.None;
            NejlepsiBlazen.BackgroundImage = (Image)resources.GetObject("NejlepsiBlazen.BackgroundImage");
            NejlepsiBlazen.BackgroundImageLayout = ImageLayout.Stretch;
            NejlepsiBlazen.Location = new Point(27, 310);
            NejlepsiBlazen.Name = "NejlepsiBlazen";
            NejlepsiBlazen.Size = new Size(412, 474);
            NejlepsiBlazen.TabIndex = 16;
            NejlepsiBlazen.TabStop = false;
            // 
            // NejlepsiBlazen2
            // 
            NejlepsiBlazen2.Anchor = AnchorStyles.None;
            NejlepsiBlazen2.BackgroundImage = (Image)resources.GetObject("NejlepsiBlazen2.BackgroundImage");
            NejlepsiBlazen2.BackgroundImageLayout = ImageLayout.Stretch;
            NejlepsiBlazen2.Location = new Point(925, 311);
            NejlepsiBlazen2.Name = "NejlepsiBlazen2";
            NejlepsiBlazen2.Size = new Size(412, 474);
            NejlepsiBlazen2.TabIndex = 17;
            NejlepsiBlazen2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1408, 978);
            Controls.Add(NejlepsiBlazen2);
            Controls.Add(NejlepsiBlazen);
            Controls.Add(MonkeyImage2);
            Controls.Add(textAutora);
            Controls.Add(OdpovedD);
            Controls.Add(OdpovedC);
            Controls.Add(OdpovedB);
            Controls.Add(OdpovedA);
            Controls.Add(ApplicationEnd);
            Controls.Add(Otazka);
            Controls.Add(Test);
            Controls.Add(MonkeyImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)MonkeyImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NejlepsiBlazen).EndInit();
            ((System.ComponentModel.ISupportInitialize)NejlepsiBlazen2).EndInit();
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
        private Label textAutora;
        private PictureBox MonkeyImage2;
        private PictureBox NejlepsiBlazen;
        private PictureBox NejlepsiBlazen2;
    }
}