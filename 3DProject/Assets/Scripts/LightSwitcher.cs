using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    [SerializeField] Light lightSource;
    [SerializeField] KeyCode toogleKey = KeyCode.L;
    void Update()
    {
        if(Input.GetKeyDown(toogleKey) && lightSource != null)
        {
            lightSource.enabled = !lightSource.enabled;
        }
    }
}
