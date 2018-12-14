using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroesScrpt : UnitScript {

    GameObject LevelUpObject;
    public bool Alive = false;
    public string ButtonTag;
    public int LevelGoldCost ;
    public Text NotEnoughGold;
    public float NEGold = 5f;

    public virtual void LevelUp()
    {

        LevelGoldCost = Level * 10;
       

        if (CurrencyTab.MyGold.Gold >= LevelGoldCost)
        {
            print("Hey");
            this.Level++;
            this.MaxHealth += (int)(10 * Scaling);
            this.Damage += (int)(2 * Scaling);
            this.Speed += (float)(2 / 100 * Scaling);
            this.Defence += (int)(1 * Scaling);
            CurrentHealth = this.MaxHealth;

            CurrencyTab.MyGold.Gold -= LevelGoldCost;
        }


    }


    public void HeroDeath()

    {
        if (CurrentHealth <= 0)
        {
            Alive = false;
        }
        print("HeroDeath");
    }



    public void LevelAwake()
    {
        print("Hey1");
        LevelUpObject = GameObject.FindGameObjectWithTag(ButtonTag);
        if (LevelUpObject != null)
        {
            print("hey2");
            Button LevelUpButton = LevelUpObject.GetComponent<Button>();
            LevelUpButton.onClick.AddListener(LevelUp);
        }
    }
    public void OnLevelWasLoaded()
    {
        print("Hey1");
        LevelUpObject = GameObject.FindGameObjectWithTag("HeroButtonTag");
        if (LevelUpObject != null)
        {
            print("hey2");
            Button LevelUpButton = LevelUpObject.GetComponent<Button>();
            LevelUpButton.onClick.AddListener(LevelAwake);
        }
    }

}
