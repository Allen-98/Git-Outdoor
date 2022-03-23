using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationShow : MonoBehaviour
{
    private GameManager gm;
    private Animation ani;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AutoShow()
    {
        ani.Play();
    }

    public void ShowRain()
    {
        gm.Rain();
    }

    public void ShowFog()
    {
        gm.Fog();
    }

    public void ShowSnow()
    {
        gm.Snow();
    }

    public void ChangeWeather()
    {
        gm.SeasonChange();
    }


}
