extends Button

var MainScreen = 'res://Main.tscn'

func _on_Button_pressed():
	get_tree().change_scene(MainScreen)
