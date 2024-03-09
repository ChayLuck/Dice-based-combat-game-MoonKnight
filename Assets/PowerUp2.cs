using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public GameObject a1, a3;
    public GameObject aa1, aa3;
    public GameObject aaa1, aaa3;
    public GameObject aaaa1, aaaa3;
    int whichaIsOn = 1;
    int whichaaIsOn = 1;
    int whichaaaIsOn = 1;
    int whichaaaaIsOn = 1;

    public void Start()
    {

        a1.gameObject.SetActive(true);
        a3.gameObject.SetActive(false);

        aa1.gameObject.SetActive(true);
        aa3.gameObject.SetActive(false);

        aaa1.gameObject.SetActive(true);
        aaa3.gameObject.SetActive(false);

        aaaa1.gameObject.SetActive(true);
        aaaa3.gameObject.SetActive(false);


    }



    public void PowerUp()
    {

        switch (whichaIsOn)
        {
            case 1:
                whichaIsOn = 2;
                a1.gameObject.SetActive(false);
                a3.gameObject.SetActive(true);

                break;

            case 2:
                whichaIsOn = 1;
                a1.gameObject.SetActive(true);
                a3.gameObject.SetActive(false);
                break;

        }

        switch (whichaaIsOn)
        {
            case 1:
                whichaaIsOn = 2;
                aa1.gameObject.SetActive(false);
                aa3.gameObject.SetActive(true);

                break;

            case 2:
                whichaaIsOn = 1;
                aa1.gameObject.SetActive(true);
                aa3.gameObject.SetActive(false);
                break;

        }


        switch (whichaaaIsOn)
        {
            case 1:
                whichaaaIsOn = 2;
                aaa1.gameObject.SetActive(false);
                aaa3.gameObject.SetActive(true);

                break;

            case 2:
                whichaaaIsOn = 1;
                aaa1.gameObject.SetActive(true);
                aaa3.gameObject.SetActive(false);
                break;

        }

        switch (whichaaaaIsOn)
        {
            case 1:
                whichaaaaIsOn = 2;
                aaaa1.gameObject.SetActive(false);
                aaaa3.gameObject.SetActive(true);

                break;

            case 2:
                whichaaaaIsOn = 1;
                aaaa1.gameObject.SetActive(true);
                aaaa3.gameObject.SetActive(false);
                break;

        }


    }

}
