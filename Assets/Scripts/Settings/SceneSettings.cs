using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSettings : MonoBehaviour
{
    private void Start()
    {
        pSettings.instance.SetCurrentSceneName(SceneManager.GetActiveScene().name);

	}
}
