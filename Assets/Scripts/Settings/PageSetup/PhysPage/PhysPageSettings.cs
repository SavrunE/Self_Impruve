using System;
using UnityEngine;
using UnityEngine.Video;

public class PhysPageSettings : MonoBehaviour
{
	public PhysPageVariant[] physPageVariants;
}


[Serializable]
public class PhysPageVariant
{
	public PhysPageSetup physPages;
	public ButtonSettings buttonSettings;

	[HideInInspector] public int indexOfCurrentScene;
}


[Serializable]
public class PhysPageSetup : Page
{
	public VideoClip[] video;
	public Sprite[] pictures;

	[SerializeField] private AudioClip[] _audio;
	[SerializeField] private string[] _text;
	[SerializeField] private Sprite[] _backImages;
}