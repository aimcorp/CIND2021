Imports System.Windows.Forms

Public Class ErrMsgDialog
Private Sub ErrMsgDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'reset command buttons
If Rsolution = True Then ReSize1.Enabled = True
Me.TopMost = True
bt1.Visible = False : bt2.Visible = False
bt3.Visible = False : bt4.Visible = False : bt5.Visible = False
bt0.Text = "OK"
Select Case MsgId
  Case "ErroconFile" : Call ErroconFile()
  Case "PauseNow" : Call PauseNow()
  Case "EscEnviado" : Call EscEnviado()
  Case "EsUnDemo" : Call EsUnDemo()
  Case "NoCerrarPla" : Call NoCerrarPla()
  Case "GenAutoUpdateBad" : Call GenAutoUpdateBad()
  Case "ArchivoAbierto" : Call GenArchivoAbierto()
  Case "ArchivoPlanillPerdido" : Call GenArchivoPlanillaPerdido()
  Case "GenArchivoPaisPerdido" : Call GenArchivoPaisPerdido()
  Case "GenArchivoZipPerdido" : Call GenArchivoZipPerdido()
  Case "EstaSeguroDeSalir" : Call EstaSeguroDeSalir()
  Case "GenDebeEntrarElNombreFolder" : Call GenDebeEntrarElNombreFolder()
  Case "GenDebeCrearFolderPrimero" : Call GenDebeCrearFolderPrimero()
  Case "ZipFaltaArchivoForma" : Call ZipFaltaArchivoForma()
  Case "EstaSeguroDeSalirFolder" : Call EstaSeguroDeSalirFolder()
  Case "AnejoNegFileCtasRestored" : Call AnejoNegFileCtasRestored()
  Case "ImpDatosEsp" : Call ImpDatosEsp()
  Case "DatosEspReq" : Call DatosEspReq()
  Case "TraerSioNo" : Call TraerSioNo()
  Case "CSIPag1Email" : Call CSIPag1Email()
  Case "BorrarSE" : Call BorrarSE()
  Case "PlaNoList" : Call PlaNoList()
  Case "NuevaORepetida" : Call NuevaORepetida()
  Case "NuevaPla" : Call NuevaPla()
  Case "AbrirCtaAtrasada" : Call AbrirCtaAtrasada()
  Case "SalvarConOtroNombre" : Call SalvarConOtroNombre()
  Case "SalvarConOtroNombre2" : Call SalvarConOtroNombre2()
  Case "NuevoAño" : Call NuevoAno()
  Case "YaExistePlanCreada" : Call YaExistePlanCreada()
  Case "VerifyEmail" : Call VerifyEmail()
  Case "FaltaInfEnviarEscenario" : Call FaltaInfEnviarEscenario()
  Case "NumSegSocMal" : Call NumSegSocMal()
  Case "MsgCuestLinea1" : Call MsgCuestLinea1()
  Case "SalirSinSalvar" : Call SalirSinSalvar()
  Case "ShowImpMasFacil" : Call ShowImpMasFacil()
   Case "NoPipeBuscarEnlace" : Call NoPipeBuscarEnlace()
   Case "MsgNoImpBB" : Call MsgNoImpBB()
  'temp 'veriaim
   Case "NoReadyAnejoD" : Call NoReadyAnejoD()

          'update
  Case "UpdateMsg" : Call UpdateMsg()
  Case "GenAutoUpdateBad" : Call GenAutoUpdateBad()
  Case "GeAutoUpdateCancel" : Call GeAutoUpdateCancel()
  Case "GeAutoUpdateMasRec" : Call GeAutoUpdateMasRec()
  Case "GenAutoErrDownLoad" : Call GenAutoErrDownLoad()
          'Print
  Case "PrinterError" : Call PrinterError()
  Case "PrintFileNotInDLL" : Call PrintFileNotInDLL()
  Case "PrinterReaderError" : Call PrinterReaderError()
  Case "PrinterReqEscPdfFolder" : Call PrinterReqEscPdfFolder()
          'IncentivosPagina1
  Case "Pag1Email" : Call Pag1Email()
  Case "EstaSeguroBorrarDatos" : Call EstaSeguroBorrarDatos()
  Case "AnejoNegFileCtasSave" : Call AnejoNegFileCtasSave()
  Case "ctasIncentivos" : Call ctasIncentivos()
  Case "ErrorNoFileNecesarioAlt" : Call ErrorNoFileNecesarioAlt()
  Case "ErrorNoFileNecesarioAlt2" : Call ErrorNoFileNecesarioAlt2()
  Case "OnClosingForm" : Call OnClosingForm()
  Case "GenMsg" : Call GenMsg()
  Case "EstaSeguroBorrarDatosAccionistas" : Call EstaSeguroBorrarDatosAccionistas()
  Case "AccionistasFull" : Call AccionistasFull()
  Case "ErrorDataExis" : Call ErrorDataExis()
  Case "NollenarOExenta" : Call NollenarOExenta()
  Case "AportacionMunLimit" : Call AportacionMunLimit()
  Case "BorrarTodosOCantidades" : Call BorrarTodosOCantidades()
  Case "AportacionMunBorrarTodos" : Call AportacionMunBorrarTodos()
  Case "AportacionMunBorrar" : Call AportacionMunBorrar()
  Case "ErrNoDatosReusables" : Call ErrNoDatosReusables()
  Case "ErrorEstSituacionNoPrint" : Call ErrorEstSituacionNoPrint()
  Case "ErrorEstSituacionMove" : Call ErrorEstSituacionMove()
  Case "ErrorEstSituacion" : Call ErrorEstSituacion()
  Case "ErrorEstSituacionMej" : Call ErrorEstSituacionMej()
  Case "ErrorEstSituacionFianzas" : Call ErrorEstSituacionFianzas()
  Case "ErrorEstSituacionProv" : Call ErrorEstSituacionProv()
  Case "ErrorEstSituacionCtasPagOtras" : Call ErrorEstSituacionCtasPagOtras()
  Case "ErrorEstSituacionCtasActOtros" : Call ErrorEstSituacionCtasActOtros()
  Case "EstSegLimp" : Call EstSegLimp()
  Case "GenArchivoCorrupto" : Call GenArchivoCorrupto()
  Case "ErrorExistFile" : Call ErrorExistFile()
  Case "ErrSaveOtroNombre" : Call ErrSaveOtroNombre()
  Case "ErrMayor25" : Call ErrMayor25()
  Case "CambiarDesarrollo" : Call CambiarDesarrollo()
  Case "CambiarTurismo" : Call CambiarTurismo()
  Case "CambiarCine" : Call CambiarCine()
  Case "CambiarEnerg" : Call CambiarEnerg()
  Case "CambiarOtras" : Call CambiarOtras()
  Case "SegBorrarPlan" : Call SegBorrarPlan()
  Case "SC6042Lineas" : Call SC6042Lineas()
      'caudal relicto
  Case "BorrarProp" : Call BorrarProp()
      'donativos
  Case "SeguroCambiarDonativos" : Call SeguroCambiarDonativos()
        'Security 
  Case "RegOportunidades" : Call RegOportunidades()
  Case "RegNoLib" : Call RegNoLib()
  Case "YaActivado" : Call YaActivado()
  Case "LicPWIncorrecto" : Call LicPWIncorrecto()
  Case "OtrosProb" : Call OtrosProb()
  Case "FaltaInfo" : Call FaltaInfo()
  Case "EmailWrong" : Call EmailWrong()
  Case "EmailSendErr" : Call EmailSendErr()
  Case "RegNotByInt" : Call RegNotByInt()
  Case "DeactivateError" : Call DeactivateError()
   Case "ErrImpresora" : Call ErrImpresora()
    'Entidad Conducto
   Case "NoIgualComp" : Call NoIgualComp()
   Case "msgErrorBasMayorRegular" : Call msgErrorBasMayorRegular()
   Case "msgErrorBasMayorRegularPag2" : Call msgErrorBasMayorRegularPag2()
   Case "msgErrorBasMayorRegularPag3" : Call msgErrorBasMayorRegularPag3()
  End Select
