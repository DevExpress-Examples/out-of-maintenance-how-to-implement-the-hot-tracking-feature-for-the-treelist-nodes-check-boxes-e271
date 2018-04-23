Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DXSample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			treeList.ExpandAll()
		End Sub

		Private hotTrackCheckBoxRectangle_Renamed As Rectangle = Rectangle.Empty

		Public Property HotTrackCheckBoxRectangle() As Rectangle
			Get
				Return hotTrackCheckBoxRectangle_Renamed
			End Get
			Set(ByVal value As Rectangle)
				If hotTrackCheckBoxRectangle_Renamed = value Then
					Return
				End If
				Dim prevHotTrackCheckBoxRectangle As Rectangle = hotTrackCheckBoxRectangle_Renamed
				hotTrackCheckBoxRectangle_Renamed = value
				treeList.Invalidate(prevHotTrackCheckBoxRectangle)
				treeList.Invalidate(hotTrackCheckBoxRectangle_Renamed)
			End Set
		End Property

		Private Sub OnCustomDrawNodeCheckBox(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventArgs) Handles treeList.CustomDrawNodeCheckBox
			If e.Bounds.Equals(HotTrackCheckBoxRectangle) Then
				e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Hot
			End If
		End Sub

		Private Sub OnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList.MouseMove
			Dim tree As TreeList = TryCast(sender, TreeList)
			Dim info As TreeListHitInfo = tree.CalcHitInfo(e.Location)
			If info.HitInfoType = HitInfoType.NodeCheckBox Then
				HotTrackCheckBoxRectangle = info.Bounds
			Else
				HotTrackCheckBoxRectangle = Rectangle.Empty
			End If
		End Sub
	End Class
End Namespace
