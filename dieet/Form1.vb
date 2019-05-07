Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dag As String
        Dim filterdag As String
        Dim aantalcal As Integer
        Dim totaalperdag As Integer
        Dim totaal As Integer
        Dim watikhebgegeten As String
        Dim einde As Boolean = False

        FileOpen(1, "C:\Users\Arthur\Downloads\dieet.txt", OpenMode.Input)
        FileOpen(2, "C:\Users\Arthur\Downloads\dieet2.txt", OpenMode.Output)

        Try
            Input(1, dag)
            Input(1, watikhebgegeten)
            Input(1, aantalcal)

        Catch ex As Exception
            einde = True
        End Try

        Do While Not einde
            totaalperdag = 0
            filterdag = dag
            Do While Not einde And dag = filterdag
                totaalperdag += aantalcal
                Try
                    Input(1, dag)
                    Input(1, watikhebgegeten)
                    Input(1, aantalcal)

                Catch ex As Exception
                    einde = True
                End Try
            Loop
            PrintLine(2, filterdag & " at ik " & totaalperdag & " aantal kcal.")
            totaal += totaalperdag
        Loop
        PrintLine(2, "in totaal at ik " & " at ik " & totaal & " aantal kcal.")
    End Sub
End Class
