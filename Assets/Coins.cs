using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, ICollectables
{
    public void Collect()
    {
        GameManger.gameManger.Coincollected();
        Destroy(gameObject);
    }

    public float scaleTime = 2f;
    private float Scale = 1f;
    public float rotateAmount = 2f;
    public float scaleAmount = 0.005f;

    private void Start()
    {
        StartCoroutine(ScaleObject());
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, rotateAmount, 0);
        transform.localScale += new Vector3(1, 1f, 1f) * Scale * scaleAmount;
    }

    private IEnumerator ScaleObject()
    {
        yield return new WaitForSeconds(scaleTime);
        Scale = -Scale;
        yield return ScaleObject();
    }
}
