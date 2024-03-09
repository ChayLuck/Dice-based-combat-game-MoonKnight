using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    private int health = 200;
    [SerializeField] Text healthText;





    public void UpdateHealth(int damage)
    {

        health -= damage;

        healthText.text = ("Can : " + health).ToString();


    }


}