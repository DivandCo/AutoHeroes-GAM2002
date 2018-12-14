using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CurrencyTab: MonoBehaviour { 


    public static CurrencyTab MyGold;
    public int Gold;
  

    private void Awake()
    {
        if (MyGold == null)
        {
            MyGold = this;
        }

        else if (MyGold != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }


}

