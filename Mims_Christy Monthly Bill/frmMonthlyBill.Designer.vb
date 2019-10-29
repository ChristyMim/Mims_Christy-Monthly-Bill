<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyBill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlyBill))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskAccountNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radDiscount20 = New System.Windows.Forms.RadioButton()
        Me.radDiscount10 = New System.Windows.Forms.RadioButton()
        Me.radDiscountNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radOptionC = New System.Windows.Forms.RadioButton()
        Me.radOptionB = New System.Windows.Forms.RadioButton()
        Me.radOptionA = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkLiteracyFoundation = New System.Windows.Forms.CheckBox()
        Me.chkWorldHungerRelief = New System.Windows.Forms.CheckBox()
        Me.chkCanineShelter = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.mskAccountNumber)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Information"
        '
        'mskAccountNumber
        '
        Me.mskAccountNumber.Location = New System.Drawing.Point(170, 69)
        Me.mskAccountNumber.Mask = "0000000"
        Me.mskAccountNumber.Name = "mskAccountNumber"
        Me.mskAccountNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskAccountNumber.Size = New System.Drawing.Size(145, 20)
        Me.mskAccountNumber.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(170, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 20)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.radDiscount20)
        Me.GroupBox2.Controls.Add(Me.radDiscount10)
        Me.GroupBox2.Controls.Add(Me.radDiscountNone)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(553, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 116)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Promotional Discount"
        '
        'radDiscount20
        '
        Me.radDiscount20.AutoSize = True
        Me.radDiscount20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiscount20.Location = New System.Drawing.Point(351, 53)
        Me.radDiscount20.Name = "radDiscount20"
        Me.radDiscount20.Size = New System.Drawing.Size(55, 20)
        Me.radDiscount20.TabIndex = 2
        Me.radDiscount20.TabStop = True
        Me.radDiscount20.Text = "20%"
        Me.radDiscount20.UseVisualStyleBackColor = True
        '
        'radDiscount10
        '
        Me.radDiscount10.AutoSize = True
        Me.radDiscount10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiscount10.Location = New System.Drawing.Point(193, 53)
        Me.radDiscount10.Name = "radDiscount10"
        Me.radDiscount10.Size = New System.Drawing.Size(55, 20)
        Me.radDiscount10.TabIndex = 1
        Me.radDiscount10.TabStop = True
        Me.radDiscount10.Text = "10%"
        Me.radDiscount10.UseVisualStyleBackColor = True
        '
        'radDiscountNone
        '
        Me.radDiscountNone.AutoSize = True
        Me.radDiscountNone.Checked = True
        Me.radDiscountNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiscountNone.Location = New System.Drawing.Point(29, 53)
        Me.radDiscountNone.Name = "radDiscountNone"
        Me.radDiscountNone.Size = New System.Drawing.Size(63, 20)
        Me.radDiscountNone.TabIndex = 0
        Me.radDiscountNone.TabStop = True
        Me.radDiscountNone.Text = "None"
        Me.radDiscountNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.radOptionC)
        Me.GroupBox3.Controls.Add(Me.radOptionB)
        Me.GroupBox3.Controls.Add(Me.radOptionA)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(34, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 159)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Internet Option"
        '
        'radOptionC
        '
        Me.radOptionC.AutoSize = True
        Me.radOptionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOptionC.Location = New System.Drawing.Point(23, 120)
        Me.radOptionC.Name = "radOptionC"
        Me.radOptionC.Size = New System.Drawing.Size(220, 20)
        Me.radOptionC.TabIndex = 2
        Me.radOptionC.TabStop = True
        Me.radOptionC.Text = "Internet Option C (100 Mbps)"
        Me.radOptionC.UseVisualStyleBackColor = True
        '
        'radOptionB
        '
        Me.radOptionB.AutoSize = True
        Me.radOptionB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOptionB.Location = New System.Drawing.Point(23, 76)
        Me.radOptionB.Name = "radOptionB"
        Me.radOptionB.Size = New System.Drawing.Size(212, 20)
        Me.radOptionB.TabIndex = 1
        Me.radOptionB.TabStop = True
        Me.radOptionB.Text = "Internet Option B (50 Mbps)"
        Me.radOptionB.UseVisualStyleBackColor = True
        '
        'radOptionA
        '
        Me.radOptionA.AutoSize = True
        Me.radOptionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOptionA.Location = New System.Drawing.Point(23, 32)
        Me.radOptionA.Name = "radOptionA"
        Me.radOptionA.Size = New System.Drawing.Size(212, 20)
        Me.radOptionA.TabIndex = 0
        Me.radOptionA.TabStop = True
        Me.radOptionA.Text = "Internet Option A (24 Mbps)"
        Me.radOptionA.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.chkLiteracyFoundation)
        Me.GroupBox4.Controls.Add(Me.chkWorldHungerRelief)
        Me.GroupBox4.Controls.Add(Me.chkCanineShelter)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(553, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(434, 159)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Charitable Donation"
        '
        'chkLiteracyFoundation
        '
        Me.chkLiteracyFoundation.AutoSize = True
        Me.chkLiteracyFoundation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiteracyFoundation.Location = New System.Drawing.Point(29, 120)
        Me.chkLiteracyFoundation.Name = "chkLiteracyFoundation"
        Me.chkLiteracyFoundation.Size = New System.Drawing.Size(288, 20)
        Me.chkLiteracyFoundation.TabIndex = 2
        Me.chkLiteracyFoundation.Text = "The Literacy Foundation ($3 dontaion)"
        Me.chkLiteracyFoundation.UseVisualStyleBackColor = True
        '
        'chkWorldHungerRelief
        '
        Me.chkWorldHungerRelief.AutoSize = True
        Me.chkWorldHungerRelief.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWorldHungerRelief.Location = New System.Drawing.Point(29, 76)
        Me.chkWorldHungerRelief.Name = "chkWorldHungerRelief"
        Me.chkWorldHungerRelief.Size = New System.Drawing.Size(261, 20)
        Me.chkWorldHungerRelief.TabIndex = 1
        Me.chkWorldHungerRelief.Text = "World Hunger Relief ($2 donation)"
        Me.chkWorldHungerRelief.UseVisualStyleBackColor = True
        '
        'chkCanineShelter
        '
        Me.chkCanineShelter.AutoSize = True
        Me.chkCanineShelter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCanineShelter.Location = New System.Drawing.Point(29, 32)
        Me.chkCanineShelter.Name = "chkCanineShelter"
        Me.chkCanineShelter.Size = New System.Drawing.Size(253, 20)
        Me.chkCanineShelter.TabIndex = 0
        Me.chkCanineShelter.Text = "The Canine Shelter ($1 donation)"
        Me.chkCanineShelter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Boulevard Internet Service"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(34, 500)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(953, 228)
        Me.lstResults.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(312, 425)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 51)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNewClient
        '
        Me.btnNewClient.Location = New System.Drawing.Point(483, 425)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(111, 51)
        Me.btnNewClient.TabIndex = 5
        Me.btnNewClient.Text = "&New Client"
        Me.btnNewClient.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(654, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 51)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMonthlyBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1022, 769)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewClient)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMonthlyBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mskAccountNumber As MaskedTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radDiscount20 As RadioButton
    Friend WithEvents radDiscount10 As RadioButton
    Friend WithEvents radDiscountNone As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radOptionC As RadioButton
    Friend WithEvents radOptionB As RadioButton
    Friend WithEvents radOptionA As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkLiteracyFoundation As CheckBox
    Friend WithEvents chkWorldHungerRelief As CheckBox
    Friend WithEvents chkCanineShelter As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNewClient As Button
    Friend WithEvents btnExit As Button
End Class
