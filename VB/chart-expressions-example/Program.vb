Imports DevExpress.XtraReports.UI
Imports ExpressionsExample
Imports System

Namespace chart_expressions_example
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Dim report As New XtraReport1()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowRibbonPreviewDialog()
		End Sub
	End Module
End Namespace
