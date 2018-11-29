using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

    private Animator anim;
    private Rigidbody rb;
    public float speed;
    private bool flag;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        flag = true;
    }
	
	// Update is called once per frame
	void Update () {

        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0f, y);

        rb.velocity = movement * speed;

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        if (x != 0 && y != 0)
        {
            anim.Play("RUN00_F", -1);
        }
        else if(flag)
        {
            anim.Play("WAIT00", -1);
        }
    }

    public void Kalah()
    {
        flag = false;
        anim.Play("LOSE00", -1, 0f);
    }

    public void Menang()
    {
        SoundFX.playsound("victory");
        flag = false;
        anim.Play("WIN00", -1, 0f);
    }
}
