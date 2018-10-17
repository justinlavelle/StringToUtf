<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.UtfTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ConvertToUtfButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.StringTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(754, 410)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.UtfTextBox)
        Me.MetroTabPage1.Controls.Add(Me.ConvertToUtfButton)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.StringTextBox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(746, 368)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Convert"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'UtfTextBox
        '
        '
        '
        '
        Me.UtfTextBox.CustomButton.Image = Nothing
        Me.UtfTextBox.CustomButton.Location = New System.Drawing.Point(630, 1)
        Me.UtfTextBox.CustomButton.Name = ""
        Me.UtfTextBox.CustomButton.Size = New System.Drawing.Size(109, 109)
        Me.UtfTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UtfTextBox.CustomButton.TabIndex = 1
        Me.UtfTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UtfTextBox.CustomButton.UseSelectable = True
        Me.UtfTextBox.CustomButton.Visible = False
        Me.UtfTextBox.Lines = New String(-1) {}
        Me.UtfTextBox.Location = New System.Drawing.Point(3, 227)
        Me.UtfTextBox.MaxLength = 32767
        Me.UtfTextBox.Multiline = True
        Me.UtfTextBox.Name = "UtfTextBox"
        Me.UtfTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UtfTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UtfTextBox.SelectedText = ""
        Me.UtfTextBox.SelectionLength = 0
        Me.UtfTextBox.SelectionStart = 0
        Me.UtfTextBox.ShortcutsEnabled = True
        Me.UtfTextBox.Size = New System.Drawing.Size(740, 111)
        Me.UtfTextBox.Style = MetroFramework.MetroColorStyle.Purple
        Me.UtfTextBox.TabIndex = 2
        Me.UtfTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UtfTextBox.UseSelectable = True
        Me.UtfTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UtfTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ConvertToUtfButton
        '
        Me.ConvertToUtfButton.Highlight = True
        Me.ConvertToUtfButton.Location = New System.Drawing.Point(566, 168)
        Me.ConvertToUtfButton.Name = "ConvertToUtfButton"
        Me.ConvertToUtfButton.Size = New System.Drawing.Size(177, 42)
        Me.ConvertToUtfButton.Style = MetroFramework.MetroColorStyle.Purple
        Me.ConvertToUtfButton.TabIndex = 1
        Me.ConvertToUtfButton.Text = "Convert Now!"
        Me.ConvertToUtfButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ConvertToUtfButton.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(0, 205)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Copy Convered Text Here:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'StringTextBox
        '
        '
        '
        '
        Me.StringTextBox.CustomButton.Image = Nothing
        Me.StringTextBox.CustomButton.Location = New System.Drawing.Point(630, 1)
        Me.StringTextBox.CustomButton.Name = ""
        Me.StringTextBox.CustomButton.Size = New System.Drawing.Size(109, 109)
        Me.StringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.StringTextBox.CustomButton.TabIndex = 1
        Me.StringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.StringTextBox.CustomButton.UseSelectable = True
        Me.StringTextBox.CustomButton.Visible = False
        Me.StringTextBox.Lines = New String(-1) {}
        Me.StringTextBox.Location = New System.Drawing.Point(3, 37)
        Me.StringTextBox.MaxLength = 32767
        Me.StringTextBox.Multiline = True
        Me.StringTextBox.Name = "StringTextBox"
        Me.StringTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.StringTextBox.SelectedText = ""
        Me.StringTextBox.SelectionLength = 0
        Me.StringTextBox.SelectionStart = 0
        Me.StringTextBox.ShortcutsEnabled = True
        Me.StringTextBox.Size = New System.Drawing.Size(740, 111)
        Me.StringTextBox.Style = MetroFramework.MetroColorStyle.Purple
        Me.StringTextBox.TabIndex = 0
        Me.StringTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.StringTextBox.UseSelectable = True
        Me.StringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StringTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(-4, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(135, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Paste Text to Convert:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(746, 368)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "About"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(-4, 26)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(276, 38)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "StringToUtf is Licensed under the M.I.T. License" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Feel free to use and alter to s" &
    "uit your needs."
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(454, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(285, 285)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String() {"Copyright 2015 Justin Lavelle", "", resources.GetString("MetroTextBox1.Lines"), "", "The above copyright notice and this permission notice shall be included in all co" &
            "pies or substantial portions of the Software.", "", resources.GetString("MetroTextBox1.Lines1")}
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 70)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(740, 287)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.Text = resources.GetString("MetroTextBox1.Text")
        Me.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 496)
        Me.MinimumSize = New System.Drawing.Size(800, 496)
        Me.Name = "MainForm"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "String to UTF Converter"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ConvertToUtfButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents StringTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents UtfTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
End Class
