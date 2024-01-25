using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pSettings : Singleton<pSettings>
{
	public string currentSceneName { get; private set; }
	public string lastSceneName { get; private set; }

	public static bool systemInitialized { get; private set; } = false;

	private void Awake()
	{
		currentSceneName = SceneManager.GetActiveScene().name;
		lastSceneName = currentSceneName;
		Debug.Log("currentSceneName " + currentSceneName);


		systemInitialized = true;
		Debug.Log("GameSystem::Start()");
	}

	public void SetCurrentSceneName(string sceneName)
	{
		lastSceneName = currentSceneName;
		currentSceneName = sceneName;
		Debug.Log("currentSceneName " + currentSceneName);
	}
}
