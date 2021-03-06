﻿namespace RailwayVehicleRapairIntervalCompute
{
    partial class BatchProcess
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonImportExcel = new System.Windows.Forms.Button();
            this.buttonGetTemplate = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonGenerateData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preFactoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preDepotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SealDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curDepotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDepotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextFactoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "使用说明";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox1.Location = new System.Drawing.Point(24, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(840, 262);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1. 下载Excel填写模板（保存在当前文件夹下）\r\n2. 将Excel模板改名为【计划.xlsx】\r\n3. 点击【导入】，可直接读取名为 计划.xlsx 的Ex" +
    "cel文件\r\n4. 点击【生成结果】计算厂段修日期，显示在软件中。\r\n5. 点击【导出Excel】可导出。\r\n";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "批量导入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.vehCate,
            this.produceDate,
            this.preFactoryDate,
            this.preDepotDate,
            this.SealDuration,
            this.curDepotDate,
            this.nextDepotDate,
            this.nextFactoryDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(966, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // buttonImportExcel
            // 
            this.buttonImportExcel.Location = new System.Drawing.Point(232, 475);
            this.buttonImportExcel.Name = "buttonImportExcel";
            this.buttonImportExcel.Size = new System.Drawing.Size(145, 35);
            this.buttonImportExcel.TabIndex = 2;
            this.buttonImportExcel.Text = "[导入]Excel";
            this.buttonImportExcel.UseVisualStyleBackColor = true;
            this.buttonImportExcel.Click += new System.EventHandler(this.buttonImportExcel_Click);
            // 
            // buttonGetTemplate
            // 
            this.buttonGetTemplate.Location = new System.Drawing.Point(16, 475);
            this.buttonGetTemplate.Name = "buttonGetTemplate";
            this.buttonGetTemplate.Size = new System.Drawing.Size(177, 35);
            this.buttonGetTemplate.TabIndex = 3;
            this.buttonGetTemplate.Text = "下载Excel填写模板";
            this.buttonGetTemplate.UseVisualStyleBackColor = true;
            this.buttonGetTemplate.Click += new System.EventHandler(this.buttonGetTemplate_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(662, 475);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(145, 35);
            this.buttonOutput.TabIndex = 4;
            this.buttonOutput.Text = "[导出]Excel";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonGenerateData
            // 
            this.buttonGenerateData.Location = new System.Drawing.Point(393, 475);
            this.buttonGenerateData.Name = "buttonGenerateData";
            this.buttonGenerateData.Size = new System.Drawing.Size(145, 35);
            this.buttonGenerateData.TabIndex = 5;
            this.buttonGenerateData.Text = "生成结果";
            this.buttonGenerateData.UseVisualStyleBackColor = true;
            this.buttonGenerateData.Click += new System.EventHandler(this.buttonGenerateData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Position
            // 
            this.Position.HeaderText = "台位";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 66;
            // 
            // vehCate
            // 
            this.vehCate.HeaderText = "车种车型";
            this.vehCate.MinimumWidth = 6;
            this.vehCate.Name = "vehCate";
            this.vehCate.Width = 96;
            // 
            // produceDate
            // 
            this.produceDate.HeaderText = "制造年月";
            this.produceDate.MinimumWidth = 6;
            this.produceDate.Name = "produceDate";
            this.produceDate.Width = 96;
            // 
            // preFactoryDate
            // 
            this.preFactoryDate.HeaderText = "前次厂修";
            this.preFactoryDate.MinimumWidth = 6;
            this.preFactoryDate.Name = "preFactoryDate";
            this.preFactoryDate.Width = 96;
            // 
            // preDepotDate
            // 
            this.preDepotDate.HeaderText = "前次段修";
            this.preDepotDate.MinimumWidth = 6;
            this.preDepotDate.Name = "preDepotDate";
            this.preDepotDate.Width = 96;
            // 
            // SealDuration
            // 
            this.SealDuration.HeaderText = "封存期";
            this.SealDuration.MinimumWidth = 6;
            this.SealDuration.Name = "SealDuration";
            this.SealDuration.Width = 81;
            // 
            // curDepotDate
            // 
            this.curDepotDate.HeaderText = "本次段修";
            this.curDepotDate.MinimumWidth = 6;
            this.curDepotDate.Name = "curDepotDate";
            this.curDepotDate.Width = 96;
            // 
            // nextDepotDate
            // 
            this.nextDepotDate.HeaderText = "下次段修";
            this.nextDepotDate.MinimumWidth = 6;
            this.nextDepotDate.Name = "nextDepotDate";
            this.nextDepotDate.Width = 96;
            // 
            // nextFactoryDate
            // 
            this.nextFactoryDate.HeaderText = "下次厂修";
            this.nextFactoryDate.MinimumWidth = 6;
            this.nextFactoryDate.Name = "nextFactoryDate";
            this.nextFactoryDate.Width = 96;
            // 
            // BatchProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGenerateData);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonGetTemplate);
            this.Controls.Add(this.buttonImportExcel);
            this.Controls.Add(this.tabControl1);
            this.Name = "BatchProcess";
            this.Text = "BatchProcess";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonImportExcel;
        private System.Windows.Forms.Button buttonGetTemplate;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonGenerateData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn preFactoryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn preDepotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SealDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDepotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDepotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextFactoryDate;
    }
}