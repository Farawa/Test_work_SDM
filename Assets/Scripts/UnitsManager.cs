using UnityEngine;

public class UnitsManager : MonoBehaviour
{
    [SerializeField] private UnitsPool _pool;
    [SerializeField] private Transform _startCircle;
    [SerializeField] private Transform _finishCircle;
    private float _lastSpawnTime;
    private Vector3 _startPosition = Vector3.zero;
    private Vector3 _finishPosition;

    private void Start()
    {
        _finishPosition = _startPosition + Vector3.forward * 5f;
        _startCircle.position = _startPosition;
    }

    private void Update()
    {
        _finishCircle.position = _finishPosition;
        if (Time.time > _lastSpawnTime + DataManager.DataSO.SpawnDelay)
        {
            var unit = _pool.GetUnit();
            unit.Setup(_startPosition, DataManager.DataSO.UnitSpeed, _finishPosition);
            _lastSpawnTime = Time.time;
        }
    }

    public void SetFinishPosition(Vector3 position)
    {
        _finishPosition = position;
    }
}
