using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VSIconColor : MonoBehaviour
{
    public Color startColor = Color.white;
    public Color endColor = Color.white;
    [Range(0, 10)]
    public float speed = 1;

    Image imageComp;

    private void Awake()
    {
        imageComp = GetComponent<Image>();
    }

    private void Update()
    {
        imageComp.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }

}
