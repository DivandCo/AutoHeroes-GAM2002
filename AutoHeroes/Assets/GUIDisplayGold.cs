using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIDisplayGold : MonoBehaviour {

    public Text GOLDtext;
    public int Goldy;
    public Text StageTextNumber;
    

    private Stage stage;
    
    

    // Use this for initialization
    void Start () {
        Goldy = CurrencyTab.MyGold.Gold;
        StageTextNumber.text = "Current Stage: " + GameControl.StageNumber;
        stage = GetComponent<Stage>();
    }
	
	// Update is called once per frame
	void Update () {

        Goldy = CurrencyTab.MyGold.Gold;
        GOLDtext.text = "Gold " + Goldy;
        StageTextNumber.text = "Current Stage: " + GameControl.StageNumber;

        //if (gameObject.GetComponent<Stage>

        DontDestroyOnLoad(this);
    }
}
