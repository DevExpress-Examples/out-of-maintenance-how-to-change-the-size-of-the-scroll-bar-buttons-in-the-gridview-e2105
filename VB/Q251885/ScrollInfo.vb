Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Windows.Forms

Namespace DXSample
	Public Class MyScrollInfo
		Inherits ScrollInfo
		Public Sub New(ByVal view As BaseView)
			MyBase.New(view)
		End Sub

		Protected Overrides Function CreateVScroll() As VCrkScrollBar
			Return New MyVCrkScrollBar(Me)
		End Function

		Protected Overrides Function CreateHScroll() As HCrkScrollBar
			Return New MyHCrkScrollBar(Me)
		End Function

		Public Overrides ReadOnly Property VScrollSize() As Integer
			Get
				Return SystemInformation.VerticalScrollBarWidth * 2
			End Get
		End Property


	End Class

	Public Class MyVCrkScrollBar
		Inherits VCrkScrollBar
		Public Sub New(ByVal scrollInfo As ScrollInfo)
			MyBase.New(scrollInfo)
		End Sub

		Protected Overrides Function CreateScrollBarViewInfo() As ScrollBarViewInfo
			Return New MyScrollBarViewinfo(Me)
		End Function
	End Class

	Public Class MyHCrkScrollBar
		Inherits HCrkScrollBar
		Public Sub New(ByVal scrollInfo As ScrollInfo)
			MyBase.New(scrollInfo)
		End Sub

		Protected Overrides Function CreateScrollBarViewInfo() As ScrollBarViewInfo
			Return New MyScrollBarViewinfo(Me)
		End Function
	End Class

	Public Class MyScrollBarViewinfo
		Inherits ScrollBarViewInfo
		Public Sub New(ByVal scrollBar As IScrollBar)
			MyBase.New(scrollBar)
		End Sub

		Public Overrides ReadOnly Property ButtonWidth() As Integer
			Get
				Return SystemInformation.VerticalScrollBarArrowHeight * 2
			End Get
		End Property
	End Class
End Namespace