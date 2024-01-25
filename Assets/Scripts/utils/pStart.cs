using UnityEngine;

public class pStart : MonoBehaviour
{
    private void Awake()
    {
		if (pSettings.systemInitialized == false)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
