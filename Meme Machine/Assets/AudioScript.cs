using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {


	// Your audio clip
	public AudioClip MusicClip;

	// the component that Unity uses to play your clip
	public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
		MusicSource.clip = MusicClip;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			MusicSource.Play();	
	}
}
