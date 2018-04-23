Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace NumericChartClient
	Partial Public Class Form1
		Inherits Form

		Private Const pointCount As Integer = 20
		Private Const seriesCount As Integer = 2
		Private rand As New Random()
		Private data As New List(Of NumericItem)()

		Public Sub New()
			InitializeComponent()

			' Assign a numeric chart client to the Range control. 
			rangeControl1.Client = numericChartRangeControlClient1

			' Generate a list of NumericItem objects and bind the numeric chart client to it.
			numericChartRangeControlClient1.DataProvider.DataSource = GenerateNumericData()

			' Specify data members to bind the chart client.
			numericChartRangeControlClient1.DataProvider.ArgumentDataMember = "Argument"
			numericChartRangeControlClient1.DataProvider.ValueDataMember = "Value"
			numericChartRangeControlClient1.DataProvider.SeriesDataMember = "Series"

			' Specify the chart range control client view.
			Dim areaView As New AreaChartRangeControlClientView()
			numericChartRangeControlClient1.DataProvider.TemplateView = areaView

			' Customize the area view appearance. 
			areaView.AreaOpacity = 90
			areaView.Color = Color.Gray
			areaView.ShowMarkers = True
			areaView.MarkerSize = 5
			areaView.MarkerColor = Color.Red

			' Specify the palette name to get a nice-looking chart.
			numericChartRangeControlClient1.PaletteName = "NatureColors"

			' Change the default range of the numeric chart range control client.          
			numericChartRangeControlClient1.Range.Min = 4
			numericChartRangeControlClient1.Range.Max = 12

			' Customize the grid options of the numeric chart range control client.          
			numericChartRangeControlClient1.GridOptions.GridSpacing = 2
			numericChartRangeControlClient1.GridOptions.SnapSpacing = 1
		End Sub

		Private Function GenerateNumericData() As List(Of NumericItem)

			For seriesIndex As Integer = 0 To seriesCount - 1
				For i As Integer = 0 To pointCount - 1
					data.Add(New NumericItem() With {.Argument = i, .Value = rand.Next(0, 30) + i, .Series = seriesIndex})
				Next i
			Next seriesIndex
			Return data
		End Function
	End Class

	Public Class NumericItem
		Private privateArgument As Double
		Public Property Argument() As Double
			Get
				Return privateArgument
			End Get
			Set(ByVal value As Double)
				privateArgument = value
			End Set
		End Property
		Private privateValue As Double
		Public Property Value() As Double
			Get
				Return privateValue
			End Get
			Set(ByVal value As Double)
				privateValue = value
			End Set
		End Property
		Private privateSeries As Double
		Public Property Series() As Double
			Get
				Return privateSeries
			End Get
			Set(ByVal value As Double)
				privateSeries = value
			End Set
		End Property
	End Class
End Namespace


