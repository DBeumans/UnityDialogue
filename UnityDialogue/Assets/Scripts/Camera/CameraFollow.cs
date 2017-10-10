using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject cameraTarget;

    [SerializeField]
    private Vector3 cameraOffset;

    private void Start()
    {
        cameraTarget = GameObject.FindGameObjectWithTag(TagList.Player);
    }

    private void FixedUpdate()
    {
        calculate();
    }

    private void calculate()
    {
        Vector3 desiredRotation;
    }

    private void perform()
    {

    }
}
