Public Class Form1
    Public username, password As String

    Private Function custo_item() As Double

        Dim sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To grid_item.Rows.Count - 1
            sum = sum + Convert.ToDouble(grid_item.Rows(i).Cells(2).Value)
        Next i
        Return sum

    End Function

    Sub add_cust()
        Dim i As Integer = 0
        Dim tax, q As Double
        tax = 3.9

        If grid_item.Rows.Count > 0 Then
            txt_taxa.Text = FormatCurrency(((custo_item() * tax) / 100).ToString("0.00"))
            txt_subtotal.Text = FormatCurrency(custo_item().ToString("0.00"))
            q = ((custo_item() * tax) / 100)
            txt_totall.Text = FormatCurrency(q + custo_item().ToString("0.00"))
        End If


    End Sub
    Sub troco()
        Dim tax, q, c As Double
        tax = 3.9


        If grid_item.Rows.Count > 0 Then
            q = ((custo_item() * tax) / 100) + custo_item()
            c = Val(txt_pagamento.Text)
            txt_troco.Text = FormatCurrency((c - q).ToString("0.00"))

        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_troco.Text = " "
        txt_totall.Text = " "
        txt_taxa.Text = " "
        txt_pagamento.Text = " "
        txt_subtotal.Text = " "
        bx_metpagamento.Text = " "
        grid_item.Rows.Clear()
        grid_item.Refresh()
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles btt_cinco.Click, btt_tres.Click, Btt_dois.Click, btt_um.Click, btt_zero.Click, btt_ponto.Click, btt_nove.Click, btt_sete.Click, btt_oito.Click, Btt_seis.Click, Btt_quatro.Click
        Dim b As Button = sender

        If txt_pagamento.Text = "0" Then
            txt_pagamento.Text = " "
            txt_pagamento.Text = b.Text
        ElseIf b.Text = "." Then
            If Not txt_pagamento.Text.Contains(" . ") Then
                txt_pagamento.Text = txt_pagamento.Text + b.Text
            End If
        Else
            txt_pagamento.Text = txt_pagamento.Text + b.Text
        End If
    End Sub

    Private Sub btt_clear_Click(sender As Object, e As EventArgs) Handles btt_clear.Click
        txt_pagamento.Text = "0"
        bx_metpagamento.Text = " "
        txt_troco.Text = " "
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bx_metpagamento.Items.Add(" Dinheiro ")
        bx_metpagamento.Items.Add(" Credito ")
        bx_metpagamento.Items.Add(" Debito ")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        troco()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For Each row As DataGridViewRow In grid_item.SelectedRows
            grid_item.Rows.Remove(row)
        Next
        add_cust()
        troco()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, txt_taxa.Click, txt_taxa.Validated
        Dim custoitem As Double = 0.45

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Água" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Água", "1", custoitem)
        add_cust()

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim custoitem As Double = 0.7

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Café Preto" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Café Preto", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim custoitem As Double = 1.8

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Capoccino" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Capoccino", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim custoitem As Double = 1.8

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Suco De laranja" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Suco De laranja", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim custoitem As Double = 2.1

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Suco Detox" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Suco Detox", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim custoitem As Double = 5.49

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Chese-Bacon" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Chese-Bacon", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim custoitem As Double = 3.4

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Bolo De Nozes pedaç" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Bolo De Nozes pedaç", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim custoitem As Double = 3.4

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "Bolo De Cenoura pedaç" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("Bolo De Cenoura pedaç", "1", custoitem)
        add_cust()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim custoitem As Double = 4.8

        For Each row As DataGridViewRow In grid_item.Rows
            If row.Cells(0).Value = "CheseBurguer" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * custoitem
                Exit Sub
            End If
        Next
        grid_item.Rows.Add("CheseBurguer", "1", custoitem)
        add_cust()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.grid_item.Width, Me.grid_item.Height)
        grid_item.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.grid_item.Width, Me.grid_item.Height))
        e.Graphics.DrawImage(imagebmp, 120, 20)
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btt_total.Click
        add_cust()
    End Sub

End Class



