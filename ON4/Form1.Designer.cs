
namespace ON4
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
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.tree = new HZH_Controls.Controls.TreeViewEx();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spContainer
            // 
            resources.ApplyResources(this.spContainer, "spContainer");
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            resources.ApplyResources(this.spContainer.Panel1, "spContainer.Panel1");
            this.spContainer.Panel1.Controls.Add(this.tree);
            // 
            // spContainer.Panel2
            // 
            resources.ApplyResources(this.spContainer.Panel2, "spContainer.Panel2");
            this.spContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            // 
            // tree
            // 
            resources.ApplyResources(this.tree, "tree");
            this.tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tree.FullRowSelect = true;
            this.tree.HideSelection = false;
            this.tree.IsShowByCustomModel = true;
            this.tree.IsShowTip = false;
            this.tree.ItemHeight = 50;
            this.tree.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("tree.LstTips")));
            this.tree.Name = "tree";
            this.tree.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tree.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("tree.NodeDownPic")));
            this.tree.NodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.tree.NodeHeight = 50;
            this.tree.NodeIsShowSplitLine = false;
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("tree.Nodes")))});
            this.tree.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tree.NodeSelectedForeColor = System.Drawing.Color.Black;
            this.tree.NodeSplitLineColor = System.Drawing.Color.RoyalBlue;
            this.tree.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("tree.NodeUpPic")));
            this.tree.ParentNodeCanSelect = true;
            this.tree.ShowLines = false;
            this.tree.ShowPlusMinus = false;
            this.tree.ShowRootLines = false;
            this.tree.TipFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tree.TipImage = ((System.Drawing.Image)(resources.GetObject("tree.TipImage")));
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spContainer);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.TreeViewEx tree;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

