Imports System.IO

Public Class clients


    '  . . . means missing or incomplete code



    Private Structure client
        Public ClientID As String
        Public Title As String
        Public Firstname As String
        Public Surname As String
        Public Address As String
    End Structure

    Private Sub Clientss_Load() Handles MyBase.Load
        If Dir$("clients.txt") = "" Then
            Dim sw As New StreamWriter("clients.txt", True)
            sw.WriteLine("")
            sw.Close()
            MsgBox("A new file has been created", vbExclamation, "Warning!")
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim clientData As New client
        Dim sw As New System.IO.StreamWriter("clients.txt", True)
        clientData.ClientID = LSet(txtClientID.Text, 50)
        clientData.Title = LSet(txtTitle.Text, 50)
        clientData.Firstname = LSet(txtFirstname.Text, 50)
        clientData.Surname = LSet(txtSurname.Text, 50)
        clientData.Address = LSet(txtAddress.Text, 50)

        sw.WriteLine(clientData.ClientID & clientData.Title & clientData.Firstname & clientData.Surname & clientData.Address)
        sw.Close()
        MsgBox("File Saved!")
    End Sub

    Private Sub cmdCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCount.Click
        Dim CountGot As Integer
        CountGot = 0
        Dim clientCount As Integer
        clientCount = 0

        Dim clientData() As String = File. '  . . . (" '  . . . .txt")
        For i = 0 To UBound(clientData)

            CountGot = 0
            If Trim(Mid(clientData(i), 1, 50)) = txtClientID.Text And Not txtClientID.Text = "" Then CountGot = CountGot + 1
            If Trim(Mid(clientData(i), 51, 50)) =  '  . . . .Text And Not txtTitle.Text = "" Then CountGot = CountGot + 1
            If Trim(Mid(clientData(i), 101, 50)) = . . . ..Text And Not txtFirstname.Text = "" Then CountGot = CountGot + 1
            If Trim(Mid(clientData(i), 151, 50)) = . . . ..Text And Not txtSurname.Text = "" Then CountGot = CountGot + 1 'Counting how many attributes follow the search
            If Trim(Mid(clientData(i), 201, 50)) = . . . ..Text And Not txtAddress.Text = "" Then CountGot = CountGot + 1
                If CountGot > 0 Then  '  . . .  = clientCount + 1 
        Next i
        MsgBox("There were: " & clientCount & " Found")

    End Sub










End Class
