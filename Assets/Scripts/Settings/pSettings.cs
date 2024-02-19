using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pSettings : Singleton<pSettings>
{
	public string currentSceneName { get; private set; }
	public string lastSceneName { get; private set; }

	public static bool systemInitialized { get; private set; } = false;

	public bool isSubscriber { get; private set; }

	private const string _startSceneName = "Start";

	private void Awake()
	{
		base.Awake();
		currentSceneName = SceneManager.GetActiveScene().name;
		lastSceneName = currentSceneName;

		systemInitialized = true;
		Debug.Log("pSettings Awake()");
	}

	private void Start()
	{
		SceneManager.LoadScene(_startSceneName);
	}

	public void SetCurrentSceneName(string sceneName)
	{
		lastSceneName = currentSceneName;
		currentSceneName = sceneName;
		Debug.Log("currentSceneName " + currentSceneName);
	}

	public void MoveBackScene()
	{
		if (currentSceneName != _startSceneName)
		{
			SceneManager.LoadScene(lastSceneName);
		}
		else
		{
			Debug.Log("that is Start scene, can't move back");
		}
	}
}
