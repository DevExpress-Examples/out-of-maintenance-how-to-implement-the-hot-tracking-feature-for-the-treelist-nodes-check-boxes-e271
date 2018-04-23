namespace DXSample
{
    partial class MainForm
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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCheck,
            this.treeListColumn1});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeList.Name = "treeList1";
            this.treeList.BeginUnboundLoad();
            this.treeList.AppendNode(new object[] {
            true,
            "A"}, -1);
            this.treeList.AppendNode(new object[] {
            false,
            "B"}, -1, System.Windows.Forms.CheckState.Checked);
            this.treeList.AppendNode(new object[] {
            true,
            "C"}, -1);
            this.treeList.AppendNode(new object[] {
            false,
            "D"}, 2);
            this.treeList.AppendNode(new object[] {
            false,
            "E"}, 3);
            this.treeList.AppendNode(new object[] {
            false,
            "F"}, -1, System.Windows.Forms.CheckState.Checked);
            this.treeList.AppendNode(new object[] {
            false,
            "G"}, 5);
            this.treeList.AppendNode(new object[] {
            true,
            "H"}, -1, System.Windows.Forms.CheckState.Checked);
            this.treeList.EndUnboundLoad();
            this.treeList.OptionsView.ShowCheckBoxes = true;
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treeList.Size = new System.Drawing.Size(718, 386);
            this.treeList.TabIndex = 0;
            this.treeList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.treeList.CustomDrawNodeCheckBox += new DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(this.OnCustomDrawNodeCheckBox);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "State";
            this.colCheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCheck.FieldName = "State";
            this.colCheck.MinWidth = 70;
            this.colCheck.Name = "colCheck";
            this.colCheck.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.treeList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraForm1";
            this.Text = "How to implement the hot-tracking feature for the nodes\' check boxes";
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}