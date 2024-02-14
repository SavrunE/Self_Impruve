using System;
using UnityEngine;

public class Page
{
	[SerializeField]
	protected bool isFree;

	protected void SetIsFree(bool value)
	{
		isFree = value;
	}
}