using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    public GameObject Prefab;
    public Transform ParentContent;

    public void AddPref()
    {
        Instantiate(Prefab, Prefab.transform.position, Prefab.transform.rotation, ParentContent);
    }
}