'show msg
Me.Tag = Answer
Lb1.Text = msg
Answer = Me.Tag
End Sub

Private Sub pb0_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt0.MouseClick, bt0.Click
Answer = 0
Me.Close()
End Sub

Private Sub pb1_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt1.MouseClick, bt1.Click
Answer = 1
Me.Close()
End Sub

Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt2.MouseClick, bt2.Click
Answer = 2
Me.Close()
End Sub

Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt3.MouseClick
Answer = 3
Me.Close()
End Sub

Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt4.MouseClick
Answer = 4
Me.Close()
End Sub

Private Sub pb5_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt5.MouseClick
Answer = 5
Me.Close()
End Sub

Private Sub GenDebeEntrarElNombreFolder()
msg = "Primero debe entrar el nuevo nombre arriba" & vbCr
msg = msg & "para poder crearlo en el folder que escoja"
End Sub

Private Sub GenDebeCrearFolderPrimero()
msg = "Primero debe escoger el Folder para" & vbCr
msg = msg & "los PDF arriba, luego continúe aquí"
End Sub

Private Sub ZipFaltaArchivoForma()
msg = "Falta un Archivo en el sistema para poder" & vbCr
msg = msg & "imprimir la planilla deseada, reinstale el" & vbCr
msg = msg & "o solicite a Aim el siguiente Archivo:" & vbCr & vbCr
msg = msg & c
End Sub

Private Sub EstaSeguroDeSalirFolder()
msg = "¿Está Seguro de salir sin crear un" & vbCr & _
						"folder o escoger uno previo creado?"
bt0.Text = "Salir" : bt1.Text = "No Salir"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub AnejoNegFileCtasSave()
msg = "Archivo de Cuentas fue Salvado"
End Sub

Private Sub AnejoNegFileCtasRestored()
msg = "Archivo de Cuentas Restaurado"
End Sub

Private Sub PrintFileNotInDLL()
msg = "El archivo para imprimir no existe en el folder debe reinsta-" & vbCr
msg = msg & "lar o solicitarlo enviando un email a aimcorp@aimsite.com"
End Sub

Private Sub PrinterError()
msg = "Aparentemente hay un problema con su impresora" & vbCr
msg = msg & "sugerimos escoger otra o instalar una nueva"
End Sub

Private Sub PrinterReaderError()
msg = "Aparentemente el Acrobat Reader no está" & vbCr
msg = msg & "instalado en esta computadora, debe"
msg = msg & "instalar o imprimir a la impresora"
End Sub

Private Sub PrinterReqEscPdfFolder()
msg = "Primero debe crear el folder para" & vbCr
msg = msg & "salvar los archivos a PDF, hágalo" & vbCr
msg = msg & "en la siguiente pantalla"
End Sub

Private Sub GenAutoUpdateBad()
						msg = "Aparentemente hay algún problema en el servidor en el Internet;" & vbCr
msg = msg & "trate más tarde o envíe un email a aimcorp@aimcorporation.net"
End Sub

Private Sub GeAutoUpdateCancel()
						msg = "Download Cancelado, el sistema no está al día," & vbCr
msg = msg & "esto puede generar problemas con sus planillas"
End Sub

Private Sub GeAutoUpdateMasRec()
						msg = "No hay nada nuevo en el Internet, usted" & vbCr
msg = msg & "tiene la revisión más reciente, Felicidades"
End Sub

