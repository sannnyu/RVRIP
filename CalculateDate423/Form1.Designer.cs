﻿namespace CalculateDate423
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2_Fac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1_Generate = new System.Windows.Forms.Button();
            this.textBox1_DBG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NextDep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NextFac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1_Produce = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_SealSpan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox1_CurrentTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_Dep = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBatch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(207, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 124);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 30;
            this.listBox2.Location = new System.Drawing.Point(21, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(151, 454);
            this.listBox2.TabIndex = 1;
            this.listBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "包含车型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(203, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "车辆类型选择：";
            // 
            // dateTimePicker2_Fac
            // 
            this.dateTimePicker2_Fac.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2_Fac.CustomFormat = "";
            this.dateTimePicker2_Fac.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2_Fac.Location = new System.Drawing.Point(207, 342);
            this.dateTimePicker2_Fac.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2_Fac.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2_Fac.Name = "dateTimePicker2_Fac";
            this.dateTimePicker2_Fac.Size = new System.Drawing.Size(249, 34);
            this.dateTimePicker2_Fac.TabIndex = 2;
            this.dateTimePicker2_Fac.Value = new System.DateTime(2014, 2, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(203, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "前次厂修时间：";
            // 
            // button1_Generate
            // 
            this.button1_Generate.Location = new System.Drawing.Point(897, 298);
            this.button1_Generate.Name = "button1_Generate";
            this.button1_Generate.Size = new System.Drawing.Size(136, 56);
            this.button1_Generate.TabIndex = 8;
            this.button1_Generate.Text = "生成";
            this.button1_Generate.UseVisualStyleBackColor = true;
            this.button1_Generate.Click += new System.EventHandler(this.button1_Generate_Click);
            // 
            // textBox1_DBG
            // 
            this.textBox1_DBG.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1_DBG.Location = new System.Drawing.Point(487, 71);
            this.textBox1_DBG.Multiline = true;
            this.textBox1_DBG.Name = "textBox1_DBG";
            this.textBox1_DBG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_DBG.Size = new System.Drawing.Size(534, 124);
            this.textBox1_DBG.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(483, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "提示信息：";
            // 
            // textBox_NextDep
            // 
            this.textBox_NextDep.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox_NextDep.Location = new System.Drawing.Point(20, 62);
            this.textBox_NextDep.Name = "textBox_NextDep";
            this.textBox_NextDep.Size = new System.Drawing.Size(249, 34);
            this.textBox_NextDep.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "下次段修时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(288, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "下次厂修时间：";
            // 
            // textBox_NextFac
            // 
            this.textBox_NextFac.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox_NextFac.Location = new System.Drawing.Point(292, 62);
            this.textBox_NextFac.Name = "textBox_NextFac";
            this.textBox_NextFac.Size = new System.Drawing.Size(249, 34);
            this.textBox_NextFac.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(203, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "制造日期";
            // 
            // dateTimePicker1_Produce
            // 
            this.dateTimePicker1_Produce.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_Produce.CustomFormat = "";
            this.dateTimePicker1_Produce.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_Produce.Location = new System.Drawing.Point(207, 250);
            this.dateTimePicker1_Produce.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1_Produce.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1_Produce.Name = "dateTimePicker1_Produce";
            this.dateTimePicker1_Produce.Size = new System.Drawing.Size(249, 34);
            this.dateTimePicker1_Produce.TabIndex = 1;
            this.dateTimePicker1_Produce.Value = new System.DateTime(2005, 2, 1, 0, 0, 0, 0);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 576);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(988, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(17, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "修程进度：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(12, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "|前次厂修";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(174, 599);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "|一次段修";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(338, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "|二次段修";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(503, 599);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "|三次段修";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(998, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "|下次厂修";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(668, 599);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "|四次段修";
            // 
            // textBox_SealSpan
            // 
            this.textBox_SealSpan.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox_SealSpan.Location = new System.Drawing.Point(488, 252);
            this.textBox_SealSpan.Name = "textBox_SealSpan";
            this.textBox_SealSpan.Size = new System.Drawing.Size(249, 32);
            this.textBox_SealSpan.TabIndex = 4;
            this.textBox_SealSpan.Text = "0";
            this.textBox_SealSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SealSpan_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(484, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(490, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "封存备用期（可选）";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(257, 555);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "|1次段修";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(504, 556);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "|2次段修";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(750, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "|3次段修";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(832, 599);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "|五次段修";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 33F);
            this.label22.ForeColor = System.Drawing.Color.Teal;
            this.label22.Location = new System.Drawing.Point(588, 521);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 55);
            this.label22.TabIndex = 31;
            this.label22.Text = "|";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("宋体", 33F);
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(786, 600);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 48);
            this.label23.TabIndex = 32;
            this.label23.Text = "|";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.Teal;
            this.label24.Location = new System.Drawing.Point(618, 527);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 20);
            this.label24.TabIndex = 33;
            this.label24.Text = "三次段修";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.Teal;
            this.label25.Location = new System.Drawing.Point(818, 627);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 20);
            this.label25.TabIndex = 34;
            this.label25.Text = "加强段修";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(174, 622);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 20);
            this.label26.TabIndex = 35;
            this.label26.Text = "（通用60t）";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label27.Location = new System.Drawing.Point(257, 535);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 20);
            this.label27.TabIndex = 36;
            this.label27.Text = "（通用70t）";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.Teal;
            this.label28.Location = new System.Drawing.Point(607, 501);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 20);
            this.label28.TabIndex = 37;
            this.label28.Text = "（70t加强）";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(769, 219);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(156, 20);
            this.label29.TabIndex = 39;
            this.label29.Text = "本次段修时间：";
            // 
            // textBox1_CurrentTime
            // 
            this.textBox1_CurrentTime.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox1_CurrentTime.Location = new System.Drawing.Point(773, 250);
            this.textBox1_CurrentTime.Name = "textBox1_CurrentTime";
            this.textBox1_CurrentTime.Size = new System.Drawing.Size(260, 34);
            this.textBox1_CurrentTime.TabIndex = 38;
            // 
            // dateTimePicker1_Dep
            // 
            this.dateTimePicker1_Dep.AllowDrop = true;
            this.dateTimePicker1_Dep.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_Dep.CustomFormat = "";
            this.dateTimePicker1_Dep.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_Dep.Location = new System.Drawing.Point(207, 434);
            this.dateTimePicker1_Dep.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1_Dep.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1_Dep.Name = "dateTimePicker1_Dep";
            this.dateTimePicker1_Dep.Size = new System.Drawing.Size(249, 34);
            this.dateTimePicker1_Dep.TabIndex = 3;
            this.dateTimePicker1_Dep.Value = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(203, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "前次段修时间：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(197, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 271);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_NextFac);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_NextDep);
            this.panel2.Location = new System.Drawing.Point(473, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 127);
            this.panel2.TabIndex = 41;
            // 
            // buttonBatch
            // 
            this.buttonBatch.Location = new System.Drawing.Point(21, 655);
            this.buttonBatch.Name = "buttonBatch";
            this.buttonBatch.Size = new System.Drawing.Size(42, 36);
            this.buttonBatch.TabIndex = 42;
            this.buttonBatch.UseVisualStyleBackColor = true;
            this.buttonBatch.Click += new System.EventHandler(this.buttonBatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 712);
            this.Controls.Add(this.buttonBatch);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox1_CurrentTime);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_SealSpan);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1_Produce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_DBG);
            this.Controls.Add(this.button1_Generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2_Fac);
            this.Controls.Add(this.dateTimePicker1_Dep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Railway Vehicle Repair Interval Process";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_Fac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1_Generate;
        private System.Windows.Forms.TextBox textBox1_DBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NextDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_NextFac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Produce;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_SealSpan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox1_CurrentTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Dep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBatch;
    }
}

