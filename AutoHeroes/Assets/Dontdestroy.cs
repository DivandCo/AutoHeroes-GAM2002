using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{

    public GameObject[] gObjects;

    // Use this for initialization
    void Awake()
    {
        gObjects = GameObject.FindGameObjectsWithTag("Player");

        if (gObjects.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this);
    }
}
	
            //if (GameObject.Find("Player").GetComponent<Summon>().SummonCount >= 1 && GetComponent<Summon>().SummonCost[2] == 1000)

            //    {

            //    }

            //    else if (GameObject.Find("Player").GetComponent<Summon>().SummonCount <= 0)
            //    {
            //        Destroy(gameObject);
            //    }
