using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Before_AfterShowSceneController: SceneController
{

    public void DoUpdate()
    {

        if(Input.GetKeyDown("escape"))
        {
            sceneReset("Show");
            ScenePhase = BaseScene.Scene.DefaultScene;
        }
        
    }
}
