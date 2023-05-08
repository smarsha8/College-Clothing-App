Public Class FrmClothingApp
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This button event when clicked calls three sub methods to compute discounted price

        lblThePrice.Visible = True









        Dim cdecdiscount As Decimal = 0.5D
        Dim intDiscount As Integer
        Dim strDiscount As String = ""
        Dim decPrice As Decimal

        Dim strItem As String = ""
        Dim strOrder As String = ""
        Dim decPercentdiscount As String = ""
        Dim decFinalCost As Decimal

        Dim strPrice As String = ""

        Dim decEntry As Decimal



        If IsNumeric(txtquantityentry.Text) Then


            intDiscount = Convert.ToInt32(txtquantityentry.Text)
            strDiscount = "after discount of 50%."
            'MsgBox(intDiscount)





            If rdbtncap.Checked Then
                decPrice = 10D
                strOrder = "CSU Cap"
            ElseIf rdbtnHoodie.Checked Then
                decPrice = 30D
                strOrder = "CSU Hoodie"
            ElseIf rdbtnTShirt.Checked Then
                decPrice = 10D
                strOrder = "CSU T-Shirt"

            End If

            decEntry = (intDiscount * 50) / 100



            If decEntry > 1 Then
                decEntry = 1
            End If



            MsgBox(decEntry)





            lblThePrice.Text = "Your Price For" & strOrder & "Merchandise Cost" & decFinalCost.ToString("C") & strPrice & strDiscount
        Else



            MsgBox("An Error Has Occured!!!",, "Valid Numerical Input Is Needed!")
            Me.btnClear.PerformClick()



        End If
    End Sub

    Private Sub FrmClothingApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnClear.PerformClick()
    End Sub


    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click


        rdbtncap.Checked = True
        rdbtnHoodie.Checked = False
        rdbtnTShirt.Checked = False
        txtquantityentry.Text = ""
        txtquantityentry.Focus()

        lblThePrice.Visible = False















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





End Class








