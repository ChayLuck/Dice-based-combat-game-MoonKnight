using UnityEngine;
using UnityEngine.UI;
public class DiceSteven : MonoBehaviour
{
  
    public Text score;
    public Text scoreEnemy;

   
    public void RollDice()
    {
        int number = Random.Range(1, 16);
        score.text = number.ToString();

        int numberenemy = Random.Range(6, 13);
        scoreEnemy.text = numberenemy.ToString();
    }

    public void Hit()
    {
        int number = Random.Range(1, 16);
        FindObjectOfType<HealthEnemy>().UpdateHealthEnemy(number);

    }

    public void HitEnemy()
    {
        int numberenemy = Random.Range(6, 13);
        FindObjectOfType<Health>().UpdateHealth(numberenemy);

    }


}