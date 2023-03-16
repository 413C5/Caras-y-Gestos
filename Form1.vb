Public Class frmPrincipal
#Region "Atributos"
    Private _indiceSpider As Integer
    Private _indiceDuende As Integer
    Public Property IndiceSpider As Integer
        Set(value As Integer)
            If value <> _indiceSpider Then                'Validar que haya algun cambio en el valor
                _indiceSpider = value
            End If
        End Set
        Get
            Return _indiceSpider
        End Get
    End Property

    Public Property IndiceDuende As Integer
        Set(value As Integer)
            If value <> _indiceDuende Then                'Validar que haya algun cambio en el valor
                _indiceDuende = value
            End If
        End Set
        Get
            Return _indiceDuende
        End Get
    End Property
#End Region
#Region "Metodos"
    Private Sub cambiarImagenSpider(ByVal indice)
        Select Case indice
            Case 0
                picSpider.Image = My.Resources.spiderSonriendo
            Case 1
                picSpider.Image = My.Resources.spiderLlorando
            Case 2
                picSpider.Image = My.Resources.spiderEnojado
            Case 3
                picSpider.Image = My.Resources.spiderBurla
        End Select
    End Sub
    Private Sub cambiarImagenDuende(ByVal indice)
        Select Case indice
            Case 0
                picDuende.Image = My.Resources.duendeSonriendo
            Case 1
                picDuende.Image = My.Resources.duendeLlorando
            Case 2
                picDuende.Image = My.Resources.duendeEnojado
            Case 3
                picDuende.Image = My.Resources.duendeBurla
        End Select
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSpider.SelectedIndex = 0
        cmbDuende.SelectedIndex = 0
        IndiceSpider = cmbSpider.SelectedIndex
        IndiceDuende = cmbDuende.SelectedIndex
    End Sub

    Private Sub cmbSpider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSpider.SelectedIndexChanged
        IndiceSpider = cmbSpider.SelectedIndex
        cambiarImagenSpider(IndiceSpider)
    End Sub

    Private Sub cmbDuende_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDuende.SelectedIndexChanged
        IndiceDuende = cmbDuende.SelectedIndex
        cambiarImagenDuende(IndiceDuende)
    End Sub
#End Region
End Class
