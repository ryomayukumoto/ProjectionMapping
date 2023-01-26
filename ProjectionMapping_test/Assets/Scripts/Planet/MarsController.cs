using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MarsController : MonoBehaviour
{

    void Start()
    {
        transform.DOLocalPath
        (new[]
        {
            new Vector3(0f, 4f, 0f),
            new Vector3(7f, 0f, 0f),
            new Vector3(0f, -4f, 0f)
        },
        15f,
        PathType.CatmullRom).SetEase(Ease.Linear).SetOptions(true).SetLoops(-1, LoopType.Restart);
    }
}
