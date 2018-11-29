using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public GameObject explosion;

    void Start()
    {
        StartCoroutine(ExplodeBomb());
    }

    IEnumerator ExplodeBomb()
    {
        Vector3 bomblocation = transform.position;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
        var collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x, bomblocation.y + 51, bomblocation.z), 50);
        int found = 0;
        GameObject explo1 = Instantiate(explosion, new Vector3(bomblocation.x, bomblocation.y, bomblocation.z), Quaternion.identity) as GameObject;

        collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x - 100f, bomblocation.y + 51, bomblocation.z), 50);
        foreach (Collider obj in collidersInRange)
        {
            if (obj.tag == "Wall")
            {
                found = 1;
                break;
            }
        }
        if (found == 0)
        {
            GameObject explo2 = Instantiate(explosion, new Vector3(bomblocation.x - 100f, bomblocation.y, bomblocation.z), Quaternion.identity) as GameObject;
            collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x - 200f, bomblocation.y + 51, bomblocation.z), 50);
            foreach (Collider obj in collidersInRange)
            {
                if (obj.tag == "Wall")
                {
                    found = 1;
                    break;
                }
                if (found == 0)
                {
                    GameObject explo3 = Instantiate(explosion, new Vector3(bomblocation.x - 200f, bomblocation.y, bomblocation.z), Quaternion.identity) as GameObject;
                }
            }
        }
        found = 0;

        collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x + 100f, bomblocation.y + 51, bomblocation.z), 50);
        foreach (Collider obj in collidersInRange)
        {
            if (obj.tag == "Wall")
            {
                found = 1;
                break;
            }
        }
        if (found == 0)
        {
            GameObject explo4 = Instantiate(explosion, new Vector3(bomblocation.x + 100f, bomblocation.y, bomblocation.z), Quaternion.identity) as GameObject;
            collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x + 200f, bomblocation.y + 51, bomblocation.z), 50);
            foreach (Collider obj in collidersInRange)
            {
                if (obj.tag == "Wall")
                {
                    found = 1;
                    break;
                }
                if (found == 0)
                {
                    GameObject explo5 = Instantiate(explosion, new Vector3(bomblocation.x + 200f, bomblocation.y, bomblocation.z), Quaternion.identity) as GameObject;
                }
            }
        }
        found = 0;

        collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x, bomblocation.y + 51, bomblocation.z - 100f), 50);
        foreach (Collider obj in collidersInRange)
        {
            if (obj.tag == "Wall")
            {
                found = 1;
                break;
            }
        }
        if (found == 0)
        {
            GameObject explo6 = Instantiate(explosion, new Vector3(bomblocation.x, bomblocation.y, bomblocation.z - 100f), Quaternion.identity) as GameObject;
            collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x, bomblocation.y + 51, bomblocation.z - 200f), 50);
            foreach (Collider obj in collidersInRange)
            {
                if (obj.tag == "Wall")
                {
                    found = 1;
                    break;
                }
                if (found == 0)
                {
                    GameObject explo7 = Instantiate(explosion, new Vector3(bomblocation.x, bomblocation.y, bomblocation.z - 200f), Quaternion.identity) as GameObject;
                }
            }
        }
        found = 0;

        collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x, bomblocation.y + 51, bomblocation.z + 100f), 50);
        foreach (Collider obj in collidersInRange)
        {
            if (obj.tag == "Wall")
            {
                found = 1;
                break;
            }
        }
        if (found == 0)
        {
            GameObject explo8 = Instantiate(explosion, new Vector3(bomblocation.x, bomblocation.y, bomblocation.z + 100f), Quaternion.identity) as GameObject;
            collidersInRange = Physics.OverlapSphere(new Vector3(bomblocation.x, bomblocation.y + 51, bomblocation.z + 200f), 50);
            foreach (Collider obj in collidersInRange)
            {
                if (obj.tag == "Wall")
                {
                    found = 1;
                    break;
                }
                if (found == 0)
                {
                    GameObject explo9 = Instantiate(explosion, new Vector3(bomblocation.x, bomblocation.y, bomblocation.z + 200f), Quaternion.identity) as GameObject;
                }
            }
        }
        found = 0;
    }
}
