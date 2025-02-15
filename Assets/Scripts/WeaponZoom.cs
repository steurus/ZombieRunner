using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera VCam;
    [SerializeField] StarterAssets.FirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV=20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;
    
    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }
    private void ZoomIn()
    {
        zoomedInToggle = true;
        VCam.m_Lens.FieldOfView = zoomedInFOV;
        fpsController.RotationSpeed=zoomInSensitivity;
    }
    private void ZoomOut()
    {
        zoomedInToggle=false;
        VCam.m_Lens.FieldOfView = zoomedOutFOV;
        fpsController.RotationSpeed=zoomOutSensitivity;
    }
}