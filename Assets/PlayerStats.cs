﻿using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 20;

    void Start()
    {
        money = startMoney;
        Lives = startLives;
    }

}
