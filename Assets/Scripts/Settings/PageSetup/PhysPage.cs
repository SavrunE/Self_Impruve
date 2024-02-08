using System;
using UnityEngine;
using UnityEngine.Video;

public class PhysPage : MonoBehaviour
{
	public PhysPageSetup[] _physPages;


}

[Serializable]
public class PhysPageSetup
{
	public VideoClip _video;
	[SerializeField] private AudioClip _audio;
	[SerializeField] private string _text;
	[SerializeField] private Sprite _image;
}