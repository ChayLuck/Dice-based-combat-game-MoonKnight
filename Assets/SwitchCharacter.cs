using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject avatar1, avatar2, avatar3, avatar4;
    public GameObject dice1, dice2, dice3, dice4;
    public GameObject y1, y2, y3, y4;
    public GameObject xx1, xx2;

    int whichAvatarIsOn = 1;
    int whichDiceIsOn = 1;
    int whichYIsOn = 1;
    int whichxxIsOn = 1;
    public void Start()
    {



        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
        avatar3.gameObject.SetActive(false);
        avatar4.gameObject.SetActive(false);



        dice1.gameObject.SetActive(true);
        dice2.gameObject.SetActive(false);
        dice3.gameObject.SetActive(false);
        dice4.gameObject.SetActive(false);


      

        y1.gameObject.SetActive(true);
        y2.gameObject.SetActive(false);
        y3.gameObject.SetActive(false);
        y4.gameObject.SetActive(false);


        xx1.gameObject.SetActive(true);
        xx2.gameObject.SetActive(false);


    }

    public void SwitchAvatar()
    {

        switch (whichAvatarIsOn)
        {

            case 1:
                whichAvatarIsOn = 2;

                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                break;

            case 2:
                whichAvatarIsOn = 1;

                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                break;

            case 3:

                whichAvatarIsOn = 3;

                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(true);
                avatar4.gameObject.SetActive(false);
                break;


            case 4:

                whichAvatarIsOn = 4;

                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(true);
                break;





        }

        switch (whichDiceIsOn)
        {

            case 1:
                whichDiceIsOn = 2;
                dice1.gameObject.SetActive(false);
                dice2.gameObject.SetActive(true);
                dice3.gameObject.SetActive(false);
                dice4.gameObject.SetActive(false);

                break;

            case 2:
                whichDiceIsOn = 1;
                dice1.gameObject.SetActive(true);
                dice2.gameObject.SetActive(false);
                dice3.gameObject.SetActive(false);
                dice4.gameObject.SetActive(false);
                break;

            case 3:
                whichDiceIsOn = 3;
                dice1.gameObject.SetActive(false);
                dice2.gameObject.SetActive(false);
                dice3.gameObject.SetActive(true);
                dice4.gameObject.SetActive(false);
                break;

            case 4:
                whichDiceIsOn = 4;
                dice1.gameObject.SetActive(false);
                dice2.gameObject.SetActive(false);
                dice3.gameObject.SetActive(false);
                dice4.gameObject.SetActive(true);
                break;


        }

     

        switch (whichYIsOn)
        {

            case 1:
                whichYIsOn = 2;
                y1.gameObject.SetActive(false);
                y2.gameObject.SetActive(true);
                y3.gameObject.SetActive(false);
                y4.gameObject.SetActive(false);

                break;

            case 2:
                whichYIsOn = 1;
                y1.gameObject.SetActive(true);
                y2.gameObject.SetActive(false);
                y3.gameObject.SetActive(false);
                y4.gameObject.SetActive(false);
                break;

            case 3:
                whichYIsOn = 3;
                y1.gameObject.SetActive(false);
                y2.gameObject.SetActive(false);
                y3.gameObject.SetActive(true);
                y4.gameObject.SetActive(false);
                break;

            case 4:
                whichYIsOn = 4;
                y1.gameObject.SetActive(false);
                y2.gameObject.SetActive(false);
                y3.gameObject.SetActive(false);
                y4.gameObject.SetActive(true);
                break;


        }


        switch (whichxxIsOn)
        {

            case 1:
                whichxxIsOn = 2;
                xx1.gameObject.SetActive(false);
                xx2.gameObject.SetActive(true);


                break;

            case 2:
                whichxxIsOn = 1;
                xx1.gameObject.SetActive(true);
                xx2.gameObject.SetActive(false);
                break;

        }




    }

}

