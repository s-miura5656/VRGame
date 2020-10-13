using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class PositionAccel : MonoBehaviour
{
    [SerializeField] private Transform headPos;
    [SerializeField] private Transform leftHandPos;
    [SerializeField] private Transform brushPos;
    [SerializeField] private TextMesh meshText = null;

    private float accelValue = 0f;
    private float boost = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        accelValue = transform.position.y - headPos.position.y;

        if (meshText != null)
            meshText.text = $"{accelValue}";

        boost += OVRInput.Get(OVRInput.RawButton.LIndexTrigger) ? 0.1f : -0.1f;

        if (boost > 10f)
        {
            boost = 10f;
        }
        else if (boost < 0)
        {
            boost = 0;
        }

        var move = headPos.transform.forward * accelValue * boost;

        transform.position += new Vector3(move.x, 0, move.z);
    }
}
