using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        Vector2 mousePos = (Vector2)camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dirVec = mousePos - (Vector2)transform.position;
        
        transform.up = dirVec.normalized;
    }
}