Private Sub GenAutoErrDownLoad()
						msg = "Un error ocurrió mientras se intentaba bajar el update" & vbCr
msg = msg & "Las posibles causas son:" & vbCr & vbCr
msg = msg & "1) El Archivo de Update no existe en el Server" & vbCr
msg = msg & "2) Problemas con la conexión al Internet"
End Sub

Private Sub EstSegLimp()
msg = "¿Está seguro de Limpiar toda la pantalla?"
bt0.Text = "No" : bt1.Text = "Si"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ErrorExistFile()
						msg = "Ya existe el archivo " & vbCr & vbCr
msg = msg & c & vbCr & vbCr
msg = msg & "¿Desea salvarlo sustituyéndolo?" & vbCr & vbCr
msg = msg & "Si escoge No, el sistema no abre ningún archivo"
bt0.Text = "No" : bt1.Text = "Si"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ErrSaveOtroNombre()
						msg = "Usted cambió el año de esta planilla. La Data se" & vbCr
msg = msg & "va a retener en esta planilla y en la nueva que" & vbCr
msg = msg & "se cree con la nueva extensión del año escogido" & vbCr & vbCr
msg = msg & "En la próxima pantalla escoja el folder al" & vbCr
msg = msg & "cual salvar la planilla y el nombre con" & vbCr
msg = msg & "el que desea identificar esta nueva" & vbCr
msg = msg & "planilla o puede cancelar la operación"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ErrMayor25()
msg = "El máximo a reclamar es $25 mil"
End Sub

Private Sub CambiarDesarrollo()
      msg = "¿Desea cambiar a Desarrollo Industrial?" & vbCr & vbCr
msg = msg & "Si lo hace, toda la data entrada en los" & vbCr
msg = msg & "Anejos L, Y, Y1, W, Z será borrada"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub CambiarTurismo()
      msg = "¿Desea cambiar a Turismo?" & vbCr & vbCr
msg = msg & "Si lo hace, toda la data entrada en los" & vbCr
msg = msg & "Anejos N, V, X, N1, V1, X1, Y, Y1, W" & vbCr
msg = msg & "será borrada"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub CambiarCine()
      msg = "¿Desea cambiar a Cine?" & vbCr & vbCr
msg = msg & "Si lo hace, toda la data entrada en los" & vbCr
msg = msg & "Anejos N, V, X, N1, V1, X1, L, Z" & vbCr
msg = msg & "será borrada"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub CambiarEnerg()
     msg = "¿Desea cambiar a Energía Verde?" & vbCr & vbCr
msg = msg & "Si lo hace, toda la data entrada en los" & vbCr
msg = msg & "Anejos N, V, X, N1, V1, X1, L, W, Z" & vbCr
msg = msg & "será borrada"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub CambiarOtras()
     msg = "¿Desea cambiar a Otras Leyes?" & vbCr & vbCr
msg = msg & "Si lo hace, toda la data entrada en los" & vbCr
msg = msg & "Anejos N, V, X, N1, V1, X1, L, W, Y, Y1, Z" & vbCr
msg = msg & "será borrada"
bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub SegBorrarPlan()
msg = "¿Está seguro de borrar este plan?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub SC6042Lineas()
						msg = "Si en uno o más formularios SC 6042 hay cantidad" & vbCr
msg = msg & "en la líneas 6, 11, 32 ó 38 no puede radicar de" & vbCr
msg = msg & "manera eletrónica"
End Sub

Private Sub GenArchivoCorrupto()
msg = "El archivo que está utilizando está dañado"
End Sub

Private Sub ErrorEstSituacionNoPrint()
msg = "Imprima este Estado de Situación desde la " & _
      "planilla en la cual desea utilizar el " & _
      "Estado de Situación; Ej. Informe corp"
End Sub

Private Sub ErrorEstSituacionMej()
msg = "¡Esta partida va en Otros activos misceláneos " & _
      "en el Estado de Situación de otras planillas; ya que " & _
      "esta cuenta no existe en ese estado!"
End Sub

Private Sub ErrorEstSituacionFianzas()
msg = "¡Esta partida va en Otros Gastos Prepagados y diferidos " & _
  "en el Estado de Situación de Prop Mueble; ya que no esta " & _
  "cuenta no existe en ese estado!"
End Sub

Private Sub ErrorEstSituacionProv()
msg = "¡Esta partida va en Concesiones y otros créditos diferidos " & _
  "en el Estado de Situación de otras planillas; ya que esta " & _
  "cuenta no existe en ese estado!"
End Sub

Private Sub ErrorEstSituacionCtasPagOtras()
msg = "¡Esta partida va en Intereses (Gastos Acumulados por Pagar) " & _
      "en el Estado de Situación de Incentivos; ya que esta " & _
      "cuenta no existe en ese estado!"
End Sub

Private Sub ErrorEstSituacionCtasActOtros()
msg = "¡Esta partida va en Embarcaciones en el Estado " & _
      "de Situación de Incentivos; ya que esta " & _
      "cuenta no existe en ese estado!"
End Sub

Private Sub ErrNoDatosReusables()
msg = "No hay datos entrados en la pantalla de Datos Reusables." & vbCr & vbCr
msg = msg & "¿Desea entrarlos?"
bt0.Text = "No" : bt1.Text = "Si"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub AportacionMunBorrar()
msg = "¿Está seguro de borrar este municipio?"
bt0.Text = "No" : bt1.Text = "Si"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub AportacionMunBorrarTodos()
msg = "¿Está seguro de borrar todos los municipios?"
bt0.Text = "No" : bt1.Text = "Si"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub BorrarTodosOCantidades()
msg = "Borrar todos los datos de la pantalla" & vbCr & _
      "o borrar sólo las cantidades"
