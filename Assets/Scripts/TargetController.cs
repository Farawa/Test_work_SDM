using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] private UnitsManager unitsManager;
    [SerializeField] private LayerMask _floorLayerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, 50, _floorLayerMask))
            {
                unitsManager.SetFinishPosition(hit.point);
            }
        }
    }
}
