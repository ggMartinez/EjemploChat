Imports System.Data.Odbc

Public MustInherit Class Modelo
    Public DbDriver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public DbUser As String = "usuario"
    Public DbPassword As String = "1234"
    Public DbPort As String = "3306"
    Public DbName As String = "chat"
    Public DbHost As String = "192.168.70.144"



    Public Conexion As New OdbcConnection("DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost)


    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader


    Public Sub New()
        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion
    End Sub



End Class
