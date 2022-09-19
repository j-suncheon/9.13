namespace _9._13
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("베토벤");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("슈베르트");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("모짜르트");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("클래식", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Britney Spears");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Mariah Carey");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Carpenters");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("팝", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("이승환");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("전인권");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("이효리");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("가요", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-down-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-penguin-32.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "노드 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "노드 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 22;
            this.treeView1.Location = new System.Drawing.Point(42, 44);
            this.treeView1.Name = "treeView1";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "노드1";
            treeNode13.Text = "베토벤";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "노드2";
            treeNode14.Text = "슈베르트";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "노드3";
            treeNode15.Text = "모짜르트";
            treeNode16.Name = "노드0";
            treeNode16.Text = "클래식";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "노드5";
            treeNode17.Text = "Britney Spears";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "노드6";
            treeNode18.Text = "Mariah Carey";
            treeNode19.ImageIndex = 1;
            treeNode19.Name = "노드7";
            treeNode19.Text = "Carpenters";
            treeNode20.Name = "노드4";
            treeNode20.Text = "팝";
            treeNode21.ImageIndex = 1;
            treeNode21.Name = "노드9";
            treeNode21.Text = "이승환";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "노드10";
            treeNode22.Text = "전인권";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "노드11";
            treeNode23.Text = "이효리";
            treeNode24.Name = "노드8";
            treeNode24.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode24});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(239, 271);
            this.treeView1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "TreeViewApp";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imageList1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
    }
}