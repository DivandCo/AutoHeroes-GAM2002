using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : UnitScript {

    int GoldValue = 5;


    public void Awake()
    {
        this.MaxHealth += (int)(10 * Scaling * Level);
        CurrentHealth = MaxHealth;
        this.Damage += (int)(8 * Scaling * Level);
        this.Speed += (2 /100 * Scaling * Level);
        this.Defence += (int)(3 * Scaling * Level);
    }

    public void Levelup(int level)
    {
        this.Level = level;
        this.MaxHealth += (int)(10 * Scaling * Level);
        CurrentHealth = MaxHealth;
        this.Damage += (int)(8 * Scaling * Level);
        this.Speed += (2 / 100 * Scaling * Level);
        this.Defence += (int)(3 * Scaling * Level);
    }



    public void Death()

    {
        CurrencyTab.MyGold.Gold += 5 * GameControl.StageNumber;
        print(CurrencyTab.MyGold.Gold);
        Destroy(this.gameObject);
        print("hey");
    }

}
