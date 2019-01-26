using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour {

    private SoundManager soundManager;

	// Use this for initialization
	void Start () {
        soundManager = GetComponent<SoundManager>();
        soundManager.Play("8-bit");
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
