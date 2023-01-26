using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingSceneController : SceneController
{
    private int pushCount = -1;
    [SerializeField]
    private List<GameObject> tintinkasukasu = new List<GameObject>();
    [SerializeField]
    private GameObject LayerManager;
    public void DoUpdate()
    {
        
        if (Input.GetKeyDown("space"))
        {
            pushCount++;
            Debug.Log(pushCount);
            LayerCtrl.AddLayer(pushCount);
        }

        if(Input.GetKeyDown("return"))
        {
            foreach (GameObject obj in UnityEngine.Object.FindObjectsOfType(typeof(GameObject)))
            {
                if(obj.name == "LayerManager(MappingScene)(Clone)")
                    Destroy(obj);
            }
            pushCount = 0;
        }
    }
}
