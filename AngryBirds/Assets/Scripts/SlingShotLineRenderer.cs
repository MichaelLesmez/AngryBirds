using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotLineRenderer : MonoBehaviour
{
    private LineRenderer _sFrontLine;
    private LineRenderer _sBackLine;
    private AngryBirdMouseController _angryBirdMouseControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        _sFrontLine = GameObject.Find("SFrontPoint").GetComponent<LineRenderer>();
        _sBackLine = GameObject.Find("SBackPoint").GetComponent<LineRenderer>();

        _angryBirdMouseControllerScript = gameObject.GetComponent<AngryBirdMouseController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_angryBirdMouseControllerScript.isAimingNow)
            EnableLineRenderer();
        else DisableLineRender();
    }
    private void EnableLineRenderer() {
        // enable line rendeerer
        _sFrontLine.enabled = true;
        _sBackLine.enabled = true;

        // draw lines
        _sFrontLine.SetPosition(0, _sFrontLine.transform.position);
        _sFrontLine.SetPosition(1, _angryBirdMouseControllerScript._myTargetJoint.transform.position);
        _sBackLine.SetPosition(0, _sBackLine.transform.position);
        _sBackLine.SetPosition(1, _angryBirdMouseControllerScript._myTargetJoint.transform.position);
    }
    private void DisableLineRender()
    {
        _sFrontLine.enabled = false;
        _sBackLine.enabled = false;
    }
}
