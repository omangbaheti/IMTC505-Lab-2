using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : SubjectController
{
    float turnSpeed = 0.5f;
    private bool isLazer = false;
    private bool canRotateDrone = false;
    GameObject lazer;


    private void TurnTowards(Vector3 towardsVector)
    {
        float singleStep = turnSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, towardsVector, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection, transform.up);
        lazer = transform.GetChild(0).gameObject;
    }

    public override void MoveRight()
    {
        if (canRotateDrone)
        {
            TurnRight();
            return;
        }
        base.MoveRight();
    }
    
    public override void MoveLeft()
    {
        if (canRotateDrone)
        {
            TurnLeft();
            return;
        }
        base.MoveLeft();
    }
    
    public void TurnRight()
    {
        TurnTowards(transform.right);
    }

    public void TurnLeft()
    {
        TurnTowards(-transform.right);
    }

    public void ToggleRotation()
    {
        canRotateDrone = !canRotateDrone;
    }

    public void LazerOn()
    {
        isLazer = !isLazer;
        this.lazer.SetActive(isLazer);
        
    }

    public void LazerOff()
    {
        this.lazer.SetActive(false);
    }

    public void DestroyTarget()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 3.2f, 3, QueryTriggerInteraction.UseGlobal);
        if (hit)
        {
            Destroy(hitInfo.collider.gameObject);
        }
    }
}
