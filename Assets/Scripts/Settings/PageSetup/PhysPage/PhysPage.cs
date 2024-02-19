using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysPage : MonoBehaviour
{
	private PhysPageSettings physPageSettings;

	void Start()
	{
		physPageSettings = PagesSettings.instance.GetPhysPage();
		Debug.Log(physPageSettings);
	}
}
