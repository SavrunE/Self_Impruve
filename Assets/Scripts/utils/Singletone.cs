using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance;

    protected void Awake()
    {
		if (instance == null)
		{ 
			instance = this as T; 
		}
		else if (instance == this)
		{ 
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}
}
