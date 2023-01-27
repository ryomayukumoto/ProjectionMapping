using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public float T;
    public GameObject littlerain;
    public GameObject rain;
    public GameObject bigrain;
    public GameObject snow;

    // Start is called littlerainbefore the first frame update
    void Start()
    {            
        littlerain.SetActive(false);
        rain.SetActive(false);
        bigrain.SetActive(false);
        snow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;

        if (T > 0 && T < 10)

        {
            Debug.Log("??1");
            littlerain.SetActive(true);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);
        }
        if (T > 10 && T < 20)
        {
            Debug.Log("??2");
            littlerain.SetActive(false);
            rain.SetActive(true);
            bigrain.SetActive(false);
            snow.SetActive(false);
        }
        if (T >20 && T <30)
        {
            Debug.Log("??3");
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(true);
            snow.SetActive(false);

        }
        if (T > 30 && T < 40)
        {
            Debug.Log("??4");
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(true);
        }
        if (T > 40 && T < 50)
        {
            Debug.Log("??5");
            littlerain.SetActive(false);
            rain.SetActive(false);
            bigrain.SetActive(false);
            snow.SetActive(false);
            T = 0;
        }  
         
    } 
}
