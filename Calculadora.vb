Public Class Calculadora
    Private dblResultado As Double = 0
    Private dblNumero As Double = 0
    Private strOperador As String = String.Empty
    Private blnLimpa As Boolean = True
    Private blnDecimal As Boolean = False
    Private strNumero As String = 1
    Private blnOperador As Boolean = False
    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblNumero = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado / dblNumero
            txtResultado.Text = dblResultado
            dblNumero = 0
        End If
        strOperador = "/"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        dblNumero = 0
        dblResultado = 0
        strOperador = String.Empty
        txtResultado.Text = "0"
        blnDecimal = False
        blnLimpa = False
        strNumero = "1"

    End Sub
    Private Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblNumero = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado * dblNumero
            txtResultado.Text = dblResultado
            dblNumero = 0
        End If
        strOperador = "*"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub
    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        If blnLimpa = True Then
            txtResultado.Text = "0"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "0"
        End If
        blnOperador = True
    End Sub
    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        If blnLimpa = True Then
            txtResultado.Text = "1"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "1"
        End If
        blnOperador = True
    End Sub
    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        If blnLimpa = True Then
            txtResultado.Text = "2"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "2"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        If blnLimpa = True Then
            txtResultado.Text = "3"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "3"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        If blnLimpa = True Then
            txtResultado.Text = "4"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "4"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        If blnLimpa = True Then
            txtResultado.Text = "5"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "5"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        If blnLimpa = True Then
            txtResultado.Text = "6"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "6"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        If blnLimpa = True Then
            txtResultado.Text = "7"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "7"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        If blnLimpa = True Then
            txtResultado.Text = "8"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "8"

        End If
        blnOperador = True
    End Sub
    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        If blnLimpa = True Then
            txtResultado.Text = "9"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "9"

        End If
        blnOperador = True
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblNumero = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado + dblNumero
            txtResultado.Text = dblResultado
            dblNumero = 0
        End If
        strOperador = "+"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub btnSubstracao_Click(sender As Object, e As EventArgs) Handles btnSubstracao.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblNumero = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado - dblNumero
            txtResultado.Text = dblResultado
            dblNumero = 0
        End If
        strOperador = "-"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub btnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        If blnDecimal = False Then
            txtResultado.Text = txtResultado.Text & ","
            blnDecimal = True
        End If
    End Sub
    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If strOperador = "+" And dblNumero = 0 Then
            dblResultado = dblResultado + Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "-" And dblNumero = 0 Then
            dblResultado = dblResultado - Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "*" And dblNumero = 0 Then
            dblResultado = dblResultado * Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "/" And dblNumero = 0 Then
            dblResultado = dblResultado / Convert.ToInt32(txtResultado.Text)
        End If

        txtResultado.Text = dblResultado
        blnLimpa = True
        blnOperador = False
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub img_BackgroundImageChanged(sender As Object, e As EventArgs) Handles img.BackgroundImageChanged

    End Sub

    Private Sub labelganso_Click(sender As Object, e As EventArgs) Handles labelganso.Click

    End Sub
End Class
