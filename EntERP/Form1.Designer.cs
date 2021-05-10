namespace EntERP
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
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("过磅数据录入");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("过磅数据查询");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("数据操作", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(1069, 672);
			this.splitContainer1.SplitterDistance = 171;
			this.splitContainer1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode13.Name = "节点1";
			treeNode13.Text = "过磅数据录入";
			treeNode14.Name = "节点2";
			treeNode14.Text = "过磅数据查询";
			treeNode15.Name = "节点0";
			treeNode15.Text = "数据操作";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
			this.treeView1.Size = new System.Drawing.Size(171, 672);
			this.treeView1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(894, 672);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(886, 643);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "数据录入";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer2.Panel1MinSize = 100;
			this.splitContainer2.Panel2MinSize = 100;
			this.splitContainer2.Size = new System.Drawing.Size(880, 637);
			this.splitContainer2.SplitterDistance = 473;
			this.splitContainer2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox16);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.textBox14);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.textBox15);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.textBox13);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox10);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.textBox12);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox11);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox9);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(880, 473);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "车辆信息";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(99, 179);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(199, 25);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "收货单位";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(99, 128);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(199, 25);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "供应商";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(99, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 25);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "车辆号码";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(886, 643);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "数据查询";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(99, 77);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 25);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "车型";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(99, 281);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(200, 25);
			this.textBox5.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "货物名称";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(99, 332);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(199, 25);
			this.textBox6.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 337);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "卸货位置";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(99, 230);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(199, 25);
			this.textBox7.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(36, 235);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 15);
			this.label7.TabIndex = 12;
			this.label7.Text = "司机";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(416, 26);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(200, 25);
			this.textBox8.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(345, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 15);
			this.label8.TabIndex = 14;
			this.label8.Text = "毛重";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(416, 77);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(200, 25);
			this.textBox9.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(345, 82);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 15);
			this.label9.TabIndex = 16;
			this.label9.Text = "皮重";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(416, 128);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(200, 25);
			this.textBox10.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(345, 133);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "净重";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(416, 179);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(200, 25);
			this.textBox11.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(345, 184);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 15);
			this.label11.TabIndex = 20;
			this.label11.Text = "扣杂";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(751, 77);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(200, 25);
			this.textBox12.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(669, 82);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 15);
			this.label12.TabIndex = 22;
			this.label12.Text = "监磅员";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(416, 281);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(200, 25);
			this.textBox13.TabIndex = 25;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(315, 286);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 15);
			this.label13.TabIndex = 24;
			this.label13.Text = "车辆号码";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(751, 26);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(200, 25);
			this.textBox14.TabIndex = 27;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(684, 31);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(37, 15);
			this.label14.TabIndex = 26;
			this.label14.Text = "单号";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(416, 230);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(200, 25);
			this.textBox15.TabIndex = 25;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(345, 235);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(37, 15);
			this.label15.TabIndex = 24;
			this.label15.Text = "扣水";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(751, 128);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(200, 25);
			this.textBox16.TabIndex = 29;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(669, 133);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 15);
			this.label16.TabIndex = 28;
			this.label16.Text = "司磅员";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(99, 410);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 45);
			this.button1.TabIndex = 30;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(318, 410);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 45);
			this.button2.TabIndex = 31;
			this.button2.Text = "打印";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 672);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "entERP";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

