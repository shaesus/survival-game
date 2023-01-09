using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    [SerializeField] private LayerMask hitLayers;

    private Camera mainCam => Camera.main;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Hit();
        }
    }

    //Переименовать метод
    private void Hit()
    {
        Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, hitLayers);
    }
}
