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

    private PlayerData playerData;

    private void Start()
    {
        playerData = FindObjectOfType<PlayerData>();

        cameraTarget = GameObject.FindGameObjectWithTag(TagList.Player);

        cameraOffset = cameraTarget.transform.position - transform.position;

        enableUpdate = true;
    }

    void Update()
    {
        if (!enableUpdate)
            return;

        if (playerData.IsInConversation)
            return;

        horizontal = InputManager.Get_MouseInputX * rotationSpeed;
        cameraTarget.transform.Rotate(0, horizontal, 0);

        float desiredAngle = cameraTarget.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = cameraTarget.transform.position - (rotation * cameraOffset);

        transform.LookAt(cameraTarget.transform);

    }
}
