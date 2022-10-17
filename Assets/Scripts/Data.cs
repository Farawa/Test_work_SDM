using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptables/Data", order = 1)]
public class Data : ScriptableObject
{
    public GameObject UnitPrefab;
    public float SpawnDelay = 2f;
    public float UnitSpeed = 2f;
}