bt0.Text = "Cancelar" : bt1.Text = "Cantidades" : bt2.Text = "Todos"
bt0.Visible = True : bt1.Visible = True : bt2.Visible = True
End Sub

Private Sub AportacionMunLimit()
msg = "Ya existen seis municipios en este cliente, debe borrar alguno " & vbCr & _
"o crear otra nueva planilla. "
End Sub

Private Sub NollenarOExenta()
msg = "Usted marcó que no ha solicitado exención por lo cual " & vbCr & _
"esta planilla no debe ser cumplimentada; someta la" & vbCr & _
"planilla de Corporaciones 480.2"
End Sub

Private Sub ErrorDataExis()
msg = "Ya los Datos de Generales de esta pantalla están llenos, " & vbCr & _
						"si transfiere de la pantalla de Datos Generales, " & vbCr & _
						"quizás algunos de estos sean diferentes."
bt0.Text = "Cancelar" : bt1.Text = "Aceptar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub AccionistasFull()
msg = "Lo Sentimos pero no hay espacio para otro Accionista! " & vbCr & vbCr & _
"Debe borrar alguno que ya no utilice."
End Sub

Private Sub EstaSeguroBorrarDatosAccionistas()
msg = "¿Está seguro(a) de borrar todos los Accionistas de " & vbCr & _
"esta pantalla para comenzar nuevamente? "
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub GenMsg()
msg = "La cantidad no puede ser mas de $500 dólares"
End Sub

Private Sub OnClosingForm()
msg = "jEl Archivo en Uso ha sido modificado !" & _
     "¿Desea Salvaro ?"
bt0.Text = "Cancelar" : bt1.Text = "No Salvar" : bt2.Text = "Salvar"
bt0.Visible = True : bt1.Visible = True : bt2.Visible = True
End Sub

Private Sub ErrorNoFileNecesarioAlt()
msg = "¡El archivo >> aCpoCodigoInd.cpro" & vbCr & vbCr & _
"Es necesario para esta operación y no se encontró!" & vbCr & vbCr & _
"Reinstale el programa o envíe un email a Aim Corp " & vbCr & _
"e indique que le falta este archivo para instrucciones"
End Sub

Private Sub ErrorNoFileNecesarioAlt2()
msg = "¡El archivo >> aCtasIncentivos.cpro" & vbCr & vbCr & _
"Es necesario para esta operación y no se encontró!" & vbCr & vbCr & _
"Reinstale el programa o envíe un email a Aim Corp " & vbCr & _
"e indique que le falta este archivo para instrucciones"
End Sub

Private Sub ErrorEstSituacionMove()
msg = "Esta opción mueve los datos existentes en la columna del Final " & _
      "del año a la columna del Principio de año, ¿Continuar?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ErrorEstSituacion()
msg = "Esta Opción borra los datos existentes en el Estado de Situacion de esta planilla " & _
      "y trae los entrados en el Estado de Situacion General, ¿Continuar?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ctasIncentivos()
msg = "El archivo >> " & UCase(AreaErr$) & vbCr & vbCr & _
"Es necesario para esta operación y no se encontró . . ." & vbCr & vbCr & _
"Reinstale el programa o busque dicho archivo " & _
"en algún Backup que tenga disponible. El mismo debe ir en el " & _
"directorio " & vbCr & vbCr '& ErrDesc$
Answer = 0
End Sub

Private Sub GenArchivoAbierto()
msg = "El Archivo del cliente previamente utilizado o " & vbCr & _
"el archivo que desea abrir ésta abierto por otro " & vbCr & _
"proceso; tendría que cerrarlo primero"
End Sub

Private Sub GenArchivoPlanillaPerdido()
msg = "El Archivo del cliente deseado no se encuentra en" & vbCr & _
"el fólder escogido, quizas ésta en otro folder"
End Sub

Private Sub GenArchivoPaisPerdido()
msg = "Se intentó abrir el archivo de Paises y" & vbCr & _
"éste no fue encontrado. Solicite el mismo" & vbCr & _
"a AIM o instale el programa nuevamente"
End Sub

Private Sub GenArchivoZipPerdido()
msg = "Se intentó abrir el archivo del Códigos Postales" & vbCr & _
"y éste no fue encontrado. Solicite el mismo" & vbCr & _
"a AIM o instale el programa nuevamente"
End Sub

Private Sub Pag1Email()
msg = "Corrija la direccion de Email, debe ser una dirección válida" & vbCr & _
"y debe tener '@' y la palabra: .com .net .org, u otra" & vbCr & _
"extensión válida"
End Sub

Private Sub EstaSeguroDeSalir()
msg = "¿Está Seguro de salir sin " & vbCr & _
"crear ni abrir una planilla?"
bt0.Text = "Salir" : bt1.Text = "No Salir"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub W2PensionesLlegoMaximo()
msg = "El máximo de pensiones que puede crear es cuatro" & vbCr
msg = msg & "lamenteblemente no puede crear ninguna más"
End Sub

Private Sub W2NecesitaFechaPension()
msg = "Marcó Ingreso de Pensión así que debe" & vbCr
msg = msg & "entrar la fecha del comienzo de ésta"
End Sub

Private Sub W2RetencionMayorQueTotal()
msg = "Corrija las retenciones, la suma no puede ser igual" & vbCr
msg = msg & "o mayor que el total de salarios, comisiones, etc."
End Sub

Private Sub W2NecesitaNombrePatrono()
msg = "Si entra una cantidad tiene que entrar" & vbCr
msg = msg & "el nombre del patrono"
End Sub

Private Sub W2NecesitaNControl()
msg = "Se intentó salvar la data de esta W2 pero el número de" & vbCr
msg = msg & "control está incompleto. Éntrelo para poder Salvar" & vbCr
msg = msg & "o presione el botón para limpiar esta W2s" & vbCr
End Sub

