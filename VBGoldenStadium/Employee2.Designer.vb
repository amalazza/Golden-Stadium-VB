<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnTransac = New System.Windows.Forms.Button()
        Me.btnSeat = New System.Windows.Forms.Button()
        Me.btnMatch = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.TableEmp = New System.Windows.Forms.DataGridView()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Insert = New System.Windows.Forms.Button()
        Me.UpdateE = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Names = New System.Windows.Forms.TextBox()
        Me.Position = New System.Windows.Forms.ComboBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Salary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        Me.Panel26.SuspendLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel28.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 65)
        Me.Panel2.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dashboard / Employee Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.btnTransac)
        Me.Panel1.Controls.Add(Me.btnSeat)
        Me.Panel1.Controls.Add(Me.btnMatch)
        Me.Panel1.Controls.Add(Me.btnEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 611)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 92)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(41, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nama Admin"
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.DodgerBlue
        Me.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logout.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.logout.Image = Global.VBGoldenStadium.My.Resources.Resources.LogOut
        Me.logout.Location = New System.Drawing.Point(81, 557)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(52, 42)
        Me.logout.TabIndex = 13
        Me.logout.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(170, 510)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(20, 20)
        Me.Button7.TabIndex = 12
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(12, 510)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(20, 20)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnTransac
        '
        Me.btnTransac.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTransac.FlatAppearance.BorderSize = 0
        Me.btnTransac.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransac.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransac.ForeColor = System.Drawing.Color.White
        Me.btnTransac.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnTransac.Location = New System.Drawing.Point(8, 294)
        Me.btnTransac.Name = "btnTransac"
        Me.btnTransac.Size = New System.Drawing.Size(192, 38)
        Me.btnTransac.TabIndex = 3
        Me.btnTransac.Text = "Transaction"
        Me.btnTransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransac.UseVisualStyleBackColor = False
        '
        'btnSeat
        '
        Me.btnSeat.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSeat.FlatAppearance.BorderSize = 0
        Me.btnSeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeat.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeat.ForeColor = System.Drawing.Color.White
        Me.btnSeat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeat.Location = New System.Drawing.Point(8, 250)
        Me.btnSeat.Name = "btnSeat"
        Me.btnSeat.Size = New System.Drawing.Size(192, 38)
        Me.btnSeat.TabIndex = 2
        Me.btnSeat.Text = "Seat"
        Me.btnSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSeat.UseVisualStyleBackColor = False
        '
        'btnMatch
        '
        Me.btnMatch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMatch.FlatAppearance.BorderSize = 0
        Me.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatch.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatch.ForeColor = System.Drawing.Color.White
        Me.btnMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatch.Location = New System.Drawing.Point(8, 206)
        Me.btnMatch.Name = "btnMatch"
        Me.btnMatch.Size = New System.Drawing.Size(192, 38)
        Me.btnMatch.TabIndex = 1
        Me.btnMatch.Text = "Match"
        Me.btnMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMatch.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEmployee.FlatAppearance.BorderSize = 0
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmployee.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Location = New System.Drawing.Point(8, 162)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(192, 38)
        Me.btnEmployee.TabIndex = 0
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.AutoScroll = True
        Me.pnlDashboard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDashboard.Controls.Add(Me.Panel26)
        Me.pnlDashboard.Controls.Add(Me.Panel28)
        Me.pnlDashboard.Controls.Add(Me.Panel7)
        Me.pnlDashboard.Controls.Add(Me.Panel9)
        Me.pnlDashboard.Controls.Add(Me.Panel6)
        Me.pnlDashboard.Controls.Add(Me.Panel3)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(944, 611)
        Me.pnlDashboard.TabIndex = 29
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Controls.Add(Me.TableEmp)
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Location = New System.Drawing.Point(206, 102)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(726, 113)
        Me.Panel26.TabIndex = 38
        '
        'TableEmp
        '
        Me.TableEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableEmp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableEmp.Location = New System.Drawing.Point(24, 10)
        Me.TableEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.TableEmp.Name = "TableEmp"
        Me.TableEmp.RowTemplate.Height = 24
        Me.TableEmp.Size = New System.Drawing.Size(700, 98)
        Me.TableEmp.TabIndex = 29
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel27.Location = New System.Drawing.Point(-5, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(10, 115)
        Me.Panel27.TabIndex = 5
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel28.Controls.Add(Me.Label33)
        Me.Panel28.Location = New System.Drawing.Point(206, 71)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(726, 36)
        Me.Panel28.TabIndex = 37
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semilight", 13.25!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Location = New System.Drawing.Point(8, 3)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(130, 25)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Employee Table"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Search)
        Me.Panel7.Location = New System.Drawing.Point(206, 252)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(726, 43)
        Me.Panel7.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(220, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Search"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(-5, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 99)
        Me.Panel8.TabIndex = 5
        '
        'Search
        '
        Me.Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Search.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(344, 11)
        Me.Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(162, 22)
        Me.Search.TabIndex = 32
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(206, 221)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(726, 36)
        Me.Panel9.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 13.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(8, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Employee Search"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Location = New System.Drawing.Point(206, 304)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(726, 36)
        Me.Panel6.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semilight", 13.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(19, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 25)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Employee Data"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Insert)
        Me.Panel3.Controls.Add(Me.UpdateE)
        Me.Panel3.Controls.Add(Me.Delete)
        Me.Panel3.Controls.Add(Me.Names)
        Me.Panel3.Controls.Add(Me.Position)
        Me.Panel3.Controls.Add(Me.Gender)
        Me.Panel3.Controls.Add(Me.Password)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Username)
        Me.Panel3.Controls.Add(Me.Salary)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Phone)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Address)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Id)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(206, 335)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(726, 272)
        Me.Panel3.TabIndex = 33
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.Tomato
        Me.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Insert.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.ForeColor = System.Drawing.Color.White
        Me.Insert.Location = New System.Drawing.Point(431, 232)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(75, 32)
        Me.Insert.TabIndex = 43
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = False
        '
        'UpdateE
        '
        Me.UpdateE.BackColor = System.Drawing.Color.Tomato
        Me.UpdateE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateE.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateE.ForeColor = System.Drawing.Color.White
        Me.UpdateE.Location = New System.Drawing.Point(329, 232)
        Me.UpdateE.Name = "UpdateE"
        Me.UpdateE.Size = New System.Drawing.Size(75, 32)
        Me.UpdateE.TabIndex = 42
        Me.UpdateE.Text = "Update"
        Me.UpdateE.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Tomato
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Delete.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Location = New System.Drawing.Point(223, 232)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 32)
        Me.Delete.TabIndex = 41
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Names
        '
        Me.Names.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Names.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Names.Location = New System.Drawing.Point(344, 32)
        Me.Names.Margin = New System.Windows.Forms.Padding(2)
        Me.Names.MaxLength = 50
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(162, 22)
        Me.Names.TabIndex = 40
        '
        'Position
        '
        Me.Position.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position.FormattingEnabled = True
        Me.Position.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.Position.Location = New System.Drawing.Point(344, 129)
        Me.Position.Margin = New System.Windows.Forms.Padding(2)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(162, 21)
        Me.Position.TabIndex = 39
        Me.Position.Text = "Admin"
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(344, 56)
        Me.Gender.Margin = New System.Windows.Forms.Padding(2)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(162, 21)
        Me.Gender.TabIndex = 38
        Me.Gender.Text = "Male"
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(344, 202)
        Me.Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Password.MaxLength = 16
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(162, 22)
        Me.Password.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(220, 205)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Password"
        '
        'Username
        '
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Username.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(344, 178)
        Me.Username.Margin = New System.Windows.Forms.Padding(2)
        Me.Username.MaxLength = 16
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(162, 22)
        Me.Username.TabIndex = 35
        '
        'Salary
        '
        Me.Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Salary.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary.Location = New System.Drawing.Point(344, 154)
        Me.Salary.Margin = New System.Windows.Forms.Padding(2)
        Me.Salary.MaxLength = 11
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(162, 22)
        Me.Salary.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(220, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "User Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 157)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Salary"
        '
        'Phone
        '
        Me.Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Phone.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(344, 105)
        Me.Phone.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone.MaxLength = 16
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(162, 22)
        Me.Phone.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Phone Number"
        '
        'Address
        '
        Me.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Address.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(344, 81)
        Me.Address.Margin = New System.Windows.Forms.Padding(2)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(162, 22)
        Me.Address.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Gender"
        '
        'Id
        '
        Me.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id.Enabled = False
        Me.Id.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(344, 8)
        Me.Id.Margin = New System.Windows.Forms.Padding(2)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(162, 22)
        Me.Id.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(220, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(220, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Employee Id"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-5, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 277)
        Me.Panel4.TabIndex = 5
        '
        'Employee2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 611)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Name = "Employee2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDashboard.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logout As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnTransac As Button
    Friend WithEvents btnSeat As Button
    Friend WithEvents btnMatch As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Search As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents TableEmp As DataGridView
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Salary As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Position As ComboBox
    Friend WithEvents Names As TextBox
    Friend WithEvents UpdateE As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Insert As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
