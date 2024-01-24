using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartScene : MonoBehaviour
{
    private void Awake()
    {
		SceneManager.LoadScene("StartScene");
	}
}
