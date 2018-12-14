using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class UnitScript : MonoBehaviour
{
    //setting unit values from inspector
    //public int level;
    //public int maxhealth;
    //public int currenthealth;
    //public int damage;
    //public int speed;
    //public int defence;
    //public float scaling;

    public Image HealthBar;
    public Text PercentHP;

    //Keeping the unit values
    public int Level;
    public int MaxHealth;
    public int CurrentHealth;
    public int Damage;
    public float Speed;
    public int Defence;
    public float Scaling;



    //public void awake()
    //{
    //    this.maxhealth = maxhealth;
    //    this.currenthealth = maxhealth;
    //    this.damage = damage;
    //    this.speed = speed;
    //    this.defence = defence;
    //    this.scaling = scaling;
    //    this.level = 1;
    //}

    public void DamageTaken(int DamageTaken)

    {
        //CurrentHealth -= (DamageTaken - Defence);
        if (Defence > DamageTaken)
        {
            CurrentHealth -= 1;
        }
        else CurrentHealth -= (DamageTaken - Defence);
    }



        //Use this for initialization

        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
        HealthBar.fillAmount = (float)CurrentHealth / MaxHealth;
        PercentHP.text = ((float)CurrentHealth / MaxHealth * 100).ToString("f0") + "%";
    }
}




