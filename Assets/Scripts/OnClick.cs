using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit didHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out didHit))
            {
                if (didHit.transform != null)
                {
                    GameObject objectInQuestion;
                    if (objectInQuestion = didHit.transform.gameObject)
                    {
                        print(objectInQuestion.transform.gameObject.name);
                        NotifyObject(objectInQuestion);
                    }
                }
            }
        }
    }
    private void NotifyObject(GameObject objectInQuestion)
    {
        objectInQuestion.SendMessage("Clicked"); 
    }
}