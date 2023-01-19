using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSceneController : SceneController
{

    private int pushCount = -1;

    public void DoUpdate()
    {
        
        if(Input.GetKeyDown("space"))
        {
            pushCount++;
            Debug.Log(pushCount);
            LayerCtrl.AddLayer(pushCount);
        }

        if(Input.GetKeyDown("escape"))
        {
            sceneReset("Show");
            pushCount = -1;
            ScenePhase = BaseScene.Scene.DefaultScene;
        }
    }
}
