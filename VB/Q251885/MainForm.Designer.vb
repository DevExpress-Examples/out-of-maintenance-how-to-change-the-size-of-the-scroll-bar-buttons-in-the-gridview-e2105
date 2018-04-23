Imports Microsoft.VisualBasic
Imports System
Namespace Q251885
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
			Me.categoriesViewLayout = New DXSample.MyLayoutView()
			Me.colCategoryID1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCategoryID1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colCategoryName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCategoryName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colDescription1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colDescription1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.categoriesGrid = New DXSample.MyGridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q251885.nwindDataSet()
			Me.categoriesViewSimple = New DXSample.MyGridView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.categoriesTableAdapter = New Q251885.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.categoriesViewLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryID1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryName1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDescription1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesViewSimple, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' categoriesViewLayout
			' 
			Me.categoriesViewLayout.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colCategoryID1, Me.colCategoryName1, Me.colDescription1})
			Me.categoriesViewLayout.GridControl = Me.categoriesGrid
			Me.categoriesViewLayout.Name = "categoriesViewLayout"
			Me.categoriesViewLayout.TemplateCard = Me.layoutViewCard1
			' 
			' colCategoryID1
			' 
			Me.colCategoryID1.FieldName = "CategoryID"
			Me.colCategoryID1.LayoutViewField = Me.layoutViewField_colCategoryID1
			Me.colCategoryID1.Name = "colCategoryID1"
			' 
			' layoutViewField_colCategoryID1
			' 
			Me.layoutViewField_colCategoryID1.EditorPreferredWidth = 112
			Me.layoutViewField_colCategoryID1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colCategoryID1.Name = "layoutViewField_colCategoryID1"
			Me.layoutViewField_colCategoryID1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colCategoryID1.TextSize = New System.Drawing.Size(79, 13)
			' 
			' colCategoryName1
			' 
			Me.colCategoryName1.FieldName = "CategoryName"
			Me.colCategoryName1.LayoutViewField = Me.layoutViewField_colCategoryName1
			Me.colCategoryName1.Name = "colCategoryName1"
			' 
			' layoutViewField_colCategoryName1
			' 
			Me.layoutViewField_colCategoryName1.EditorPreferredWidth = 112
			Me.layoutViewField_colCategoryName1.Location = New System.Drawing.Point(0, 27)
			Me.layoutViewField_colCategoryName1.Name = "layoutViewField_colCategoryName1"
			Me.layoutViewField_colCategoryName1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colCategoryName1.TextSize = New System.Drawing.Size(79, 13)
			' 
			' colDescription1
			' 
			Me.colDescription1.FieldName = "Description"
			Me.colDescription1.LayoutViewField = Me.layoutViewField_colDescription1
			Me.colDescription1.Name = "colDescription1"
			' 
			' layoutViewField_colDescription1
			' 
			Me.layoutViewField_colDescription1.EditorPreferredWidth = 112
			Me.layoutViewField_colDescription1.Location = New System.Drawing.Point(0, 54)
			Me.layoutViewField_colDescription1.Name = "layoutViewField_colDescription1"
			Me.layoutViewField_colDescription1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colDescription1.TextSize = New System.Drawing.Size(79, 13)
			' 
			' categoriesGrid
			' 
			Me.categoriesGrid.DataSource = Me.categoriesBindingSource
			Me.categoriesGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.categoriesGrid.Location = New System.Drawing.Point(0, 0)
			Me.categoriesGrid.MainView = Me.categoriesViewSimple
			Me.categoriesGrid.Name = "categoriesGrid"
			Me.categoriesGrid.Size = New System.Drawing.Size(249, 143)
			Me.categoriesGrid.TabIndex = 1
			Me.categoriesGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.categoriesViewSimple, Me.categoriesViewLayout})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesViewSimple
			' 
			Me.categoriesViewSimple.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription})
			Me.categoriesViewSimple.GridControl = Me.categoriesGrid
			Me.categoriesViewSimple.Name = "categoriesViewSimple"
			Me.categoriesViewSimple.OptionsView.ColumnAutoWidth = False
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCategoryID1, Me.layoutViewField_colCategoryName1, Me.layoutViewField_colDescription1})
			Me.layoutViewCard1.Name = "layoutViewTemplateCard"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 143)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(249, 33)
			Me.panelControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(5, 5)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Switch View"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnSwitchViewButtonClick);
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(249, 176)
			Me.Controls.Add(Me.categoriesGrid)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.categoriesViewLayout, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryID1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryName1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDescription1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesViewSimple, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As Q251885.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private categoriesGrid As DXSample.MyGridControl
		Private categoriesViewLayout As DXSample.MyLayoutView
		Private categoriesViewSimple As DXSample.MyGridView
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCategoryID1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCategoryName1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCategoryName1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colDescription1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colDescription1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	End Class
End Namespace

