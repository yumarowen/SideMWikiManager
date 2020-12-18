extends Control

onready var BaseURLConfirmChange = find_node("BaseURLLoad")
onready var BaseURLLoad = find_node("FileDialog")
onready var OldBaseURLValue = find_node("OldBaseURLEdit")
onready var NewBaseURLValue = find_node("NewBaseURLEdit")
var FileSelected = File.new()
var NewFile = File.new()
var NewFileSelected
var NewBaseURL
var OldBaseURL
var files
var OldBaseURLPath = "res://BaseURLSorter/BaseURL/old/"
var NewBaseURLPath = "res://BaseURLSorter/BaseURL/new/"

func _ready():
	pass

func _on_BaseURLLoad_pressed():
	NewBaseURL = NewBaseURLValue.text
	print(NewBaseURL)
	OldBaseURL = OldBaseURLValue.text
	NewFile.open("res://BaseURLSorter/BaseURL/OldBaseURL.txt",File.WRITE)
	list_files_in_dir(NewBaseURLPath,0)
	list_files_in_dir(OldBaseURLPath,1)

func list_files_in_dir(path,BaseURLState):
	var files = []
	var dir = Directory.new()
	dir.open(path)
	dir.list_dir_begin()
	while true:
		var file = dir.get_next()
		if file == "":
			break
		elif not file.begins_with("."):
			files.append(file)
	dir.list_dir_end()
	remove_base_url_from_files(files,BaseURLState)

func remove_base_url_from_files(files,BaseURLState):
	for file in files:
		FileSelected.open(file,File.READ_WRITE)
		NewFileSelected = FileSelected.get_as_text()
		match BaseURLState:
			0:
				NewFileSelected = NewFileSelected.replace(NewBaseURL,"")
			1:
				NewFileSelected = NewFileSelected.replace(OldBaseURL,"")
	NewFile.store_string(NewFileSelected)
	NewFile.close()
