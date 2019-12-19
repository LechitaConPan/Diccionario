<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.txtDefinicion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Location = New System.Drawing.Point(79, 43)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(62, 20)
        Me.lblPalabra.TabIndex = 0
        Me.lblPalabra.Text = "palabra"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(63, 311)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(160, 57)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'txtDefinicion
        '
        Me.txtDefinicion.Location = New System.Drawing.Point(83, 105)
        Me.txtDefinicion.Name = "txtDefinicion"
        Me.txtDefinicion.Size = New System.Drawing.Size(477, 26)
        Me.txtDefinicion.TabIndex = 3
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDefinicion)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblPalabra)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalabra As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtDefinicion As TextBox
End Class