Private Sub W2NecesitaNPatronal()
msg = "Se intentó salvar la data de esta W2 pero el número" & vbCr
msg = msg & "Patronal está incompleto. Éntrelo para poder Salvar" & vbCr
msg = msg & "o presione el botón para limpiar esta W2s" & vbCr
End Sub

Private Sub W2NecesitaDirPat()
msg = "Si entra una cantidad tiene que entrar" & vbCr
msg = msg & "la dirección completa del patrono"
End Sub

Private Sub W2DeseaSalvar()
msg = "¿Desea salvar lo cambios que hizo a esta W2s"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub W2SeguroDeEliminarW2()
msg = "¿Está seguro de eliminar esta W2s?" & vbCr & vbCr
msg = msg & "Si lo hace no se puede recuperar la información"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub W2TieneNomPatrNecCantidades()
msg = "Si entra un Nombre de Patrono y un Número de" & vbCr
msg = msg & "Control Necesita entrar cantidades abajo"
End Sub

''''''''''''''''''''''''''''''''''''''''''''' ANEJO A ''''''''''''''''''''''''''''''''''''''
Private Sub AnejoAVeteranoMax1500()
msg = "La cantidad máxima a deducir como veterano es $1500"
End Sub

Private Sub AnejoACuidoHijosEstCiv1()
msg = "La cantidad tiene que ser $1,500 por un hijo" & vbCr
msg = msg & "o un máximo de $3,000 por dos hijos o más"
End Sub

Private Sub AnejoACuidoHijosEstCiv5()
msg = "La cantidad tiene que ser $700 por un hijo" & vbCr
msg = msg & "o un máximo de $1,500 por dos hijos o más"
End Sub

Private Sub AnejoAPersonaEdadAvan600()
msg = "La cantidad tiene que ser cero o hasta un máximo de $600"
End Sub

Public Sub AnejoAPersonaEdadAvan1200()
msg = "La cantidad tiene que ser cero o hasta un máximo de $1,200"
End Sub

Public Sub AnejoAAlquilerPagEstCiv1a4()
msg = "La cantidad no puede ser mayor de $500 dólares"
End Sub

Public Sub AnejoAAlquilerPagEstCiv5()
msg = "La cantidad no puede ser mayor de $250 dólares"
End Sub

Public Sub AnejoAAlquilerPagReqSS()
msg = "Para entrar una cantidad aquí tiene que entrar" & vbCr
msg = msg & "el número de Seguro Social del Arrendador"
End Sub

Public Sub AnejoAPerdidasBienesMuebleEstCiv1()
msg = "La cantidad no puede ser mayor de $5,000 dólares"
End Sub

Public Sub AnejoAPerdidasBienesMuebleEstCivOtro()
msg = "La cantidad no puede ser mayor de $2,500 dólares"
End Sub

Public Sub AnejoAMolinoDeVientoEstCiv1()
msg = "La cantidad no puede ser mayor de $3,000 dólares"
End Sub

Public Sub AnejoAMolinoDeVientoEstCivOtro()
msg = "La cantidad no puede ser mayor de $1,500 dólares"
End Sub

Public Sub AnejoAEqOrtoEstCiv1()
msg = "La cantidad no puede ser mayor de $2,500 dólares"
End Sub

Public Sub AnejoAEqOrtoEstCivOtro()
msg = "La cantidad no puede ser mayor de $1,250 dólares"
End Sub

Public Sub AnejoAEducDepEstCiv1a4()
msg = "La cantidad tiene que ser cero o hasta un" & vbCr
msg = msg & "máximo de $3,000 para dos dependientes o más"
End Sub

Public Sub AnejoAEducDepEstCiv5()
msg = "La cantidad tiene que ser cero o hasta un" & vbCr
msg = msg & "máximo de $1,500 para su estatus civil"
End Sub

Public Sub AnejoAEqSolarEstCiv1a4()
msg = "La cantidad no puede ser mayor de $1,500 dólares"
End Sub

Public Sub AnejoAEqSolarEstCiv5()
msg = "La cantidad no puede ser mayor de $750 dólares"
End Sub

Public Sub AnejoAEnfCatastroficas()
msg = "La cantidad no puede ser mayor de $100 dólares"
End Sub

Public Sub AnejoACkReqParaEqTecnologico()
msg = "Esta partida requiere que esoja primero aquí" & vbCr
msg = msg & "al lado a quién pertence el gasto"
End Sub

Public Sub AnejoACkCancelarEqTecnologico()
msg = "Para eliminar esta marca tiene que eliminar" & vbCr
msg = msg & "primero la cantidad al lado izquierdo o marcar" & vbCr
msg = msg & "otra de las opciones y luego eliminar la desada" & vbCr
End Sub

Public Sub AnejoAIrasMaximo()
msg = "El máximo a reclamar por concepto de IRA es $5000" & vbCr
msg = msg & "por el Contribuyente y $5000 por el cónyuge, pero" & vbCr
msg = msg & "entre ambos (cuando aplica) no puede ser mayor de" & vbCr
msg = msg & "$10,000 ni mayor que el Ingreso Bruto Ajustado"
End Sub

Public Sub AnejoAIntAuto()
msg = "Puede tomar hasta un máximo de $1,200 para esta" & vbCr
msg = msg & "deducción. Puede dividir con el conyuge en partes" & vbCr
msg = msg & "iguales, es decir hasta $600 por cada uno"
End Sub

Public Sub AnejoAIntComp()
msg = "Puede tomar hasta un máximo de $500 para esta" & vbCr
msg = msg & "deducción. Puede dividir con el conyuge en partes" & vbCr
msg = msg & "iguales, es decir hasta $250 por cada uno"
End Sub

''''''''''''''''''''''''''''''''''''''''''''' ANEJO A1 ''''''''''''''''''''''''''''''''''''''
Public Sub AnejoA1NoAplicaParentezcoPorEdad()
msg = "Ese parentezco no se acepta si la fecha de " & vbCr
msg = msg & "nacimiento es menor de 30 años de diferencia"
End Sub

