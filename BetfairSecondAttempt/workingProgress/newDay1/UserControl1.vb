Public Class UserControl1

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With DataGridView1

            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)

            .ColumnHeadersVisible = False
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.White

            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowHeadersVisible = False
            .RowTemplate.Height = 19
            .ShowCellToolTips = False

            Dim sideColumn As New DataGridViewTextBoxColumn
            With sideColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "side"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 40

            End With
            .Columns.Add(sideColumn)

            Dim sizeRequestedColumn As New DataGridViewTextBoxColumn
            With sizeRequestedColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "sizeRequested"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 40
            End With
            .Columns.Add(sizeRequestedColumn)

            Dim priceRequestedColumn As New DataGridViewTextBoxColumn
            With priceRequestedColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "priceRequested"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 40
            End With
            .Columns.Add(priceRequestedColumn)

            Dim fillOrKillColumn As New DataGridViewTextBoxColumn
            With fillOrKillColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "fillOrKill"
                .DataPropertyName = "fillOrKill"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 40
            End With
            .Columns.Add(fillOrKillColumn)

            Dim sizeMatchedColumn As New DataGridViewTextBoxColumn
            With sizeMatchedColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "sizeMatched"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 40
            End With
            .Columns.Add(sizeMatchedColumn)

            Dim avgPriceMatchedColumn As New DataGridViewTextBoxColumn
            With avgPriceMatchedColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "avgPriceMatched"
                .DataPropertyName = "avgPriceMatched"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 40
            End With
            .Columns.Add(avgPriceMatchedColumn)

            Dim betIdColumn As New DataGridViewTextBoxColumn

            With betIdColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "betId"
                .DataPropertyName = "betId"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Width = 80
            End With
            .Columns.Add(betIdColumn)

        End With
    End Sub
End Class











'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

'End Sub

'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles returnPriceTextBox.TextChanged

'End Sub

'Private Sub layCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles layCheckBox.CheckedChanged

'End Sub

'Private Sub Label18_Click(sender As Object, e As EventArgs) Handles laidLabel.Click

'End Sub

'Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

'End Sub

'Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

'End Sub

'Private Sub Label17_Click(sender As Object, e As EventArgs) Handles backedLabel.Click

'End Sub

'Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

'End Sub

'Private Sub Label19_Click(sender As Object, e As EventArgs) Handles hedgeValueLabel.Click

'End Sub

'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles betButton.Click

'End Sub

'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

'End Sub



