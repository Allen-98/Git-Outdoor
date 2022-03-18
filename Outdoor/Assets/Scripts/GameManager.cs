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
    public GameObject rain;
    public GameObject fog;
    public GameObject snow;
    public Terrain[] terrain;
    public Material snowGround;
    public Material grassGround;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        controlling = false;
        csbText.text = "Rest";
    }

    // Update is called once per frame
    void Update()
    {
        if (rain.activeSelf || fog.activeSelf || snow.activeSelf)
        {
            light.transform.localRotation = Quaternion.Euler(new Vector3(200, 90, 90));
        }
        else
        {
            light.transform.localRotation = Quaternion.Euler(new Vector3(90, 90, 90));

        }
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
        if (RenderSettings.skybox == summer)
        {
            RenderSettings.skybox = winter;
            ChangeGround();
        }
        else
        {
            RenderSettings.skybox = summer;
            ChangeGround();
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

    public void Rain()
    {
        if (!rain.activeSelf)
        {
            rain.SetActive(true);
        }
        else
        {
            rain.SetActive(false);
        }
    }

    public void Fog()
    {
        if (!fog.activeSelf)
        {
            fog.SetActive(true);
        }
        else
        {
            fog.SetActive(false);
        }
    }

    public void Snow()
    {
        if (!snow.activeSelf)
        {
            snow.SetActive(true);
        }
        else
        {
            snow.SetActive(false);
        }
    }

    public void ChangeGround()
    {
        foreach (Terrain t in terrain)
        {
            if (t.materialTemplate == grassGround)
            {
                t.materialTemplate = snowGround;
            }
            else
            {
                t.materialTemplate = grassGround;
            }
        }
    }

}
