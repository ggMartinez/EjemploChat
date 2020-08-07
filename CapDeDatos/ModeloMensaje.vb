Public Class ModeloMensaje
    Inherits Modelo

    Public Id As String
    Public Sesion As String
    Public De As String
    Public Para As String
    Public Mensaje As String
    Public FechaHora As String
    Public Leido As Boolean

    Public Sub Guardar()
        Me.Comando.CommandText =
            "
            INSERT INTO mensaje(sesion,de,para,texto,fecha_hora)
            VALUES(" + Me.Sesion + "," + Me.De + "," + Me.Para + ",'" + Me.Mensaje + "',now())
            "

        Me.Comando.ExecuteNonQuery()
        Me.Conexion.Close()
    End Sub

    Public Function LeerMensajesNoLeidos()
        Me.Comando.CommandText =
            "
            SELECT 
	            m.de, m.fecha_hora, m.texto, m.id as id_mensaje, u.nombre as emisor
            FROM
	            mensaje m 
            JOIN
                usuario u 
                    ON m.de = u.id 
            

            WHERE 
	            m.para = " + Me.Para + " AND
	            m.sesion = " + Me.Sesion + " AND 
	            m.leido = false
            "
        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function

    Public Sub MarcarLeido()
        Me.Comando.CommandText =
            "UPDATE mensaje SET leido = true where id = " + Me.Id
        Comando.ExecuteNonQuery()
        Me.Conexion.Close()

    End Sub


End Class
