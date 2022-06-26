using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCustomizer : MonoBehaviour
{
    public Dropdown dropdown;
    public Material material;
    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        List<string> colours = new List<string>() { "Choose color", "White", "Black", "Blue", "Red" };
        dropdown.AddOptions(colours);
    }
    private void Update()
    {
        switch (dropdown.value)
        {
            case 1:
                material.color = Color.white;
                break;
            case 2:
                material.color = Color.black;
                Debug.Log("Excecuted");
                break;
            case 3:
                material.color = Color.blue;
                break;
            case 4:
                material.color = Color.red;
                break;
            default:
                material.color = Color.white;
                break;
        }
    }
    /*public void Dropdown_IndexChanged(int index)
    {
        if (index == 1)
        {
            material.color = Color.black;
        }
        else if (index == 2)
        {
            material.color = Color.blue;
            Debug.Log("Excecuted!!");
        }
        else if (index == 3)
        {
            material.color = Color.red;
        }
        else if (index == 4)
        {
            material.color = Color.green;
        }
    }*/

}
