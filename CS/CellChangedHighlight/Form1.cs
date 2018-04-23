using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace CellChangedHighlight
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = CreateTable(30);
			gridView1.BestFitColumns();
		}

		private DataTable CreateTable(int RowCount)
		{
			DataTable tbl = new DataTable();
			tbl.Columns.Add("ID", typeof(int));
			tbl.Columns.Add("Vendor", typeof(string));
			tbl.Columns.Add("Model", typeof(string));
			tbl.Columns.Add("ProductNumber", typeof(int));


			for ( int i = 0; i < RowCount; i++ )
			{
				int rnd = new Random(i).Next(1, 4);
				tbl.Rows.Add(new object[] { i, String.Format("Vendor {0}", rnd), String.Format("Model {0}", i), i * new Random().Next(1, 10000) });
			}

			return tbl;
		}

		private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			CellPaintHelper.CreateCellPaintHelper((GridView)sender, e.RowHandle, e.Column);
		}
	}
}
