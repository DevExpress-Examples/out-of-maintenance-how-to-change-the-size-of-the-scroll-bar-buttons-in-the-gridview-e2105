using System;
using DevExpress.XtraEditors;

namespace Q251885 {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);

        }

        private void OnSwitchViewButtonClick(object sender, EventArgs e) {
            if (categoriesGrid.MainView == categoriesViewSimple)
                categoriesGrid.MainView = categoriesViewLayout;
            else categoriesGrid.MainView = categoriesViewSimple;
        }
    }
}