using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{

    private int healthEnemy = 250;
    [SerializeField] Text healthEnemyText;
   




    public void UpdateHealthEnemy(int damage)
    {

        healthEnemy -= damage;

        healthEnemyText.text = ("Can : " + healthEnemy).ToString();


    }


}
