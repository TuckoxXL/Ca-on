using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicCanyon : MonoBehaviour
{
    public float bulletWeight;
    public float forceCannon;
    public GameObject Cannon;
    public Text EjeXText;
    public Text EjeYText;
    public Text WeightText;
    public Text ForceText;

    private void Start()
    {
        RotationX(0f);
        RotationY(0f);
        BulletWeight(0f);
        CannonForce(0f);
    }

    public void RotationX(float rotationX)
    {
        Cannon.transform.localEulerAngles = new Vector3(Cannon.transform.localEulerAngles.x, rotationX, Cannon.transform.localEulerAngles.z);
        EjeXText.text = rotationX.ToString() + "°";
    }

    public void RotationY(float rotationY)
    {
        Cannon.transform.localEulerAngles = new Vector3(-rotationY, Cannon.transform.localEulerAngles.y, Cannon.transform.localEulerAngles.z);
        EjeYText.text = rotationY.ToString() + "°";
        Debug.Log("rot: " + rotationY + "euler:" + Cannon.transform.localEulerAngles.y);
    }

    public void BulletWeight(float weight)
    {
        bulletWeight = weight * 0.4f + 8;
        WeightText.text = bulletWeight.ToString() + " kg";
    }

    public void CannonForce(float force)
    {
        forceCannon = force + 100;
        ForceText.text = forceCannon.ToString() + " N";
    }
}
