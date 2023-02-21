using System.Xml.Linq;

namespace WinFormsPasswordManager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.addPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainer.Size = new System.Drawing.Size(782, 553);
            this.splitContainer.SplitterDistance = 260;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(257, 553);
            this.treeView.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.addPassword);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(518, 70);
            this.flowLayoutPanelButtons.TabIndex = 0;
            // 
            // addPassword
            // 
            this.addPassword.BackColor = System.Drawing.Color.LawnGreen;
            this.addPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPassword.Location = new System.Drawing.Point(3, 3);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(160, 45);
            this.addPassword.TabIndex = 1;
            this.addPassword.Text = "Добавить";
            this.addPassword.UseVisualStyleBackColor = false;
            this.addPassword.Click += new System.EventHandler(this.addPassword_Click);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void addPassword_Click(object sender, EventArgs e)
        {
            Form2 passwordDialog = new();

            passwordDialog.ShowDialog();

            treeView.BeginUpdate();
            treeView.Nodes.Add(passwordDialog.getPasswordName());
            treeView.EndUpdate();
        }
    }
}