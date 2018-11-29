using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private int coinToGet;
    private static int coinNow;

    [SerializeField]
    private GameObject gameWinUI;
    [SerializeField]
    private GameObject[] controller;
    [SerializeField]
    private GameObject gameLoseUI;

    private Controller ctrl;
    

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        controller = GameObject.FindGameObjectsWithTag("Control");
        coinNow = 0;
        ctrl = FindObjectOfType<Controller>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetCoin()
    {
        coinNow += 1;
        if (coinToGet == coinNow)
        {
            controller[0].SetActive(false);
            Time.timeScale = 0;
            gameWinUI.SetActive(true);
            ctrl.Menang();
        }
    }

    public void GetHit()
    {
        controller[0].SetActive(false);
        gameLoseUI.SetActive(true);
        ctrl.Kalah();
    }
}
