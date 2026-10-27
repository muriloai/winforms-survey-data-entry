Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing

$exePath = (Resolve-Path "src\SurveyDataEntry\bin\Release\SurveyDataEntry.exe").Path
[System.Reflection.Assembly]::LoadFrom($exePath) | Out-Null
[SurveyDataEntry.ConexaoBD]::Silencioso = $true

$outputDir = (Resolve-Path "docs\screenshots").Path

function Get-Field($obj, $fieldName) {
    $field = $obj.GetType().GetField($fieldName, [System.Reflection.BindingFlags]"NonPublic,Instance,Public")
    return $field.GetValue($obj)
}

function Capture-Form($form, $fileName, $width, $height) {
    $form.StartPosition = [System.Windows.Forms.FormStartPosition]::Manual
    $form.Location = New-Object System.Drawing.Point(-4000, -4000)
    if ($width -and $height) {
        $form.Size = New-Object System.Drawing.Size($width, $height)
    }
    $form.Show()
    $form.Refresh()
    [System.Windows.Forms.Application]::DoEvents()
    Start-Sleep -Milliseconds 150

    $bmp = New-Object System.Drawing.Bitmap($form.Width, $form.Height)
    $rect = New-Object System.Drawing.Rectangle(0, 0, $form.Width, $form.Height)
    $form.DrawToBitmap($bmp, $rect)
    
    $fullPath = Join-Path $outputDir $fileName
    $bmp.Save($fullPath, [System.Drawing.Imaging.ImageFormat]::Png)
    $bmp.Dispose()
    $form.Close()
    $form.Dispose()
    Write-Host "Screenshot saved: $fileName ($($form.Width)x$($form.Height))"
}

# 1. Menu Principal (Modo Operador / Dashboard)
$fMenu = New-Object SurveyDataEntry.frm_menu
$fMenu.WindowState = [System.Windows.Forms.FormWindowState]::Normal
$pnlReg0 = Get-Field $fMenu "pnl_registro"
$pnlReg0.Visible = $false
Capture-Form $fMenu "01_menu_principal.png" 1120 720

# 2. Menu Principal (Modo Gestão / Painel Administrativo liberado)
$fMenuAdmin = New-Object SurveyDataEntry.frm_menu
$fMenuAdmin.WindowState = [System.Windows.Forms.FormWindowState]::Normal
$pnlReg1 = Get-Field $fMenuAdmin "pnl_registro"
$pnlReg1.Visible = $true
Capture-Form $fMenuAdmin "02_menu_gestao.png" 1120 720

# 3. Autenticação Administrativa
$fMenuRef = New-Object SurveyDataEntry.frm_menu
$fLogin = New-Object SurveyDataEntry.frm_acesso_restrito([SurveyDataEntry.frm_menu]$fMenuRef)
$txtLogin = Get-Field $fLogin "txt_login"
$txtSenha = Get-Field $fLogin "txt_senha"
$txtLogin.Text = "administrador"
$txtSenha.Text = "senha123"
Capture-Form $fLogin "03_autenticacao.png" 450 320
$fMenuRef.Dispose()

# 4. Seletor de Formulário / Registro
$fSeletor = New-Object SurveyDataEntry.frm_seletor(2, $null)
$cbx = Get-Field $fSeletor "cbx_resultado"
$cbx.DataSource = $null
$cbx.Items.Add("ID: 1 - Pesquisa de Clima Organizacional 2026 - Matriz") | Out-Null
$cbx.Items.Add("ID: 2 - Avaliação de Satisfação no Atendimento - Unidade Sul") | Out-Null
$cbx.Items.Add("ID: 3 - Pesquisa de Percepção de Marca e Produto - Nacional") | Out-Null
$cbx.SelectedIndex = 1
Capture-Form $fSeletor "04_seletor.png" 580 250

# 5. Cadastro de Cliente
$fCadCli = New-Object SurveyDataEntry.frm_cadastrar_cliente
$txtCli = Get-Field $fCadCli "txt_cliente_nome"
$txtCli.Text = "Acme Global Participações S.A."
Capture-Form $fCadCli "05_cadastro_cliente.png" 580 260

# 6. Cadastro de Posto de Coleta
$fCadPosto = New-Object SurveyDataEntry.frm_cadastrar_posto_coleta
$txtPosto = Get-Field $fCadPosto "txt_posto_nome"
$txtPosto.Text = "Unidade Central - Quiosque Shopping Morumbi"
Capture-Form $fCadPosto "06_cadastro_posto_coleta.png" 580 260

