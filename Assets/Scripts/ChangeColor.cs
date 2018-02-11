using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Material[] Materials;
    public Renderer rend;

    private int index = 1;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    public void Clicked()
    {
        if (Materials.Length == 0)
        {
            return;
        }
        rend.sharedMaterial = Materials[index];
        //index += 1; 
        if (index == 0)
        {
            index = 1;
        }
        else
        {
            index = 0;
        }
        print(index);

    }
}
