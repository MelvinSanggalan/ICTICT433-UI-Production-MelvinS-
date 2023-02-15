using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOnlyButton : MonoBehaviour
{
    //Melvin Sanggalan 15/02/2023

    //referencing the ui
    public GameObject uiScreenClosed;

    public void CloseScreenOnly()
    {
        //opening new ui
        uiScreenClosed.transform.gameObject.SetActive(false);
    }
}
