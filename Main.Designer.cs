namespace RegistryTool
{
    // Token: 0x02000002 RID: 2
    public partial class Main : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disablelastun = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton4 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton5 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton6 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton7 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton10 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton11 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton8 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton9 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton12 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton13 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(810, 5);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(749, 5);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "RegistryTool";
            // 
            // disablelastun
            // 
            this.disablelastun.BorderColor = System.Drawing.Color.DodgerBlue;
            this.disablelastun.BorderThickness = 1;
            this.disablelastun.CheckedState.Parent = this.disablelastun;
            this.disablelastun.CustomImages.Parent = this.disablelastun;
            this.siticoneTransition1.SetDecoration(this.disablelastun, Siticone.UI.AnimatorNS.DecorationType.None);
            this.disablelastun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.disablelastun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disablelastun.ForeColor = System.Drawing.Color.White;
            this.disablelastun.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.disablelastun.HoveredState.Parent = this.disablelastun;
            this.disablelastun.Location = new System.Drawing.Point(228, 99);
            this.disablelastun.Margin = new System.Windows.Forms.Padding(4);
            this.disablelastun.Name = "disablelastun";
            this.disablelastun.ShadowDecoration.Parent = this.disablelastun;
            this.disablelastun.Size = new System.Drawing.Size(201, 34);
            this.disablelastun.TabIndex = 26;
            this.disablelastun.Text = "Disable";
            this.disablelastun.Click += new System.EventHandler(this.disablelastun_Click);
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(451, 99);
            this.siticoneRoundedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton1.TabIndex = 34;
            this.siticoneRoundedButton1.Text = "Enable";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(308, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Display User at Windows Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(308, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Windows menu open delay";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(451, 202);
            this.siticoneRoundedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton2.TabIndex = 38;
            this.siticoneRoundedButton2.Text = "Set tp 400ms (default)";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton3.BorderThickness = 1;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(228, 202);
            this.siticoneRoundedButton3.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton3.TabIndex = 37;
            this.siticoneRoundedButton3.Text = "Set to 50ms";
            this.siticoneRoundedButton3.Click += new System.EventHandler(this.siticoneRoundedButton3_Click);
            // 
            // siticoneRoundedButton4
            // 
            this.siticoneRoundedButton4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton4.BorderThickness = 1;
            this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Location = new System.Drawing.Point(451, 305);
            this.siticoneRoundedButton4.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
            this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton4.TabIndex = 41;
            this.siticoneRoundedButton4.Text = "Hide";
            this.siticoneRoundedButton4.Click += new System.EventHandler(this.siticoneRoundedButton4_Click);
            // 
            // siticoneRoundedButton5
            // 
            this.siticoneRoundedButton5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton5.BorderThickness = 1;
            this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton5.HoveredState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Location = new System.Drawing.Point(228, 305);
            this.siticoneRoundedButton5.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
            this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton5.TabIndex = 40;
            this.siticoneRoundedButton5.Text = "Show";
            this.siticoneRoundedButton5.Click += new System.EventHandler(this.siticoneRoundedButton5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(223, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Seconds at taskbar clock (not working on windows 11)";
            // 
            // siticoneRoundedButton6
            // 
            this.siticoneRoundedButton6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton6.BorderThickness = 1;
            this.siticoneRoundedButton6.CheckedState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.CustomImages.Parent = this.siticoneRoundedButton6;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton6.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton6.HoveredState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Location = new System.Drawing.Point(228, 412);
            this.siticoneRoundedButton6.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton6.Name = "siticoneRoundedButton6";
            this.siticoneRoundedButton6.ShadowDecoration.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton6.TabIndex = 44;
            this.siticoneRoundedButton6.Text = "Disallow";
            this.siticoneRoundedButton6.Click += new System.EventHandler(this.siticoneRoundedButton6_Click);
            // 
            // siticoneRoundedButton7
            // 
            this.siticoneRoundedButton7.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton7.BorderThickness = 1;
            this.siticoneRoundedButton7.CheckedState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.CustomImages.Parent = this.siticoneRoundedButton7;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton7.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton7.HoveredState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Location = new System.Drawing.Point(451, 412);
            this.siticoneRoundedButton7.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton7.Name = "siticoneRoundedButton7";
            this.siticoneRoundedButton7.ShadowDecoration.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton7.TabIndex = 43;
            this.siticoneRoundedButton7.Text = "Allow";
            this.siticoneRoundedButton7.Click += new System.EventHandler(this.siticoneRoundedButton7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(335, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Shake Window to minimize";
            // 
            // siticoneRoundedButton10
            // 
            this.siticoneRoundedButton10.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton10.BorderThickness = 1;
            this.siticoneRoundedButton10.CheckedState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.CustomImages.Parent = this.siticoneRoundedButton10;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton10.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton10.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton10.HoveredState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Location = new System.Drawing.Point(220, 517);
            this.siticoneRoundedButton10.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton10.Name = "siticoneRoundedButton10";
            this.siticoneRoundedButton10.ShadowDecoration.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton10.TabIndex = 50;
            this.siticoneRoundedButton10.Text = "Enable";
            this.siticoneRoundedButton10.Click += new System.EventHandler(this.siticoneRoundedButton10_Click);
            // 
            // siticoneRoundedButton11
            // 
            this.siticoneRoundedButton11.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton11.BorderThickness = 1;
            this.siticoneRoundedButton11.CheckedState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.CustomImages.Parent = this.siticoneRoundedButton11;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton11.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton11.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton11.HoveredState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Location = new System.Drawing.Point(443, 517);
            this.siticoneRoundedButton11.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton11.Name = "siticoneRoundedButton11";
            this.siticoneRoundedButton11.ShadowDecoration.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton11.TabIndex = 49;
            this.siticoneRoundedButton11.Text = "Disable";
            this.siticoneRoundedButton11.Click += new System.EventHandler(this.siticoneRoundedButton11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(300, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Clear Page file at shutdown";
            // 
            // siticoneRoundedButton8
            // 
            this.siticoneRoundedButton8.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton8.BorderThickness = 1;
            this.siticoneRoundedButton8.CheckedState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.CustomImages.Parent = this.siticoneRoundedButton8;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton8.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton8.HoveredState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Location = new System.Drawing.Point(220, 622);
            this.siticoneRoundedButton8.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton8.Name = "siticoneRoundedButton8";
            this.siticoneRoundedButton8.ShadowDecoration.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton8.TabIndex = 53;
            this.siticoneRoundedButton8.Text = "Enable";
            this.siticoneRoundedButton8.Click += new System.EventHandler(this.siticoneRoundedButton8_Click);
            // 
            // siticoneRoundedButton9
            // 
            this.siticoneRoundedButton9.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton9.BorderThickness = 1;
            this.siticoneRoundedButton9.CheckedState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.CustomImages.Parent = this.siticoneRoundedButton9;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton9.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton9.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton9.HoveredState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Location = new System.Drawing.Point(443, 622);
            this.siticoneRoundedButton9.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton9.Name = "siticoneRoundedButton9";
            this.siticoneRoundedButton9.ShadowDecoration.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton9.TabIndex = 52;
            this.siticoneRoundedButton9.Text = "Disable";
            this.siticoneRoundedButton9.Click += new System.EventHandler(this.siticoneRoundedButton9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(347, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Old Volume Control";
            // 
            // siticoneRoundedButton12
            // 
            this.siticoneRoundedButton12.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton12.BorderThickness = 1;
            this.siticoneRoundedButton12.CheckedState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.CustomImages.Parent = this.siticoneRoundedButton12;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton12.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton12.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton12.HoveredState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Location = new System.Drawing.Point(443, 712);
            this.siticoneRoundedButton12.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton12.Name = "siticoneRoundedButton12";
            this.siticoneRoundedButton12.ShadowDecoration.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton12.TabIndex = 56;
            this.siticoneRoundedButton12.Text = "Enable";
            this.siticoneRoundedButton12.Click += new System.EventHandler(this.siticoneRoundedButton12_Click);
            // 
            // siticoneRoundedButton13
            // 
            this.siticoneRoundedButton13.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton13.BorderThickness = 1;
            this.siticoneRoundedButton13.CheckedState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.CustomImages.Parent = this.siticoneRoundedButton13;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton13.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton13.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton13.HoveredState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Location = new System.Drawing.Point(220, 712);
            this.siticoneRoundedButton13.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton13.Name = "siticoneRoundedButton13";
            this.siticoneRoundedButton13.ShadowDecoration.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Size = new System.Drawing.Size(201, 34);
            this.siticoneRoundedButton13.TabIndex = 55;
            this.siticoneRoundedButton13.Text = "Disable";
            this.siticoneRoundedButton13.Click += new System.EventHandler(this.siticoneRoundedButton13_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(308, 675);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Bing results in Windows Search";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(876, 782);
            this.Controls.Add(this.siticoneRoundedButton12);
            this.Controls.Add(this.siticoneRoundedButton13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.siticoneRoundedButton8);
            this.Controls.Add(this.siticoneRoundedButton9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.siticoneRoundedButton10);
            this.Controls.Add(this.siticoneRoundedButton11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.siticoneRoundedButton6);
            this.Controls.Add(this.siticoneRoundedButton7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.siticoneRoundedButton4);
            this.Controls.Add(this.siticoneRoundedButton5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.siticoneRoundedButton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disablelastun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneRoundedButton disablelastun;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton6;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton7;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton10;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton11;
        private System.Windows.Forms.Label label8;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton8;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton9;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton12;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton13;
        private System.Windows.Forms.Label label9;
    }
}
