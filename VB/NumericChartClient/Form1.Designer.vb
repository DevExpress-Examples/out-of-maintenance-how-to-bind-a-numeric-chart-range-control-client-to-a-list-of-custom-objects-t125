Imports Microsoft.VisualBasic
Imports System
Namespace NumericChartClient
	Partial Public Class Form1
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
			Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
			Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
			Me.numericChartRangeControlClient1 = New DevExpress.XtraEditors.NumericChartRangeControlClient()
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericChartRangeControlClient1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rangeControl1
			' 
			Me.rangeControl1.Client = Me.numericChartRangeControlClient1
			Me.rangeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rangeControl1.Location = New System.Drawing.Point(0, 0)
			Me.rangeControl1.Name = "rangeControl1"
			rangeControlRange1.Maximum = 9R
			rangeControlRange1.Minimum = 0R
			rangeControlRange1.Owner = Me.rangeControl1
			Me.rangeControl1.SelectedRange = rangeControlRange1
			Me.rangeControl1.Size = New System.Drawing.Size(508, 296)
			Me.rangeControl1.TabIndex = 1
			Me.rangeControl1.Text = "rangeControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(508, 296)
			Me.Controls.Add(Me.rangeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericChartRangeControlClient1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private numericChartRangeControlClient1 As DevExpress.XtraEditors.NumericChartRangeControlClient
		Private rangeControl1 As DevExpress.XtraEditors.RangeControl
	End Class
End Namespace

