using System;
using UnityEngine;
using UnityEngine.Video;

public class PhysPageSettings : MonoBehaviour
{
	public PhysPageVariant[] _physPageVariants;
}


[Serializable]
public class PhysPageVariant
{
	public PhysPageSetup[] _physPages;

	[HideInInspector] public int _indexOfCurrentScene;
}


[Serializable]
public class PhysPageSetup : Page
{
	public VideoClip _video;
	public Sprite[] _pictures;

	[SerializeField] private AudioClip _audio;
	[SerializeField] private string _text;
	[SerializeField] private Sprite[] _backImages;
}