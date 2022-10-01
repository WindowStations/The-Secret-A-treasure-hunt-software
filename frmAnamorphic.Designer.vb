Namespace AnamorphicUINS
    Partial Public Class frmAnamorphic
        Inherits Form

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnamorphic))
            Me.canvas1 = New AnamorphicCanvas.AnamorphicCanvas.Controls.Canvas
            Me.canvas2 = New AnamorphicCanvas.AnamorphicCanvas.Controls.Canvas
            Me.SuspendLayout()
            '
            'canvas1
            '
            Me.canvas1.AutoScroll = True
            Me.canvas1.AutoScrollMinSize = New System.Drawing.Size(400, 600)
            Me.canvas1.AutoSize = True
            Me.canvas1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.canvas1.CanvasImage = Nothing
            Me.canvas1.CanvasSize = New System.Drawing.Size(400, 600)
            Me.canvas1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.canvas1.ImageLocation = New System.Drawing.Point(0, 0)
            Me.canvas1.IsBilinearInterpolation = False
            Me.canvas1.Location = New System.Drawing.Point(0, 0)
            Me.canvas1.Name = "canvas1"
            Me.canvas1.Size = New System.Drawing.Size(1174, 804)
            Me.canvas1.TabIndex = 1
            Me.canvas1.ZoomFactor = 1.0!
            '
            'canvas2
            '
            Me.canvas2.AutoScroll = True
            Me.canvas2.AutoScrollMinSize = New System.Drawing.Size(400, 600)
            Me.canvas2.AutoSize = True
            Me.canvas2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.canvas2.CanvasImage = Nothing
            Me.canvas2.CanvasSize = New System.Drawing.Size(400, 600)
            Me.canvas2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.canvas2.ImageLocation = New System.Drawing.Point(0, 0)
            Me.canvas2.IsBilinearInterpolation = False
            Me.canvas2.Location = New System.Drawing.Point(0, 0)
            Me.canvas2.Name = "canvas2"
            Me.canvas2.Size = New System.Drawing.Size(1174, 804)
            Me.canvas2.TabIndex = 1
            Me.canvas2.ZoomFactor = 1.0!
            '
            'frmAnamorphic
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1174, 804)
            Me.Controls.Add(Me.canvas1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmAnamorphic"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Anamorphic color-field canvas"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Friend WithEvents canvas1 As AnamorphicCanvas.AnamorphicCanvas.Controls.Canvas
        Friend WithEvents canvas2 As AnamorphicCanvas.AnamorphicCanvas.Controls.Canvas
    End Class
End Namespace