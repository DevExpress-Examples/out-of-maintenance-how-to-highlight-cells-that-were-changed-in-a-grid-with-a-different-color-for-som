Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace CellChangedHighlight
	Friend Class CellPaintHelper
		Implements IDisposable
		Private view As GridView
		Private column As GridColumn
		Private rowHandle As Integer
		Private timer As Timer

		Private Sub New(ByVal gridView As GridView, ByVal rowHandle As Integer, ByVal column As GridColumn)
			Me.view = gridView
			AddHandler view.CustomDrawCell, AddressOf OnCustomDrawCell

			Me.rowHandle = rowHandle
			Me.column = column

			timer = New Timer()
			timer.Interval = 5000
			AddHandler timer.Tick, AddressOf OnTimer

			timer.Start()
		End Sub

		Public Shared Function CreateCellPaintHelper(ByVal gridView As GridView, ByVal rowHandle As Integer, ByVal column As GridColumn) As CellPaintHelper
			Return New CellPaintHelper(gridView, rowHandle, column)
		End Function

		Private Sub OnTimer(ByVal sender As Object, ByVal e As EventArgs)
			timer.Stop()
			view.InvalidateRowCell(rowHandle, column)
		End Sub

		Private Sub OnCustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If e.Column Is column AndAlso e.RowHandle = rowHandle Then
				If timer.Enabled Then
					e.Appearance.BackColor = Color.Red
				Else
					e.Appearance.BackColor = view.Appearance.Row.BackColor
				End If
			End If
		End Sub

		Public Sub Dispose() Implements IDisposable.Dispose
			RemoveHandler view.CustomDrawCell, AddressOf OnCustomDrawCell
			timer.Dispose()
		End Sub
	End Class
End Namespace
