using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScene : MonoBehaviour
{
    public Scene ScenePhase;
    public enum Scene
    {
        ShowScene,
        MappingScene,
        DefaultScene
    }


    protected void sceneReset()
    {
        
    }
}
