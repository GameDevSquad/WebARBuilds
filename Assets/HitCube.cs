using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCube : MonoBehaviour
{
    public GameObject entryObject;

    private void OnEnable()
    {
        entryObject.SetActive(false);
    }
    private void OnDisable()
    {
        entryObject.SetActive(true);
    }
}
