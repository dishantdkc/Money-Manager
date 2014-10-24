namespace mmapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BudgetPnl = new System.Windows.Forms.Panel();
            this.BPSubmit = new System.Windows.Forms.Button();
            this.BPdtto = new System.Windows.Forms.DateTimePicker();
            this.BPdtfrom = new System.Windows.Forms.DateTimePicker();
            this.BPBudget = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLineLable = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.close = new System.Windows.Forms.ToolStripButton();
            this.NewEvnt = new System.Windows.Forms.ToolStripButton();
            this.Reset = new System.Windows.Forms.ToolStripButton();
            this.EvntPnlOtr = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.Rmning = new System.Windows.Forms.Label();
            this.TtlYtLbl = new System.Windows.Forms.Label();
            this.EvntPnlInr = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NewEvntPnl = new System.Windows.Forms.Panel();
            this.NewEvntCancel = new System.Windows.Forms.Button();
            this.NewEvntAddEvnt = new System.Windows.Forms.Button();
            this.NewEvntCat = new System.Windows.Forms.ComboBox();
            this.NewEvntAmt = new System.Windows.Forms.TextBox();
            this.NewEvntMny = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewEvntDt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BudgetPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPBudget)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.EvntPnlOtr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NewEvntPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BudgetPnl
            // 
            this.BudgetPnl.BackColor = System.Drawing.Color.Transparent;
            this.BudgetPnl.Controls.Add(this.BPSubmit);
            this.BudgetPnl.Controls.Add(this.BPdtto);
            this.BudgetPnl.Controls.Add(this.BPdtfrom);
            this.BudgetPnl.Controls.Add(this.BPBudget);
            this.BudgetPnl.Controls.Add(this.checkBox10);
            this.BudgetPnl.Controls.Add(this.checkBox9);
            this.BudgetPnl.Controls.Add(this.checkBox8);
            this.BudgetPnl.Controls.Add(this.checkBox7);
            this.BudgetPnl.Controls.Add(this.checkBox6);
            this.BudgetPnl.Controls.Add(this.checkBox5);
            this.BudgetPnl.Controls.Add(this.checkBox4);
            this.BudgetPnl.Controls.Add(this.checkBox3);
            this.BudgetPnl.Controls.Add(this.checkBox1);
            this.BudgetPnl.Controls.Add(this.checkBox2);
            this.BudgetPnl.Controls.Add(this.label5);
            this.BudgetPnl.Controls.Add(this.label4);
            this.BudgetPnl.Controls.Add(this.label3);
            this.BudgetPnl.Controls.Add(this.label2);
            this.BudgetPnl.Controls.Add(this.label1);
            this.BudgetPnl.Location = new System.Drawing.Point(596, 69);
            this.BudgetPnl.Name = "BudgetPnl";
            this.BudgetPnl.Size = new System.Drawing.Size(22, 26);
            this.BudgetPnl.TabIndex = 1;
            // 
            // BPSubmit
            // 
            this.BPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BPSubmit.Location = new System.Drawing.Point(43, 368);
            this.BPSubmit.Name = "BPSubmit";
            this.BPSubmit.Size = new System.Drawing.Size(75, 23);
            this.BPSubmit.TabIndex = 18;
            this.BPSubmit.Text = "Get Started";
            this.BPSubmit.UseVisualStyleBackColor = true;
            this.BPSubmit.Click += new System.EventHandler(this.BPSubmit_Click);
            // 
            // BPdtto
            // 
            this.BPdtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPdtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BPdtto.Location = new System.Drawing.Point(406, 105);
            this.BPdtto.Name = "BPdtto";
            this.BPdtto.Size = new System.Drawing.Size(126, 26);
            this.BPdtto.TabIndex = 17;
            // 
            // BPdtfrom
            // 
            this.BPdtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPdtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BPdtfrom.Location = new System.Drawing.Point(128, 105);
            this.BPdtfrom.MinDate = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.BPdtfrom.Name = "BPdtfrom";
            this.BPdtfrom.Size = new System.Drawing.Size(126, 26);
            this.BPdtfrom.TabIndex = 17;
            this.BPdtfrom.ValueChanged += new System.EventHandler(this.BPdtfrom_ValueChanged);
            // 
            // BPBudget
            // 
            this.BPBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPBudget.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BPBudget.Location = new System.Drawing.Point(242, 57);
            this.BPBudget.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BPBudget.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BPBudget.Name = "BPBudget";
            this.BPBudget.Size = new System.Drawing.Size(100, 24);
            this.BPBudget.TabIndex = 16;
            this.BPBudget.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(155, 314);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(84, 24);
            this.checkBox10.TabIndex = 6;
            this.checkBox10.Text = "Grocery";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(43, 314);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(98, 24);
            this.checkBox9.TabIndex = 7;
            this.checkBox9.Text = "Acedemic";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(155, 284);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(100, 24);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "Stationary";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(43, 284);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(64, 24);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Fees";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(155, 254);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 24);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Books";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(43, 254);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(96, 24);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Transport";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(155, 224);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(82, 24);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Clothes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(43, 224);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Partys";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(43, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Food";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(155, 194);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(148, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Mobile Recharge";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "This Money Includes Expenses on :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expected/Final\r\nTo Date \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "    From \r\nStarting Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Money You Have : Rs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Your Pocket Money Details";
            // 
            // FirstLineLable
            // 
            this.FirstLineLable.AutoSize = true;
            this.FirstLineLable.BackColor = System.Drawing.Color.Transparent;
            this.FirstLineLable.Font = new System.Drawing.Font("Rockwell Extra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLineLable.Location = new System.Drawing.Point(5, 30);
            this.FirstLineLable.Name = "FirstLineLable";
            this.FirstLineLable.Size = new System.Drawing.Size(44, 17);
            this.FirstLineLable.TabIndex = 2;
            this.FirstLineLable.Text = "amt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close,
            this.NewEvnt,
            this.Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // close
            // 
            this.close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.close.Image = global::mmapp.Properties.Resources.no;
            this.close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 22);
            this.close.Text = "Close App";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // NewEvnt
            // 
            this.NewEvnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewEvnt.Image = global::mmapp.Properties.Resources._new;
            this.NewEvnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewEvnt.Name = "NewEvnt";
            this.NewEvnt.Size = new System.Drawing.Size(23, 22);
            this.NewEvnt.Text = "Add New Event";
            this.NewEvnt.Click += new System.EventHandler(this.NewEvnt_Click);
            // 
            // Reset
            // 
            this.Reset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reset.Image = global::mmapp.Properties.Resources.RiA6Exp9T;
            this.Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(23, 22);
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // EvntPnlOtr
            // 
            this.EvntPnlOtr.BackColor = System.Drawing.Color.Transparent;
            this.EvntPnlOtr.Controls.Add(this.panel1);
            this.EvntPnlOtr.Controls.Add(this.Rmning);
            this.EvntPnlOtr.Controls.Add(this.TtlYtLbl);
            this.EvntPnlOtr.Controls.Add(this.EvntPnlInr);
            this.EvntPnlOtr.Controls.Add(this.label6);
            this.EvntPnlOtr.Controls.Add(this.label12);
            this.EvntPnlOtr.Location = new System.Drawing.Point(7, 61);
            this.EvntPnlOtr.Name = "EvntPnlOtr";
            this.EvntPnlOtr.Size = new System.Drawing.Size(545, 346);
            this.EvntPnlOtr.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.New);
            this.panel1.Location = new System.Drawing.Point(354, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 193);
            this.panel1.TabIndex = 7;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(14, 19);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(115, 23);
            this.New.TabIndex = 0;
            this.New.Text = "Add New Budget";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Rmning
            // 
            this.Rmning.AutoSize = true;
            this.Rmning.BackColor = System.Drawing.Color.Transparent;
            this.Rmning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rmning.Location = new System.Drawing.Point(5, 292);
            this.Rmning.Name = "Rmning";
            this.Rmning.Size = new System.Drawing.Size(0, 20);
            this.Rmning.TabIndex = 5;
            // 
            // TtlYtLbl
            // 
            this.TtlYtLbl.AutoSize = true;
            this.TtlYtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlYtLbl.Location = new System.Drawing.Point(185, 252);
            this.TtlYtLbl.Name = "TtlYtLbl";
            this.TtlYtLbl.Size = new System.Drawing.Size(0, 17);
            this.TtlYtLbl.TabIndex = 6;
            // 
            // EvntPnlInr
            // 
            this.EvntPnlInr.AutoScroll = true;
            this.EvntPnlInr.Location = new System.Drawing.Point(9, 33);
            this.EvntPnlInr.Name = "EvntPnlInr";
            this.EvntPnlInr.Size = new System.Drawing.Size(325, 193);
            this.EvntPnlInr.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sr.      Money       Date          Amount      Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Total Expenditure Yet : Rs";
            // 
            // NewEvntPnl
            // 
            this.NewEvntPnl.BackColor = System.Drawing.Color.Transparent;
            this.NewEvntPnl.Controls.Add(this.NewEvntCancel);
            this.NewEvntPnl.Controls.Add(this.NewEvntAddEvnt);
            this.NewEvntPnl.Controls.Add(this.NewEvntCat);
            this.NewEvntPnl.Controls.Add(this.NewEvntAmt);
            this.NewEvntPnl.Controls.Add(this.NewEvntMny);
            this.NewEvntPnl.Controls.Add(this.label9);
            this.NewEvntPnl.Controls.Add(this.NewEvntDt);
            this.NewEvntPnl.Controls.Add(this.label11);
            this.NewEvntPnl.Controls.Add(this.label10);
            this.NewEvntPnl.Controls.Add(this.label8);
            this.NewEvntPnl.Controls.Add(this.label7);
            this.NewEvntPnl.Location = new System.Drawing.Point(7, 30);
            this.NewEvntPnl.Name = "NewEvntPnl";
            this.NewEvntPnl.Size = new System.Drawing.Size(42, 25);
            this.NewEvntPnl.TabIndex = 0;
            this.NewEvntPnl.Visible = false;
            // 
            // NewEvntCancel
            // 
            this.NewEvntCancel.Location = new System.Drawing.Point(315, 112);
            this.NewEvntCancel.Name = "NewEvntCancel";
            this.NewEvntCancel.Size = new System.Drawing.Size(75, 23);
            this.NewEvntCancel.TabIndex = 4;
            this.NewEvntCancel.Text = "Cancel";
            this.NewEvntCancel.UseVisualStyleBackColor = true;
            this.NewEvntCancel.Click += new System.EventHandler(this.NewEvntCancel_Click);
            // 
            // NewEvntAddEvnt
            // 
            this.NewEvntAddEvnt.Location = new System.Drawing.Point(230, 112);
            this.NewEvntAddEvnt.Name = "NewEvntAddEvnt";
            this.NewEvntAddEvnt.Size = new System.Drawing.Size(75, 23);
            this.NewEvntAddEvnt.TabIndex = 4;
            this.NewEvntAddEvnt.Text = "Save";
            this.NewEvntAddEvnt.UseVisualStyleBackColor = true;
            this.NewEvntAddEvnt.Click += new System.EventHandler(this.NewEvntAddEvnt_Click);
            // 
            // NewEvntCat
            // 
            this.NewEvntCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEvntCat.FormattingEnabled = true;
            this.NewEvntCat.Location = new System.Drawing.Point(84, 109);
            this.NewEvntCat.Name = "NewEvntCat";
            this.NewEvntCat.Size = new System.Drawing.Size(99, 24);
            this.NewEvntCat.TabIndex = 3;
            // 
            // NewEvntAmt
            // 
            this.NewEvntAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEvntAmt.Location = new System.Drawing.Point(271, 56);
            this.NewEvntAmt.Name = "NewEvntAmt";
            this.NewEvntAmt.Size = new System.Drawing.Size(100, 23);
            this.NewEvntAmt.TabIndex = 2;
            // 
            // NewEvntMny
            // 
            this.NewEvntMny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEvntMny.FormattingEnabled = true;
            this.NewEvntMny.Items.AddRange(new object[] {
            "Recieved",
            "Spend"});
            this.NewEvntMny.Location = new System.Drawing.Point(71, 53);
            this.NewEvntMny.Name = "NewEvntMny";
            this.NewEvntMny.Size = new System.Drawing.Size(102, 24);
            this.NewEvntMny.TabIndex = 1;
            this.NewEvntMny.SelectedIndexChanged += new System.EventHandler(this.NewEvntMny_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount : Rs.";
            // 
            // NewEvntDt
            // 
            this.NewEvntDt.AutoSize = true;
            this.NewEvntDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEvntDt.Location = new System.Drawing.Point(296, 21);
            this.NewEvntDt.Name = "NewEvntDt";
            this.NewEvntDt.Size = new System.Drawing.Size(0, 17);
            this.NewEvntDt.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Event";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::mmapp.Properties.Resources.bck4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 436);
            this.ControlBox = false;
            this.Controls.Add(this.NewEvntPnl);
            this.Controls.Add(this.BudgetPnl);
            this.Controls.Add(this.EvntPnlOtr);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.FirstLineLable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BudgetPnl.ResumeLayout(false);
            this.BudgetPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPBudget)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.EvntPnlOtr.ResumeLayout(false);
            this.EvntPnlOtr.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.NewEvntPnl.ResumeLayout(false);
            this.NewEvntPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BudgetPnl;
        private System.Windows.Forms.NumericUpDown BPBudget;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BPdtfrom;
        private System.Windows.Forms.DateTimePicker BPdtto;
        private System.Windows.Forms.Button BPSubmit;
        private System.Windows.Forms.Label FirstLineLable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton close;
        private System.Windows.Forms.Panel EvntPnlOtr;
        private System.Windows.Forms.Panel EvntPnlInr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton NewEvnt;
        private System.Windows.Forms.Panel NewEvntPnl;
        private System.Windows.Forms.Button NewEvntAddEvnt;
        private System.Windows.Forms.ComboBox NewEvntCat;
        private System.Windows.Forms.TextBox NewEvntAmt;
        private System.Windows.Forms.ComboBox NewEvntMny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NewEvntDt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NewEvntCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TtlYtLbl;
        private System.Windows.Forms.Label Rmning;
        private System.Windows.Forms.ToolStripButton Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button New;


    }
}

