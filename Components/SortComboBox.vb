Public Class SortComboBox
    Inherits ComboBox
    Private vDisabledItems As New Collection

    Public Sub New()
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
    End Sub

    Public Property DisabledItems(ByVal Index As Integer) As Boolean
        Get
            Dim retVal As Boolean
            If vDisabledItems.Contains("Key" & CStr(Index)) Then
                retVal = CBool(vDisabledItems("Key" & CStr(Index)))
            Else
                retVal = False
            End If
            Return retVal
        End Get
        Set(ByVal value As Boolean)
            If vDisabledItems.Contains("Key" & CStr(Index)) Then
                vDisabledItems.Remove("Key" & CStr(Index))
            End If

            If value = True Then
                vDisabledItems.Add("-1", "Key" & CStr(Index))
            End If
        End Set
    End Property

    Private Sub EnableItemComboBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        Dim Pn As Pen
        If e.Index > -1 Then
            If DisabledItems(e.Index) = False Then
                Pn = New Pen(Color.FromKnownColor(KnownColor.WindowText))
            Else
                Pn = New Pen(Color.FromKnownColor(KnownColor.InactiveCaptionText))
            End If

            Dim Br As Brush = Pn.Brush
            e.DrawBackground()
            e.DrawFocusRectangle()
            e.Graphics.DrawString(Me.Items(e.Index).ToString, e.Font, Br, e.Bounds.X, e.Bounds.Y)
        End If
    End Sub

    Private Sub EnableItemComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
        If DisabledItems(Me.SelectedIndex) = True Then
            Dim NewIndex As Integer = FindEnabledIndex(Me.SelectedIndex, True)
            If NewIndex = -1 Then
                NewIndex = FindEnabledIndex(Me.SelectedIndex, False)
            End If

            If NewIndex - 1 Then
                Me.SelectedIndex = -1
                Beep()
            End If
        End If
    End Sub

    Private Function FindEnabledIndex(ByVal StartValue As Integer, ByVal Descending As Boolean) As Integer
        Dim EndValue As Integer
        Dim Steps As Integer
        Dim t As Integer
        Dim retValue As Integer = -1

        If Descending = True Then
            StartValue = Items.Count - 1
            EndValue = 0
            Steps = -1
        Else
            StartValue = 0
            EndValue = Items.Count - 1
            Steps = 1
        End If

        For t = StartValue To EndValue Step Steps
            If DisabledItems(t) = False Then
                retValue = t
                Exit For
            End If
        Next

        Return retValue
    End Function
End Class
