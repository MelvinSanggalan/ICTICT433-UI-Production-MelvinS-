using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script created by Melvin Sanggalan on 28/03/2023


public class DeleteSaveFileScript : MonoBehaviour
{
    public GameObject saveFile;
    public GameObject deleteConfirm;
    public Button deleteConfirmYes;
    public Button deleteConfirmNo;
    
    public void DeleteButtonClicked()
    {
        deleteConfirm.SetActive(true);
        deleteConfirmYes.onClick.AddListener(DeleteFile);
        deleteConfirmNo.onClick.AddListener(CancelDelete);

    }


    public void DeleteFile()
    {
        deleteConfirmYes.onClick.RemoveListener(DeleteFile);
        deleteConfirmNo.onClick.RemoveListener(CancelDelete);
        saveFile.SetActive(false);
        deleteConfirm.SetActive(false);
    }

    public void CancelDelete()
    {
        deleteConfirmYes.onClick.RemoveListener(DeleteFile);
        deleteConfirmNo.onClick.RemoveListener(CancelDelete);
        deleteConfirm.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
