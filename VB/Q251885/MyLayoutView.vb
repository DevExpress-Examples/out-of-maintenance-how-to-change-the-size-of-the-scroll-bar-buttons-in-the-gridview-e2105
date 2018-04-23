Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Scrolling

Namespace DXSample
	Public Class MyLayoutView
		Inherits LayoutView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Friend Const MyLayoutViewName As String = "MyLayoutView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MyLayoutViewName
			End Get
		End Property

		Protected Overrides Function CreateScrollInfo() As ScrollInfo
			Return New MyScrollInfo(Me)
		End Function
	End Class

	Public Class MyLayoutViewInfoRegistrator
		Inherits LayoutViewInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MyLayoutView.MyLayoutViewName
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyLayoutView(grid)
		End Function
	End Class
End Namespace
