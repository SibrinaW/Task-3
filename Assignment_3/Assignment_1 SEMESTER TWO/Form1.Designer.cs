namespace Assignment_1_SEMESTER_TWO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.min_lbl = new System.Windows.Forms.Label();
            this.second_lbl = new System.Windows.Forms.Label();
            this.mili_lbl = new System.Windows.Forms.Label();
            this.colon_lbl = new System.Windows.Forms.Label();
            this.fullstop_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.info_txb = new System.Windows.Forms.TextBox();
            this.unitInfo_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.read_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.scrapCount_lbl = new System.Windows.Forms.Label();
            this.scrapCounter2_lbl = new System.Windows.Forms.Label();
            this.rebels_lbl = new System.Windows.Forms.Label();
            this.helvellic_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Xavier_picb = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.gameName_lbl = new System.Windows.Forms.Label();
            this.battery1_lbl = new System.Windows.Forms.Label();
            this.oil1_lbl = new System.Windows.Forms.Label();
            this.battery2_lbl = new System.Windows.Forms.Label();
            this.oil2_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Xavier_picb)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // min_lbl
            // 
            this.min_lbl.AutoSize = true;
            this.min_lbl.Font = new System.Drawing.Font("Orator Std", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_lbl.Location = new System.Drawing.Point(1036, 174);
            this.min_lbl.Name = "min_lbl";
            this.min_lbl.Size = new System.Drawing.Size(89, 67);
            this.min_lbl.TabIndex = 0;
            this.min_lbl.Text = "00";
            this.min_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // second_lbl
            // 
            this.second_lbl.AutoSize = true;
            this.second_lbl.Font = new System.Drawing.Font("Orator Std", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_lbl.Location = new System.Drawing.Point(1132, 174);
            this.second_lbl.Name = "second_lbl";
            this.second_lbl.Size = new System.Drawing.Size(89, 67);
            this.second_lbl.TabIndex = 1;
            this.second_lbl.Text = "00";
            // 
            // mili_lbl
            // 
            this.mili_lbl.AutoSize = true;
            this.mili_lbl.Font = new System.Drawing.Font("Orator Std", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mili_lbl.Location = new System.Drawing.Point(1219, 197);
            this.mili_lbl.Name = "mili_lbl";
            this.mili_lbl.Size = new System.Drawing.Size(45, 33);
            this.mili_lbl.TabIndex = 2;
            this.mili_lbl.Text = "00";
            // 
            // colon_lbl
            // 
            this.colon_lbl.AutoSize = true;
            this.colon_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon_lbl.Location = new System.Drawing.Point(1105, 174);
            this.colon_lbl.Name = "colon_lbl";
            this.colon_lbl.Size = new System.Drawing.Size(39, 58);
            this.colon_lbl.TabIndex = 3;
            this.colon_lbl.Text = ":";
            // 
            // fullstop_lbl
            // 
            this.fullstop_lbl.AutoSize = true;
            this.fullstop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullstop_lbl.Location = new System.Drawing.Point(1203, 197);
            this.fullstop_lbl.Name = "fullstop_lbl";
            this.fullstop_lbl.Size = new System.Drawing.Size(20, 29);
            this.fullstop_lbl.TabIndex = 5;
            this.fullstop_lbl.Text = ".";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(1046, 235);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(79, 36);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(1131, 235);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(79, 36);
            this.stop_btn.TabIndex = 7;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(1216, 235);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(79, 36);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 20;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.Grid.Location = new System.Drawing.Point(12, 9);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 20;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.Size = new System.Drawing.Size(1003, 1021);
            this.Grid.TabIndex = 9;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Orator Std", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_lbl.Location = new System.Drawing.Point(1035, 104);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(178, 80);
            this.timer_lbl.TabIndex = 10;
            this.timer_lbl.Text = "Time";
            // 
            // info_txb
            // 
            this.info_txb.Font = new System.Drawing.Font("Orator Std", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_txb.Location = new System.Drawing.Point(1623, 63);
            this.info_txb.Multiline = true;
            this.info_txb.Name = "info_txb";
            this.info_txb.Size = new System.Drawing.Size(267, 146);
            this.info_txb.TabIndex = 15;
            // 
            // unitInfo_lbl
            // 
            this.unitInfo_lbl.AutoSize = true;
            this.unitInfo_lbl.Font = new System.Drawing.Font("Orator Std", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitInfo_lbl.Location = new System.Drawing.Point(1550, 9);
            this.unitInfo_lbl.Name = "unitInfo_lbl";
            this.unitInfo_lbl.Size = new System.Drawing.Size(340, 44);
            this.unitInfo_lbl.TabIndex = 16;
            this.unitInfo_lbl.Text = "Unit Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1860, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 17;
            // 
            // read_btn
            // 
            this.read_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_btn.Location = new System.Drawing.Point(1815, 897);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(75, 33);
            this.read_btn.TabIndex = 22;
            this.read_btn.Text = "Read";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(1734, 897);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(77, 33);
            this.save_btn.TabIndex = 21;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // scrapCount_lbl
            // 
            this.scrapCount_lbl.AutoSize = true;
            this.scrapCount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapCount_lbl.Location = new System.Drawing.Point(1138, 352);
            this.scrapCount_lbl.Name = "scrapCount_lbl";
            this.scrapCount_lbl.Size = new System.Drawing.Size(27, 20);
            this.scrapCount_lbl.TabIndex = 24;
            this.scrapCount_lbl.Text = "00";
            this.scrapCount_lbl.Click += new System.EventHandler(this.scrapCount_lbl_Click);
            // 
            // scrapCounter2_lbl
            // 
            this.scrapCounter2_lbl.AutoSize = true;
            this.scrapCounter2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapCounter2_lbl.Location = new System.Drawing.Point(1139, 558);
            this.scrapCounter2_lbl.Name = "scrapCounter2_lbl";
            this.scrapCounter2_lbl.Size = new System.Drawing.Size(27, 20);
            this.scrapCounter2_lbl.TabIndex = 25;
            this.scrapCounter2_lbl.Text = "00";
            this.scrapCounter2_lbl.Click += new System.EventHandler(this.scrapCounter2_lbl_Click);
            // 
            // rebels_lbl
            // 
            this.rebels_lbl.AutoSize = true;
            this.rebels_lbl.Font = new System.Drawing.Font("Orator Std", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebels_lbl.Location = new System.Drawing.Point(1038, 294);
            this.rebels_lbl.Name = "rebels_lbl";
            this.rebels_lbl.Size = new System.Drawing.Size(140, 44);
            this.rebels_lbl.TabIndex = 29;
            this.rebels_lbl.Text = "Rebels";
            // 
            // helvellic_lbl
            // 
            this.helvellic_lbl.AutoSize = true;
            this.helvellic_lbl.Font = new System.Drawing.Font("Orator Std", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helvellic_lbl.Location = new System.Drawing.Point(1038, 496);
            this.helvellic_lbl.Name = "helvellic_lbl";
            this.helvellic_lbl.Size = new System.Drawing.Size(440, 44);
            this.helvellic_lbl.TabIndex = 30;
            this.helvellic_lbl.Text = "Helvellic’s syndicate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1042, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Scrap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1043, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Oil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1042, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Battery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1044, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Battery";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1045, 642);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Oil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1044, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Scrap";
            // 
            // Xavier_picb
            // 
            this.Xavier_picb.ErrorImage = null;
            this.Xavier_picb.Image = ((System.Drawing.Image)(resources.GetObject("Xavier_picb.Image")));
            this.Xavier_picb.Location = new System.Drawing.Point(1224, 475);
            this.Xavier_picb.Name = "Xavier_picb";
            this.Xavier_picb.Size = new System.Drawing.Size(734, 635);
            this.Xavier_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Xavier_picb.TabIndex = 37;
            this.Xavier_picb.TabStop = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Orator Std", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(1400, 912);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(160, 44);
            this.name_lbl.TabIndex = 38;
            this.name_lbl.Text = "Xavier ";
            // 
            // gameName_lbl
            // 
            this.gameName_lbl.AutoSize = true;
            this.gameName_lbl.Font = new System.Drawing.Font("Orator Std", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gameName_lbl.Location = new System.Drawing.Point(1021, -4);
            this.gameName_lbl.Name = "gameName_lbl";
            this.gameName_lbl.Size = new System.Drawing.Size(322, 80);
            this.gameName_lbl.TabIndex = 39;
            this.gameName_lbl.Text = "RO-BOT-S";
            // 
            // battery1_lbl
            // 
            this.battery1_lbl.AutoSize = true;
            this.battery1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battery1_lbl.Location = new System.Drawing.Point(1138, 398);
            this.battery1_lbl.Name = "battery1_lbl";
            this.battery1_lbl.Size = new System.Drawing.Size(27, 20);
            this.battery1_lbl.TabIndex = 40;
            this.battery1_lbl.Text = "00";
            // 
            // oil1_lbl
            // 
            this.oil1_lbl.AutoSize = true;
            this.oil1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oil1_lbl.Location = new System.Drawing.Point(1138, 436);
            this.oil1_lbl.Name = "oil1_lbl";
            this.oil1_lbl.Size = new System.Drawing.Size(27, 20);
            this.oil1_lbl.TabIndex = 41;
            this.oil1_lbl.Text = "00";
            // 
            // battery2_lbl
            // 
            this.battery2_lbl.AutoSize = true;
            this.battery2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battery2_lbl.Location = new System.Drawing.Point(1138, 604);
            this.battery2_lbl.Name = "battery2_lbl";
            this.battery2_lbl.Size = new System.Drawing.Size(27, 20);
            this.battery2_lbl.TabIndex = 42;
            this.battery2_lbl.Text = "00";
            // 
            // oil2_lbl
            // 
            this.oil2_lbl.AutoSize = true;
            this.oil2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oil2_lbl.Location = new System.Drawing.Point(1138, 642);
            this.oil2_lbl.Name = "oil2_lbl";
            this.oil2_lbl.Size = new System.Drawing.Size(27, 20);
            this.oil2_lbl.TabIndex = 43;
            this.oil2_lbl.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.oil2_lbl);
            this.Controls.Add(this.battery2_lbl);
            this.Controls.Add(this.oil1_lbl);
            this.Controls.Add(this.battery1_lbl);
            this.Controls.Add(this.gameName_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helvellic_lbl);
            this.Controls.Add(this.rebels_lbl);
            this.Controls.Add(this.scrapCounter2_lbl);
            this.Controls.Add(this.scrapCount_lbl);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitInfo_lbl);
            this.Controls.Add(this.info_txb);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.fullstop_lbl);
            this.Controls.Add(this.colon_lbl);
            this.Controls.Add(this.mili_lbl);
            this.Controls.Add(this.second_lbl);
            this.Controls.Add(this.min_lbl);
            this.Controls.Add(this.Xavier_picb);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Xavier_picb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label min_lbl;
        private System.Windows.Forms.Label second_lbl;
        private System.Windows.Forms.Label mili_lbl;
        private System.Windows.Forms.Label colon_lbl;
        private System.Windows.Forms.Label fullstop_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Label unitInfo_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.TextBox info_txb;
        public System.Windows.Forms.Label scrapCount_lbl;
        public System.Windows.Forms.Label scrapCounter2_lbl;
        private System.Windows.Forms.Label rebels_lbl;
        private System.Windows.Forms.Label helvellic_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Xavier_picb;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label gameName_lbl;
        public System.Windows.Forms.Label battery1_lbl;
        public System.Windows.Forms.Label oil1_lbl;
        public System.Windows.Forms.Label battery2_lbl;
        public System.Windows.Forms.Label oil2_lbl;
    }
}

