﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public float speed;
    public int hour;
    public int minute;
    public float seconds;
    public int day;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        minute = 0;
        hour = 0;
        day = 1;
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime * speed;

        if (seconds >= 60)
        {
            minute += 1;
            seconds -= 60;
        }
        if (minute >= 60)
        {
            hour += 1;
            minute -= 60;
        }
        if (hour >= 24)
        {
            hour -= 24;
            day += 1;
        }
    }

    public bool isDay()
    {
        if (hour < 13)
        {
            return true;
        } else
        {
            return false;
        }
    }

}
