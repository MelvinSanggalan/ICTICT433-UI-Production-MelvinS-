using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    //Melvin Sanggalan 14/02/2023

    //referencing the ui
    public GameObject uiScreenNew;
    public GameObject uiScreenOld;

    public void OpenScreen()
    {
          //opening new ui and closing the previous one
          uiScreenNew.transform.gameObject.SetActive(true);
          uiScreenOld.transform.gameObject.SetActive(false);
    }

}
