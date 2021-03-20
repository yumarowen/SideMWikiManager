extends Control

var CardTemplate =  'res://CardMaker/SideMoba CardData+ Template.txt'
var CardTemplateFile
var CardTemplateContent
var NewCardFile

var CardRarity

var CardDataScreen = 'res://CardMaker/CardMaker.tscn'
var InstanceBox = preload("res://IDOL2.tscn")
var New_Box

#GLOBAL VARS
onready var CardRarityEdit = find_node("Card_Rarity_Edit")
onready var CardCost = find_node("Card_Cost_Edit")
onready var LogInfo = find_node("ErrorWarning")
onready var Notes1 = find_node("NOTES1_Edit")
onready var Notes2 = find_node("NOTES2_Edit")
onready var Notes3 = find_node("NOTES3_Edit")
onready var Notes4 = find_node("NOTES4_Edit")
onready var Notes5 = find_node("NOTES5_Edit")

#JPN VARS
onready var CardTitleJPN = find_node("Card_Title_JPN_Edit")
onready var CardDescription1JPN = find_node("Description_1_JPN_Edit")
onready var CardSkillJPN = find_node("Skill_JPN_Edit")
onready var CardEffectJPN = find_node("Effect_JPN_Edit")

#ENG VARS
onready var CardTitleENG = find_node("Card_Title_ENG_Edit")
onready var CardDescription1ENG = find_node("Description_1_ENG_Edit")
onready var CardSkillENG = find_node("Skill_ENG_Edit")
onready var CardEffectENG = find_node("Effect_ENG_Edit")

func _init():
	CardTemplateFile = File.new()
	CardTemplateFile.open(CardTemplate,File.READ)
	CardTemplateContent = CardTemplateFile.get_as_text()

	NewCardFile = File.new()

func _ready():
	_init_RARITY_LIST()

func _init_RARITY_LIST():
	CardRarityEdit.add_item("R+")
	CardRarityEdit.add_item("SR+")

func generate_card():
	if not CardTitleJPN.text == "":
		NewCardFile.open('res://CardMaker/'+CardTitleJPN.text+'.txt',File.WRITE)
		replace_CardTitle()
		replace_CardRarity()
		replace_CardDescription()
		replace_CardCost()
		replace_CardSkill()
		replace_CardEffect()
		replace_CardNotes()
		NewCardFile.store_string(CardTemplateContent)
		OS.set_clipboard(CardTemplateContent)
		NewCardFile.close()
		LogInfo.text = 'Card Code has been generated and copied to clipboard!'
		reset_file()
	else:
		LogInfo.text = "Japanese Card Title is invalid"

func replace_CardTitle():
	if not CardTitleJPN.text == "":
		CardTemplateContent = CardTemplateContent.replace("TITLE_JPN",CardTitleJPN.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("TITLE_JPN","")
	if not CardTitleENG.text == "":
		CardTemplateContent = CardTemplateContent.replace("TITLE_ENG",CardTitleENG.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("TITLE_ENG","")

func replace_CardRarity():
	match CardRarityEdit.get_selected_id():
		0:
			CardRarity = "R"
		1:
			CardRarity = "SR"
		_:
			CardRarity = ""
			LogInfo.text = "Card Rarity is Invalid"
	if CardRarity != "":
		CardTemplateContent = CardTemplateContent.replace("CARD_RARITY",CardRarity)

func replace_CardDescription():
	if not CardDescription1JPN.text == "":
		CardTemplateContent = CardTemplateContent.replace("DESCRIP1_JPN",CardDescription1JPN.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("DESCRIP1_JPN","")
	if not CardDescription1ENG.text == "":
		CardTemplateContent = CardTemplateContent.replace("DESCRIP1_ENG",CardDescription1ENG.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("DESCRIP1_ENG","")

func replace_CardCost():
	if CardCost.text.is_valid_integer():
		CardTemplateContent = CardTemplateContent.replace("CARD_COST",CardCost.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("CARD_COST","")

func replace_CardSkill():
	if not CardSkillJPN.text == "":
		CardTemplateContent = CardTemplateContent.replace("SKILL_JPN",CardSkillJPN.text)
	else:	
		CardTemplateContent = CardTemplateContent.replace("SKILL_JPN","")
	if not CardSkillENG.text == "":
		CardTemplateContent = CardTemplateContent.replace("SKILL_ENG",CardSkillENG.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("SKILL_ENG","")

func replace_CardEffect():
	if not CardEffectJPN.text == "":
		CardTemplateContent = CardTemplateContent.replace("EFFECT_JPN",CardEffectJPN.text)
	else:	
		CardTemplateContent = CardTemplateContent.replace("EFFECT_JPN","")
	if not CardEffectENG.text == "":
		CardTemplateContent = CardTemplateContent.replace("EFFECT_ENG",CardEffectENG.text)
	else:		
		CardTemplateContent = CardTemplateContent.replace("EFFECT_ENG","")

func replace_CardNotes():
	if Notes1.text != "":
		CardTemplateContent = CardTemplateContent.replace("NOTES_1",Notes1.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("NOTES_1","")
	if Notes2.text != "":
		CardTemplateContent = CardTemplateContent.replace("NOTES_2",Notes2.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("NOTES_2","")
	if Notes3.text != "":
		CardTemplateContent = CardTemplateContent.replace("NOTES_3",Notes3.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("NOTES_3","")
	if Notes4.text != "":
		CardTemplateContent = CardTemplateContent.replace("NOTES_4",Notes4.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("NOTES_4","")
	if Notes5.text != "":
		CardTemplateContent = CardTemplateContent.replace("NOTES_5",Notes5.text)
	else:
		CardTemplateContent = CardTemplateContent.replace("NOTES_5","")

func _on_Button_pressed():
	generate_card()

func reset_file():
	CardTemplateContent = CardTemplateFile.get_as_text()

func _on_Button2_pressed():
	get_tree().change_scene(CardDataScreen)

func _on_Clear_pressed():
	CardRarityEdit.selected = 0
	CardCost.text = ""
	Notes1.text = ""
	Notes2.text = ""
	Notes3.text = ""
	Notes4.text = ""
	Notes5.text = ""
	CardTitleJPN.text = ""
	CardDescription1JPN.text = ""
	CardSkillJPN.text = ""
	CardEffectJPN.text = ""
	CardTitleENG.text = ""
	CardDescription1ENG.text = ""
	CardSkillENG.text = ""
	CardEffectENG.text = ""
