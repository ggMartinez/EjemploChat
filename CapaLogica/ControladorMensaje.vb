Imports CapDeDatos

Public Module ControladorMensaje

    Public Sub Guardar(Sesion As String, De As String, Para As String, Mensaje As String)
        Dim m As New ModeloMensaje()
        m.Sesion = Sesion
        m.De = De
        m.Para = Para
        m.Mensaje = Mensaje


        m.Guardar()


    End Sub

    Public Function BuscarMensajeNoLeido(Sesion As String, Para As String)

        Dim m As New ModeloMensaje
        m.Sesion = Sesion
        m.Para = Para
        Return m.LeerMensajesNoLeidos

    End Function

    Public Sub MarcarMensajeLeido(id As String)
        Dim m As New ModeloMensaje
        m.Id = id
        m.MarcarLeido()

    End Sub
End Module
