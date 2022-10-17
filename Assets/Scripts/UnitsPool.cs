using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsPool : MonoBehaviour
{
    [SerializeField] private Transform unitsParent;
    private List<Unit> units = new List<Unit>();

    public Unit GetUnit()
    {
        foreach(var unit in units)
        {
            if (!unit.gameObject.activeSelf)
            {
                unit.gameObject.SetActive(true);
                return unit;
            }
        }
        return AddNewUnit();
    }

    private Unit AddNewUnit()
    {
        var unit = Instantiate(DataManager.DataSO.UnitPrefab, unitsParent).GetComponent<Unit>();
        units.Add(unit);
        return unit;
    }
}
