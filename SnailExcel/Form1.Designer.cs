namespace SnailExcel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dir_info = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_RangeAdd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_AnchorSite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AnchorValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AnchorOrderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dir_info);
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置需要批量处理文件的目录(Excel所属目录)";
            // 
            // txt_dir_info
            // 
            this.txt_dir_info.AutoSize = true;
            this.txt_dir_info.Location = new System.Drawing.Point(119, 65);
            this.txt_dir_info.Name = "txt_dir_info";
            this.txt_dir_info.Size = new System.Drawing.Size(0, 15);
            this.txt_dir_info.TabIndex = 3;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(865, 30);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(100, 30);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "浏览";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel所属目录";
            // 
            // txt_dir
            // 
            this.txt_dir.AllowDrop = true;
            this.txt_dir.Location = new System.Drawing.Point(119, 33);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(740, 25);
            this.txt_dir.TabIndex = 0;
            this.txt_dir.TextChanged += new System.EventHandler(this.txt_dir_TextChanged);
            this.txt_dir.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_dir_DragDrop);
            this.txt_dir.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_dir_DragEnter);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Excel蜗牛助手";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_AnchorOrderNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_AnchorValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_AnchorSite);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.btn_RangeAdd);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置需要批量处理的单元格";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(919, 418);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "开始运行";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_RangeAdd
            // 
            this.btn_RangeAdd.Location = new System.Drawing.Point(248, 82);
            this.btn_RangeAdd.Name = "btn_RangeAdd";
            this.btn_RangeAdd.Size = new System.Drawing.Size(109, 34);
            this.btn_RangeAdd.TabIndex = 1;
            this.btn_RangeAdd.Text = "添加区域";
            this.btn_RangeAdd.UseVisualStyleBackColor = true;
            this.btn_RangeAdd.Click += new System.EventHandler(this.btn_RangeAdd_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "启用锚点定位";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_AnchorSite
            // 
            this.txt_AnchorSite.Location = new System.Drawing.Point(285, 32);
            this.txt_AnchorSite.Name = "txt_AnchorSite";
            this.txt_AnchorSite.Size = new System.Drawing.Size(72, 25);
            this.txt_AnchorSite.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "锚点所在列或行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "锚点值";
            // 
            // txt_AnchorValue
            // 
            this.txt_AnchorValue.Location = new System.Drawing.Point(442, 32);
            this.txt_AnchorValue.Name = "txt_AnchorValue";
            this.txt_AnchorValue.Size = new System.Drawing.Size(256, 25);
            this.txt_AnchorValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "锚点特征:第";
            // 
            // txt_AnchorOrderNumber
            // 
            this.txt_AnchorOrderNumber.Location = new System.Drawing.Point(820, 32);
            this.txt_AnchorOrderNumber.Name = "txt_AnchorOrderNumber";
            this.txt_AnchorOrderNumber.Size = new System.Drawing.Size(59, 25);
            this.txt_AnchorOrderNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "次出现";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(0, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(982, 2);
            this.label6.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Excel蜗牛助手";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label txt_dir_info;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_RangeAdd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AnchorSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AnchorOrderNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AnchorValue;
        private System.Windows.Forms.Label label6;
    }
}

