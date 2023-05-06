Public Class FrmClothingApp
    Private _decCapCost As Decimal = 10D
    Private _decHoodieCost As Decimal = 30D
    Private _decTshirt As Decimal = 10D

    Private Sub picimage_Click(sender As Object, e As EventArgs) Handles picimage.Click

    End Sub

    Private Sub lbl50percentoff_Click(sender As Object, e As EventArgs) Handles lbl50percentoff.Click
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl50percentoff.Visible = True
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl50percentoff.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtquantityentry.Text = ""
        lblThePrice.Visible = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This button event when clicked calls three sub methods to compute discounted price

        ComputeCapDiscount()
        ComputeHoodieDiscount()
        ComputeTshirtDiscount()

    End Sub

    Private Sub ComputeHoodieDiscount()
        Dim strNumberofHoodiesPurchased = txtquantityentry.Text
        'MsgBox(strNumberofHoodiesPurchased)
        Dim _decHoodie As Decimal = 30D
        Dim _decdiscount As Decimal = 0.5D

        Dim intNumberofHoodiesPuchaced As Integer
        intNumberofHoodiesPuchaced = Convert.ToInt32(strNumberofHoodiesPurchased)




        Dim dectotal As Decimal = _decdiscount * _decHoodie
        'MsgBox(dectotal)

        lblThePrice.Visible = True
        lblThePrice.Text = dectotal.ToString("c")



    End Sub
    Private Sub ComputeTshirtDiscount()
        Dim strNumberofTshirtsPurchased = txtquantityentry.Text
        Dim intTshirt As Integer = 10D
        Dim _decTshirt50PercentDiscount As Decimal = 0.5D
        Dim intNumberofTshirtsPurchased As Integer
        intNumberofTshirtsPurchased = Convert.ToInt32(strNumberofTshirtsPurchased)

        Dim dectotal As Decimal = _decTshirt50PercentDiscount * intTshirt * intNumberofTshirtsPurchased



        lblThePrice.Text = dectotal.ToString("c")
        lblThePrice.Visible = True
    End Sub
    Private Sub ComputeCapDiscount()
        Dim intCap As Integer = 10D


        Dim strNumberofItemsPurchased = txtquantityentry.Text
        Dim _dec50PercentDiscount As Decimal = 0.5D
        Dim intNumberofitemsPurchased As Integer
        intNumberofitemsPurchased = Convert.ToInt32(strNumberofItemsPurchased)

        Dim dectotal As Decimal = _dec50PercentDiscount * intCap * intNumberofitemsPurchased

        lblThePrice.Text = dectotal.ToString("c")
        lblThePrice.Visible = True




    End Sub










End Class








