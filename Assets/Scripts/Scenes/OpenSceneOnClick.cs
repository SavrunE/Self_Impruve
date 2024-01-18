using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class OpenSceneOnClick : MonoBehaviour
{
	[SerializeField] private string _sceneName;
	private Button _button;

	private void Start()
	{
		_button = transform.GetComponent<Button>();
		_button.onClick.AddListener(Click);
	}

	private void Click()
	{
		SceneManager.LoadScene(_sceneName);
	}
}
