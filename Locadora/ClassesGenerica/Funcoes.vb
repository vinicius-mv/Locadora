


Namespace ClassesGenerica
    Public Class Funcoes

        Private _varFormulario As Form

        Private _controleAtivo As Control
        Private _objDtPicker As DateTimePicker
        Private _objMonthpicker As DateTimePicker
        Private _container As Control = Nothing

        Private VAR_DATACADASTRO As String

        Public Shared Sub FechaFormulario(ByVal nomeFormulario As String)

            For Each frm As Form In CType(MdiLocadora, System.Windows.Forms.Form).MdiChildren
                If frm.Name.ToUpper() = nomeFormulario.ToUpper Then
                    frm.Close()
                End If
            Next

        End Sub
        Public Sub New()
            _varFormulario = Nothing
        End Sub

        Public Sub New(ByVal objForm As Form)
            _varFormulario = objForm
            If Not _varFormulario Is Nothing Then
                '_varFormulario.Icon = My.Resources.
            End If
        End Sub

        Public WriteOnly Property Formulario() As Form
            Set(ByVal value As Form)
                _varFormulario = value
            End Set
        End Property

        Public Function LimpaFormatacao(ByVal texto As String) As String
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            texto = Replace(texto, "(", "")
            texto = Replace(texto, ")", "")
            texto = Replace(texto, ":", "")
            texto = Replace(texto, " ", "")

            Return IIf(texto Is Nothing, "", texto)
        End Function

        Public Sub PreencheTipoTelefone(ByRef obj As ComboBox)
            obj.Items.Clear()
            obj.Items.Add("")
            obj.Items.Add("RESIDENCIAL")
            obj.Items.Add("COMERCIAL")
            obj.Items.Add("CELULAR")
            obj.Items.Add("FAX")
            obj.Items.Add("PORTARIA")
        End Sub

        Public Sub PreencheEstadoCivil(ByRef obj As ComboBox)
            obj.Items.Clear()
            obj.Items.Add("")
            obj.Items.Add("SOLTEIRO(A)")
            obj.Items.Add("CASADO(A)")
            obj.Items.Add("VIÚVO(A)")
            obj.Items.Add("DIVORCIADO(A)")
        End Sub

        Public Sub PreencheStatusServico(ByRef obj As ComboBox)
            obj.Items.Clear()
            obj.Items.Add("")
            obj.Items.Add("Parado")
            obj.Items.Add("Executando")
            obj.Items.Add("Aguardando")
            obj.Items.Add("Atrasado")
        End Sub

        Public Sub PreencheDiaSemana(ByRef obj As ComboBox)
            Dim array(7, 2) As String
            Dim objItem As Item

            array(0, 0) = 1
            array(0, 1) = "1-DOMINGO"

            array(1, 0) = 2
            array(1, 1) = "2-SEGUNDA-FEIRA"

            array(2, 0) = 3
            array(2, 1) = "3-TERÇA-FEIRA"

            array(3, 0) = 4
            array(3, 1) = "4-QUARTA-FEIRA"

            array(4, 0) = 5
            array(4, 1) = "5-QUINTA-FEIRA"

            array(5, 0) = 6
            array(5, 1) = "6-SEXTA-FEIRA"

            array(6, 0) = 7
            array(6, 1) = "7-SÁBADO"

            obj.Items.Clear()
            obj.Items.Add("")

            For I As Short = 0 To 6
                objItem = New Item(ValDouble(array(I, 0)), array(I, 1))
                obj.Items.Add(objItem)
            Next I

        End Sub

        Public Sub PreencheMesesAno(ByRef obj As ComboBox)
            Dim array(12, 2) As String
            Dim objItem As Item

            array(0, 0) = 1
            array(0, 1) = "01-JANEIRO"

            array(1, 0) = 2
            array(1, 1) = "02-FEVEREIRO"

            array(2, 0) = 3
            array(2, 1) = "03-MARÇO"

            array(3, 0) = 4
            array(3, 1) = "04-ABRIL"

            array(4, 0) = 5
            array(4, 1) = "05-MAIO"

            array(5, 0) = 6
            array(5, 1) = "06-JUNHO"

            array(6, 0) = 7
            array(6, 1) = "07-JULHO"

            array(7, 0) = 8
            array(7, 1) = "08-AGOSTO"

            array(8, 0) = 9
            array(8, 1) = "09-SETEMBRO"

            array(9, 0) = 10
            array(9, 1) = "10-OUTUBRO"

            array(10, 0) = 11
            array(10, 1) = "11-NOVEMBRO"

            array(11, 0) = 12
            array(11, 1) = "12-DEZEMBRO"

            obj.Items.Clear()
            obj.Items.Add("")

            For I As Short = 0 To 11
                objItem = New Item(ValDouble(array(I, 0)), array(I, 1))
                obj.Items.Add(objItem)
            Next I

        End Sub


        Public Sub PreencheUf(ByRef obj As ComboBox)
            Dim I As Integer
            Dim estado As String

            obj.Items.Clear()

            estado = "  ACAMAPALBACEESGOMAMGMSMTPAPBPEPIPRRJRNRORSRRSESCSPTODFEX"
            For I = 1 To Len(estado) Step 2
                obj.Items.Add(Mid(estado, I, 2))
            Next I
        End Sub


        Public Function FormataCadastro(ByVal cadastro As String) As String

            cadastro = LimpaFormatacao(cadastro)

            If IsNumeric(cadastro) Then
                If cadastro.Length = 11 Then
                    cadastro = Mid(cadastro, 1, 3) + "." + Mid(cadastro, 4, 3) + "." + Mid(cadastro, 7, 3) + "-" + Mid(cadastro, 10, 2)
                ElseIf cadastro.Length = 14 Then
                    cadastro = Mid(cadastro, 1, 2) + "." + Mid(cadastro, 3, 3) + "." + Mid(cadastro, 6, 3) + "/" + Mid(cadastro, 9, 4) + "-" + Mid(cadastro, 13, 2)
                End If
            End If

            Return cadastro

        End Function

        Public Function FormataData(ByVal data As String) As String
            Try
                'If IsDate(DATA) Then Return DATA
                If data.Length = 8 And data.Trim <> "" Then
                    data = data.Substring(6, 2) + "/" + data.Substring(4, 2) + "/" + data.Substring(0, 4)
                End If
                If data.Length = 6 And data.Trim <> "" Then
                    data = data.Substring(0, 2) + "/" + data.Substring(2, 2) + "/" + "20" + data.Substring(4, 2)
                End If
            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - FormataData")
            End Try
            Return data
        End Function

        Public Function FormataCep(ByVal cep As String) As String
            Try

                cep = LimpaFormatacao(cep)

                If Len(cep) = 8 Then
                    cep = (Mid(cep, 1, 5) + "-" + Mid(cep, 3, 3))
                End If

            Catch erro As Exception
                'Call ErroCritico(Err.Number, erro.Message, "Funcoes - FormataCEP")
            End Try
            Return cep
        End Function

        Public Function DesformataData(ByVal dataIn As String) As String
            Dim retorno As String = ""
            Dim data As Date

            If IsDate(dataIn) Then data = dataIn Else Return ""

            Try
                retorno = data.Year.ToString.PadLeft(4, "0")
                retorno += data.Month.ToString.PadLeft(2, "0")
                retorno += data.Day.ToString.PadLeft(2, "0")
            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - DesformataData")
            End Try
            Return retorno
        End Function

        Public Sub LimpaCampos(ByRef objForm As Control, Optional ByVal excecao As String = "")
            If objForm Is Nothing Then Exit Sub

            Try

                If InStr(1, objForm.Name.ToUpper, "UNIDADEPRODUCAO") > 0 Then Exit Sub

                If InStr(1, excecao.ToUpper, objForm.Name.ToUpper) = 0 Then
                    If TypeOf objForm Is TextBox Then CType(objForm, TextBox).Text = ""
                    If TypeOf objForm Is ComboBox Then
                        If CType(objForm, ComboBox).DropDownStyle = ComboBoxStyle.DropDownList Then
                            CType(objForm, ComboBox).SelectedIndex = -1
                        Else
                            CType(objForm, ComboBox).Text = ""
                        End If
                    End If
                    If TypeOf objForm Is CheckBox Then CType(objForm, CheckBox).Checked = False
                    If TypeOf objForm Is CheckBox And InStr(1, objForm.Name.ToUpper, "Ativo".ToUpper()) > 0 Then CType(objForm, CheckBox).Checked = True
                    If TypeOf objForm Is CheckBox And InStr(1, objForm.Name.ToUpper, "Compartilhado".ToUpper()) > 0 Then CType(objForm, CheckBox).Checked = True
                    If TypeOf objForm Is CheckedListBox Then
                        For I As Integer = 0 To CType(objForm, CheckedListBox).Items.Count - 1
                            CType(objForm, CheckedListBox).SetItemChecked(I, False)  'LIMPA CHECKBOX
                        Next
                    End If
                    If (TypeOf objForm Is DataGridView) Then CType(objForm, DataGridView).RowCount = 0

                    For Each obj2 As Control In objForm.Controls
                        If InStr(1, excecao.ToUpper, obj2.Name.ToUpper) = 0 Then
                            LimpaCampos(obj2, excecao.ToString)
                        End If
                    Next obj2

                    '' ''For Each obj1 As Control In objForm.Controls
                    '' ''    If InStr(excecao.ToUpper, obj1.Name.ToUpper) = 0 Then
                    '' ''        If TypeOf obj1 Is TextBox Then CType(obj1, TextBox).Text = ""
                    '' ''        If TypeOf obj1 Is ComboBox Then
                    '' ''            If CType(obj1, ComboBox).DropDownStyle = ComboBoxStyle.DropDownList Then
                    '' ''                CType(obj1, ComboBox).SelectedIndex = -1
                    '' ''            Else
                    '' ''                CType(obj1, ComboBox).Text = ""
                    '' ''            End If
                    '' ''        End If
                    '' ''        If TypeOf obj1 Is CheckBox Then CType(obj1, CheckBox).Checked = False
                    '' ''        If TypeOf obj1 Is CheckBox And InStr(1, obj1.Name.ToUpper, "Ativo".ToUpper()) > 0 Then CType(obj1, CheckBox).Checked = True
                    '' ''        If TypeOf obj1 Is CheckBox And InStr(1, obj1.Name.ToUpper, "Compartilhado".ToUpper()) > 0 Then CType(obj1, CheckBox).Checked = True
                    '' ''        If TypeOf obj1 Is CheckedListBox Then
                    '' ''            For I As Integer = 0 To CType(obj1, CheckedListBox).Items.Count - 1
                    '' ''                CType(obj1, CheckedListBox).SetItemChecked(I, False)  'LIMPA CHECKBOX
                    '' ''            Next
                    '' ''        End If
                    '' ''        If (TypeOf obj1 Is DataGridView) Then
                    '' ''            CType(obj1, DataGridView).RowCount = 0
                    '' ''        End If
                    '' ''    End If
                    '' ''    For Each obj2 As Control In obj1.Controls
                    '' ''        LimpaCampos(obj2, excecao.ToString)
                    '' ''    Next obj2
                    '' ''Next
                End If
            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - LimpaCampos")
            End Try
        End Sub

        Public Sub AtribuirEventosBasicos(ByRef objForm As Control, Optional ByVal excecao As String = "")

            Try

                For Each obj1 As Control In objForm.Controls
                    If Not InStr(excecao, obj1.Name) = 0 Then Continue For

                    If Not (TypeOf obj1 Is TextBox Or TypeOf obj1 Is ComboBox) And obj1.Controls Is Nothing Then
                        Continue For
                    ElseIf TypeOf obj1 Is TextBox Or TypeOf obj1 Is ComboBox Then
                        RemoveHandler obj1.GotFocus, AddressOf ObjGotFocus
                        RemoveHandler obj1.KeyDown, AddressOf ObjKeyDown

                        AddHandler obj1.GotFocus, AddressOf ObjGotFocus
                        AddHandler obj1.KeyDown, AddressOf ObjKeyDown

                        If TypeOf obj1 Is TextBox And InStr(1, obj1.Name.ToUpper, "DATA") Then
                            RemoveHandler obj1.DoubleClick, AddressOf ObjDateTextDoubleClick
                            AddHandler obj1.DoubleClick, AddressOf ObjDateTextDoubleClick

                        ElseIf TypeOf obj1 Is TextBox And InStr(1, obj1.Name.ToUpper, "MESANO") Then
                            RemoveHandler obj1.DoubleClick, AddressOf ObjMesAnoTextDoubleClick
                            AddHandler obj1.DoubleClick, AddressOf ObjMesAnoTextDoubleClick


                        ElseIf TypeOf obj1 Is ComboBox Then
                            CType(obj1, ComboBox).Sorted = True
                            CType(obj1, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
                            CType(obj1, ComboBox).AutoCompleteMode = AutoCompleteMode.Append
                        End If

                    Else
                        For Each obj2 As Control In objForm.Controls
                            AtribuirEventosBasicos(obj2, excecao.ToString)
                        Next obj2
                    End If
                Next
            Catch erro As Exception
                MsgBox("Houve um erro ao tentar atribuir os eventos aos controles do formulário:" + erro.Message, vbExclamation)
            End Try
        End Sub

        'Public Sub AtribuirEventos(ByRef objForm As Control, Optional ByVal excecao As String = "")
        '    Try

        '        If TypeOf objForm Is Form Then
        '            Try
        '                If objForm.Text <> "" Then
        '                    MdiGestao.Text = MdiGestao.TextoTituloMdiRaiz + "   [" + objForm.Text + "]"
        '                    AddHandler CType(objForm, Form).FormClosing, AddressOf VoltaTextoMdi
        '                End If
        '            Catch ex As Exception
        '            End Try
        '        End If

        '        If objForm.Controls.Count = 0 Or TypeOf objForm Is DataGridView Then
        '            If InStr(excecao, objForm.Name) = 0 Then
        '                RemoveHandler objForm.GotFocus, AddressOf ObjGotFocus
        '                RemoveHandler objForm.LostFocus, AddressOf ObjLostFocus
        '                RemoveHandler objForm.KeyUp, AddressOf ObjKeyUp
        '                RemoveHandler objForm.KeyDown, AddressOf ObjKeyDown
        '                RemoveHandler objForm.TextChanged, AddressOf ObjTextChanged

        '                If TypeOf objForm Is TextBox Or TypeOf objForm Is ComboBox Then
        '                    AddHandler objForm.LostFocus, AddressOf ObjLostFocus
        '                    AddHandler objForm.GotFocus, AddressOf ObjGotFocus
        '                    AddHandler objForm.TextChanged, AddressOf ObjTextChanged
        '                    AddHandler objForm.KeyUp, AddressOf ObjKeyUp
        '                End If
        '                If TypeOf objForm Is ComboBox Then
        '                    CType(objForm, ComboBox).Sorted = True
        '                    CType(objForm, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
        '                    CType(objForm, ComboBox).AutoCompleteMode = AutoCompleteMode.Append
        '                End If
        '                If TypeOf objForm Is TextBox And InStr(1, objForm.Name.ToUpper, "Data".ToUpper) Then
        '                    RemoveHandler objForm.DoubleClick, AddressOf ObjDateTextDoubleClick
        '                    AddHandler objForm.DoubleClick, AddressOf ObjDateTextDoubleClick
        '                End If
        '                If Not TypeOf objForm Is RadioButton And Not TypeOf objForm Is CheckBox Then
        '                    AddHandler objForm.KeyDown, AddressOf ObjKeyDown
        '                End If

        '                If TypeOf objForm Is DataGridView Then
        '                    AddHandler CType(objForm, DataGridView).SortCompare, AddressOf dataGridView1_SortCompare
        '                End If

        '                If InStr(1, Mid(objForm.Name.ToUpper(), 1, 3), "grd".ToUpper()) > 0 Then
        '                    AddHandler CType(objForm, DataGridView).RowsAdded, AddressOf ColorirLinhaGrid
        '                    AddHandler CType(objForm, DataGridView).CellMouseEnter, AddressOf GridMouseEnter
        '                    AddHandler CType(objForm, DataGridView).MouseLeave, AddressOf DesselecionaGrid
        '                    AddHandler CType(objForm, DataGridView).HandleCreated, AddressOf DesselecionaGrid
        '                    AddHandler CType(objForm, DataGridView).LostFocus, AddressOf DataGridViewLostFocus
        '                End If
        '            End If
        '        End If


        '        For Each obj1 As Control In objForm.Controls
        '            If InStr(excecao, obj1.Name) = 0 Then
        '                RemoveHandler obj1.GotFocus, AddressOf ObjGotFocus
        '                RemoveHandler obj1.LostFocus, AddressOf ObjLostFocus
        '                RemoveHandler obj1.KeyUp, AddressOf ObjKeyUp
        '                RemoveHandler obj1.KeyDown, AddressOf ObjKeyDown
        '                RemoveHandler obj1.TextChanged, AddressOf ObjTextChanged

        '                If TypeOf obj1 Is TextBox Or TypeOf obj1 Is ComboBox Then
        '                    AddHandler obj1.LostFocus, AddressOf ObjLostFocus
        '                    AddHandler obj1.GotFocus, AddressOf ObjGotFocus
        '                    AddHandler obj1.TextChanged, AddressOf ObjTextChanged
        '                    AddHandler obj1.KeyUp, AddressOf ObjKeyUp
        '                End If
        '                If TypeOf obj1 Is ComboBox Then
        '                    CType(obj1, ComboBox).Sorted = True
        '                    CType(obj1, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
        '                    CType(obj1, ComboBox).AutoCompleteMode = AutoCompleteMode.Append
        '                End If
        '                If TypeOf obj1 Is TextBox And InStr(1, obj1.Name.ToUpper, "Data".ToUpper) Then
        '                    RemoveHandler obj1.DoubleClick, AddressOf ObjDateTextDoubleClick
        '                    AddHandler obj1.DoubleClick, AddressOf ObjDateTextDoubleClick
        '                End If
        '                If Not TypeOf obj1 Is RadioButton And Not TypeOf obj1 Is CheckBox Then
        '                    AddHandler obj1.KeyDown, AddressOf ObjKeyDown
        '                End If
        '                If InStr(1, Mid(obj1.Name.ToUpper(), 1, 3), "grd".ToUpper()) > 0 Then
        '                    AddHandler CType(obj1, DataGridView).RowsAdded, AddressOf ColorirLinhaGrid
        '                    AddHandler CType(obj1, DataGridView).CellMouseEnter, AddressOf GridMouseEnter
        '                    AddHandler CType(obj1, DataGridView).MouseLeave, AddressOf DesselecionaGrid
        '                    AddHandler CType(obj1, DataGridView).HandleCreated, AddressOf DesselecionaGrid
        '                    AddHandler CType(obj1, DataGridView).LostFocus, AddressOf DataGridViewLostFocus
        '                End If
        '            End If
        '            For Each obj2 As Control In obj1.Controls
        '                AtribuirEventos(obj2, excecao.ToString)
        '            Next obj2
        '        Next
        '    Catch erro As Exception
        '        MsgBox("Houve um erro ao tentar atribuir os eventos aos controles do formulário:" + erro.Message, vbExclamation)
        '        'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - AtribuirEventos")
        '    End Try
        'End Sub

        Public Sub AtribuirEventos(ByRef objForm As Control, Optional ByVal excecao As String = "")
            Try

                For Each obj As Control In objForm.Controls
                    If InStr(excecao, obj.Name) = 0 Then

                        If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Or TypeOf obj Is DataGridView Then

                            RemoveHandler obj.GotFocus, AddressOf ObjGotFocus
                            RemoveHandler obj.LostFocus, AddressOf ObjLostFocus
                            RemoveHandler obj.KeyUp, AddressOf ObjKeyUp
                            RemoveHandler obj.KeyDown, AddressOf ObjKeyDown
                            RemoveHandler obj.TextChanged, AddressOf ObjTextChanged

                            AddHandler obj.KeyDown, AddressOf ObjKeyDown

                            Select Case True
                                Case TypeOf obj Is TextBox Or TypeOf obj Is ComboBox
                                    AddHandler obj.LostFocus, AddressOf ObjLostFocus
                                    AddHandler obj.GotFocus, AddressOf ObjGotFocus
                                    AddHandler obj.TextChanged, AddressOf ObjTextChanged
                                    AddHandler obj.KeyUp, AddressOf ObjKeyUp

                                    If TypeOf obj Is ComboBox Then
                                        CType(obj, ComboBox).Sorted = True
                                        CType(obj, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
                                        CType(obj, ComboBox).AutoCompleteMode = AutoCompleteMode.Append
                                    End If
                                    If TypeOf obj Is TextBox And InStr(1, obj.Name.ToUpper, "Data".ToUpper) Then
                                        RemoveHandler obj.DoubleClick, AddressOf ObjDateTextDoubleClick
                                        AddHandler obj.DoubleClick, AddressOf ObjDateTextDoubleClick
                                    End If
                                    If TypeOf obj Is TextBox And InStr(1, obj.Name.ToUpper, "mesAno".ToUpper) Then
                                        RemoveHandler obj.DoubleClick, AddressOf ObjMesAnoTextDoubleClick
                                        AddHandler obj.DoubleClick, AddressOf ObjMesAnoTextDoubleClick
                                    End If

                                Case TypeOf obj Is DataGridView
                                    AddHandler CType(obj, DataGridView).SortCompare, AddressOf dataGridView1_SortCompare
                                    AddHandler CType(obj, DataGridView).RowsAdded, AddressOf ColorirLinhaGrid
                                    AddHandler CType(obj, DataGridView).CellMouseEnter, AddressOf GridMouseEnter
                                    AddHandler CType(obj, DataGridView).MouseLeave, AddressOf DesselecionaGrid
                                    AddHandler CType(obj, DataGridView).HandleCreated, AddressOf DesselecionaGrid
                                    AddHandler CType(obj, DataGridView).LostFocus, AddressOf DataGridViewLostFocus

                            End Select

                        End If

                        If obj.Controls.Count > 0 Then
                            AtribuirEventos(obj, excecao.ToString)
                        End If
                    End If
                Next

            Catch erro As Exception
                MsgBox("Houve um erro ao tentar atribuir os eventos aos controles do formulário:" + erro.Message, vbExclamation)
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - AtribuirEventos")
            End Try
        End Sub

        Private Sub dataGridView1_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs)
            Dim teste As DataGridView = CType(sender, DataGridView)
            If e.Column.Index < 0 Then
                Exit Sub
            End If

            If teste.Columns.Count = 0 Then Exit Sub

            Dim coluna As DataGridViewColumn
            coluna = teste.Columns(e.Column.Index)

            If coluna.ValueType = Nothing Then Exit Sub

            Select Case coluna.ValueType
                Case Type.GetType("System.Int"), Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                    Try
                        e.SortResult = If(CInt(e.CellValue1) < CInt(e.CellValue2), -1, 1)
                        e.Handled = True
                    Catch
                    End Try
                Case Type.GetType("System.Date"), Type.GetType("System.Time")
                    Try
                        e.SortResult = If(CDate(e.CellValue1) < CDate(e.CellValue2), -1, 1)
                        e.Handled = True
                    Catch
                    End Try
                Case Type.GetType("System.String")
                    Try
                        e.SortResult = If(CStr(e.CellValue1) < CStr(e.CellValue2), -1, 1)
                        e.Handled = True
                    Catch
                    End Try
                Case Type.GetType("System.Double"), Type.GetType("System.Decimal"), Type.GetType("System.Float")
                    Try
                        e.SortResult = If(CDbl(e.CellValue1) < CInt(e.CellValue2), -1, 1)
                        e.Handled = True
                    Catch
                    End Try
            End Select

        End Sub

        Private Sub DataGridViewLostFocus(sender As Object, e As EventArgs)
            Dim teste As DataGridView = CType(sender, DataGridView)
            teste.EndEdit()
        End Sub

        Private Sub DesselecionaGrid(sender As Object, e As EventArgs)
            Dim teste As DataGridView = CType(sender, DataGridView)
            teste.ClearSelection()
        End Sub

        Private Sub ColorirLinhaGrid(sender As Object, e As DataGridViewRowsAddedEventArgs)
            Dim teste As DataGridView = CType(sender, DataGridView)
            If teste.RowCount = 1 Then
                teste.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.MediumAquamarine
            ElseIf teste.Rows(teste.RowCount - 2).DefaultCellStyle.BackColor = Color.SkyBlue Then
                teste.Rows(teste.RowCount - 1).DefaultCellStyle.BackColor = Color.MediumAquamarine
            Else
                teste.Rows(teste.RowCount - 1).DefaultCellStyle.BackColor = Color.SkyBlue
            End If
        End Sub

        Private Sub GridMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
            If e.RowIndex > -1 Then
                Dim teste As DataGridView = CType(sender, DataGridView)
                teste.ClearSelection()
                teste.Rows(e.RowIndex).Selected = True
            End If
        End Sub

        Private Sub ObjLostFocus(ByVal sender As Object, ByVal e As EventArgs)
            If _controleAtivo Is Nothing Then Exit Sub

            Try

                _controleAtivo.BackColor = _controleAtivo.Tag

                If TypeOf _controleAtivo Is TextBox Then
                    _controleAtivo.Text = _controleAtivo.Text.ToString.Replace("'", "`")
                    _controleAtivo.Text = _controleAtivo.Text.Trim
                    If InStr(_controleAtivo.Name.ToUpper(), "LOGIN") = 0 And InStr(_controleAtivo.Name.ToUpper(), "USUARIO") = 0 And InStr(_controleAtivo.Name.ToUpper(), "SENHA") = 0 And InStr(_controleAtivo.Name.ToUpper(), "EMAIL") = 0 And InStr(_controleAtivo.Name.ToUpper(), "E-MAIL") = 0 And InStr(_controleAtivo.Name.ToUpper(), "SITE") = 0 Then
                        _controleAtivo.Text = _controleAtivo.Text.Trim.ToUpper()
                    End If
                ElseIf TypeOf _controleAtivo Is ComboBox Then
                    Try
                        _controleAtivo.Text = _controleAtivo.Text.ToString.Replace("'", "`")
                        _controleAtivo.Text = _controleAtivo.Text.Trim.ToUpper()
                    Catch ex As Exception
                    End Try
                End If

                If InStr(_controleAtivo.Name.ToUpper, "DATA") > 0 Then
                    _controleAtivo.BackColor = Color.White
                    If Not IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.Red
                    Else
                        If IsDate(_controleAtivo.Text) Then
                            _controleAtivo.Text = CDate(_controleAtivo.Text).ToString("dd/MM/yyyy")
                        End If
                        _controleAtivo.Text = FormataCampo(_controleAtivo.Text, TipoFormato.Data, "A")
                        If CDate(_controleAtivo.Text) > DateAdd(DateInterval.Day, 60, Now.Date) Then
                            _controleAtivo.BackColor = Color.Yellow
                        ElseIf CDate(_controleAtivo.Text) < DateAdd(DateInterval.Day, -60, Now.Date) Then
                            _controleAtivo.BackColor = Color.Yellow
                        End If
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "MESANO") > 0 Then
                    _controleAtivo.BackColor = Color.White
                    If Not IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.Red
                    Else
                        If IsDate(_controleAtivo.Text) Then
                            _controleAtivo.Text = CDate(_controleAtivo.Text).ToString("MM/yyyy")
                        End If
                        _controleAtivo.Text = FormataCampo(_controleAtivo.Text, TipoFormato.MesAno, "A")
                        If CDate(_controleAtivo.Text) > DateAdd(DateInterval.Day, 60, Now.Date) Then
                            _controleAtivo.BackColor = Color.Yellow
                        ElseIf CDate(_controleAtivo.Text) < DateAdd(DateInterval.Day, -60, Now.Date) Then
                            _controleAtivo.BackColor = Color.Yellow
                        End If
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "HORA") > 0 Then
                    If Not IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.Red
                    Else
                        _controleAtivo.Text = FormataCampo(_controleAtivo.Text, "HORA", "A")
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "CADASTRO") > 0 Then
                    If Not ValidaCnpj(_controleAtivo.Text) And Not ValidaCpf(_controleAtivo.Text) Then
                        _controleAtivo.BackColor = Color.Red
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "PLACA") > 0 Then
                    If Len(_controleAtivo.Text) <> 7 And Len(_controleAtivo.Text) <> 8 Then
                        _controleAtivo.BackColor = Color.Red
                    ElseIf IsNumeric(Mid(_controleAtivo.Text, 1, 1)) Or IsNumeric(Mid(_controleAtivo.Text, 2, 1)) Or IsNumeric(Mid(_controleAtivo.Text, 3, 1)) Then
                        _controleAtivo.BackColor = Color.Red
                    ElseIf Len(_controleAtivo.Text) = 7 Then
                        If Not IsNumeric(Mid(_controleAtivo.Text, 4, 4)) Then
                            _controleAtivo.BackColor = Color.Red
                        Else
                            _controleAtivo.Text = FormataCampo(_controleAtivo.Text, "PLACA", "A")
                        End If
                    ElseIf Len(_controleAtivo.Text) = 8 Then
                        If Not IsNumeric(Mid(_controleAtivo.Text, 5, 4)) Then
                            _controleAtivo.BackColor = Color.Red
                        Else
                            _controleAtivo.Text = FormataCampo(_controleAtivo.Text, "PLACA", "A")
                        End If
                    Else
                        _controleAtivo.Text = FormataCampo(_controleAtivo.Text, "PLACA", "A")
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "VALOR") > 0 Then
                    _controleAtivo.Text = FormataNumero(_controleAtivo.Text, 2)
                ElseIf InStr(_controleAtivo.Name.ToUpper, "PESO") > 0 Or InStr(_controleAtivo.Name.ToUpper, "VOLUME") > 0 Then
                    _controleAtivo.Text = FormataNumero(_controleAtivo.Text, 3)
                    'ElseIf InStr(_controleAtivo.Name.ToUpper, "NUMERO") > 0 Then
                    '    _controleAtivo.Text = FormataNumero(_controleAtivo.Text)
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub ObjGotFocus(ByVal sender As Object, ByVal e As EventArgs)
            Try
                If _varFormulario Is Nothing Then Exit Sub
                If _varFormulario.ActiveControl Is Nothing Then Exit Sub
                If _varFormulario.ActiveControl.BackColor = Color.Red Then
                    _varFormulario.ActiveControl.Tag = Color.White
                Else
                    _varFormulario.ActiveControl.Tag = _varFormulario.ActiveControl.BackColor
                End If

                _varFormulario.ActiveControl.BackColor = Color.LightSteelBlue
                If TypeOf _varFormulario.ActiveControl Is TextBox Then CType(_varFormulario.ActiveControl, TextBox).SelectAll()
                _controleAtivo = _varFormulario.ActiveControl
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub ObjKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try
                If _varFormulario Is Nothing Then Exit Sub
                If e.KeyCode = Keys.Return Then
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub ObjKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            If _controleAtivo Is Nothing Then Exit Sub

            Try
                If e.KeyCode <> Keys.Left And e.KeyCode <> Keys.Right And e.KeyCode <> 9 And e.KeyCode <> 13 Then
                    If TypeOf _controleAtivo Is TextBox Then
                        If _controleAtivo.Text.Trim <> "" Then
                            If InStr(1, _controleAtivo.Text, "'") > 0 Then
                                _controleAtivo.Text = _controleAtivo.Text.Replace("'", "`")
                                CType(_controleAtivo, TextBox).SelectionStart = CType(_controleAtivo, TextBox).Text.Length
                            End If
                        End If
                    End If
                    If InStr(_controleAtivo.Name.ToUpper, "TELEFONE") > 0 Or InStr(_controleAtivo.Name.ToUpper, "FAX") > 0 Or InStr(_controleAtivo.Name.ToUpper, "CELULAR") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Telefone, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "CEP") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Cep, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "DATA") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Data, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "MESANO") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.MesAno, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "HORA") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Hora, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "CADASTRO") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Cpf, , e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "PLACA") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.Placa, "A", e.KeyValue)
                    ElseIf InStr(_controleAtivo.Name.ToUpper, "SOMENTENUMERO") > 0 Then
                        Formatar(_controleAtivo, TipoFormato.SomenteNumero, , e.KeyValue)
                    End If
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub ObjTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim controle As String
            If _controleAtivo Is Nothing Then Exit Sub

            Try

                If InStr(_controleAtivo.Name.ToUpper, "DATA") > 0 Then
                    If IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.White
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "MESANO") > 0 Then
                    If IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.White
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "HORA") > 0 Then
                    If IsDate(_controleAtivo.Text) And _controleAtivo.Text.Trim <> "" Then
                        _controleAtivo.BackColor = Color.White
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "CADASTRO") > 0 Then
                    If ValidaCnpj(_controleAtivo.Text) Or ValidaCpf(_controleAtivo.Text) Then
                        _controleAtivo.BackColor = Color.White
                    End If
                ElseIf InStr(_controleAtivo.Name.ToUpper, "PLACA") > 0 Then
                    controle = LimpaFormatacao(_controleAtivo.Text)
                    If Len(controle) = 7 Then
                        _controleAtivo.BackColor = Color.White
                    ElseIf Not IsNumeric(Mid(controle, 1, 1)) And Not IsNumeric(Mid(controle, 2, 1)) And Not IsNumeric(Mid(controle, 3, 1)) Then
                        _controleAtivo.BackColor = Color.White
                    ElseIf Len(controle) = 7 Then
                        If IsNumeric(Mid(controle, 4, 4)) Then
                            _controleAtivo.BackColor = Color.White
                        End If
                    End If
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub ObjDateTextDoubleClick(ByVal sender As Object, ByVal e As EventArgs)

            If _controleAtivo Is Nothing Then Exit Sub

            Try

                _objDtPicker = New DateTimePicker

                _objDtPicker.Size = New Size(20, 25)

                Dim container As Control = AchaContainerTextBox(_varFormulario, _controleAtivo)

                If container Is Nothing Then
                    _varFormulario.Controls.Add(_objDtPicker)
                Else
                    container.Controls.Add(_objDtPicker)
                End If

                _objDtPicker.Location = New Point(_controleAtivo.Location.X + _controleAtivo.Width - 1, _controleAtivo.Location.Y - 30)

                _objDtPicker.BringToFront()

                _objDtPicker.Focus()
                SendKeys.Send("{F4}")

                AddHandler _objDtPicker.CloseUp, AddressOf ObjCloseUpDTpicker

            Catch ex As Exception
                Exit Sub
            End Try
        End Sub
        Private Sub ObjMesAnoTextDoubleClick(ByVal sender As Object, ByVal e As EventArgs)

            If _controleAtivo Is Nothing Then Exit Sub

            Try

                _objMonthpicker = New DateTimePicker

                _objMonthpicker.Size = New Size(20, 25)

                Dim container As Control = AchaContainerTextBox(_varFormulario, _controleAtivo)

                If container Is Nothing Then
                    _varFormulario.Controls.Add(_objMonthpicker)
                Else
                    container.Controls.Add(_objMonthpicker)
                End If

                _objMonthpicker.Location = New Point(_controleAtivo.Location.X + _controleAtivo.Width - 1, _controleAtivo.Location.Y - 30)

                _objMonthpicker.BringToFront()

                _objMonthpicker.Focus()
                SendKeys.Send("{F4}")

                AddHandler _objMonthpicker.CloseUp, AddressOf ObjCloseUpMesAnopicker

            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Function AchaContainerTextBox(ByVal controls As Control, ByVal textbox As TextBox) As Control

            If controls.Controls.Count > 0 Then
                For Each control As Control In controls.Controls
                    If control.Controls.Count > 0 Then
                        _container = AchaContainerTextBox(control, textbox)
                        If Not _container Is Nothing Then
                            Return _container
                        End If
                    ElseIf control.Name.ToUpper = textbox.Name.ToUpper Then
                        Return controls
                    End If
                Next
                Return Nothing
            Else
                Return Nothing
            End If
        End Function

        Public Sub ObjCloseUpDTpicker(ByVal sender As Object, ByVal e As EventArgs)
            _controleAtivo.Text = _objDtPicker.Value.ToString("dd/MM/yyyy")

            If _container Is Nothing Then
                _varFormulario.Controls.Remove(_objDtPicker)
            Else
                _container.Controls.Remove(_objDtPicker)
            End If

        End Sub

        Public Sub ObjCloseUpMesAnopicker(ByVal sender As Object, ByVal e As EventArgs)
            _controleAtivo.Text = _objMonthpicker.Value.ToString("MM/yyyy")

            If _container Is Nothing Then
                _varFormulario.Controls.Remove(_objMonthpicker)
            Else
                _container.Controls.Remove(_objMonthpicker)
            End If

        End Sub

        Private Function FormataCampo(ByVal textoIn As String, ByVal tipoFormato As TipoFormato, Optional ByVal tipo As String = "N") As String
            Dim texto As String = ""

            If textoIn.Trim.Length = 0 Then Return ""

            '*************************************
            'N - NUMÉRICO ===>> A - ALFANUMÉRICO
            '*************************************
            If tipo = "N" Then
                Dim n As Short = 0

                Do While Not IsNumeric(textoIn)
                    If n < 0 Then Exit Do

                    If textoIn.Trim.Length = 0 Then Return ""

                    If Not IsNumeric(textoIn.Substring(n, 1)) Then
                        textoIn = textoIn.Replace(textoIn.Substring(n, 1), "")
                        n -= 1
                    End If
                    n += 1
                Loop
            End If

            textoIn = textoIn.Replace("/", "")
            textoIn = textoIn.Replace("+", "")
            textoIn = textoIn.Replace("-", "")
            textoIn = textoIn.Replace("\", "")
            textoIn = textoIn.Replace("(", "")
            textoIn = textoIn.Replace("}", "")
            textoIn = textoIn.Replace(".", "")

            Select Case tipoFormato
                Case TipoFormato.Data
                    For n As Short = 0 To textoIn.Length - 1
                        texto += textoIn.Substring(n, 1)
                        Select Case texto.Length
                            Case 2, 5
                                texto += "/"
                        End Select
                    Next
                    If texto.Length > 10 Then texto = texto.Substring(0, 10)
                Case TipoFormato.MesAno
                    For n As Short = 0 To textoIn.Length - 1
                        texto += textoIn.Substring(n, 1)
                        Select Case texto.Length
                            Case 2
                                texto += "/"
                        End Select
                    Next
                    If texto.Length > 8 Then texto = texto.Substring(0, 7)

                Case TipoFormato.Hora
                    For n As Short = 0 To textoIn.Length - 1
                        texto += textoIn.Substring(n, 1)
                        Select Case texto.Length
                            Case 2
                                texto += ":"
                        End Select
                    Next
                    If texto.Length > 5 Then texto = texto.Substring(0, 5)
                Case TipoFormato.Cpf, TipoFormato.Cnpj
                    If textoIn.Length <= 11 Then
                        For n As Short = 0 To textoIn.Length - 1
                            texto += textoIn.Substring(n, 1)
                            Select Case texto.Length
                                Case 3, 7
                                    texto += "."
                                Case 11
                                    texto += "-"
                            End Select
                        Next
                        If texto.Length > 14 Then texto = texto.Substring(0, 14)
                    Else
                        For n As Short = 0 To textoIn.Length - 1
                            texto += textoIn.Substring(n, 1)
                            Select Case texto.Length
                                Case 2, 6, 7
                                    texto += "."
                                Case 10
                                    texto += "/"
                                Case 15
                                    texto += "-"
                            End Select
                        Next
                        If texto.Length > 18 Then texto = texto.Substring(0, 18)
                    End If
                Case TipoFormato.Cep
                    For n As Short = 0 To textoIn.Length - 1
                        texto += textoIn.Substring(n, 1)
                        Select Case texto.Length
                            Case 5
                                texto += "-"
                        End Select
                    Next
                    If texto.Length > 9 Then texto = texto.Substring(0, 9)
                Case TipoFormato.Placa
                    For n As Short = 0 To textoIn.Length - 1
                        texto += textoIn.Substring(n, 1)
                        If (texto.Length <= 3 And IsNumeric(textoIn.Substring(n, 1))) Or (texto.Length > 3 And Not IsNumeric(textoIn.Substring(n, 1))) Then
                            texto = texto.Substring(0, texto.Length - 1)
                        End If
                        Select Case texto.Trim.Length
                            Case 3
                                texto += "-"
                        End Select
                    Next
                    If texto.Length > 8 Then texto = texto.Substring(0, 8)
                Case TipoFormato.Telefone
                    texto = LimpaFormatacao(textoIn)
                    If Mid(texto, 1, 1) <> "0" Then
                        texto = Mid(texto, 1, 11)
                        Select Case texto.Length
                            Case 8
                                texto = Mid(texto, 1, 4) + "-" + Mid(texto, 5, 4)
                            Case 9
                                texto = Mid(texto, 1, 5) + "-" + Mid(texto, 6, 4)
                            Case 10
                                texto = "(" + Mid(texto, 1, 2) + ")" + Mid(texto, 3, 4) + "-" + Mid(texto, 7, 4)
                            Case 11
                                texto = "(" + Mid(texto, 1, 2) + ")" + Mid(texto, 3, 5) + "-" + Mid(texto, 8, 4)
                            Case 12
                                texto = "(" + Mid(texto, 1, 2) + ")" + Mid(texto, 5, 4) + "-" + Mid(texto, 9, 4)
                            Case 13
                                texto = "(" + Mid(texto, 1, 2) + ")" + Mid(texto, 5, 5) + "-" + Mid(texto, 10, 4)
                        End Select
                    Else
                        texto = Mid(texto, 1, 12)
                        Select Case texto.Length
                            Case 8
                                texto = Mid(texto, 1, 4) + "-" + Mid(texto, 5, 4)
                            Case 9
                                texto = Mid(texto, 1, 5) + "-" + Mid(texto, 6, 4)
                            Case 11
                                texto = "(" + Mid(texto, 1, 3) + ")" + Mid(texto, 4, 4) + "-" + Mid(texto, 8, 4)
                            Case 12
                                texto = "(" + Mid(texto, 1, 3) + ")" + Mid(texto, 4, 5) + "-" + Mid(texto, 9, 4)
                            Case 13
                                texto = "(" + Mid(texto, 1, 5) + ")" + Mid(texto, 6, 4) + "-" + Mid(texto, 10, 4)
                            Case 14
                                texto = "(" + Mid(texto, 1, 5) + ")" + Mid(texto, 6, 5) + "-" + Mid(texto, 11, 4)
                        End Select
                    End If
                    If texto.Length > 14 Then texto = Mid(texto, 1, 14)
                Case TipoFormato.SomenteNumero
                    For n As Short = 0 To textoIn.Length - 1
                        If IsNumeric(textoIn.Substring(n, 1)) Then
                            texto += textoIn.Substring(n, 1)
                        End If
                    Next
            End Select

            Return texto
        End Function

        Public Function Formatar(ByVal obj As Object, ByVal tipoFormato As TipoFormato, Optional ByVal tipo As String = "N", Optional ByVal keyValue As Integer = 0) As String
            ' ReSharper disable once RedundantAssignment
            Dim texto As String = ""

            Try
                If TypeOf obj Is TextBox Then
                    If Not CType(obj, TextBox).Tag = Nothing Then
                        If CType(obj, TextBox).Tag.ToString.ToUpper = "RETORNO" Then
                            CType(obj, TextBox).SelectionStart = CType(obj, TextBox).Text.Length
                            CType(obj, TextBox).Tag = Nothing
                            Return obj.ToString
                        End If
                    End If
                    texto = FormataCampo(CType(obj, TextBox).Text.ToString, tipoFormato, tipo)
                    CType(obj, TextBox).Text = texto
                    CType(obj, TextBox).SelectionStart = Len(CType(obj, TextBox).Text)
                ElseIf TypeOf obj Is ToolStripTextBox Then
                    texto = FormataCampo(CType(obj, ToolStripTextBox).Text.ToString, tipoFormato, tipo)
                    CType(obj, ToolStripTextBox).Text = texto
                    CType(obj, ToolStripTextBox).SelectionStart = Len(CType(obj, ToolStripTextBox).Text)
                ElseIf TypeOf obj Is ComboBox Then
                    If CType(obj, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                        texto = FormataCampo(CType(obj, ComboBox).Text.ToString, tipoFormato, tipo)
                        CType(obj, ComboBox).Text = texto
                        CType(obj, ComboBox).SelectionStart = Len(CType(obj, ComboBox).Text)
                    End If
                Else
                    texto = FormataCampo(obj.ToString, tipoFormato, tipo)
                End If

            Catch erro As Exception
                'Call ErroCritico(Err.Number, Err.Description, "Funcoes - Formatar")
                Return ""
            End Try

            Return texto
        End Function

        Public Enum TipoFormato
            Data = 1
            Hora = 2
            Cpf = 3
            Cnpj = 4
            Cep = 5
            Placa = 6
            Telefone = 7
            SomenteNumero = 8
            MesAno = 9
        End Enum

        Public Function CorrigeString(ByVal texto As String) As String

            Dim auxTexto As String

            auxTexto = texto

            auxTexto = Replace(auxTexto, "À", "A")
            auxTexto = Replace(auxTexto, "Â", "A")
            auxTexto = Replace(auxTexto, "Ã", "A")
            auxTexto = Replace(auxTexto, "Á", "A")
            auxTexto = Replace(auxTexto, "Ä", "A")
            auxTexto = Replace(auxTexto, "Ê", "E")
            auxTexto = Replace(auxTexto, "É", "E")
            auxTexto = Replace(auxTexto, "Ë", "E")
            auxTexto = Replace(auxTexto, "Í", "I")
            auxTexto = Replace(auxTexto, "Ì", "I")
            auxTexto = Replace(auxTexto, "Î", "I")
            auxTexto = Replace(auxTexto, "Ï", "I")
            auxTexto = Replace(auxTexto, "Õ", "O")
            auxTexto = Replace(auxTexto, "Ó", "O")
            auxTexto = Replace(auxTexto, "Ô", "O")
            auxTexto = Replace(auxTexto, "Ö", "O")
            auxTexto = Replace(auxTexto, "Ú", "U")
            auxTexto = Replace(auxTexto, "Ü", "U")
            auxTexto = Replace(auxTexto, "Ç", "C")

            auxTexto = Replace(auxTexto, "á", "a")
            auxTexto = Replace(auxTexto, "â", "a")
            auxTexto = Replace(auxTexto, "ã", "a")
            auxTexto = Replace(auxTexto, "à", "a")
            auxTexto = Replace(auxTexto, "ä", "a")
            auxTexto = Replace(auxTexto, "ê", "e")
            auxTexto = Replace(auxTexto, "é", "e")
            auxTexto = Replace(auxTexto, "ë", "e")
            auxTexto = Replace(auxTexto, "í", "i")
            auxTexto = Replace(auxTexto, "ì", "i")
            auxTexto = Replace(auxTexto, "î", "i")
            auxTexto = Replace(auxTexto, "ï", "i")
            auxTexto = Replace(auxTexto, "õ", "o")
            auxTexto = Replace(auxTexto, "ó", "o")
            auxTexto = Replace(auxTexto, "ô", "o")
            auxTexto = Replace(auxTexto, "ö", "o")
            auxTexto = Replace(auxTexto, "ú", "u")
            auxTexto = Replace(auxTexto, "ü", "u")
            auxTexto = Replace(auxTexto, "ç", "c")

            auxTexto = Replace(auxTexto, "'", " ")
            auxTexto = Replace(auxTexto, "`", " ")
            auxTexto = Replace(auxTexto, "´", " ")
            auxTexto = Replace(auxTexto, "¨", " ")

            Return auxTexto
        End Function

        Public Function ValidaCadastro(ByVal cadastro As String) As Boolean
            cadastro = LimpaFormatacao(cadastro)

            If cadastro.Length <> 11 And cadastro.Length <> 14 Then Return False

            If cadastro.Length = 11 Then Return ValidaCpf(cadastro)

            Return ValidaCnpj(cadastro)

        End Function

        '*******************************************************************
        'Descrição: Confere DAC do CGC
        'Data: 27/5/94
        'Parâmetro(s): VA_CGC$ = CGC
        'Retorno:   True => DAC OK
        '           False => DAC Inválido
        '*******************************************************************
        Private Function ValidaCnpj(ByVal vaCgc As String) As Boolean
            Dim vaCgctot As String    'Numero CGC Completo
            Dim vaCgcnum As String    'Numero CGC sem DAC
            Dim vaPosicao As Integer  'Uso Diversos
            Dim vaAcum As Long        'Acumulador
            Dim vaNumero As Integer   'Guardar um Dígito
            Dim vaResultado As String 'Resultado do Calculo do DAC
            Dim vaRetorno As Boolean = False

            vaCgc = LimpaFormatacao(vaCgc)

            Try
                ' Guarda o Numero e os Digitos
                ' ----------------------------
                vaCgctot = vaCgc.PadLeft(14, "0")
                vaCgcnum = Left$(vaCgctot, 12)

                ' Calcula o 1. DAC
                ' ----------------
                vaAcum = 0
                For vaPosicao = 12 To 1 Step -1
                    'Pega um Dígito na posição
                    vaNumero = ValDouble(Mid$(vaCgcnum, vaPosicao, 1))
                    'Calculo Dígito
                    vaNumero = vaNumero * IIf((14 - vaPosicao) > 9, 6 - vaPosicao, 14 - vaPosicao)
                    'Acumula
                    vaAcum = vaAcum + vaNumero
                Next vaPosicao
                'Calcula e Verifica o 1. DAC
                vaNumero = 11 - (vaAcum Mod 11)
                If vaNumero > 9 Then vaNumero = 0

                ' Guarda o 1. DAC e Acumula
                ' -------------------------
                vaResultado = vaNumero.ToString.PadLeft(1, "0")
                vaCgcnum = vaCgcnum & vaResultado

                ' Calcula o 2. DAC
                ' ----------------
                vaAcum = 0
                For vaPosicao = 13 To 1 Step -1
                    'Pega um Dígito na posição
                    vaNumero = ValDouble(Mid$(vaCgcnum, vaPosicao, 1))
                    'Calculo Dígito
                    vaNumero = vaNumero * IIf((15 - vaPosicao) > 9, 7 - vaPosicao, 15 - vaPosicao)
                    'Acumula
                    vaAcum = vaAcum + vaNumero
                Next vaPosicao
                'Calcula e Verifica o 1. DAC
                vaNumero = 11 - (vaAcum Mod 11)
                If vaNumero > 9 Then vaNumero = 0

                ' Guarda o 2. DAC e Verifica
                ' --------------------------
                vaResultado = vaResultado & vaNumero.ToString.PadLeft(1, "0")
                If vaResultado = Right$(vaCgctot, 2) Then
                    vaRetorno = True
                End If
            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - ValidaCNPJ")
            End Try

            Return vaRetorno
        End Function

        '*******************************************************************
        'Descrição: Confere DAC do CPF
        'Data: 27/5/94
        'Parâmetro(s): VA_CPF$ = N. CPF Completo
        'Retorno:   True => DAC OK
        '           False => DAC Inválido
        '*******************************************************************
        Private Function ValidaCpf(ByVal cpf As String) As Boolean
            Dim vaCpftot As String    'Numero CPF Completo
            Dim vaCpfnum As String    'Numero CPF sem DAC
            Dim vaPosicao As Integer  'Uso Diversos
            Dim vaAcum As Long        'Acumulador
            Dim vaNumero As Integer   'Guardar um Dígito
            Dim vaResultado As String 'Resultado do Calculo do DAC
            Dim vaRetorno As Boolean = False

            cpf = cpf.Replace("/", "")
            cpf = cpf.Replace("-", "")
            cpf = cpf.Replace(".", "")

            Try
                ' Guarda o Numero e os Digitos
                ' ----------------------------
                vaCpftot = cpf.PadLeft(11, "0")
                vaCpfnum = Left$(vaCpftot, 9)

                ' Calcula o 1. DAC
                ' ----------------
                vaAcum = 0
                For vaPosicao = 1 To 9
                    'Pega um Dígito na posição
                    vaNumero = ValDouble(Mid$(vaCpfnum, vaPosicao, 1))
                    'Calculo Dígito
                    vaNumero = vaNumero * (11 - vaPosicao)
                    'Acumula
                    vaAcum = vaAcum + vaNumero
                Next vaPosicao

                'Calcula e Verifica o 1. DAC
                vaNumero = 11 - (vaAcum Mod 11)
                If vaNumero > 9 Then vaNumero = 0

                ' Guarda o 1. DAC e Acumula
                ' -------------------------
                vaResultado = vaNumero.ToString.PadLeft(1, "0")
                vaCpfnum = vaCpfnum & vaResultado

                ' Calcula o 2. DAC
                ' ----------------
                vaAcum = 0
                For vaPosicao = 1 To 10
                    'Pega um Dígito na posição
                    vaNumero = ValDouble(Mid$(vaCpfnum, vaPosicao, 1))
                    'Calculo Dígito
                    vaNumero = vaNumero * (12 - vaPosicao)
                    'Acumula
                    vaAcum = vaAcum + vaNumero
                Next vaPosicao
                'Calcula e Verifica o 1. DAC
                vaNumero = 11 - (vaAcum Mod 11)
                If vaNumero > 9 Then vaNumero = 0

                ' Guarda o 2. DAC e Verifica
                ' --------------------------
                vaResultado = vaResultado & vaNumero.ToString.PadLeft(1, "0")
                If vaResultado = Right$(vaCpftot, 2) Then
                    vaRetorno = True
                End If
            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes - ValidaCPF")
                Return False
            End Try

            Return vaRetorno
        End Function
        Public Function ValDouble(ByVal value As String) As Double
            If Not IsNumeric(value) Then value = 0
            Return CDbl(value)
        End Function
        Public Function FormataNumero(ByVal valorIn As String, Optional ByVal qtdcasasdecimais As Short = 0) As String
            Dim valor As String
            Dim formato As String

            formato = "###############0" + IIf(qtdcasasdecimais > 0, ".".PadRight(1 + qtdcasasdecimais, "0"), "")

            Try

                valor = ValDouble(valorIn).ToString(formato)

            Catch erro As Exception
                'Call ErroCritico(Err.Number, ERRO.Message, "Funcoes")
                Return "0,00"
            End Try

            Return valor
        End Function

        Public Sub PreencheTelas(ByRef obj As ComboBox, ByVal nomeSistema As String)
            obj.Items.Clear()
            obj.Items.Add("")
            If InStr(1, nomeSistema.ToUpper(), "TMS".ToUpper()) > 0 Then
                obj.Items.Add("Login")
                obj.Items.Add("CTe")
                obj.Items.Add("Minuta")
                obj.Items.Add("Fatura")
                obj.Items.Add("Despesa")
            Else
                obj.Items.Add("Login")
            End If

        End Sub

        Public Function ConverteHoraEmDecimal(ByVal horaDataValor As String) As Double
            Dim resultado As Single
            Dim horaString As String
            Dim qtdHora As Double
            Dim qtdMinutos As Double
            Dim negativo As Boolean = False

            If Len(horaDataValor) < 4 Then Return 0
            If Len(horaDataValor) >= 8 Then horaDataValor = Mid(horaDataValor, 1, 5)

            horaString = horaDataValor

            If Trim(horaString) = "" Then Return 0
            If horaString = ":" Then Return 0
            If InStr(horaString, ":") = 0 Then Return 0

            If InStr(horaString, "-") > 0 Then negativo = True

            horaString = horaDataValor.Replace("-", "")

            qtdHora = ValDouble(Mid(horaString, 1, InStr(horaString, ":") - 1))
            qtdMinutos = ValDouble(Mid(horaString, InStr(horaString, ":") + 1))

            If ValDouble(qtdHora).Equals(0) And ValDouble(qtdMinutos).Equals(0) Then Return 0
            If ValDouble(qtdHora) < 0 Or ValDouble(qtdMinutos) < 0 Then Return 0

            resultado = qtdHora + ((qtdMinutos * 100) / 60) / 100

            Return ValDouble(IIf(negativo, -resultado, resultado))

        End Function

        Public Function ConverteDecimalEmHora(ByVal horaDecimalValor As Double) As String
            Dim sHr As String
            Dim sMin As String
            Dim hora As String

            Dim negativo = horaDecimalValor < 0

            horaDecimalValor = Math.Abs(horaDecimalValor)

            If InStr(horaDecimalValor.ToString, ",", CompareMethod.Text) > 0 Then
                sHr = Mid(horaDecimalValor.ToString, 1, InStr(horaDecimalValor.ToString, ",", CompareMethod.Text) - 1)
            Else
                sHr = horaDecimalValor
            End If

            sMin = Math.Round((horaDecimalValor - ValDouble(sHr)) * 60)

            hora = ValDouble(sHr).ToString("########00") + ":" + ValDouble(sMin).ToString("00")

            Return IIf(negativo, "-" + hora, hora)

        End Function

        Public Function ConverteTempoEmSegundos(ByVal horaDataValor As String) As Double
            Dim resultado As Single
            Dim horaString As String
            Dim qtdHora As Double
            Dim qtdMinutos As Double
            Dim negativo As Boolean = False

            If Len(horaDataValor) < 4 Then Return 0

            horaString = horaDataValor

            If Trim(horaString) = "" Then Return 0
            If horaString = ":" Then Return 0
            If InStr(horaString, ":") = 0 Then Return 0

            If InStr(horaString, "-") > 0 Then negativo = True

            horaString = horaDataValor.Replace("-", "")

            qtdHora = ValDouble(Mid(horaString, 1, InStr(horaString, ":") - 1))
            qtdMinutos = ValDouble(Mid(horaString, InStr(horaString, ":") + 1))

            If ValDouble(qtdHora).Equals(0) And ValDouble(qtdMinutos).Equals(0) Then Return 0
            If ValDouble(qtdHora) < 0 Or ValDouble(qtdMinutos) < 0 Then Return 0

            resultado = qtdHora * 3600 + qtdMinutos * 60

            Return ValDouble(IIf(negativo, -resultado, resultado))

        End Function


        Public Function SoNumeros(ByVal keyascii As Short) As Short
            If InStr("1234567890", Chr(keyascii)) = 0 Then
                SoNumeros = 0
            Else
                SoNumeros = keyascii
            End If

            Select Case keyascii
                Case 8
                    SoNumeros = keyascii
                Case 13
                    SoNumeros = keyascii
                Case 32
                    SoNumeros = keyascii
            End Select
        End Function

        Public Function Cript(ByVal texto As String) As String
            Dim strTempChar As String = ""

            For i = 1 To Len(texto)

                If Asc(Mid$(texto, i, 1)) < 128 Then
                    strTempChar = Asc(Mid$(texto, i, 1)) + 128
                ElseIf Asc(Mid$(texto, i, 1)) > 128 Then
                    strTempChar = Asc(Mid$(texto, i, 1)) - 128
                End If

                Mid$(texto, i, 1) = Chr(strTempChar)

            Next i

            Return texto
        End Function

        '    Private Function FormataCampo(ByVal Texto_IN As String, ByVal TipoFormato As TipoFormato, Optional ByVal TIPO As String = "N") As String
        '        Dim TEXTO As String = ""

        '        If Texto_IN.Trim.Length = 0 Then Return ""

        '        '*************************************
        '        'N - NUMÉRICO ===>> A - ALFANUMÉRICO
        '        '*************************************
        '        If TIPO = "N" Then
        '            Dim N As Short = 0

        '            Do While Not IsNumeric(Texto_IN)
        '                If N < 0 Then Exit Do

        '                If Texto_IN.Trim.Length = 0 Then Return ""

        '                If Not IsNumeric(Texto_IN.Substring(N, 1)) Then
        '                    Texto_IN = Texto_IN.Replace(Texto_IN.Substring(N, 1), "")
        '                    N -= 1
        '                End If
        '                N += 1
        '            Loop
        '        End If

        '        Texto_IN = Texto_IN.Replace("/", "")
        '        Texto_IN = Texto_IN.Replace("+", "")
        '        Texto_IN = Texto_IN.Replace("-", "")
        '        Texto_IN = Texto_IN.Replace("\", "")
        '        Texto_IN = Texto_IN.Replace("(", "")
        '        Texto_IN = Texto_IN.Replace("}", "")
        '        Texto_IN = Texto_IN.Replace(".", "")

        '        Select Case TipoFormato
        '            Case Funcoes.TipoFormato.Data
        '                For N As Short = 0 To Texto_IN.Length - 1
        '                    TEXTO += Texto_IN.Substring(N, 1)
        '                    Select Case TEXTO.Length
        '                        Case 2, 5
        '                            TEXTO += "/"
        '                    End Select
        '                Next
        '                If TEXTO.Length > 10 Then TEXTO = TEXTO.Substring(0, 10)
        '            Case Funcoes.TipoFormato.Hora
        '                For N As Short = 0 To Texto_IN.Length - 1
        '                    TEXTO += Texto_IN.Substring(N, 1)
        '                    Select Case TEXTO.Length
        '                        Case 2
        '                            TEXTO += ":"
        '                    End Select
        '                Next
        '                If TEXTO.Length > 5 Then TEXTO = TEXTO.Substring(0, 5)
        '            Case Funcoes.TipoFormato.CPF, Funcoes.TipoFormato.CNPJ
        '                If Texto_IN.Length <= 11 Then
        '                    For N As Short = 0 To Texto_IN.Length - 1
        '                        TEXTO += Texto_IN.Substring(N, 1)
        '                        Select Case TEXTO.Length
        '                            Case 3, 7
        '                                TEXTO += "."
        '                            Case 11
        '                                TEXTO += "-"
        '                        End Select
        '                    Next
        '                    If TEXTO.Length > 14 Then TEXTO = TEXTO.Substring(0, 14)
        '                Else
        '                    For N As Short = 0 To Texto_IN.Length - 1
        '                        TEXTO += Texto_IN.Substring(N, 1)
        '                        Select Case TEXTO.Length
        '                            Case 2, 6, 7
        '                                TEXTO += "."
        '                            Case 10
        '                                TEXTO += "/"
        '                            Case 15
        '                                TEXTO += "-"
        '                        End Select
        '                    Next
        '                    If TEXTO.Length > 18 Then TEXTO = TEXTO.Substring(0, 18)
        '                End If
        '            Case Funcoes.TipoFormato.CEP
        '                For N As Short = 0 To Texto_IN.Length - 1
        '                    TEXTO += Texto_IN.Substring(N, 1)
        '                    Select Case TEXTO.Length
        '                        Case 5
        '                            TEXTO += "-"
        '                    End Select
        '                Next
        '                If TEXTO.Length > 9 Then TEXTO = TEXTO.Substring(0, 9)
        '            Case Funcoes.TipoFormato.Placa
        '                For N As Short = 0 To Texto_IN.Length - 1
        '                    TEXTO += Texto_IN.Substring(N, 1)
        '                    'If (TEXTO.Length <= 3 And IsNumeric(Texto_IN.Substring(N, 1))) Or (TEXTO.Length > 3 And Not IsNumeric(Texto_IN.Substring(N, 1))) Then
        '                    '    TEXTO = TEXTO.Substring(0, TEXTO.Length - 1)
        '                    'End If
        '                    Select Case TEXTO.Trim.Length
        '                        Case 3
        '                            TEXTO += "-"
        '                    End Select
        '                Next
        '                If TEXTO.Length > 8 Then TEXTO = TEXTO.Substring(0, 8)
        '            Case Funcoes.TipoFormato.Telefone
        '                TEXTO = LimpaFormatacao(Texto_IN)
        '                If Mid(TEXTO, 1, 1) <> "0" Then
        '                    TEXTO = Mid(TEXTO, 1, 13)
        '                    Select Case TEXTO.Length
        '                        Case 8
        '                            TEXTO = Mid(TEXTO, 1, 4) + "-" + Mid(TEXTO, 5, 4)
        '                        Case 9
        '                            TEXTO = Mid(TEXTO, 1, 5) + "-" + Mid(TEXTO, 6, 4)
        '                        Case 10
        '                            TEXTO = "(" + Mid(TEXTO, 1, 2) + ")" + Mid(TEXTO, 3, 4) + "-" + Mid(TEXTO, 7, 4)
        '                        Case 11
        '                            TEXTO = "(" + Mid(TEXTO, 1, 2) + ")" + Mid(TEXTO, 3, 5) + "-" + Mid(TEXTO, 8, 4)
        '                        Case 12
        '                            TEXTO = "(" + Mid(TEXTO, 1, 4) + ")" + Mid(TEXTO, 5, 4) + "-" + Mid(TEXTO, 9, 4)
        '                        Case 13
        '                            TEXTO = "(" + Mid(TEXTO, 1, 4) + ")" + Mid(TEXTO, 5, 5) + "-" + Mid(TEXTO, 10, 4)
        '                    End Select
        '                Else
        '                    TEXTO = Mid(TEXTO, 1, 14)
        '                    Select Case TEXTO.Length
        '                        Case 8
        '                            TEXTO = Mid(TEXTO, 1, 4) + "-" + Mid(TEXTO, 5, 4)
        '                        Case 9
        '                            TEXTO = Mid(TEXTO, 1, 5) + "-" + Mid(TEXTO, 6, 4)
        '                        Case 11
        '                            TEXTO = "(" + Mid(TEXTO, 1, 3) + ")" + Mid(TEXTO, 4, 4) + "-" + Mid(TEXTO, 8, 4)
        '                        Case 12
        '                            TEXTO = "(" + Mid(TEXTO, 1, 3) + ")" + Mid(TEXTO, 4, 5) + "-" + Mid(TEXTO, 9, 4)
        '                        Case 13
        '                            TEXTO = "(" + Mid(TEXTO, 1, 5) + ")" + Mid(TEXTO, 6, 4) + "-" + Mid(TEXTO, 10, 4)
        '                        Case 14
        '                            TEXTO = "(" + Mid(TEXTO, 1, 5) + ")" + Mid(TEXTO, 6, 5) + "-" + Mid(TEXTO, 11, 4)
        '                    End Select
        '                End If
        '                If TEXTO.Length > 18 Then TEXTO = Mid(TEXTO, 1, 18)
        '        End Select

        '        Return TEXTO
        '    End Function

        '    Public Function FormataCadastro(ByVal cadastro As String) As String

        '        cadastro = LimpaFormatacao(cadastro)

        '        If IsNumeric(cadastro) Then
        '            If cadastro.Length = 11 Then
        '                cadastro = Mid(cadastro, 1, 3) + "." + Mid(cadastro, 4, 3) + "." + Mid(cadastro, 7, 3) + "-" + Mid(cadastro, 10, 2)
        '            ElseIf cadastro.Length = 14 Then
        '                cadastro = Mid(cadastro, 1, 2) + "." + Mid(cadastro, 3, 3) + "." + Mid(cadastro, 6, 3) + "/" + Mid(cadastro, 9, 4) + "-" + Mid(cadastro, 13, 2)
        '            End If
        '        End If

        '        Return cadastro

        '    End Function

        '    Public Function Formatar(ByVal obj As Object, ByVal tipoFormato As TipoFormato, Optional ByVal tipo As String = "N", Optional ByVal keyValue As Integer = 0) As String
        '        ' ReSharper disable once RedundantAssignment
        '        Dim texto As String = ""

        '        Try
        '            If TypeOf obj Is TextBox Then
        '                If Not CType(obj, TextBox).Tag = Nothing Then
        '                    If CType(obj, TextBox).Tag.ToString.ToUpper = "RETORNO" Then
        '                        CType(obj, TextBox).SelectionStart = CType(obj, TextBox).Text.Length
        '                        CType(obj, TextBox).Tag = Nothing
        '                        Return obj.ToString
        '                    End If
        '                End If
        '                texto = FormataCampo(CType(obj, TextBox).Text.ToString, tipoFormato, tipo)
        '                CType(obj, TextBox).Text = texto
        '                CType(obj, TextBox).SelectionStart = Len(CType(obj, TextBox).Text)
        '            ElseIf TypeOf obj Is ToolStripTextBox Then
        '                texto = FormataCampo(CType(obj, ToolStripTextBox).Text.ToString, tipoFormato, tipo)
        '                CType(obj, ToolStripTextBox).Text = texto
        '                CType(obj, ToolStripTextBox).SelectionStart = Len(CType(obj, ToolStripTextBox).Text)
        '            ElseIf TypeOf obj Is ComboBox Then
        '                If CType(obj, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
        '                    texto = FormataCampo(CType(obj, ComboBox).Text.ToString, tipoFormato, tipo)
        '                    CType(obj, ComboBox).Text = texto
        '                    CType(obj, ComboBox).SelectionStart = Len(CType(obj, ComboBox).Text)
        '                End If
        '            Else
        '                texto = FormataCampo(obj.ToString, tipoFormato, tipo)
        '            End If

        '        Catch erro As Exception
        '            'Call ErroCritico(Err.Number, Err.Description, "Funcoes - Formatar")
        '            Return ""
        '        End Try

        '        Return texto
        '    End Function

        '    Public Enum TipoFormato
        '        Data = 1
        '        Hora = 2
        '        CPF = 3
        '        CNPJ = 4
        '        CEP = 5
        '        Placa = 6
        '        Telefone = 7
        '    End Enum

        '    Public Function FormataData(ByVal DATA As String) As String
        '        Try
        '            'If IsDate(DATA) Then Return DATA
        '            If Not DATA = Nothing Then
        '                If IsDate(DATA) Then
        '                    Return CDate(DATA).ToString("dd/MM/yyyy")
        '                End If
        '                If DATA.Length = 8 And DATA.Trim <> "" Then
        '                    DATA = DATA.Substring(6, 2) + "/" + DATA.Substring(4, 2) + "/" + DATA.Substring(0, 4)
        '                End If
        '                If DATA.Length = 6 And DATA.Trim <> "" Then
        '                    DATA = DATA.Substring(0, 2) + "/" + DATA.Substring(2, 2) + "/" + "20" + DATA.Substring(4, 2)
        '                End If
        '            Else
        '                DATA = ""
        '            End If
        '        Catch ERRO As Exception
        '            Throw
        '        End Try
        '        Return DATA
        '    End Function

        '    Public Function LimpaFormatacao(ByVal Texto As String) As String
        '        Texto = Replace(Texto, ".", "")
        '        Texto = Replace(Texto, ",", "")
        '        Texto = Replace(Texto, "/", "")
        '        Texto = Replace(Texto, "-", "")
        '        Texto = Replace(Texto, "(", "")
        '        Texto = Replace(Texto, ")", "")
        '        Texto = Replace(Texto, ":", "")

        '        Return IIf(Texto Is Nothing, "", Texto)
        '    End Function

        '    Public Function LimpaFormatacaoparaEspaco(ByVal Texto As String) As String
        '        Texto = Replace(Texto, ".", " ")
        '        Texto = Replace(Texto, ",", " ")
        '        Texto = Replace(Texto, "/", " ")
        '        Texto = Replace(Texto, "-", " ")
        '        Texto = Replace(Texto, "(", " ")
        '        Texto = Replace(Texto, ")", " ")
        '        Texto = Replace(Texto, ":", " ")

        '        Return IIf(Texto Is Nothing, "", Texto)
        '    End Function

        '    Public Function DesformataData(ByVal Data_IN As String) As String
        '        Dim RETORNO As String = ""
        '        Dim Data As Date

        '        If Data_IN Is Nothing Then Return ""

        '        If IsDate(Data_IN) Then
        '            Data = Data_IN
        '        Else
        '            If IsNumeric(Data_IN) And Data_IN.Length = 8 Then
        '                Return Data_IN
        '            Else
        '                Return ""
        '            End If
        '        End If

        '        Try
        '            RETORNO = Data.Year.ToString.PadLeft(4, "0")
        '            RETORNO += Data.Month.ToString.PadLeft(2, "0")
        '            RETORNO += Data.Day.ToString.PadLeft(2, "0")
        '        Catch ERRO As Exception
        '            Throw
        '        End Try
        '        Return RETORNO
        '    End Function

    End Class
End Namespace