using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOnlyButton : MonoBehaviour
{
    //Melvin Sanggalan 14/02/2023

    //referencing the ui
    public GameObject uiScreenOpened;

    public void OpenScreenOnly()
    {
        //opening new ui
        uiScreenOpened.transform.gameObject.SetActive(true);
    }

}
