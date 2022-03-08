using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool controlling;
    public GameObject panel;
    public Material summer;
    public Material winter;
    public Text csbText;

    // Start is called before the first frame update
    void Start()
    {
        controlling = false;
        csbText.text = "Rest";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettings()
    {
        panel.SetActive(true);
    }

    public void CloseSettings()
    {
        panel.SetActive(false);
    }


    public void SeasonChange()
    {
        if (RenderSettings.skybox = summer)
        {
            RenderSettings.skybox = winter;
        }
        else
        {
            RenderSettings.skybox = summer;
        }

    }

    public void ControlSwitch()
    {
        if (!controlling)
        {
            controlling = true;
            csbText.text = "Moving";
        }
        else
        {
            controlling = false;
            csbText.text = "Rest";
        }


    }

}
