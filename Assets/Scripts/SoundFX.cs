using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour {

    public static AudioClip getCoin, select, victory;
    static AudioSource audiosrc;

    // Use this for initialization
    void Start () {
        getCoin = Resources.Load<AudioClip>("5_Coins");
        select = Resources.Load<AudioClip>("Select");
        victory = Resources.Load<AudioClip>("Victory");
        audiosrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void playsound(string clip)
    {
        switch (clip)
        {
            case "getCoin":
                audiosrc.PlayOneShot(getCoin);
                break;
            case "select":
                audiosrc.PlayOneShot(select);
                break;
            case "victory":
                audiosrc.PlayOneShot(victory);
                break;
        }

    }
}
