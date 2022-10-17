using UnityEngine;

public class UnitsManager : MonoBehaviour
{
    [SerializeField] private UnitsPool pool;
    private float _lastSpawnTime;
    private Vector3 _startPosition = Vector3.zero;
    private Vector3 _finishPosition;

    private void Start()
    {
        _finishPosition = _startPosition + Vector3.forward * 5f;
    }

    private void Update()
    {
        if (Time.time > _lastSpawnTime + DataManager.DataSO.SpawnDelay)
        {
            var unit = pool.GetUnit();
            var offset = unit.GetComponent<MeshFilter>().sharedMesh.bounds.size.y / 2 * Vector3.up;
            unit.Setup(_startPosition + offset, DataManager.DataSO.UnitSpeed, _finishPosition + offset);
            _lastSpawnTime = Time.time;
        }
    }
}
