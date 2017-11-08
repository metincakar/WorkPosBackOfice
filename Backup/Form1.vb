Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Q364852
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim xtraForm1 As New XtraForm1()
			xtraForm1.MdiParent = Me
			xtraForm1.WindowState = FormWindowState.Maximized
			xtraForm1.Show()
		End Sub
	End Class
End Namespace
