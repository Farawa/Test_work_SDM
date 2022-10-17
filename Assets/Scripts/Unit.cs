using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private float speed = 0;
    private Vector3 offset;

    private void Awake()
    {
        offset = GetComponent<MeshFilter>().sharedMesh.bounds.size.y / 2 * Vector3.up;
    }

    public void Setup(Vector3 startPosition, float speed, Vector3 targetPosition)
    {
        this.speed = speed;
        transform.position = startPosition + offset;
        StartCoroutine(MoveCoroutine(targetPosition + offset));
    }

    private IEnumerator MoveCoroutine(Vector3 targetPosition)
    {
        transform.LookAt(targetPosition + offset);

        while (true)
        {
            transform.position += (targetPosition - transform.position).normalized * speed * Time.deltaTime;
            if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
            {
                break;
            }
            yield return null;
        }
        gameObject.SetActive(false);
    }
}
