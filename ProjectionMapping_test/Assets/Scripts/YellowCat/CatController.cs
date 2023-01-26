using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CatController : MonoBehaviour
{


    void Start()
    {
        transform.DOLocalPath(
        new[]
        {
            new Vector3(2f, -2f, 0f),
            new Vector3(7f, 3.5f, 0f),
            new Vector3(-2, 2f, 0),
        },
        20f, PathType.CatmullRom).SetEase(Ease.Linear).SetOptions(true).SetLoops(-1, LoopType.Restart);

        transform.DOScale(new Vector3(0.5f, 0.5f, 1),10).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

}
