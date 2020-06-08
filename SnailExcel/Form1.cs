using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnailExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string DirPath = "";

        /// <summary>
        /// 目录浏览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_view_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择所有文件存放目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {

                string sPath = folder.SelectedPath;
                DirPath = sPath;
                txt_dir.Text = sPath;
            }
        }

        /// <summary>
        /// 目录文本框拖拽事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dir_DragDrop(object sender, DragEventArgs e)
        {
            //DataFormats 数据的格式，下有多个静态属性都为string型，除FileDrop格式外还有Bitmap,Text,WaveAudio等格式    
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.txt_dir.Text = path;
            DirPath = path;
            this.txt_dir.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状 
        }

        private void txt_dir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.txt_dir.Cursor = System.Windows.Forms.Cursors.Arrow;//指定鼠标形状   
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 目录文本框内容变化触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dir_TextChanged(object sender, EventArgs e)
        {
            //目录是否为空
            if(string.IsNullOrEmpty(txt_dir.Text))
            {
                DirPath = "";
                txt_dir_info.Text = "";
            }
            else
            {
                //目录不存在
                if (!Directory.Exists(txt_dir.Text))
                {
                    DirPath = "";
                    txt_dir_info.Text = "目录不存在，请检查目录的有效性";
                    txt_dir_info.ForeColor = Color.Red;
                }
                else
                {
                    DirPath = txt_dir.Text;
                    txt_dir_info.Text = "";
                }
            }

        }


    }
}
