Public Class Main

    Private Sub afilEnviarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afilEnviarBtn.Click

        '   vacia el campo de resultados
        afilResultados.Text = ""

        '   vacia el campo de resultados
        afilResultados.Text = ""

        '   crea objeto
        Dim wsoh As New ar.com.openhex.ohWSDL()

        '   ejecuta la autorizacion
        Try
            '   muestra el resultado
            afilResultados.Text = wsoh.wsvo_verificar_afiliado(baseTxt.Text, usuarioTxt.Text, claveTxt.Text, afiliadoTxt.Text, empresaTxt.Text)
        Catch ex As Exception
            '   muestra el error
            afilResultados.Text = ex.Message
        End Try

    End Sub

    Private Sub afilLimpiarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afilLimpiarBtn.Click

        '   vacia el campo de resultados
        afilResultados.Text = ""

    End Sub

    Private Sub valEnviarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valEnviarBtn.Click

        '   vacia el campo de resultados
        valResultados.Text = ""

        '   crea objeto
        Dim wsoh As New ar.com.openhex.ohWSDL()

        '   ejecuta la autorizacion
        Try
            '   muestra el resultado
            valResultados.Text = wsoh.wsvo_autorizar(baseTxt.Text, usuarioTxt.Text, claveTxt.Text, afiliadoTxt.Text, empresaTxt.Text, prestadorTxt.Text, valCantidad01Txt.Text, valPractica01Txt.Text, valCantidad02Txt.Text, valPractica02Txt.Text, valCantidad03Txt.Text, valPractica03Txt.Text, valCantidad04Txt.Text, valPractica04Txt.Text, valCantidad05Txt.Text, valPractica05Txt.Text, valCantidad06Txt.Text, valPractica06Txt.Text, valCantidad07Txt.Text, valPractica07Txt.Text, valCantidad08Txt.Text, valPractica08Txt.Text, valCantidad09Txt.Text, valPractica09Txt.Text, valCantidad10Txt.Text, valPractica10Txt.Text, valCantidad11Txt.Text, valPractica11Txt.Text, valCantidad12Txt.Text, valPractica12Txt.Text, valCantidad13Txt.Text, valPractica13Txt.Text, valCantidad14Txt.Text, valPractica14Txt.Text, valCantidad15Txt.Text, valPractica15Txt.Text, valCantidad16Txt.Text, valPractica16Txt.Text, valCantidad17Txt.Text, valPractica17Txt.Text, valCantidad18Txt.Text, valPractica18Txt.Text, valCantidad19Txt.Text, valPractica19Txt.Text, valCantidad20Txt.Text, valPractica20Txt.Text)
        Catch ex As Exception
            '   muestra el error
            valResultados.Text = ex.Message
        End Try

    End Sub

    Private Sub valLimpiarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valLimpiarBtn.Click

        '   vacia el campo de diagnostico
        valDiagnosticoTxt.Text = ""

        '   vacia los campos de practicas
        valPractica01Txt.Text = ""
        valCantidad01Txt.Text = ""
        valPractica02Txt.Text = ""
        valCantidad02Txt.Text = ""
        valPractica03Txt.Text = ""
        valCantidad03Txt.Text = ""
        valPractica04Txt.Text = ""
        valCantidad04Txt.Text = ""
        valPractica05Txt.Text = ""
        valCantidad05Txt.Text = ""
        valPractica06Txt.Text = ""
        valCantidad06Txt.Text = ""
        valPractica07Txt.Text = ""
        valCantidad07Txt.Text = ""
        valPractica08Txt.Text = ""
        valCantidad08Txt.Text = ""
        valPractica09Txt.Text = ""
        valCantidad09Txt.Text = ""
        valPractica10Txt.Text = ""
        valCantidad10Txt.Text = ""
        valPractica11Txt.Text = ""
        valCantidad11Txt.Text = ""
        valPractica12Txt.Text = ""
        valCantidad12Txt.Text = ""
        valPractica13Txt.Text = ""
        valCantidad13Txt.Text = ""
        valPractica14Txt.Text = ""
        valCantidad14Txt.Text = ""
        valPractica15Txt.Text = ""
        valCantidad15Txt.Text = ""
        valPractica16Txt.Text = ""
        valCantidad16Txt.Text = ""
        valPractica17Txt.Text = ""
        valCantidad17Txt.Text = ""
        valPractica18Txt.Text = ""
        valCantidad18Txt.Text = ""
        valPractica19Txt.Text = ""
        valCantidad19Txt.Text = ""
        valPractica20Txt.Text = ""
        valCantidad20Txt.Text = ""

        '   vacia el campo de resultados
        valResultados.Text = ""

    End Sub

    Private Sub anuEnviarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anuEnviarBtn.Click

        '   vacia el campo de resultados
        anuResultados.Text = ""

        '   crea objeto
        Dim wsoh As New ar.com.openhex.ohWSDL()

        '   ejecuta la anulacion
        Try
            '   muestra el resultado
            anuResultados.Text = wsoh.wsvo_anular(baseTxt.Text, usuarioTxt.Text, claveTxt.Text, 994, anuAutorizacionTxt.Text, prestadorTxt.Text, afiliadoTxt.Text, empresaTxt.Text)
        Catch ex As Exception
            '   muestra el error
            anuResultados.Text = ex.Message
        End Try

    End Sub

    Private Sub anuLimpiarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anuLimpiarBtn.Click

        '   vacia el campo de autorizaciones
        anuAutorizacionTxt.Text = ""

        '   vacia el campo de resultados
        anuResultados.Text = ""

    End Sub

    Private Sub openHexSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles openHexSite.LinkClicked

        '   abre la pagina de openHex :D
        System.Diagnostics.Process.Start("http://openhex.com.ar")

    End Sub

End Class
