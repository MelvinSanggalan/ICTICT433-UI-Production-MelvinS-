using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSIconBounce : MonoBehaviour
{
    public Vector3 newScale;
  
    private void Bounce()
    {
        LeanTween.scale(gameObject, newScale, 4f).setEase(LeanTweenType.easeOutBounce);
    }

    private void Start()
    {
        Bounce();
    }
}
