using UnityEngine;
using UnityEngine.UI;
public class DiceMarc : MonoBehaviour
{
    public Text score2;
    public Text scoreEnemy;

    public void RollDice2()
    {
        int number = Random.Range(5, 11);
        score2.text = number.ToString();

        int numberenemy = Random.Range(6, 13);
        scoreEnemy.text = numberenemy.ToString();
    }

    public void Hit2()
    {
        int number = Random.Range(5, 11) + Random.Range(5, 11);
        FindObjectOfType<HealthEnemy>().UpdateHealthEnemy(number);

    }

    public void HitEnemy()
    {
        int numberenemy = Random.Range(7, 15);
        FindObjectOfType<Health>().UpdateHealth(numberenemy);

    }

}

