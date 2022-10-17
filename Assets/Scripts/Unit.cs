using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private float speed = 0;

    public void Setup(Vector3 startPosition, float speed, Vector3 targetPosition)
    {
        this.speed = speed;
        transform.position = startPosition;
        StartCoroutine(MoveCoroutine(targetPosition));
    }

    private IEnumerator MoveCoroutine(Vector3 targetPosition)
    {
        transform.rotation.SetLookRotation(targetPosition);
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
