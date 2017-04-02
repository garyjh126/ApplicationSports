'Notes: 1. Need a 'ss' in time parameter. 


Imports System.IO

Public Class Form1

    Public dataSet As DataSet = New DataSet("RaceData")
    Private dataTable As DataTable = dataSet.Tables.Add("Runners") 'small d, not capital.
    Private dataView As DataView
    Public bindingSource As New BindingSource

    Public Class MarketDetail
        Public marketId As String
        Public status As String
        Public inPlay As Boolean
        Public removed As Boolean
    End Class

    Private marketDictionary As New Dictionary(Of String, MarketDetail)
    Private bookRequestList As New List(Of String)

    Public runnerFormDictionary As New Dictionary(Of Integer, RunnerForm)

    Public Class BetDetail
        Public status As String
        Public averagePriceMatched As Double
        Public sizeMatched As Double
        Public fillOrKill As Integer
    End Class

    Public betDictionary As New Dictionary(Of String, BetDetail)



    Public Class RunnerDetail
        Public marketId As String
        Public status As String
        Public backPrice As Double
        Public layPrice As Double

        Public sumBacked As Double
        Public backReturn As Double
        Public avgBackPrice As Double

        Public sumLaid As Double
        Public layLiability As Double
        Public avgLayPrice As Double

        Public hedgeStake As Double
        Public hedge As Double

    End Class

    Public runnerDictionary As New Dictionary(Of Integer, RunnerDetail)

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
        BuildListMarketBookRequests()
        Timer1.Enabled = True

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


    Private Sub BuildListMarketBookRequests()

        Dim count As Integer = 0
        Dim marketIdList As New List(Of String)
        bookRequestList.Clear()

        Dim pair As KeyValuePair(Of String, MarketDetail)
        For Each pair In marketDictionary

            If pair.Value.removed = False Then
                marketIdList.Add(pair.Value.marketId)
            End If

        Next

        For n As Integer = 0 To (marketIdList.Count \ 9)

            Dim jsonRequest As String
            Dim requestList As New List(Of MarketBookRequest)
            Dim request As New MarketBookRequest
            Dim params As New MarketBookParams

            If n = (marketIdList.Count \ 9) Then

                For m As Integer = 1 To marketIdList.Count Mod 9
                    params.marketIds.Add(marketIdList.Item(count))
                    count += 1
                Next

            Else
                For m As Integer = 1 To 9
                    params.marketIds.Add(marketIdList(count))
                    count += 1
                Next
            End If

            params.priceProjection.priceData.Add("EX_BEST_OFFERS")
            params.priceProjection.priceData.Add("EX_TRADED")
            params.orderProjection = "ALL"

            request.params = params

            requestList.Add(request)

            jsonRequest = SerializeMarketBookRequest(requestList)

            bookRequestList.Add(jsonRequest)

        Next

    End Sub

    Private Sub ListMarketBook()

        Dim jsonResponse As String

        Dim keys(1) As Object 'dataView search keys 
        Dim foundRow As DataRow

        For n As Integer = 0 To bookRequestList.Count - 1

            ' Dim jsonResponse As String = GetRawBook(bookRequestList.Item(n))

            jsonResponse = ""

            Do
                jsonResponse = GetRawBook(bookRequestList.Item(n))
                If jsonResponse = "" Then
                    Print("jsonResponse empty - retrying")
                End If
            Loop While jsonResponse = ""

            Dim book() As MarketBookResponse = DeserializeRawBook(jsonResponse)

            For bookCount As Integer = 0 To book(0).result.Count - 1

                For runnerCount As Integer = 0 To book(0).result(bookCount).runners.Count - 1

                    With book(0).result(bookCount).runners(runnerCount)

                        keys(0) = book(0).result(bookCount).marketId
                        keys(1) = .selectionId
                        foundRow = dataSet.Tables("Runners").Rows.Find(keys)

                        foundRow("marketStatus") = book(0).result(bookCount).status

                        marketDictionary.Item(book(0).result(bookCount).marketId).status = book(0).result(bookCount).status
                        marketDictionary.Item(book(0).result(bookCount).marketId).inPlay = book(0).result(bookCount).inplay

                        If book(0).result(bookCount).inplay = True Then
                            foundRow("inPlay") = "inPlay"
                        Else
                            foundRow("inPlay") = ""

                        End If

                        foundRow("runnerStatus") = .status
                        runnerDictionary(.selectionId).status = .status

                        If .status = "ACTIVE" Then
                            foundRow("runnerStatus") = "ACTIVE"

                            If .ex.availableToBack.Count > 0 Then
                                runnerDictionary(.selectionId).backPrice = .ex.availableToBack(0).price
                                foundRow("back") = .ex.availableToBack(0).price

                            End If
                            If .ex.availableToLay.Count > 0 Then
                                runnerDictionary(.selectionId).layPrice = .ex.availableToLay(0).price
                                foundRow("lay") = .ex.availableToLay(0).price

                            End If

                            If .orders.Count > 0 Then
                                ProcessOrders(.selectionId, .orders)
                            End If

                        End If
                    End With
                Next
            Next
        Next
    End Sub

    Private Sub CheckMarkets()

        Dim racesRemoved As Boolean = False

        Dim pair As KeyValuePair(Of String, MarketDetail)

        For Each pair In marketDictionary

            If pair.Value.status = "CLOSED" And pair.Value.removed = False Then
                pair.Value.removed = True
                racesRemoved = True

            End If
        Next

        If racesRemoved = True Then
            BuildListMarketBookRequests()
        End If

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

            Dim detail As New MarketDetail
            detail.marketId = allMarkets(0).result(n).marketId
            detail.removed = False

            marketDictionary.Add(allMarkets(0).result(n).marketId, detail)

            For m = 0 To allMarkets(0).result(n).runners.Count - 1

                Dim course() As String
                course = Split(allMarkets(0).result(n).event.name)

                'Print(Format(allMarkets(0).result(n).marketStartTime, "Short Time") & " " & course(0) & " " & allMarkets(0).result(n).marketName & " " & allMarkets(0).result(n).runners.Item(m).runnerName)

                Try 'add runner to dataTable
                    dataTable.Rows.Add(Format(allMarkets(0).result(n).marketStartTime, "Short Time"), allMarkets(0).result(n).marketId, "", "", course(0) & " " & allMarkets(0).result(n).marketName, allMarkets(0).result(n).runners.Item(m).selectionId, allMarkets(0).result(n).runners.Item(m).runnerName)

                    If Not runnerDictionary.ContainsKey(allMarkets(0).result(n).runners.Item(m).selectionId) Then
                        Dim data As New RunnerDetail
                        data.marketId = allMarkets(0).result(n).marketId
                        runnerDictionary.Add(allMarkets(0).result(n).runners.Item(m).selectionId, data)
                    End If


                Catch ex As Exception 'Ignore duplicates

                End Try

            Next

        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ListMarketBook()
        CheckMarkets()
        UpdateRunnerForms()
    End Sub

    ' Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    ' End Sub

    Function PlaceOrders(ByVal selectionId As Integer, ByVal marketId As String, ByVal side As String, ByVal size As Double, ByVal price As Double)

        Dim requestList As New List(Of PlaceOrdersRequest) 'request object 
        Dim request As New PlaceOrdersRequest ' holds data for request object 
        Dim params As New PlaceOrdersParams
        params.marketId = marketId

        Dim instructions As New PlaceInstructions
        instructions.selectionId = selectionId
        instructions.handicap = 0
        instructions.side = side
        instructions.orderType = "LIMIT"

        Dim limitOrder As New LimitOrder
        limitOrder.size = size
        limitOrder.price = price
        limitOrder.persistenceType = "LAPSE"

        instructions.limitOrder = limitOrder

        params.instructions.Add(instructions)

        request.params = params

        requestList.Add(request)

        Dim orders() As PlaceOrdersResponse

        orders = DeserializePlaceOrdersResponse(SerializePlaceOrdersRequest(requestList))

        Return (orders(0).result.instructionReports(0).betId)

    End Function

    Function PlaceSub2Orders(ByVal selectionId As Integer, ByVal marketId As String, ByVal side As String, ByVal preferredSize As Double, ByVal preferredPrice As Double)
        Dim requestList As New List(Of PlaceOrdersRequest)
        Dim request As New PlaceOrdersRequest
        Dim params As New PlaceOrdersParams
        params.marketId = marketId

        Dim instructions As New PlaceInstructions
        instructions.selectionId = selectionId
        instructions.handicap = 0
        instructions.side = side
        instructions.orderType = "LIMIT"

        Dim limitOrder As New LimitOrder
        limitOrder.size = 2

        If side = "BACK" Then
            limitOrder.price = 1000
        Else
            limitOrder.price = 1.01

        End If

        limitOrder.persistenceType = "LAPSE"
        instructions.limitOrder = limitOrder
        params.instructions.Add(instructions)

        request.params = params
        requestList.Add(request)

        Dim orders() As PlaceOrdersResponse
        orders = DeserializePlaceOrdersResponse(SerializePlaceOrdersRequest(requestList))

        Dim betId As String = orders(0).result.instructionReports(0).betId
        betId = CancelOrders(betId, marketId, 2 - preferredSize)
        betId = ReplaceOrders(betId, marketId, preferredPrice)

        Return betId


    End Function


    Public Function CancelOrders(ByVal betId As String, ByVal marketId As String, ByVal sizeReduction As Double)

        Dim requestList As New List(Of CancelOrdersRequest)
        Dim request As New CancelOrdersRequest

        Dim params As New CancelOrdersParams
        params.marketId = marketId

        Dim instructions As New CancelInstructions
        instructions.betId = betId
        instructions.sizeReduction = sizeReduction
        params.instructions.Add(instructions)

        request.params = params

        requestList.Add(request)

        Dim orders() As CancelOrdersResponse

        orders = DeserializeCancelOrdersResponse(SerializeCancelOrdersRequest(requestList))

        Return orders(0).result.instructionReports(0).instruction.betId


    End Function

    Public Function ReplaceOrders(ByVal betId As String, ByVal marketId As String, ByVal newPrice As Double)
        Dim requestList As New List(Of ReplaceOrdersRequest)
        Dim request As New ReplaceOrdersRequest

        Dim params As New ReplaceOrdersParams
        params.marketId = marketId

        Dim instructions As New ReplaceInstructions
        instructions.betId = betId
        instructions.newPrice = newPrice

        params.instructions.Add(instructions)

        request.params = params

        requestList.Add(request)

        Dim orders() As ReplaceOrdersResponse

        orders = DeserializeReplaceOrdersReponse(SerializeReplaceOrdersRequest(requestList))

        Return orders(0).result.instructionReports(0).placeInstructionReport.betId

    End Function


    Public Function SendBet(ByVal marketId As String, ByVal selectionId As Integer, ByVal side As String, ByVal size As Double, ByVal price As Double)

        Dim betId As String
        If size < 2 Then
            betId = PlaceSub2Orders(selectionId, marketId, side, size, price)
        Else
            betId = PlaceOrders(selectionId, marketId, side, size, price)

        End If
        Return betId

    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = 6 Then
            Dim runnerForm As New RunnerForm(DataGridView1.Item("runnerName", e.RowIndex).Value & " - " & DataGridView1.Item("marketStartTime", e.RowIndex).Value & " " & DataGridView1.Item("course", e.RowIndex).Value, DataGridView1.Item("marketId", e.RowIndex).Value, DataGridView1.Item("selectionId", e.RowIndex).Value)

            runnerFormDictionary.Add(DataGridView1.Item("selectiondId", e.RowIndex).Value, runnerForm)

        End If
    End Sub

    Private Sub UpdateRunnerForms()

        Dim pair As KeyValuePair(Of Integer, RunnerForm)

        For Each pair In runnerFormDictionary
            runnerFormDictionary(pair.Key).MonitorBets()
        Next
    End Sub

    Private Sub ProcessOrders(ByVal selectionId As Integer, ByVal orders As List(Of Order))

        Dim sumBacked As Double = 0
        Dim sumLaid As Double = 0
        Dim backReturn As Double = 0
        Dim layLiability As Double = 0

        For m As Integer = 0 To orders.Count - 1

            If Not betDictionary.ContainsKey(orders(m).betId) Then
                Dim betDetail As New BetDetail
                betDictionary.Add(orders(m).betId, betDetail)
            End If

            betDictionary(orders(m).betId).status = orders(m).status
            betDictionary(orders(m).betId).averagePriceMatched = orders(m).avgPriceMatched
            betDictionary(orders(m).betId).sizeMatched = orders(m).sizeMatched

            If orders(m).side = "BACK" Then
                sumBacked += orders(m).sizeMatched
                backReturn += orders(m).sizeMatched = orders(m).avgPriceMatched
            Else
                sumLaid += orders(m).sizeMatched
                layLiability = orders(m).sizeMatched = orders(m).avgPriceMatched
            End If

        Next

        runnerDictionary(selectionId).sumBacked = sumBacked
        runnerDictionary(selectionId).backReturn = backReturn

        If sumBacked > 0 Then
            runnerDictionary(selectionId).avgBackPrice = Math.Round(backReturn / sumBacked, 2)

        Else
            runnerDictionary(selectionId).avgBackPrice = 0
        End If

        runnerDictionary(selectionId).sumLaid = sumLaid
        runnerDictionary(selectionId).layLiability = layLiability

        If sumLaid > 0 Then
            runnerDictionary(selectionId).avgLayPrice = Math.Round(layLiability / sumLaid, 2)

        Else
            runnerDictionary(selectionId).avgLayPrice = 0
        End If

        Dim hedgeStake As Double = 0

        If backReturn > layLiability Then
            hedgeStake = Math.Round(((backReturn - layLiability) / runnerDictionary(selectionId).layPrice), 2)
            If hedgeStake <> 0 Then
                runnerDictionary(selectionId).hedge = Math.Round(hedgeStake - (sumBacked - sumLaid), 2)

            Else
                runnerDictionary(selectionId).hedge = 0

            End If

        End If

        If layLiability > backReturn Then 'hedge excess Liability 

            hedgeStake = Math.Round(((layLiability - backReturn) / runnerDictionary(selectionId).backPrice), 2)

            If hedgeStake <> 0 Then
                runnerDictionary(selectionId).hedge = Math.Round(hedgeStake - (sumBacked - sumLaid), 2)

            Else

                runnerDictionary(selectionId).hedge = 0
            End If
        End If

        runnerDictionary(selectionId).hedgeStake = hedgeStake

    End Sub


End Class
