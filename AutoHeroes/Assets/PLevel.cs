using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLevel : MonoBehaviour {

    public Text HeroOneLevel;
    private GameObject HeroLevel;
    private int HeroPLevel;
    public Text HeroTwoLevel;
    public Text HeroThreeLevel;


    // Use this for initialization
    void Start () {

        HeroLevel = GameObject.FindGameObjectWithTag("Hero1");

        if (HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroOneLevel.text = "Hero level: " + HeroPLevel;
        }

            HeroLevel = GameObject.FindGameObjectWithTag("Hero2");

        if(HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroTwoLevel.text = "Hero level: " + HeroPLevel;
        }
           
       HeroLevel = GameObject.FindGameObjectWithTag("Hero3");

        if (HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroThreeLevel.text = "Hero level: " + HeroPLevel;
        }

    }

	// Update is called once per frame
	void Update () {

        HeroLevel = GameObject.FindGameObjectWithTag("Hero1");

        if (HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroOneLevel.text = "Hero level: " + HeroPLevel;
        }

        HeroLevel = GameObject.FindGameObjectWithTag("Hero2");

        if (HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroTwoLevel.text = "Hero level: " + HeroPLevel;
        }

        HeroLevel = GameObject.FindGameObjectWithTag("Hero3");
        if (HeroLevel != null)
        {
            HeroPLevel = HeroLevel.GetComponent<HeroesScrpt>().Level;
            HeroThreeLevel.text = "Hero level: " + HeroPLevel;
        }
    }
}
