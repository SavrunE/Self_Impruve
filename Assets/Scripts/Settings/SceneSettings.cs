using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSettings : MonoBehaviour
{
	private void Start()
	{
		string sceneName = SceneManager.GetActiveScene().name;
		pSettings.instance.SetCurrentSceneName(sceneName);
		Debug.Log("Current scene name is " + sceneName);
	}
}
