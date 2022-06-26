using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colours : MonoBehaviour
{
    public Dropdown dropdown;
    public Renderer[] renderers;

    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        List<string> colours = new List<string>() { "Choose color","Black", "Blue", "Red", "Grey" };
        dropdown.AddOptions(colours);
    }

    public void Dropdown_IndexChanged(int index)
    {
        if (index == 1)
        {
            for (int i = 0; i < renderers.Length; i++)
                renderers[i].material.color = Color.black;
        }
        else if (index == 2)
        {
            for (int i = 0; i < renderers.Length; i++)
                renderers[i].material.color = Color.blue;
            Debug.Log("Excecuted");
        }
        else if (index == 3)
        {
            for (int i = 0; i < renderers.Length; i++)
                renderers[i].material.color = Color.red;
        }
        else if (index == 4)
        {
            for (int i = 0; i < renderers.Length; i++)
                renderers[i].material.color = Color.white;
        }
    }
}