Public Sub AnejoA1DepNoPuedeserNoUni()
msg = "Este dependiente tiene más de 20 años; no" & vbCr
msg = msg & "puede reclamarse como No Universitario"
End Sub

Public Sub AnejoA1DepNoPuedeSerUniverCon26()
msg = "Este dependiente tiene más de 25 años; no" & vbCr
msg = msg & "puede reclamarse como Universitario"
End Sub

Public Sub AnejoA1DepNoPuedeSerUniverCon11()
msg = "Este dependiente tiene menos de 11 años; no" & vbCr
msg = msg & "puede reclamarse como Universitario"
End Sub

Private Sub AnejoA1DepNoPuedeserMenor65()
msg = "Este dependiente tiene menos de 65 años;" & vbCr
msg = msg & "no puede reclamarse de esta manera"
End Sub

Private Sub AnejoA1CantMayor500()
msg = "La cantidad aportada no" & vbCr
msg = msg & "puede ser mayor de $500"
End Sub

Private Sub AnejoA1FunEducativa()
msg = "La cantidad aportada no" & vbCr
msg = msg & "puede ser mayor de $250"
End Sub

Private Sub AnejoA1CertMembresia()
msg = "La cantidad aportada no puede" & vbCr
msg = msg & "ser mayor de $1000"
End Sub

Private Sub AnejoA1AutoImpEnergia()
msg = "La cantidad aportada no puede" & vbCr
msg = msg & "ser mayor de $2000"
End Sub

Private Sub F480SeguroDeEliminar()
msg = "¿Está seguro de eliminar esta 480.6x" & vbCr & vbCr
msg = msg & "Si lo hace no se puede recuperar la información"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub F480NecesitaNControl()
msg = "Se intentó salvar la data de esta 480.6x pero el número" & vbCr
msg = msg & "de control está incompleto. Éntrelo para poder Salvar" & vbCr
msg = msg & "o presione el botón para limpiar esta 480.6x" & vbCr
End Sub

Private Sub F480NecesitaNPatronal()
msg = "Se intentó salvar la data de esta 480.6x pero el número" & vbCr
msg = msg & "Patronal está incompleto. Éntrelo para poder Salvar" & vbCr
msg = msg & "o presione el botón para limpiar esta 480.6x" & vbCr
End Sub

Private Sub F480DeseaSalvar()
msg = "¿Desea salvar lo cambios que hizo a esta 480.6"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub EstaSeguroBorrarDatos()
msg = "¿Está seguro(a) de borrar todos los datos de" & vbCr & _
       "esta planilla para comenzar nuevamente?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub UpdateMsg()
      msg = "Un nueva Revisión (update) está disponible para ser" & vbCr
msg = msg & "bajada de nuestro website y luego aplicada"
bt0.Text = "Ahora No" : bt1.Text = "Bajarla"
bt0.Visible = True : bt1.Visible = True
End Sub

Sub NoCerrarPla()
      msg = "En esta versión no es necesario cerrar la" & vbCr
msg = msg & "planilla en uso, simplemente abra otra " & vbCr
msg = msg & "planilla o cree una nueva planilla"
End Sub

Private Sub ErroconFile()
      msg = "¡Hubo un problema al abrir el archivo deseado!" & vbCr & vbCr
msg = msg & "Para evitar que se dañe, el programa va a cerrar" & vbCr & vbCr
msg = msg & "Abralo nuevamente y escoja dicha planilla; la" & vbCr
msg = msg & "misma debe estar bien pues no se ha manipulado"
End Sub

Sub PauseNow()
      msg = "Este es el error: " & Err.Number & vbCr & vbCr
msg = msg & "Descripcion es: " & Err.Description
End Sub

Private Sub EscEnviado()
      msg = "Escenario Enviado" & vbCr & vbCr
msg = msg & "Gracias "
End Sub

Sub EsUnDemo()
						msg = "Estimado usuario, para utilizar este programa para la" & vbCr
msg = msg & "preparación de la forma que está cumplimentando, usted" & vbCr
msg = msg & "debe registrar este programa ordenando una versión" & vbCr
msg = msg & "autorizada. Por favor visite nuestra página de internet" & vbCr
msg = msg & "si desea ordenar una versión completa.  Gracias" & vbCr & vbCr
msg = msg & "¿Desea visitar nuestra página ahora?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub BorrarProp()
msg = "¿Está seguro(a) de borrar esta propiedad? "
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub SeguroCambiarDonativos()
msg = "¿Está seguro de cambiar y borrar lo entrado? "
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub ImpDatosEsp()
msg = "Debe completar los datos requeridos marcados con " & vbCr
msg = msg & "asterisco rojos en la pantalla para entrar los " & vbCr
msg = msg & "datos del especialista para utilizar esta opción." & vbCr & vbCr
msg = msg & "También debe marcar en Preferencias, la opción" & vbCr
msg = msg & "de imprimir Datos de Especialista"
End Sub

Private Sub DatosEspReq()
msg = "Algún campo requerido no está lleno" & vbCr
msg = msg & "verifique y corrija antes de salvar"
End Sub

Sub TraerSioNo()
						msg = "¿Está seguro de traer la data " & vbCr
msg = msg & "del Estado de Situación"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Sub CSIPag1Email()
msg = "Corrija la dirección de Email, debe ser una dirección válida" & vbCr & _
						"y debe tener '@' y la palabra: .com .net .org, u otra" & vbCr & _
						"extensión válida"
