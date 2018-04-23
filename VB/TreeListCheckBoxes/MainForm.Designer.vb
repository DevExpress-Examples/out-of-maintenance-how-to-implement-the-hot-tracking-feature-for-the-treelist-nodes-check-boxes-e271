Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList = New DevExpress.XtraTreeList.TreeList()
			Me.colCheck = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colCheck, Me.treeListColumn1})
			Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList.Location = New System.Drawing.Point(0, 0)
			Me.treeList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.treeList.Name = "treeList1"
			Me.treeList.BeginUnboundLoad()
			Me.treeList.AppendNode(New Object() { True, "A"}, -1)
			Me.treeList.AppendNode(New Object() { False, "B"}, -1, System.Windows.Forms.CheckState.Checked)
			Me.treeList.AppendNode(New Object() { True, "C"}, -1)
			Me.treeList.AppendNode(New Object() { False, "D"}, 2)
			Me.treeList.AppendNode(New Object() { False, "E"}, 3)
			Me.treeList.AppendNode(New Object() { False, "F"}, -1, System.Windows.Forms.CheckState.Checked)
			Me.treeList.AppendNode(New Object() { False, "G"}, 5)
			Me.treeList.AppendNode(New Object() { True, "H"}, -1, System.Windows.Forms.CheckState.Checked)
			Me.treeList.EndUnboundLoad()
			Me.treeList.OptionsView.ShowCheckBoxes = True
			Me.treeList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
			Me.treeList.Size = New System.Drawing.Size(718, 386)
			Me.treeList.TabIndex = 0
'			Me.treeList.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnMouseMove);
'			Me.treeList.CustomDrawNodeCheckBox += New DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(Me.OnCustomDrawNodeCheckBox);
			' 
			' colCheck
			' 
			Me.colCheck.Caption = "State"
			Me.colCheck.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.colCheck.FieldName = "State"
			Me.colCheck.MinWidth = 70
			Me.colCheck.Name = "colCheck"
			Me.colCheck.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean
			Me.colCheck.Visible = True
			Me.colCheck.VisibleIndex = 0
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 1
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(718, 386)
			Me.Controls.Add(Me.treeList)
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Name = "XtraForm1"
			Me.Text = "How to implement the hot-tracking feature for the nodes' check boxes"
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList As DevExpress.XtraTreeList.TreeList
		Private colCheck As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace