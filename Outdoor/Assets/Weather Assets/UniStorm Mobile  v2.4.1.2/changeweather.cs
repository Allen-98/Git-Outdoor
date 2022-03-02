using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeweather : MonoBehaviour
{
    UniStormWeatherSystem_C UniStormSystem;
    // Start is called before the first frame update
    private void OnGUI()
    {
        Rect rect1 = new Rect(10, 20, 50, 30);
        Rect rect2 = new Rect(10, 60, 50, 30);
        Rect rect3 = new Rect(10, 100, 50, 30);
        Rect rect4 = new Rect(10, 140, 50, 30);
        if ( GUI.Button(rect1, "雨"))
        {
            UniStormSystem.GetComponent<UniStormWeatherSystem_C>().weatherForecaster = 12;  //雨
        }
        if (GUI.Button(rect2, "雪"))
        {
            UniStormSystem.GetComponent<UniStormWeatherSystem_C>().weatherForecaster = 3;  //雪
        }
        if (GUI.Button(rect3, "晴天"))
        {
            UniStormSystem.GetComponent<UniStormWeatherSystem_C>().weatherForecaster = 7;  //晴天
        }
        if (GUI.Button(rect4, "雾霾"))
        {
            UniStormSystem.GetComponent<UniStormWeatherSystem_C>().weatherForecaster = 1;  //雾霾
        }
    }
    void Start()
    {
        UniStormSystem = GameObject.Find("UniStormSystemEditor").GetComponent<UniStormWeatherSystem_C>();
    }
}
