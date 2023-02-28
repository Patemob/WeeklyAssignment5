<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvention))
        Me.ComicPic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radSuperExperience = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.ComicPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComicPic
        '
        Me.ComicPic.Image = CType(resources.GetObject("ComicPic.Image"), System.Drawing.Image)
        Me.ComicPic.Location = New System.Drawing.Point(2, 2)
        Me.ComicPic.Name = "ComicPic"
        Me.ComicPic.Size = New System.Drawing.Size(698, 212)
        Me.ComicPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ComicPic.TabIndex = 2
        Me.ComicPic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(52, 217)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(599, 55)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.Red
        Me.txtGroupSize.Location = New System.Drawing.Point(419, 291)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(70, 31)
        Me.txtGroupSize.TabIndex = 4
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Red
        Me.lblGroupSize.Location = New System.Drawing.Point(210, 283)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(176, 39)
        Me.lblGroupSize.TabIndex = 5
        Me.lblGroupSize.Text = "Group Size:"
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radAutographs)
        Me.grpBadgeType.Controls.Add(Me.radSuperExperience)
        Me.grpBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Red
        Me.grpBadgeType.Location = New System.Drawing.Point(113, 330)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(477, 160)
        Me.grpBadgeType.TabIndex = 6
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radSuperExperience
        '
        Me.radSuperExperience.AutoSize = True
        Me.radSuperExperience.Checked = True
        Me.radSuperExperience.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperExperience.Location = New System.Drawing.Point(38, 30)
        Me.radSuperExperience.Name = "radSuperExperience"
        Me.radSuperExperience.Size = New System.Drawing.Size(382, 27)
        Me.radSuperExperience.TabIndex = 0
        Me.radSuperExperience.TabStop = True
        Me.radSuperExperience.Text = "Convention + Superhero Experience"
        Me.radSuperExperience.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutographs.Location = New System.Drawing.Point(38, 70)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(278, 27)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(38, 115)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(141, 27)
        Me.radConvention.TabIndex = 2
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Red
        Me.lblCost.Location = New System.Drawing.Point(157, 521)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(236, 35)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Registration Cost: "
        '
        'lblCostPrice
        '
        Me.lblCostPrice.AutoSize = True
        Me.lblCostPrice.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPrice.ForeColor = System.Drawing.Color.Red
        Me.lblCostPrice.Location = New System.Drawing.Point(454, 521)
        Me.lblCostPrice.Name = "lblCostPrice"
        Me.lblCostPrice.Size = New System.Drawing.Size(92, 35)
        Me.lblCostPrice.TabIndex = 8
        Me.lblCostPrice.Text = "$0000"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(105, 604)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(194, 54)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(403, 604)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(194, 54)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(702, 677)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostPrice)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.ComicPic)
        Me.Name = "frmConvention"
        Me.Text = "Comic Convention Registration"
        CType(Me.ComicPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComicPic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperExperience As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCostPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
