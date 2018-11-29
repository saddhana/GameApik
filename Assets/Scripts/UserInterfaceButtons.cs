using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour
{
    public float translationSpeed = 5.0f;
    //	public GameObject Player;
    bool repeatPositionUp = false;
    bool repeatPositionDown = false;
    bool repeatPositionLeft = false;
    bool repeatPositionRight = false;

    public GameObject player;
    public GameObject bomb;
    public Transform tr;

    void Update()
    {
        tr = GetComponent<Transform>();
        player = GameObject.FindWithTag("Player");
    }


    public void DropBombs()
    {
        //GameObject obj = Instantiate(bomb, new Vector3(GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y, GameObject.FindWithTag("Player").transform.position.z), Quaternion.identity) as GameObject;
        GameObject obj = Instantiate(bomb, new Vector3(tr.position.x, tr.position.y, tr.position.z), Quaternion.identity) as GameObject;
    }
}
