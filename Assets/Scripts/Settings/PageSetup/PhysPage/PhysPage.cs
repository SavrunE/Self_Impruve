using System;
using UnityEngine;
using UnityEngine.Video;

public class PhysPage : MonoBehaviour
{
	public PhysPageVariant[] _physPageVariants;
}


[Serializable]
public class PhysPageVariant
{
	public PhysPageSetup[] _physPages;
}


[Serializable]
public class PhysPageSetup : Page
{
	public VideoClip _video;
	[SerializeField] private AudioClip _audio;
	[SerializeField] private string _text;
	[SerializeField] private Sprite[] _backImages;
}