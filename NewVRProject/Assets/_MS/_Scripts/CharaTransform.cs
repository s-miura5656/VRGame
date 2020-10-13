using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;

public class CharaTransform : MonoBehaviour
{
    [SerializeField] private Transform _obj = null;
    [SerializeField] private TextMesh meshText = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = _obj.rotation;

        if (meshText != null)
            meshText.text = $"{transform.rotation.eulerAngles}";
    }
}