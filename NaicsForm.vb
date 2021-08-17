Public Class NaicsForm

 Private Sub txtnaics_TextChanged(sender As Object, e As EventArgs) Handles txtnaics.TextChanged
  'con este obtengo el dataset del archivo ods con la dll, debes manejar el dataset para tu trabajo
  Dim naics As New Naics()
  Dim data As DataSet = naics.readODS("c:\Aimcorp\Aim.cpwn\AimFiles\naics.ods")

  'aqui estoy haciendo un ejemplo de busqueda con el dataset, la respuesta de la busqueda lo da en un DataRow y no se como lo puedas manejar y pasarlo a un Dataset ese DataRow
  Dim table As DataTable = data.Tables("NAICS")
  Dim expresion As String = "Column1 like '%" & txtnaics.Text & "%' or Column2 like '%" & txtnaics.Text & "%' or Column3 like '%" & txtnaics.Text & "%'"
  Dim result As DataRow() = table.Select(expresion)
  Dim i As Integer
  Dim hasta As Integer = result.Length - 1
  dgv_tabla.Rows.Clear()
  For i = 0 To hasta Step 1
   Dim arrStrings As String()
   arrStrings = New String() _
             {
             result(i).Item(0), result(i).Item(1), result(i).Item(2)
             }
   dgv_tabla.Rows.Add(arrStrings)
   arrStrings = Nothing
  Next
 End Sub

 Private Sub dgv_tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tabla.CellContentClick

 End Sub
End Class
