<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tabsMain = New System.Windows.Forms.TabControl()
        Me.tabCourse = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chlSea = New System.Windows.Forms.CheckedListBox()
        Me.chlChicken = New System.Windows.Forms.CheckedListBox()
        Me.chlBeef = New System.Windows.Forms.CheckedListBox()
        Me.chlPork = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chlDessert = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.chlMerienda = New System.Windows.Forms.CheckedListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.chlDrinks = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPAX = New System.Windows.Forms.TextBox()
        Me.tabsMain.SuspendLayout()
        Me.tabCourse.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        resources.ApplyResources(Me.btnCompute, "btnCompute")
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.Name = "lblTotal"
        '
        'tabsMain
        '
        Me.tabsMain.Controls.Add(Me.tabCourse)
        Me.tabsMain.Controls.Add(Me.TabPage2)
        Me.tabsMain.Controls.Add(Me.TabPage1)
        resources.ApplyResources(Me.tabsMain, "tabsMain")
        Me.tabsMain.Name = "tabsMain"
        Me.tabsMain.SelectedIndex = 0
        '
        'tabCourse
        '
        Me.tabCourse.Controls.Add(Me.Label5)
        Me.tabCourse.Controls.Add(Me.Label4)
        Me.tabCourse.Controls.Add(Me.Label3)
        Me.tabCourse.Controls.Add(Me.Label2)
        Me.tabCourse.Controls.Add(Me.chlSea)
        Me.tabCourse.Controls.Add(Me.chlChicken)
        Me.tabCourse.Controls.Add(Me.chlBeef)
        Me.tabCourse.Controls.Add(Me.chlPork)
        resources.ApplyResources(Me.tabCourse, "tabCourse")
        Me.tabCourse.Name = "tabCourse"
        Me.tabCourse.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'chlSea
        '
        Me.chlSea.FormattingEnabled = True
        Me.chlSea.Items.AddRange(New Object() {resources.GetString("chlSea.Items"), resources.GetString("chlSea.Items1"), resources.GetString("chlSea.Items2"), resources.GetString("chlSea.Items3")})
        resources.ApplyResources(Me.chlSea, "chlSea")
        Me.chlSea.Name = "chlSea"
        '
        'chlChicken
        '
        Me.chlChicken.FormattingEnabled = True
        Me.chlChicken.Items.AddRange(New Object() {resources.GetString("chlChicken.Items"), resources.GetString("chlChicken.Items1"), resources.GetString("chlChicken.Items2"), resources.GetString("chlChicken.Items3"), resources.GetString("chlChicken.Items4"), resources.GetString("chlChicken.Items5")})
        resources.ApplyResources(Me.chlChicken, "chlChicken")
        Me.chlChicken.Name = "chlChicken"
        '
        'chlBeef
        '
        Me.chlBeef.FormattingEnabled = True
        Me.chlBeef.Items.AddRange(New Object() {resources.GetString("chlBeef.Items"), resources.GetString("chlBeef.Items1"), resources.GetString("chlBeef.Items2"), resources.GetString("chlBeef.Items3")})
        resources.ApplyResources(Me.chlBeef, "chlBeef")
        Me.chlBeef.Name = "chlBeef"
        '
        'chlPork
        '
        Me.chlPork.FormattingEnabled = True
        Me.chlPork.Items.AddRange(New Object() {resources.GetString("chlPork.Items"), resources.GetString("chlPork.Items1"), resources.GetString("chlPork.Items2"), resources.GetString("chlPork.Items3"), resources.GetString("chlPork.Items4"), resources.GetString("chlPork.Items5")})
        resources.ApplyResources(Me.chlPork, "chlPork")
        Me.chlPork.Name = "chlPork"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chlDessert)
        Me.TabPage2.Controls.Add(Me.CheckedListBox2)
        Me.TabPage2.Controls.Add(Me.chlMerienda)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chlDessert
        '
        Me.chlDessert.FormattingEnabled = True
        Me.chlDessert.Items.AddRange(New Object() {resources.GetString("chlDessert.Items"), resources.GetString("chlDessert.Items1"), resources.GetString("chlDessert.Items2"), resources.GetString("chlDessert.Items3"), resources.GetString("chlDessert.Items4"), resources.GetString("chlDessert.Items5"), resources.GetString("chlDessert.Items6"), resources.GetString("chlDessert.Items7")})
        resources.ApplyResources(Me.chlDessert, "chlDessert")
        Me.chlDessert.Name = "chlDessert"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        resources.ApplyResources(Me.CheckedListBox2, "CheckedListBox2")
        Me.CheckedListBox2.Name = "CheckedListBox2"
        '
        'chlMerienda
        '
        Me.chlMerienda.FormattingEnabled = True
        Me.chlMerienda.Items.AddRange(New Object() {resources.GetString("chlMerienda.Items"), resources.GetString("chlMerienda.Items1"), resources.GetString("chlMerienda.Items2"), resources.GetString("chlMerienda.Items3"), resources.GetString("chlMerienda.Items4"), resources.GetString("chlMerienda.Items5"), resources.GetString("chlMerienda.Items6")})
        resources.ApplyResources(Me.chlMerienda, "chlMerienda")
        Me.chlMerienda.Name = "chlMerienda"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckedListBox3)
        Me.TabPage1.Controls.Add(Me.CheckedListBox1)
        Me.TabPage1.Controls.Add(Me.chlDrinks)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {resources.GetString("CheckedListBox3.Items"), resources.GetString("CheckedListBox3.Items1"), resources.GetString("CheckedListBox3.Items2"), resources.GetString("CheckedListBox3.Items3"), resources.GetString("CheckedListBox3.Items4")})
        resources.ApplyResources(Me.CheckedListBox3, "CheckedListBox3")
        Me.CheckedListBox3.Name = "CheckedListBox3"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {resources.GetString("CheckedListBox1.Items"), resources.GetString("CheckedListBox1.Items1"), resources.GetString("CheckedListBox1.Items2"), resources.GetString("CheckedListBox1.Items3"), resources.GetString("CheckedListBox1.Items4")})
        resources.ApplyResources(Me.CheckedListBox1, "CheckedListBox1")
        Me.CheckedListBox1.Name = "CheckedListBox1"
        '
        'chlDrinks
        '
        Me.chlDrinks.FormattingEnabled = True
        Me.chlDrinks.Items.AddRange(New Object() {resources.GetString("chlDrinks.Items"), resources.GetString("chlDrinks.Items1"), resources.GetString("chlDrinks.Items2"), resources.GetString("chlDrinks.Items3"), resources.GetString("chlDrinks.Items4")})
        resources.ApplyResources(Me.chlDrinks, "chlDrinks")
        Me.chlDrinks.Name = "chlDrinks"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtPAX
        '
        resources.ApplyResources(Me.txtPAX, "txtPAX")
        Me.txtPAX.Name = "txtPAX"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtPAX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tabsMain)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCompute)
        Me.Name = "Form1"
        Me.tabsMain.ResumeLayout(False)
        Me.tabCourse.ResumeLayout(False)
        Me.tabCourse.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents tabsMain As TabControl
    Friend WithEvents tabCourse As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chlPork As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chlSea As CheckedListBox
    Friend WithEvents chlChicken As CheckedListBox
    Friend WithEvents chlBeef As CheckedListBox
    Friend WithEvents chlDessert As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents chlMerienda As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents chlDrinks As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPAX As TextBox

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        lblTotal.Text = "P500.0"


    End Sub
End Class
