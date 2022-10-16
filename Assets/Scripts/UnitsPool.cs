using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsPool : MonoBehaviour
{
    [SerializeField] private Transform unitsParent;
    private List<GameObject> units = new List<GameObject>();

    public GameObject GetUnit()
    {
        foreach(var unit in units)
        {
            if (!unit.activeSelf)
            {
                unit.SetActive(true);
                return unit;
            }
        }
        return AddNewUnit();
    }

    private GameObject AddNewUnit()
    {
        var unit = Instantiate(gameObject, unitsParent);
        units.Add(unit);
        return unit;
    }
}
