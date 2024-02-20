using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysPage : MonoBehaviour
{
	private PhysPageSettings physPageSettings;
	[SerializeField] private LessonButton _ButtonExample;
	[SerializeField] private Canvas _canvas;

	void Start()
	{
		physPageSettings = PagesSettings.instance.GetPhysPage();
		Debug.Log(physPageSettings);
		CreateButtons();
	}

	private void CreateButtons()
	{
		var variants = physPageSettings.physPageVariants;
		foreach (var variant in variants)
		{
			var button = Instantiate(_ButtonExample, _canvas.transform);

			ButtonSettings bSet = variant.buttonSettings;
			button.SetParameters(bSet.isFree, bSet.buttonImages, bSet.buttonText, bSet.sceneId);

			button.UpdateButton();
		}
	}
}
