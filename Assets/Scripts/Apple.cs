﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : Items
{
    public Text playerMessage;
    public Text Stats;
    private int Intake;
    private int Karma;

    private void Awake()
    {
        Intake = 0;
        Karma = 0;
    }
    public void WriteMessage()
    {
        playerMessage.text = "You hurts me";
    }

    public void UpdateStats(int cals, int karm)
    {
        Intake += Calories;
        Karma += Karmas;
        Stats.text = "Your caloric intake is " + Intake + " and your karma is " + Karma;
        if ((Intake < -30) || (Karma < -20))
        {
            Stats.text = "You Died!";
        }


    }

    public override void UseItem()
    {
        base.UseItem();
        UpdateStats(Karma, Intake);
        WriteMessage();
        Debug.Log("Put things here");

    }
}
