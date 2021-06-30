using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometricTransformsManager : MonoBehaviour
{

    public string translateScriptName  = "LeanDragTranslate";
    public string rotateScriptName     = "LeanTwistRotate";
    public string scaleScriptName      = "LeanPinchScale";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag enter");
        //this.GetComponent(this.translateScriptName).enabled = false;
        (this.GetComponent(this.translateScriptName) as MonoBehaviour).enabled = true;
        (this.GetComponent(this.rotateScriptName) as MonoBehaviour).enabled = true;
        (this.GetComponent(this.scaleScriptName) as MonoBehaviour).enabled = true;
        Debug.Log("OnMouseDrag end");
    }

    private void OnMouseUp()
    {
        Debug.Log("onMouseUp enter");
        //this.GetComponent(this.translateScriptName).enabled = false;
        (this.GetComponent(this.translateScriptName) as MonoBehaviour).enabled = false;
        (this.GetComponent(this.rotateScriptName) as MonoBehaviour).enabled = false;
        (this.GetComponent(this.scaleScriptName) as MonoBehaviour).enabled = false;
        Debug.Log("onMouseUp end");
    }
}
