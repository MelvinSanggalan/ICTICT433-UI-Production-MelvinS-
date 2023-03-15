using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleIconBounce : MonoBehaviour
{
    public Vector3 newScale;
    public float speedTime;


    private void SideBounce()
    {
        LeanTween.scale(gameObject, newScale, speedTime).setEase(LeanTweenType.easeOutElastic);

    }

    private void Start()
    {
        SideBounce();
    }

}
