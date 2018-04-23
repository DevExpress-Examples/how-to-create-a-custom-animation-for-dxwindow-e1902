Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace Q386075
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub showPopup(ByVal sender As Object, ByVal e As RoutedEventArgs)
			popupWindow.Show()
		End Sub
		Private Sub popupWindow_Closed(ByVal sender As Object, ByVal e As EventArgs)
			popupWindow.ShowAnimation.Stop()
			popupWindow.HideAnimation.Stop()
		End Sub
		Private Sub closePopup(ByVal sender As Object, ByVal e As RoutedEventArgs)
			popupWindow.Hide()
		End Sub
	End Class
End Namespace