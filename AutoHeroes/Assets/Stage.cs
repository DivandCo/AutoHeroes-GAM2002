using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour {

    

  
    public GameObject[] enemyPrefabs;
    Vector2 WhereToSpawn;
    float RandX;
    GameObject CurrentEnemy;
    GameObject HeroeS;
    public List<HeroesScrpt> AliveHeroesList;

    int frames;
    /*
        Instantiate Units.
        access enemy script.update values, Spawn Units,
        Scaling
        Fighting Each other
        List
        Fighting stops when enemys die, heroes die or player clicks to go back to Hub
        Despawn dead object
        Stage ++ 
    */

    // Use this for initialization

    void Start () {

        frames = 0;
        FloatingDamageControl.Initialize();
       
        //hero1 = instantiate;
        //hero2 = instantiate;
        //hero3 = instantiate;

    }

    // Update is called once per frame
    void Update() {


        for (int i = 0; i < enemyPrefabs.Length; i++)
        {

            int r = Random.Range(i, enemyPrefabs.Length);

            if (CurrentEnemy == null)
            {
                RandX = Random.Range(0f, 5.4f);
                WhereToSpawn = new Vector2(RandX, transform.position.y);

                CurrentEnemy = Instantiate(enemyPrefabs[r], WhereToSpawn, Quaternion.identity);
                EnemyScript enemyOneS = CurrentEnemy.GetComponent<EnemyScript>();
                enemyOneS.Levelup(GameControl.StageNumber);


                // we make enemyOne object
                // receive the enemyscript from the enemyoneobject
                // running death from the enemyonescript on the enemyoneobject
            }
        }

        EnemyScript enemyOneScript = CurrentEnemy.GetComponent<EnemyScript>();
       
        //enemyOneScript.DamageTaken(10);

        if (enemyOneScript.CurrentHealth < 1)
        {
            enemyOneScript.Death();
            GameControl.StageNumber++;
            
            foreach (HeroesScrpt Hero in AliveHeroesList)
            {
                Hero.CurrentHealth = Hero.MaxHealth;
            }

            //if (StageNumber %10 == 0)
            {

            }
        }
     
        HeroeS = GameObject.FindGameObjectWithTag("Player");
        Summon summonnedlist = HeroeS.GetComponent<Summon>();

        AliveHeroesList = new List<HeroesScrpt>();
        foreach (GameObject Hero in summonnedlist.SummonedHeroes)
        {
            HeroesScrpt HeroScript = Hero.GetComponent<HeroesScrpt>();
            if (HeroScript.Alive)
            {
                AliveHeroesList.Add(HeroScript);
            }
        }

        //Hero Attack

        foreach (HeroesScrpt Hero in AliveHeroesList) 
        {
            if (frames % (60 / Hero.Speed) == 0)
            {
                FloatingDamageControl.CreateFloatingText(Hero.Damage.ToString(), transform);
                enemyOneScript.DamageTaken(Hero.Damage);
            }
        }
    

        // Runs 1 per 60 frames
        if (frames % 60 == 0)
        {
            if (summonnedlist.SummonedHeroes.Count > 0)
            {

                int randomnumber = Random.Range(0, AliveHeroesList.Count);
                HeroesScrpt CurrentHeroScript = AliveHeroesList[randomnumber];

                CurrentHeroScript.DamageTaken(enemyOneScript.Damage);

                CurrentHeroScript.HeroDeath();

                bool allheroesdead = true;

                foreach (GameObject Hero in summonnedlist.SummonedHeroes)
                {
                    HeroesScrpt SelectedHero = Hero.GetComponent<HeroesScrpt>();

                    if (SelectedHero.Alive == true)
                    {
                        allheroesdead = false;
                    }

                    else
                    {
                        Hero.SetActive(false);
                    }

                }

                if (allheroesdead == true)
                {

                    GameControl.StageNumber--;

                    if (GameControl.StageNumber == 0)
                    {
                        
                    }
                                           
                    foreach (GameObject DeadHero in summonnedlist.SummonedHeroes)
                    {
                        HeroesScrpt SelectedHero = DeadHero.GetComponent<HeroesScrpt>();
                        SelectedHero.CurrentHealth = SelectedHero.MaxHealth;
                        SelectedHero.Alive = true;
                        DeadHero.SetActive(true);
                    }

                }
            }
        }
        frames++;








            

        //(gameObject.GetComponent<Summon>().SummonedHeroes)

    }


    //HeroesScrpt Hero = Hero.GetCOmpenent<HeroesScrpt>();
    //enemyOneScript.DamageTaken(Hero.Damage);

    //if (enemyscript.enemyhealth == 0)
    //{
    //    enemyscript.enemydeath.death();
    //}

    //private void newStage()
    //{
    //    if all heroes == dead && Stage > 1{
    //        Stage--
    //    }

    //    if enemy == dead 
    //}
}
