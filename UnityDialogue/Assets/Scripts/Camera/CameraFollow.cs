using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject cameraTarget;

    [SerializeField]
    private Vector3 cameraOffset;

    [SerializeField]
    private float rotationSpeed;

    private bool enableUpdate;

    private float horizontal;
    private float vertical;

    private CursorLockCheck cursorLockCheck;
    private PauseBehaviour pauseBehaviour;

    private void Start()
    {
        cursorLockCheck = FindObjectOfType<CursorLockCheck>();
        pauseBehaviour = FindObjectOfType<PauseBehaviour>();

        cameraTarget = GameObject.FindGameObjectWithTag(TagList.Player);

        cameraOffset = cameraTarget.transform.position - transform.position;

        enableUpdate = true;
    }

    void Update()
    {
        if (!enableUpdate)
            return;

        if (cursorLockCheck.Get_CursorActiveState)
            return;

        if (pauseBehaviour.Get_IsPaused)
            return;

        horizontal = InputManager.Get_MouseInputX * rotationSpeed;
        cameraTarget.transform.Rotate(0, horizontal, 0);

        float desiredAngle = cameraTarget.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = cameraTarget.transform.position - (rotation * cameraOffset);

        transform.LookAt(cameraTarget.transform);

    }
}
