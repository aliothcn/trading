Public Class PersonBLL
    Function loginChk(ByVal name As String, ByVal password As String)
        Dim person As New Model.Person
        Dim personDal As New DAL.PersonDAL
        person = personDal.getPersonByName(name)
        If person.password = password Then
            Return True
        End If
        Return False
    End Function
    Function getbyname(ByVal name As String) As Model.Person
        Dim person As New Model.Person
        Dim personDal As New DAL.PersonDAL
        person = personDal.getPersonByName(name)
        Return person
    End Function
    Function edit(ByVal person As Model.Person) As Boolean
        Dim personDal As New DAL.PersonDAL
        Return personDal.edit(person)
    End Function
End Class
