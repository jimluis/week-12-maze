using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover Enter by: " + interactor.gameObject.name);
    }

    public void LogHoverExit(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover Exit by: " + interactor.gameObject.name);
    }

    public void LogSelect(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover LogSelect by: " + interactor.gameObject.name);
    }

    public void LogDeselected(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover LogDeselected by: " + interactor.gameObject.name);
    }

    public void LogActivate(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover LogActivate by: " + interactor.gameObject.name);
    }

    public void LogDeactivate(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover LogDeactivate by: " + interactor.gameObject.name);
    }

}
