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
            this.groupBox1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Excel蜗牛助手";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label txt_dir_info;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

