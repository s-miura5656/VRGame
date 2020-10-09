using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAccel : MonoBehaviour
{
    [SerializeField] private Transform headPos;
    [SerializeField] private TextMesh meshText = null;

    private float accelValue = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        accelValue = transform.position.y - headPos.position.y;

        if (meshText != null)
            meshText.text = $"{accelValue}";

        var move = headPos.transform.forward * accelValue;

        transform.position += new Vector3(move.x, 0, move.z);
    }
}
