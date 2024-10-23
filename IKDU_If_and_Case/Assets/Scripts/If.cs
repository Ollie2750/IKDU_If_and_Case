using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    string[] Weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    void Start()
    {
        string dayOfTheWeek = "";
        
        for (int i = 0; i < Weekdays.Length; i++)
        {

            dayOfTheWeek = Weekdays[i];
            
            if (dayOfTheWeek == "Monday") 
            { 
                Debug.Log("Important activity of the day: IKEA trip");
            }
            else if (dayOfTheWeek == "Tuesday") 
            { 
                Debug.Log("Important activity of the day: Nachos and beer with friends"); 
            }
            else if(dayOfTheWeek == "Wednesday") 
            { 
                Debug.Log("Important activity of the day: Work 16-21"); 
            }
            else if(dayOfTheWeek == "Thursday") 
            { 
                Debug.Log("Important activity of the day: Pupcrawl :)"); 
            }
            else if(dayOfTheWeek == "Friday") 
            { 
                Debug.Log("Important activity of the day: Work 14-21"); 
            }
            else if(dayOfTheWeek == "Saturday") 
            { 
                Debug.Log("Important activity of the day: Drinking with friends"); 
            }
            else if(dayOfTheWeek == "Sunday") 
            { 
                Debug.Log("Important activity of the day: More work 10-18"); 
            }
        }
    }

}
