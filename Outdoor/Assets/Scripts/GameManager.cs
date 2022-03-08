using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    public GameObject panel;
    public Material summer;
    public Material winter;

    // Start is called before the first frame update
    void Start()
    {
        
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

}
