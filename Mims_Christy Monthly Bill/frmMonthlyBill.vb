'Program: Monthly Bill
'Programmer Name: Christy Mims
'Date: 2/21/17
'Description: This program allows the user to calculate their monthly internet bill through the use of text boxes, radio buttons, and
'check boxes.  The program also automatically calculates the information entered in for the user then displays all the data in a list
'box.
Public Class frmMonthlyBill
    Const Charge_Option_A As Decimal = 29.99D
    Const Charge_Option_B As Decimal = 39.99D
    Const Charge_Option_C As Decimal = 59.99D
    Const Canine_Shelter_Donation As Decimal = 1D
    Const World_Hunger_Donation As Decimal = 2D
    Const Literacy_Foundation_Donation As Decimal = 3D

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'This button allows the user to close the program.
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This button calculates and then displays the entered and chosen inforamtion in the list box.
        Dim Discount, base_rate, donation_1, donation_2, donation_3, total As Decimal
        Dim FormatList As String = " {0, -30}{1, 30}"

        lstResults.Items.Add(String.Format(FormatList, "Client Name:", txtName.Text))
        lstResults.Items.Add(String.Format(FormatList, "Account Number:", mskAccountNumber.Text))

        If radOptionA.Checked Then
            base_rate = Charge_Option_A
            lstResults.Items.Add(String.Format(FormatList, "Internet Option:", "Internet Package A"))
            lstResults.Items.Add(" ")
            lstResults.Items.Add(String.Format(FormatList, "Internet Service Base Charge:", base_rate.ToString("C")))
        ElseIf radOptionB.Checked Then
            base_rate = Charge_Option_B
            lstResults.Items.Add(String.Format(FormatList, "Internet Option:", "Internet Package B"))
            lstResults.Items.Add(" ")
            lstResults.Items.Add(String.Format(FormatList, "Internet Service Base Charge:", base_rate.ToString("C")))
        ElseIf radOptionC.Checked Then
            base_rate = Charge_Option_C
            lstResults.Items.Add(String.Format(FormatList, "Internet Option:", "Internet Package C"))
            lstResults.Items.Add(" ")
            lstResults.Items.Add(String.Format(FormatList, "Internet Service Base Charge:", base_rate.ToString("C")))
        End If


        If radDiscount10.Checked Then
            Discount = 0.1D * base_rate
            lstResults.Items.Add(String.Format(FormatList, "Discount:", (-1 * Discount).ToString("C")))
        ElseIf radDiscount20.Checked Then
            Discount = 0.2D * base_rate
            lstResults.Items.Add(String.Format(FormatList, "Discount:", (-1 * Discount).ToString("C")))
        Else
            Discount = 0
            lstResults.Items.Add(String.Format(FormatList, "Discount:", (-1 * Discount).ToString("C")))
        End If


        If chkCanineShelter.Checked Then
            donation_1 = Canine_Shelter_Donation
            lstResults.Items.Add(String.Format(FormatList, "The Canine Shelter:", donation_1.ToString("C")))
        Else
            donation_1 = 0
        End If
        If chkWorldHungerRelief.Checked Then
            donation_2 = World_Hunger_Donation
            lstResults.Items.Add(String.Format(FormatList, "World Hunger Relief:", donation_2.ToString("C")))
        Else
            donation_2 = 0
        End If
        If chkLiteracyFoundation.Checked Then
            donation_3 = Literacy_Foundation_Donation
            lstResults.Items.Add(String.Format(FormatList, "The Literacy Foundation:", donation_3.ToString("C")))
        Else
            donation_3 = 0
        End If


        total = base_rate - Discount + donation_1 + donation_2 + donation_3
        lstResults.Items.Add(String.Format(FormatList, "Total:", total.ToString("C")))
        lstResults.Items.Add(" ")
    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        'This button resets all the data chosen and entered in while keeping previous information entered in displayed in the list box.
        txtName.Text = ""
        mskAccountNumber.Text = ""
        radOptionA.Checked = False
        radOptionB.Checked = False
        radOptionC.Checked = False
        radDiscountNone.Checked = True
        radDiscount10.Checked = False
        radDiscount20.Checked = False
        chkCanineShelter.Checked = False
        chkLiteracyFoundation.Checked = False
        chkWorldHungerRelief.Checked = False
    End Sub
End Class
