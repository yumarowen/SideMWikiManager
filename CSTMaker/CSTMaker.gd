extends Control

var CardTemplate =  'res://CSTMaker/TEMPLATE.txt'
var URLTemplate =  'res://CSTMaker/TEMPLATE3.txt'
var CSTtoTemplate =  'res://CSTMaker/TEMPLATE2.txt'
var URLListLoc =  'res://CSTMaker/URLLIST.txt'
var CardTemplateFile
var CardTemplateContent
var NewCardFile
var csv = []
var csvFileLocation = 'res://CSTMaker/list.csv'
var csvFile
var csvFileContent=""
var AppendContent=""
var AppendContent2=""

var CSTtoFile
var CSTtoWriteFile
var CSTtoContent=""

var URLFile
var URLList
var URlChangedFile
var URLContent=""
var URLToChange= []

onready var LogInfo = find_node("ErrorWarning")
onready var Notes1 = find_node("NOTES1_Edit")
onready var Notes2 = find_node("NOTES2_Edit")


func _ready():
	pass

func OpenURLFiles():
	URLFile = File.new()
	URLFile.open(URLTemplate,File.READ)	
	URLContent = URLFile.get_as_text()
	URLList = File.new()
	URlChangedFile = File.new()

func OpenCSTfiles():
	CardTemplateFile = File.new()
	CardTemplateFile.open(CardTemplate,File.READ)
	CardTemplateContent = CardTemplateFile.get_as_text()

	CSTtoFile = File.new()
	CSTtoFile.open(CSTtoTemplate,File.READ)

	NewCardFile = File.new()

	csvFile = File.new()
	csvFile.open(csvFileLocation,File.READ)
	csvFileContent = csvFile.get_as_text()
	
	CSTtoWriteFile = File.new()

func generate_card():
	if not Notes1.text == "":
		NewCardFile.open('res://CSTMaker/'+Notes1.text+'.cs',File.WRITE)
		replace_Notes(Notes1.text,Notes2.text)
		NewCardFile.store_string(CardTemplateContent)
		NewCardFile.close()
		LogInfo.text = 'CST Code has been generated!'
		ResetCSTFiles()
	else:
		LogInfo.text = "ok there was an error and it didn't feel very 315"

func generate_CST_batch(NOTES1,NOTES2):
	CSTtoWriteFile.open('res://CSTMaker/CstToALL.cs',File.WRITE)
	NewCardFile.open('res://CSTMaker/All.cs',File.WRITE)
	replace_Notes(NOTES1,NOTES2)
	NewCardFile.store_string("\n"+AppendContent)
	CSTtoWriteFile.store_string(AppendContent2)

func replace_Notes(NOTES1,NOTES2):
	CardTemplateContent = CardTemplateContent.replace("NAME1",NOTES1)
	CardTemplateContent = CardTemplateContent.replace("NAME2",NOTES2)
	CSTtoContent = CSTtoContent.replace("NAME1",NOTES1)
	AppendContent = AppendContent + CardTemplateContent
	AppendContent2 = AppendContent2 + CSTtoContent

func _init_csv():
	while !csvFile.eof_reached():
		var line = csvFile.get_csv_line(",")
		csv.append(line)
	csvFile.close()
	for number in csv:
		print(number)
		CardTemplateContent = CardTemplateFile.get_as_text()
		CSTtoContent = CSTtoFile.get_as_text()
		if number[0] != "":
			if number[1] != "":
				generate_CST_batch(number[0],number[1])
	NewCardFile.close()
	ResetCSTFiles()
		
func _on_Button_pressed():
	generate_card()


func URL_changer():
	URlChangedFile.open('res://CSTMaker/URLs.cs',File.WRITE)
	URLList.open(URLListLoc,File.READ)
	var URLTemplate = URLContent
	while !URLList.eof_reached():
		var line = URLList.get_line()
		line = line.replace("\t","")
		if line.ends_with("]"):
			if "Token(Token" in line:
				pass
			elif "[FieldOffset" in line:
				pass
			else:
				AppendContent = 'urls += "' + line + '" + '
		if line.ends_with(";"):
			line[-1] = ""
			var EndLine = line.rfind(" ")
			line[EndLine] = ""
			line = line.substr(EndLine)
			print(line)
			URLContent = URLTemplate.replace("NAME",line)
			AppendContent = AppendContent + URLContent
	if AppendContent.ends_with("+"):
		AppendContent[-1] = ";"
	else:
		pass
	URlChangedFile.store_string(AppendContent + '\n+ "\\r\\n";\n')
	pass

func ResetCSTFiles():
	NewCardFile.close()
	CSTtoWriteFile.close()
	CardTemplateContent = CardTemplateFile.get_as_text()
	CardTemplateFile.close()

func ResetURLFiles():
	URlChangedFile.close()
	URLFile.close()

func _on_Button2_pressed():
	OpenCSTfiles()
	_init_csv()
	ResetCSTFiles()
	LogInfo.text = 'CST Codes have been generated!'

func _on_Details_pressed():
	OpenURLFiles()
	URL_changer()
	OS.set_clipboard(AppendContent)
	LogInfo.text = "CST Details have been generated and copied to clipboard!"
	ResetURLFiles()
