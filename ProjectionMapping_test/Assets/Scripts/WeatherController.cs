using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public float T;
    public GameObject littlerain;
    public GameObject rainmc;
    public GameObject rain;
    public GameObject bigrain;
    public GameObject snow;

    // Start is called littlerainbefore the first frame update
    void Start()
    {            
        littlerain.SetActive(false);
        rain.SetActive(false);
        rainmc.SetActive(false);
        bigrain.SetActive(false);
        snow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;

        if (T > 600 && T < 900)

        {
            rainmc.SetActive(true);
            littlerain.SetActive(true);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);
        }
        if (T > 900 && T < 1500)
        {

            rainmc.SetActive(false);
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);

        }
        if (T > 1500 && T < 1800)
        {
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(true);
        }
        if (T > 1800 && T < 2400)
        {

            rainmc.SetActive(false);
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);

        }

        if (T >2400 && T <2700)
        {
            rainmc.SetActive(true);
            littlerain.SetActive(false);
            rain.SetActive(true);
            bigrain.SetActive(false);
            snow.SetActive(false);

        }

        if (T > 2700 && T < 3300)
        {

            rainmc.SetActive(false);
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);

        }

        if (T > 3300 && T < 3600)
        {
            rainmc.SetActive(true);
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(true);
            snow.SetActive(false);
        }
        if (T > 3600)
        {
            rainmc.SetActive(false);
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);
            T = 0;
        }  
         
    } 
}