End Sub

Private Sub BorrarSE()
msg = "¿Está seguro de borrar este Socio?"
bt0.Text = "No" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub PlaNoList()
						msg = "Esta planilla aún no está lista para utilizarse;" & vbCr
msg = msg & "estamos trabajando duro en ella para tenerla" & vbCr
msg = msg & "lista lo mas pronto posible - si la utiliza es" & vbCr
msg = msg & "a su propio riesgos y no garantizmos los " & vbCr
msg = msg & "cálculos. Gracias"
End Sub

Private Sub NuevaORepetida()
						msg = "¿Desea crear una nueva planilla o Salvar " & vbCr
msg = msg & "la actual bajo otro nombre?"
bt0.Text = "Nueva" : bt1.Text = "Otro" : bt2.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True : bt2.Visible = True
End Sub

Private Sub NuevaPla()
						msg = "Para una nueva planilla por favor, cambie el año en" & vbCr
msg = msg & "el combo del año en el toolbar; si es para el mismo" & vbCr
msg = msg & "año, escoja nuevamente el año actual"
End Sub

Private Sub AbrirCtaAtrasada()
						msg = "El archivo de planilla que intenta abrir es de una" & vbCr
msg = msg & "versión más atrasada, debe intentar abrir esa planilla" & vbCr
msg = msg & "con la versión de ese año"
End Sub

Private Sub NuevoAno()
      msg = "Si continúa la planilla actual será salvada y una nueva" & vbCr
msg = msg & "planilla para el año escogido de este cliente será" & vbCr
msg = msg & "creada con los datos principales" & vbCr & vbCr
msg = msg & "Puede buscar esta u otras planillas de este cliente " & vbCr
msg = msg & "en el botón para estos efectos en el toolbar " & vbCr
msg = msg & "'Otras Planillas de este cliente'"

bt0.Text = "Continuar" : bt1.Text = "Cancelar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub NumSegSocMal()
      msg = "El número de Seguro Social es repetitivo o" & vbCr
msg = msg & "es consecutivo o comienza con tres ceros"
End Sub

Private Sub NoReadyAnejoD()
      msg = "Esta forma aun no esta lista, puede hacerla" & vbCr
msg = msg & "manualmente y entrar los números directamente" & vbCr
msg = msg & "en la primera pantalla"
End Sub

Private Sub MsgCuestLinea1()
      msg = "Si hay una diferencia significativa en los derechos al voto" & vbCr
msg = msg & "entre los miembros de la junta, o si la junta de directores" & vbCr
msg = msg & "delega autoridad suficiente a un comité ejecutivo o comité de" & vbCr
msg = msg & "naturaleza similar, someta explicación"
End Sub

Private Sub SalirSinSalvar()
      msg = "El sistema siempre salva los cambios al salir del programa" & vbCr
msg = msg & "pero usted puede salir sin salvar los cambios más recientes." & vbCr & vbCr
msg = msg & "Hay cambios que siempre se salvan; por ejemplo en la" & vbCr
msg = msg & "pantalla de Negocios; este comando sólo ignora los" & vbCr
msg = msg & "cambios más recientes" & vbCr & vbCr
msg = msg & "Desea salir sin salvar sus cambios más recientes?"
bt0.Text = "Si" : bt1.Text = "No"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub NoPipeBuscarEnlace()
      msg = "Esta planilla la puede llenar en el PDF directamente" & vbCr
msg = msg & "puede presionar 'Sí' abajo para abrir el archivo en" & vbCr
msg = msg & "el reader y entrar la informacin o puede cancelar"
bt0.Text = "Salir" : bt1.Text = "Sí"
bt0.Visible = True : bt1.Visible = True
End Sub

 Private Sub MsgNoImpBB()
  msg = "Tiene marcado acogerse al computo opcional en la primera" & vbCr
  msg = msg & "pantalla pero el anejo BB (de computo opcional) no le" & vbCr
  msg = msg & "aplica a esta planilla, por favor, quite la marca en" & vbCr
  msg = msg & "dicha pantalla"
 End Sub

 Private Sub ShowImpMasFacil()
      msg = "La manera más fácil de imprimir es utilizando el 'Reader'" & vbCr & vbCr
msg = msg & "Con el 'Reader' usted puede ver la planilla en pantalla," & vbCr
msg = msg & "salvar la planilla al disco duro e imprimirla las veces" & vbCr
msg = msg & "que desee.  Para usar el 'Reader', escójalo en el menú" & vbCr
msg = msg & "de Preferencias; ADEMAS, debe imprimir siempre utilizando" & vbCr
msg = msg & "la opción 'Por Pantalla'"
End Sub

Private Sub FaltaInfEnviarEscenario()
      msg = "Falta el nombre suyo, el Email o la" & vbCr
msg = msg & "explicación correspondiente;" & vbCr
msg = msg & "cumplimente por favor"
End Sub

Private Sub VerifyEmail()
      msg = "Verifique su dirección de Email," & vbCr
msg = msg & "aparenta estar incorrecta"
End Sub

Private Sub YaExistePlanCreada()
      msg = "¡Ya existe ese año creado en el sistema!" & vbCr & vbCr
msg = msg & "Para acceder planillas de ese año, por favor, ábrala" & vbCr
msg = msg & "en el combo al lado izquierdo de este mismo toolbar" & vbCr
msg = msg & "bajo 'Abrir otra Planilla de este cliente'" & vbCr & vbCr
msg = msg & "Si desea salvar otra planilla para el mismo año" & vbCr
msg = msg & "pero con otro nombre utilice el icono de múltiples" & vbCr
msg = msg & "floppies al lado izquierdo"
End Sub

