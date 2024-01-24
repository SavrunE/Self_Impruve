using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LessonPage : OpenSceneButton
{
	[SerializeField] private bool _isFree;
	[SerializeField] private TextMeshProUGUI _tmp;
	[SerializeField] private Sprite _sprite;
	[SerializeField] private string _buttonText;

	private void Start()
	{
		if (_buttonText != "")
		{
			ChangeText(_buttonText);
		}
		if (_isFree == false)
		{
			GetComponent<Button>().interactable = false;
		}
		if (_sprite != null)
		{
			GetComponent<Image>().sprite = _sprite;
		}
	}

	public void ChangeText(string text)
	{
		_tmp.text = text;
	}
}
