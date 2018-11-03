namespace WindowsFormsApp5
{
    partial class UserControl1
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelprogress = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labeltarget = new System.Windows.Forms.Label();
            this.labelcreated = new System.Windows.Forms.Label();
            this.labelkategori = new System.Windows.Forms.Label();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.progressbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelprority = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.progressbar);
            this.panel1.Controls.Add(this.labeltext);
            this.panel1.Controls.Add(this.bunifuCheckBox1);
            this.panel1.Controls.Add(this.labelprogress);
            this.panel1.Controls.Add(this.labeltarget);
            this.panel1.Controls.Add(this.labelcreated);
            this.panel1.Controls.Add(this.labelkategori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 79);
            this.panel1.TabIndex = 0;
            // 
            // labelprogress
            // 
            this.labelprogress.AutoSize = true;
            this.labelprogress.BackColor = System.Drawing.Color.Transparent;
            this.labelprogress.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelprogress.ForeColor = System.Drawing.Color.Gray;
            this.labelprogress.Location = new System.Drawing.Point(894, 24);
            this.labelprogress.Name = "labelprogress";
            this.labelprogress.Size = new System.Drawing.Size(76, 14);
            this.labelprogress.TabIndex = 22;
            this.labelprogress.Text = "PROGRESS";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.BackColor = System.Drawing.Color.Transparent;
            this.labelage.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelage.ForeColor = System.Drawing.Color.White;
            this.labelage.Location = new System.Drawing.Point(12, 10);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(12, 14);
            this.labelage.TabIndex = 21;
            this.labelage.Text = "1";
            // 
            // labeltarget
            // 
            this.labeltarget.AutoSize = true;
            this.labeltarget.BackColor = System.Drawing.Color.Transparent;
            this.labeltarget.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarget.ForeColor = System.Drawing.Color.Gray;
            this.labeltarget.Location = new System.Drawing.Point(667, 31);
            this.labeltarget.Name = "labeltarget";
            this.labeltarget.Size = new System.Drawing.Size(56, 14);
            this.labeltarget.TabIndex = 20;
            this.labeltarget.Text = "TARGET";
            // 
            // labelcreated
            // 
            this.labelcreated.AutoSize = true;
            this.labelcreated.BackColor = System.Drawing.Color.Transparent;
            this.labelcreated.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcreated.ForeColor = System.Drawing.Color.Gray;
            this.labelcreated.Location = new System.Drawing.Point(504, 31);
            this.labelcreated.Name = "labelcreated";
            this.labelcreated.Size = new System.Drawing.Size(87, 14);
            this.labelcreated.TabIndex = 19;
            this.labelcreated.Text = "CREATED ON";
            // 
            // labelkategori
            // 
            this.labelkategori.AutoSize = true;
            this.labelkategori.BackColor = System.Drawing.Color.Transparent;
            this.labelkategori.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkategori.ForeColor = System.Drawing.Color.Gray;
            this.labelkategori.Location = new System.Drawing.Point(78, 17);
            this.labelkategori.Name = "labelkategori";
            this.labelkategori.Size = new System.Drawing.Size(47, 14);
            this.labelkategori.TabIndex = 17;
            this.labelkategori.Text = "TITTLE";
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControl = null;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.Checked = false;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(17, 24);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 23;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.BackColor = System.Drawing.Color.Transparent;
            this.labeltext.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltext.ForeColor = System.Drawing.Color.Gray;
            this.labeltext.Location = new System.Drawing.Point(78, 45);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(47, 14);
            this.labeltext.TabIndex = 24;
            this.labeltext.Text = "TITTLE";
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.Silver;
            this.progressbar.BorderRadius = 5;
            this.progressbar.Location = new System.Drawing.Point(897, 42);
            this.progressbar.MaximumValue = 100;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(226)))));
            this.progressbar.Size = new System.Drawing.Size(183, 10);
            this.progressbar.TabIndex = 25;
            this.progressbar.Value = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelage);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(800, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 34);
            this.panel2.TabIndex = 26;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelprority);
            this.panel3.Location = new System.Drawing.Point(323, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 34);
            this.panel3.TabIndex = 27;
            // 
            // labelprority
            // 
            this.labelprority.AutoSize = true;
            this.labelprority.BackColor = System.Drawing.Color.Transparent;
            this.labelprority.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelprority.Location = new System.Drawing.Point(25, 8);
            this.labelprority.Name = "labelprority";
            this.labelprority.Size = new System.Drawing.Size(45, 16);
            this.labelprority.TabIndex = 0;
            this.labelprority.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1100, 94);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuProgressBar progressbar;
        public System.Windows.Forms.Label labeltext;
        public Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        public System.Windows.Forms.Label labelprogress;
        public System.Windows.Forms.Label labeltarget;
        public System.Windows.Forms.Label labelcreated;
        public System.Windows.Forms.Label labelkategori;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelprority;
        public System.Windows.Forms.Label labelage;
    }
}
