using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool waterReqMet = false;
    private bool foodReqMet = false;
    public GameObject nextSceneButton;
    public GameObject waterObj;
    public GameObject foodObj;
    private bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        //yes i did this, it felt more convient than having a bloated start area; this code just finds the corresponing objects
        //FindGamobjectWithTag didnt work but FindWithTag did? even though they are game objects
        //if (nextSceneButton == null){ nextSceneButton = GameObject.FindGameObjectWithTag("NextSceneButton"); }
        if (waterObj == null){waterObj = GameObject.FindWithTag("Water");}
        if (foodObj == null){foodObj = GameObject.FindWithTag("Food");}
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isSelected == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            isSelected = true;

            GameObject selectedGO = this.gameObject;
            print("holding this GO:" + selectedGO);

            if (selectedGO  = waterObj)
            {
                print("This is a waterObj:" + selectedGO);
            }
            if (selectedGO = foodObj)
            {
                print("This is a foodObj:" + selectedGO);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            isSelected = true;
        }
    }

    private void OnMouseUp()
    {
        isSelected = false;
    }

}
