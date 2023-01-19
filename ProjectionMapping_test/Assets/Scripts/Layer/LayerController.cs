using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : BaseLayer
{
    void Start()
    {
        
        LayerArr = new string[4]
        {
            "Layer/Layer0",
            "Layer/Layer1",
            "Layer/Layer2",
            "Layer/Layer3"
        };
        
    }
    public void AddLayer(int counter)
    {
        if(counter < LayerArr.Length)
         Instantiate(Resources.Load(LayerArr[counter]), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }

   
}

