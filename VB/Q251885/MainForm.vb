Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace Q251885
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)

		End Sub

		Private Sub OnSwitchViewButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			If categoriesGrid.MainView Is categoriesViewSimple Then
				categoriesGrid.MainView = categoriesViewLayout
			Else
				categoriesGrid.MainView = categoriesViewSimple
			End If
		End Sub
	End Class
End Namespace