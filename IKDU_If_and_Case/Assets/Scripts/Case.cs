using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    string[] Weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    void Start()
    {
        for (int i = 0; i < Weekdays.Length; i++)
        {

            switch (Weekdays[i])
            {
                case "Monday":
                    Debug.Log("Important activity of the day: IKEA trip");
                    break;
                case "Tuesday":
                    Debug.Log("Important activity of the day: Nachos and beer with friends");
                    break;
                case "Wednesday":
                    Debug.Log("Important activity of the day: Work 16-21");
                    break;
                case "Thursday":
                    Debug.Log("Important activity of the day: Pupcrawl :)");
                    break;
                case "Friday":
                    Debug.Log("Important activity of the day: Work 14-21");
                    break;
                case "Saturday":
                    Debug.Log("Important activity of the day: Drinking with friends");
                    break;
                case "Sunday":
                    Debug.Log("Important activity of the day: More work 10-18");
                    break;
            }
        }
    }

}
