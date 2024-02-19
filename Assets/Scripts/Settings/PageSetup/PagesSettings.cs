using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesSettings : Singleton<PagesSettings>
{
	[SerializeField] private PhysPageSettings _physPage;

	public PhysPageSettings GetPhysPage()
	{
		return _physPage;
	}
}
