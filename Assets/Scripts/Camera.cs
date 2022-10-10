using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    public Player target;
    private float ofset;

    private void Awake()
    {
        ofset = transform.position.y - target.transform.position.y;
    }

    private void Update()
    {
        Vector3 curPos = transform.position;
        curPos.y = target.transform.position.y + ofset;
        transform.position = curPos;
    }
}
