namespace Q251885 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.categoriesViewLayout = new DXSample.MyLayoutView();
            this.colCategoryID1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCategoryID1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCategoryName1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCategoryName1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDescription1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.categoriesGrid = new DXSample.MyGridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Q251885.nwindDataSet();
            this.categoriesViewSimple = new DXSample.MyGridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.categoriesTableAdapter = new Q251885.nwindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesViewLayout
            // 
            this.categoriesViewLayout.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colCategoryID1,
            this.colCategoryName1,
            this.colDescription1});
            this.categoriesViewLayout.GridControl = this.categoriesGrid;
            this.categoriesViewLayout.Name = "categoriesViewLayout";
            this.categoriesViewLayout.TemplateCard = this.layoutViewCard1;
            // 
            // colCategoryID1
            // 
            this.colCategoryID1.FieldName = "CategoryID";
            this.colCategoryID1.LayoutViewField = this.layoutViewField_colCategoryID1;
            this.colCategoryID1.Name = "colCategoryID1";
            // 
            // layoutViewField_colCategoryID1
            // 
            this.layoutViewField_colCategoryID1.EditorPreferredWidth = 112;
            this.layoutViewField_colCategoryID1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCategoryID1.Name = "layoutViewField_colCategoryID1";
            this.layoutViewField_colCategoryID1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colCategoryID1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // colCategoryName1
            // 
            this.colCategoryName1.FieldName = "CategoryName";
            this.colCategoryName1.LayoutViewField = this.layoutViewField_colCategoryName1;
            this.colCategoryName1.Name = "colCategoryName1";
            // 
            // layoutViewField_colCategoryName1
            // 
            this.layoutViewField_colCategoryName1.EditorPreferredWidth = 112;
            this.layoutViewField_colCategoryName1.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colCategoryName1.Name = "layoutViewField_colCategoryName1";
            this.layoutViewField_colCategoryName1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colCategoryName1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.LayoutViewField = this.layoutViewField_colDescription1;
            this.colDescription1.Name = "colDescription1";
            // 
            // layoutViewField_colDescription1
            // 
            this.layoutViewField_colDescription1.EditorPreferredWidth = 112;
            this.layoutViewField_colDescription1.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colDescription1.Name = "layoutViewField_colDescription1";
            this.layoutViewField_colDescription1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colDescription1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // categoriesGrid
            // 
            this.categoriesGrid.DataSource = this.categoriesBindingSource;
            this.categoriesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGrid.Location = new System.Drawing.Point(0, 0);
            this.categoriesGrid.MainView = this.categoriesViewSimple;
            this.categoriesGrid.Name = "categoriesGrid";
            this.categoriesGrid.Size = new System.Drawing.Size(249, 143);
            this.categoriesGrid.TabIndex = 1;
            this.categoriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoriesViewSimple,
            this.categoriesViewLayout});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesViewSimple
            // 
            this.categoriesViewSimple.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription});
            this.categoriesViewSimple.GridControl = this.categoriesGrid;
            this.categoriesViewSimple.Name = "categoriesViewSimple";
            this.categoriesViewSimple.OptionsView.ColumnAutoWidth = false;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCategoryID1,
            this.layoutViewField_colCategoryName1,
            this.layoutViewField_colDescription1});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(249, 33);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Switch View";
            this.simpleButton1.Click += new System.EventHandler(this.OnSwitchViewButtonClick);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 176);
            this.Controls.Add(this.categoriesGrid);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Q251885.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DXSample.MyGridControl categoriesGrid;
        private DXSample.MyLayoutView categoriesViewLayout;
        private DXSample.MyGridView categoriesViewSimple;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryID1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryID1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryName1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryName1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDescription1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDescription1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

