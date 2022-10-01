Namespace AnamorphicUINS
    Friend Module Program
        <STAThread()> _
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmAnamorphic())
        End Sub
    End Module
End Namespace