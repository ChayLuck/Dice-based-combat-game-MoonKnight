using UnityEngine;
using UnityEngine.UI;
public class DiceSuit : MonoBehaviour
{
    public Text score3;

    public void RollDice3()
    {
        int number = Random.Range(5, 24);
        score3.text = number.ToString();
    }

    public void Hit3()
    {
        int number = Random.Range(5, 24) + Random.Range(5, 24);
        FindObjectOfType<HealthEnemy>().UpdateHealthEnemy(number);

    }

    public void HitEnemy()
    {
        int numberenemy = Random.Range(12, 18);
        FindObjectOfType<Health>().UpdateHealth(numberenemy);

    }

}
