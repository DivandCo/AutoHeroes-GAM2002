using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Summon : MonoBehaviour
{

    private bool IsSummoned = false;
    public int SummonCount = 0;
    private int r;
    GameObject summonobject;
    




    public List<GameObject> Heroes = new List<GameObject>();

    public List<GameObject> SummonedHeroes = new List<GameObject>();

    public readonly int[] SummonCost = {0, 10, 100, 250 };

    // Use this for initialization
    void Start()
    {
        summonobject = GameObject.FindGameObjectWithTag("summonbutton");
        if (summonobject != null)
        {
            Button summonbutton = summonobject.GetComponent<Button>();
            summonbutton.onClick.AddListener(summoning);
        }

    }

    // Update is called once per frame

    public void summoning()
    {
        if (Heroes.Count > 0)
        {
            int r = Random.Range(0, Heroes.Count);

            if (CurrencyTab.MyGold.Gold >= SummonCost[SummonCount])
            {
                Heroes[r].SetActive(true);
                SummonedHeroes.Add(Heroes[r]);
                Heroes[r].GetComponent<HeroesScrpt>().Alive = true;
                Heroes.RemoveAt(r);
                SummonCount++;
                CurrencyTab.MyGold.Gold -= SummonCost[SummonCount];
                
            }
        }
    }
 
    public void OnLevelWasLoaded()
    {
        summonobject = GameObject.FindGameObjectWithTag("summonbutton");
        if (summonobject != null)
        {
            Button summonbutton = summonobject.GetComponent<Button>();
            summonbutton.onClick.AddListener(summoning);
        }
    }
}   

//}//for (int i = 0 ; i < Heroes.Length; i++)
    //{
    //    int r = Random.Range (0, Heroes.Length);
    //}

    //if (Counter == 0 && CurrencyTab.MyGold.Gold >= 10)
    //{
    //    Heroes[r].SetActive(true);