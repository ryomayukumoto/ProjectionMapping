using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSceneController : SceneController
{
    public bool IsCheck = false;
    public void CheckNextScene()
    {
        
        if(Input.GetKeyDown("s"))
        {
            IsCheck = true;
            Debug.Log("s");
           
            ScenePhase = BaseScene.Scene.ShowScene;
            InitScene("LayerManager(ShowScene)");
            IsCheck = false;
        }
        else if(Input.GetKeyDown("m"))
        {
            Debug.Log("m");
            ScenePhase = BaseScene.Scene.MappingScene;
            InitScene("LayerManager(MappingScene)");
        }
        
    }
}
