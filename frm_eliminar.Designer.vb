﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_eliminar
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
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.lv_palabras = New System.Windows.Forms.ListView()
        Me.gbx_agregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.btn_menu)
        Me.gbx_agregar.Controls.Add(Me.lv_palabras)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(26, 45)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Size = New System.Drawing.Size(501, 277)
        Me.gbx_agregar.TabIndex = 4
        Me.gbx_agregar.TabStop = False
        Me.gbx_agregar.Text = "Eliminar"
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.White
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_menu.Location = New System.Drawing.Point(182, 233)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(111, 38)
        Me.btn_menu.TabIndex = 8
        Me.btn_menu.Text = "Menú"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'lv_palabras
        '
        Me.lv_palabras.FullRowSelect = True
        Me.lv_palabras.GridLines = True
        Me.lv_palabras.HideSelection = False
        Me.lv_palabras.Location = New System.Drawing.Point(21, 42)
        Me.lv_palabras.Name = "lv_palabras"
        Me.lv_palabras.Size = New System.Drawing.Size(447, 185)
        Me.lv_palabras.TabIndex = 5
        Me.lv_palabras.UseCompatibleStateImageBehavior = False
        Me.lv_palabras.View = System.Windows.Forms.View.List
        '
        'frm_eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(552, 366)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Name = "frm_eliminar"
        Me.Text = "frm_eliminar"
        Me.gbx_agregar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents lv_palabras As ListView
    Friend WithEvents btn_menu As Button
End Class
