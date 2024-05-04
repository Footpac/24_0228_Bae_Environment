using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private bool waterReqMet;
    private bool foodReqMet;
    public GameObject nextSceneButton;
    public GameObject waterObj;
    public GameObject foodObj;
    public GameObject selectedGO;

    // Start is called before the first frame update
    void Start()
    {
        //yes i did this, it felt more convient than having a bloated start area; this code just finds the corresponing objects
        //FindGamobjectWithTag didnt work but FindWithTag did? even though they are game objects
        //if (nextSceneButton == null){ nextSceneButton = GameObject.FindGameObjectWithTag("NextSceneButton"); }
        if (waterObj == null){waterObj = GameObject.FindWithTag("Water");}
        if (foodObj == null){foodObj = GameObject.FindWithTag("Food");}
        if (nextSceneButton == null) { nextSceneButton = GameObject.FindWithTag("Button"); }
        waterReqMet = false;
        foodReqMet = false;
}
    
    // Update is called once per frame
    void Update()
    {
        if (selectedGO == waterObj && waterReqMet == false)
        {
            print("This is a waterObj: " + selectedGO);
            waterReqMet = true;
        }
        if (selectedGO == foodObj && foodReqMet == false)
        {
            print("This is a foodObj: " + selectedGO);
            foodReqMet = true;
        }
        if (foodReqMet && waterReqMet)
        {
            nextSceneButton.SetActive(true);

        }
    }
}
