using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenSceneButton : MonoBehaviour
{
	[SerializeField] protected string _openSceneName;
	protected Button _button;

	protected void Start()
	{
		_button = transform.GetComponent<Button>();
		_button.onClick.AddListener(Click);
	}

	public void Click()
	{
		SceneManager.LoadScene(_openSceneName);
	}
}
