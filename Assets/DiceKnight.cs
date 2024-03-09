using UnityEngine;
using UnityEngine.UI;
public class DiceKnight : MonoBehaviour
{
    public Text score4;

    public void RollDice4()
    {
        int number = Random.Range(10, 24);
        score4.text = number.ToString();
    }


    public void Hit4()
    {
        int number = Random.Range(10, 24) + Random.Range(10, 24);
        FindObjectOfType<HealthEnemy>().UpdateHealthEnemy(number);

    }

    public void HitEnemy()
    {
        int numberenemy = Random.Range(12, 18);
        FindObjectOfType<Health>().UpdateHealth(numberenemy);

    }

}
