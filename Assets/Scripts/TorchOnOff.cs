using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TorchOnOff : MonoBehaviour
{ 
    private Light torchLight;
    private bool isTorchOn = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => toggleTorch());

        torchLight = GetComponentInChildren<Light>();
    }

    public void toggleTorch()
    {
        if (torchLight != null)
        {
            isTorchOn = !isTorchOn;
            torchLight.enabled = isTorchOn;
        }
    }
}
