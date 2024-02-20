using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LessonButton : OpenSceneButton
{
	[SerializeField] private bool _isFree;
	[SerializeField] private TextMeshProUGUI _tmp;
	[SerializeField] private Sprite _sprite;
	[SerializeField] private string _buttonText;
	[SerializeField] private int _sceneId;

	private const string _templateSceneName = "LessonTemplate";

	private void Start()
	{
		base.Start();

		_openSceneName = _templateSceneName;

		//if (_buttonText != "")
		//{
		//	ChangeText(_buttonText);
		//}
		//if (_isFree == false)
		//{
		//	GetComponent<Button>().interactable = false;
		//}
		//if (_sprite != null)
		//{
		//	GetComponent<Image>().sprite = _sprite;
		//}
	}

	public void UpdateButton()
	{
		ChangeText(_buttonText);
		
		if (_isFree == false)
		{
			GetComponent<Button>().interactable = false;
		}
		else
		{
			GetComponent<Button>().interactable = true;
		}
		if (_sprite != null)
		{
			GetComponent<Image>().sprite = _sprite;
		}
		else
		{
			Debug.Log("Sprite is null");
		}
	}

	public void ChangeText(string text)
	{
		_tmp.text = text;
	}

	public void SetParameters(bool isFree, Sprite sprite, string buttonText, int sceneId)
	{
		_isFree = isFree;
		_sprite = sprite;
		_buttonText = buttonText;
		_sceneId = sceneId;
	}
}

[Serializable]
public class ButtonSettings
{
	public bool isFree;
	public Sprite buttonImages;
	public string buttonText;
	public int sceneId;
}