# 7. Cadastro de Formulário
$fCadForm = New-Object SurveyDataEntry.frm_cadastrar_formulario(1)
$lblCli = Get-Field $fCadForm "lbl_cliente_nome"
$txtForm = Get-Field $fCadForm "txt_formulario"
$dtpck = Get-Field $fCadForm "dtpck_entrega"
$lblCli.Text = "Acme Global Participações S.A."
$txtForm.Text = "Pesquisa de Satisfação e Eficiência no Atendimento ao Consumidor 2026"
$dtpck.Value = (Get-Date).AddDays(45)
Capture-Form $fCadForm "07_cadastro_formulario.png" 600 370

# 8. Cadastro de Pergunta
$fCadPerg = New-Object SurveyDataEntry.frm_cadastrar_perguntas(1)
$txtPerg = Get-Field $fCadPerg "txt_pergunta"
$txtPos = Get-Field $fCadPerg "txt_posicao"
$txtMax = Get-Field $fCadPerg "txt_maxPermitido"
$chkNulo = Get-Field $fCadPerg "chk_nulo"
$txtPerg.Text = "Como você avalia a agilidade, presteza e cortesia demonstradas pela equipe de atendimento durante sua visita?"
$txtPos.Text = "1"
$txtMax.Text = "1"
$chkNulo.Checked = $false
Capture-Form $fCadPerg "08_cadastro_pergunta.png" 680 380

# 9. Responder Pesquisa (Interface de Coleta)
$fResp = New-Object SurveyDataEntry.frm_responder_pesquisa(1, 1)
$fResp.WindowState = [System.Windows.Forms.FormWindowState]::Normal
$lblP = Get-Field $fResp "lbl_pergunta"
$lblM = Get-Field $fResp "lbl_maxPerm"
$pnlR = Get-Field $fResp "pnl_respostas"
$lblP.Text = "1. Qual o seu grau de satisfação com o atendimento prestado pela nossa equipe?"
$lblM.Text = "(Assinale uma única alternativa)"

# Adicionar alternativas de exemplo
$alt1 = New-Object SurveyDataEntry.resposta
$alt1.alterarComprimentoPainel(920)
$alt1.alterar_posicao_resposta(1)
$alt1.alterar_resposta("Totalmente Satisfeito - Superou amplamente as expectativas")
$alt1.alterar_tipoResposta(1)

$alt2 = New-Object SurveyDataEntry.resposta
$alt2.alterarComprimentoPainel(920)
$alt2.alterar_posicao_resposta(2)
$alt2.alterar_resposta("Satisfeito - Atendeu plenamente ao solicitado com eficiência")
$alt2.alterar_tipoResposta(1)
$alt2.selecionarEsteComponente()

$alt3 = New-Object SurveyDataEntry.resposta
$alt3.alterarComprimentoPainel(920)
$alt3.alterar_posicao_resposta(3)
$alt3.alterar_resposta("Neutro / Regular - Atendeu com ressalvas ou atraso")
$alt3.alterar_tipoResposta(1)

$alt4 = New-Object SurveyDataEntry.resposta
$alt4.alterarComprimentoPainel(920)
$alt4.alterar_posicao_resposta(4)
$alt4.alterar_resposta("Outro / Comentário específico")
$alt4.alterar_tipoResposta(2)
$alt4.escrever_textoDigitadoNaResposta("Atendimento atencioso, porém o tempo de fila poderia ser menor.")

$pnlR.Controls.Add($alt1)
$pnlR.Controls.Add($alt2)
$pnlR.Controls.Add($alt3)
$pnlR.Controls.Add($alt4)

$qtd = -1
foreach ($i in $pnlR.Controls) {
    $qtd++
    $i.SetBounds($i.Location.X, ($i.Location.Y + $i.Size.Height + 8) * $qtd, $i.Width, $i.Height, [System.Windows.Forms.BoundsSpecified]::All)
}

Capture-Form $fResp "09_responder_pesquisa.png" 1080 700

# 10. Conclusão da Pesquisa
$fRespRef = New-Object SurveyDataEntry.frm_responder_pesquisa(1, 1)
$fFinal = New-Object SurveyDataEntry.tela_final($fRespRef)
$fFinal.WindowState = [System.Windows.Forms.FormWindowState]::Normal
$lblTit = Get-Field $fFinal "lbl_titulo"
$lblTit.Text = "Questionário Concluído com Sucesso!"
$btnDeNovo = Get-Field $fFinal "btn_deNovoPesquisa"
$btnVoltar = Get-Field $fFinal "btn_voltar"
$btnDeNovo.Text = "&Responder Mais Uma Pesquisa"
$btnVoltar.Visible = $true
Capture-Form $fFinal "10_conclusao_pesquisa.png" 1120 680
$fRespRef.Dispose()

Write-Host "ALL_CAPTURES_COMPLETED_SUCCESSFULLY"
