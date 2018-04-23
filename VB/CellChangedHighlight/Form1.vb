Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace CellChangedHighlight
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = CreateTable(30)
			gridView1.BestFitColumns()
		End Sub

		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Vendor", GetType(String))
			tbl.Columns.Add("Model", GetType(String))
			tbl.Columns.Add("ProductNumber", GetType(Integer))


			For i As Integer = 0 To RowCount - 1
				Dim rnd As Integer = New Random(i).Next(1, 4)
				tbl.Rows.Add(New Object() { i, String.Format("Vendor {0}", rnd), String.Format("Model {0}", i), i * New Random().Next(1, 10000) })
			Next i

			Return tbl
		End Function

		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles gridView1.CellValueChanged
			CellPaintHelper.CreateCellPaintHelper(CType(sender, GridView), e.RowHandle, e.Column)
		End Sub
	End Class
End Namespace
