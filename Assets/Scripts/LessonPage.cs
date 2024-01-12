using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LessonPage : MonoBehaviour
{
	[SerializeField] private bool _isFree;
	[SerializeField] private TextMeshProUGUI _tmp;

	private void Start()
	{
		if (_isFree == false)
		{
			GetComponent<Button>().interactable = false;
		}
	}

	public void ChangeText(string text)
	{
		_tmp.text = text;
	}
}
