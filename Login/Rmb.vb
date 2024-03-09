Public Class Rmb
    '输入字串 
    Private _InputString As String
    '输出字串,如果无效则输出错误信息 
    Private _OutString As String
    '判断输出字串是否有效 
    Private _Valiad As Boolean

    Public WriteOnly Property InputString() As String
        Set(ByVal Value As String)
            _InputString = Value
            ConvertToChineseNum()
        End Set
    End Property

    Public ReadOnly Property Valiad() As Boolean
        Get
            Return _Valiad
        End Get
    End Property

    Public ReadOnly Property OutString() As String
        Get
            Return _OutString
        End Get
    End Property

    Private Sub ConvertToChineseNum()
        Dim numList As String = "零壹贰叁肆伍陆柒捌玖"
        Dim rmbList As String = "分角元拾佰仟万拾佰仟亿拾佰仟万"
        Dim number As Double = 0
        Dim tempOutString As String = ""
        Try
            number = Double.Parse(Me._InputString)
        Catch ex As SystemException
            Me._OutString = "传入参数非数字！"
            Me._Valiad = False
            Return
        End Try
        If number > 9999999999999.99 Then
            Me._Valiad = False
            Me._OutString = "超出范围的人民币值"
            Return
        End If
        Dim tempNumberString As String = Convert.ToInt64(number * 100).ToString()
        Dim tempNmberLength As Integer = tempNumberString.Length
        Dim i As Integer = 0
        While i < tempNmberLength
            Dim oneNumber As Integer = Int32.Parse(tempNumberString.Substring(i, 1))
            Dim oneNumberChar As String = numList.Substring(oneNumber, 1)
            Dim oneNumberUnit As String = rmbList.Substring(tempNmberLength - i - 1, 1)
            If Not (oneNumberChar = "零") Then
                tempOutString += oneNumberChar + oneNumberUnit
            Else
                If oneNumberUnit = "亿" OrElse oneNumberUnit = "万" OrElse oneNumberUnit = "元" OrElse oneNumberUnit = "零" Then
                    While tempOutString.EndsWith("零")
                        tempOutString = tempOutString.Substring(0, tempOutString.Length - 1)
                    End While
                End If
                If oneNumberUnit = "亿" OrElse (oneNumberUnit = "万" AndAlso Not tempOutString.EndsWith("亿")) OrElse oneNumberUnit = "元" Then
                    tempOutString += oneNumberUnit
                Else
                    Dim tempEnd As Boolean = tempOutString.EndsWith("亿")
                    Dim zeroEnd As Boolean = tempOutString.EndsWith("零")
                    If tempOutString.Length > 1 Then
                        Dim zeroStart As Boolean = tempOutString.Substring(tempOutString.Length - 2, 2).StartsWith("零")
                        If Not zeroEnd AndAlso (zeroStart OrElse Not tempEnd) Then
                            tempOutString += oneNumberChar
                        End If
                    Else
                        If Not zeroEnd AndAlso Not tempEnd Then
                            tempOutString += oneNumberChar
                        End If
                    End If
                End If
            End If
            i += 1
        End While
        While tempOutString.EndsWith("零")
            tempOutString = tempOutString.Substring(0, tempOutString.Length - 1)
        End While
        While tempOutString.EndsWith("元")
            tempOutString = tempOutString + "整"
        End While
        Me._OutString = tempOutString
        Me._Valiad = True
    End Sub
End Class
