using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class disableHandOnGrab : MonoBehaviour
{
    public GameObject rightHandModel;
    public GameObject leftHandModel;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideHandOnGrab);
        grabInteractable.selectExited.AddListener(ShowHandOnGrab);
    }

    public void HideHandOnGrab(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        } else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowHandOnGrab(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
