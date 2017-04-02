'Notes: 1. Need a 'ss' in time parameter. 


Imports System.IO

Public Class Form1

    Public dataSet As DataSet = New DataSet("RaceData")
    Private dataTable As DataTable = dataSet.Tables.Add("Runners") 'small d, not capital.
    Private dataView As DataView
    Public bindingSource As New BindingSource


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Show()
    End Sub

    Public Sub Print(ByVal message As String)
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.SelectedText = vbCrLf & message
    End Sub

    Public Sub Initialise() 'Will be called from within loginForm
        BuildDataGridView() 'build datagridview
        BuildDataTable() 'build dataTable
        ListMarketCatalogue() 'Gets list of today's markets
    End Sub

    Private Sub BuildDataTable()
        dataTable.Columns.Add("marketStartTime", GetType(System.String), Nothing)
        dataTable.Columns.Add("marketId", GetType(System.String), Nothing)
        dataTable.Columns.Add("marketStatus", GetType(System.String), Nothing)
        dataTable.Columns.Add("inPlay", GetType(System.String), Nothing)
        dataTable.Columns.Add("course", GetType(System.String), Nothing)
        dataTable.Columns.Add("selectionId", GetType(System.String), Nothing)
        dataTable.Columns.Add("runnerName", GetType(System.String), Nothing)
        dataTable.Columns.Add("runnerStatus", GetType(System.String), Nothing)
        dataTable.Columns.Add("back", GetType(System.Double), Nothing)
        dataTable.Columns.Add("lay", GetType(System.Double), Nothing)

        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("marketId"), dataTable.Columns("selectionId")}

        Dim dataView As DataView = dataSet.Tables("Runners").DefaultView

        dataView.Sort = "marketStartTime" 'sort data by time

        bindingSource = New BindingSource

        DataGridView1.DataSource = bindingSource

        bindingSource.DataSource = dataView

    End Sub

    Private Sub BuildDataGridView()

        With DataGridView1

            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False

            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)

            .ColumnHeadersVisible = False
            .DefaultCellStyle.Font = New Font("Microsft Sans Serif", 8, FontStyle.Regular)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.Black
            .RowHeadersVisible = False
            .RowTemplate.Height = 19
            .ShowCellToolTips = False

            Dim marketStartTimeColumn As New DataGridViewTextBoxColumn
            With marketStartTimeColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "marketStartTime"
                .DataPropertyName = "marketStartTime"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 40
            End With
            .Columns.Add(marketStartTimeColumn)

            Dim marketIdColumn As New DataGridViewTextBoxColumn
            With marketIdColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "marketId"
                .DataPropertyName = "marketId"
                Width = 80
            End With
            .Columns.Add(marketIdColumn)

            Dim marketStatusColumn As New DataGridViewTextBoxColumn
            With marketStatusColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "marketStatus"
                .DataPropertyName = "marketStatus"
                .Width = 80
            End With
            .Columns.Add(marketStatusColumn)

            Dim inPlayColumn As New DataGridViewTextBoxColumn
            With inPlayColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "inPlay"
                .DataPropertyName = "inPlay"
                .Width = 50
            End With
            .Columns.Add(inPlayColumn)

            Dim courseColumn As New DataGridViewTextBoxColumn
            With courseColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "course"
                .DataPropertyName = "course"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 120
            End With
            .Columns.Add(courseColumn)

            Dim selectionIdColumn As New DataGridViewTextBoxColumn
            With selectionIdColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "selectionId"
                .DataPropertyName = "selectionId"
                .Width = 60
            End With
            .Columns.Add(selectionIdColumn)

            Dim runnerNameColumn As New DataGridViewTextBoxColumn
            With runnerNameColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "runnerName"
                .DataPropertyName = "runnerName"
                .Width = 110
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            .Columns.Add(runnerNameColumn)

            Dim runnerStatusColumn As New DataGridViewTextBoxColumn
            With runnerStatusColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "runnerStatus"
                .DataPropertyName = "runnerStatus"
                .Width = 70
            End With
            .Columns.Add(runnerStatusColumn)

            Dim backColumn As New DataGridViewTextBoxColumn
            With backColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "back"
                .DataPropertyName = "back"
                .DefaultCellStyle.BackColor = Color.LightSkyBlue
                .DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
                .Width = 40
            End With
            .Columns.Add(backColumn)

            Dim layColumn As New DataGridViewTextBoxColumn
            With layColumn
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Name = "lay"
                .DataPropertyName = "lay"
                .DefaultCellStyle.BackColor = Color.Pink
                .DefaultCellStyle.SelectionBackColor = Color.Pink
                .Width = 40
            End With
            .Columns.Add(layColumn)
        End With
    End Sub



    Private Sub ListMarketCatalogue() 'Gets list of today's races

        Dim requestList As New List(Of MarketCatalogueRequest)
        Dim request As New MarketCatalogueRequest
        Dim params As New Params

        Dim eventTypeIds As New List(Of String)
        eventTypeIds.Add("7")
        params.filter.eventTypeIds = eventTypeIds

        Dim marketCountries As New List(Of String)
        marketCountries.Add("GB")
        params.filter.marketCountries = marketCountries

        Dim marketProjection As New List(Of String)
        marketProjection.Add("MARKET_START_TIME")
        marketProjection.Add("RUNNER_DESCRIPTION")
        marketProjection.Add("EVENT")
        params.marketProjection = marketProjection

        Dim marketTypeCodes As New List(Of String)
        marketTypeCodes.Add("WIN")
        params.filter.marketTypeCodes = marketTypeCodes

        Dim marketStartTime As New StartTime

        If Today.IsDaylightSavingTime() Then
            marketStartTime.from = Format(Date.Now, "yyyy-MM-dd") & "T" & Format(Now.AddHours(-1), "HH:mm:ss") & "Z" 'urgent change made here

        Else
            marketStartTime.from = Format(Date.Now, "yyyy-MM-dd") & "T" & Format(Now, "HH:mm:ss") & "Z" 'urgent change made here

        End If

        marketStartTime.to = Today.ToString("u").Replace(" ", "T").Replace("00:00", "23:00")
        params.filter.marketStartTime = marketStartTime

        request.params = params
        requestList.Add(request)

        Dim allMarkets() As MarketCatalogueResponse


        allMarkets = DeserializeMarketCatalogueResponse(SerializeMarketCatalogueRequest(requestList))

        For n = 0 To allMarkets(0).result.Count - 1

            For m = 0 To allMarkets(0).result(n).runners.Count - 1

                Dim course() As String
                course = Split(allMarkets(0).result(n).event.name)

                'Print(Format(allMarkets(0).result(n).marketStartTime, "Short Time") & " " & course(0) & " " & allMarkets(0).result(n).marketName & " " & allMarkets(0).result(n).runners.Item(m).runnerName)

                Try 'add runner to dataTable
                    dataTable.Rows.Add(Format(allMarkets(0).result(n).marketStartTime, "Short Time"), allMarkets(0).result(n).marketId, "", "", course(0) & " " & allMarkets(0).result(n).marketName, allMarkets(0).result(n).runners.Item(m).selectionId, allMarkets(0).result(n).runners.Item(m).runnerName)
                    '
                Catch ex As Exception 'Ignore duplicates

                End Try

            Next

        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    ' Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    ' End Sub
End Class