Private Sub SalvarConOtroNombre()
      msg = "El archivo actual es temporero, debe salvarlo con otro Nombre," & vbCr
msg = msg & "presione 'Cancelar' para que salve el archivo o 'Continuar' " & vbCr
msg = msg & "para olvidar este archivo y abrir otro" & vbCr
bt0.Text = "Cancelar" : bt1.Text = "Continuar"
bt0.Visible = True : bt1.Visible = True
End Sub

Private Sub SalvarConOtroNombre2()
      msg = "El archivo actual es temporero, debe salvarlo con" & vbCr
msg = msg & "otro Nombre antes de Salir del Programa'"
End Sub

Private Sub RegOportunidades()
      msg = "Si desea registrar posteriormente puede" & vbCr
msg = msg & "presionar el botón arriba en el Toolbar" & vbCr & vbCr
msg = msg & "Nota:" & vbCr
msg = msg & "Recuerde que mientras no se registre este programa" & vbCr
msg = msg & "está en modo de Demo y los resultados estarán" & vbCr
msg = msg & "distorsionados pues la idea es que usted evaule" & vbCr
msg = msg & "mayormente el funcionamiento del programa."
End Sub

Private Sub RegNoLib()
      msg = "Hay un problema con la seguridad de este" & vbCr
msg = msg & "programa, por favor, desinstaley reinstale" & vbCr
msg = msg & "para corregir el mismo"
End Sub

Private Sub YaActivado()
     msg = "Lo sentimos mucho, pero este programa" & vbCr
msg = msg & "ya fue activado previamente"
End Sub

Private Sub LicPWIncorrecto()
      msg = "Ese no es el número de Licencia o" & vbCr
msg = msg & "su contraseña está incorrecta"
End Sub

Private Sub OtrosProb()
      msg = "Hay algún tipo de problema en su activación por" & vbCr
msg = msg & "Internet, quizás algún problema de comunicación,"
msg = msg & "intente más tarde"
End Sub

Private Sub FaltaInfo()
      msg = "Falta completar uno de los campos requeridos" & vbCr
msg = msg & " marcados con asterisco rojo"
End Sub

Private Sub EmailWrong()
msg = "Corrija la direccion de Email, debe ser una dirección válida" & vbCr & _
      "y debe tener '@' y la palabra: .com .net .org, u otra" & vbCr & _
      "extensión válida"
End Sub

Private Sub EmailSendErr()
msg = "Existe un problema en la conexión de su máquina o la dirección" & vbCr & _
      "de Email escrita está incorrecta, corrija la dirección de email" & vbCr & _
      "o utilice la opción de la hoja de fax y envíela al 787-258-9271"
End Sub

Private Sub RegNotByInt()
msg = "Esta copia no fue registrada originalmente por medio del" & vbCr & _
      "Internet, intente la desactivación por medio de Fax;" & vbCr & _
      "imprima la hoja de Confirmación y envíela al 787-258-9271"
End Sub

Private Sub DeactivateError()
msg = "Hay algun problema con esta Desactivación por Internet;" & vbCr & _
      "verifique que está utilizando la licencia y contraseña" & vbCr & _
      "correctas; si continúa el problema sugerimos tratar " & vbCr & _
      "la desactivación por medio de Fax"
End Sub

Private Sub ErrImpresora()
msg = "Hay algún problema con su Impresora, verifique la misma y" & vbCr & _
      "trate otra vez, o intente la desactivación por Internet"
End Sub

 Private Sub NoIgualComp()
  msg = "Por favor, visite el anejo L, para recalcular el mismo por" & vbCr &
        "cambios a compensación oficiales o directores.  Si ya tiene" & vbCr &
        "en pantalla dicho anejo, salga y entre nuevamente al mismo"
 End Sub

 Private Sub msgErrorBasMayorRegular()
  msg = "En el anejo L, la cantidad en la línea " & z1 & vbCr &
        "de la" & b1 & " no puede ser mayor que" & vbCr &
         "la cantidad de la columna Regular"
 End Sub

 Private Sub msgErrorBasMayorRegularPag2()
  msg = "En la página 3, la cantidad en la línea " & z1 & vbCr &
        "de la " & b1 & " no puede ser mayor que" & vbCr &
         "la cantidad de la columna Regular"
 End Sub

 Private Sub msgErrorBasMayorRegularPag3()
  msg = "En la página 3, la cantidad en la línea " & z1 & " de la parte" & vbCr &
         "IX no puede ser mayor de 1.25% de la cantidad" & vbCr &
         "de la columna Regular"
 End Sub

 Private Sub pb0_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt0.MouseDown
  bt0.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb0_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt0.MouseEnter
  bt0.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb0_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt0.MouseLeave
  bt0.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb0_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt0.MouseUp
  bt0.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt1.MouseDown
  bt1.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.MouseEnter
  bt1.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.MouseLeave
  bt1.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt1.MouseUp
  bt1.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt2.MouseDown
  bt2.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.MouseEnter
  bt2.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.MouseLeave
  bt2.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt2.MouseUp
  bt2.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt3.MouseDown
  bt3.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.MouseEnter
  bt3.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.MouseLeave
  bt3.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb3_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt3.MouseUp
  bt3.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt4.MouseDown
  bt4.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.MouseEnter
  bt4.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.MouseLeave
  bt4.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb4_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt4.MouseUp
  bt4.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt5.MouseDown
  bt5.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgC
 End Sub

 Private Sub pb5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt5.MouseEnter
  bt5.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub

 Private Sub pb5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt5.MouseLeave
  bt5.Image = AIMContribucionesIncentivos.My.Resources.Resources.Msg
 End Sub

 Private Sub pb5_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt5.MouseUp
  bt5.Image = AIMContribucionesIncentivos.My.Resources.Resources.MsgH
 End Sub
End Class
