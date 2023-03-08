using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSIconBounce : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    private void Bounce()
    {
        tranform.LeanScale(Vector2.one, 0.8f);
    }
    
    void Start()
    {
        Bounce();
    }
}
