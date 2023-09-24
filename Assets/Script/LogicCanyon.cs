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
        BarrelRotationX(0f);
        BarrelRotationY(0f);
        CannonBallWeight(0f);
        CannonForce(0f);
    }

    public void BarrelRotationX(float rotationX)
    {
        Cannon.transform.localEulerAngles = new Vector3(Cannon.transform.localEulerAngles.x, rotationX, Cannon.transform.localEulerAngles.z);
        EjeXText.text = rotationX.ToString() + "°";
    }

    public void BarrelRotationY(float rotationY)
    {
        Cannon.transform.localEulerAngles = new Vector3(-rotationY, Cannon.transform.localEulerAngles.y, Cannon.transform.localEulerAngles.z);
        EjeYText.text = rotationY.ToString() + "°";
    }

    public void CannonBallWeight(float weight)
    {
        bulletWeight = weight * 0.2f + 8;
        WeightText.text = bulletWeight.ToString() + " kg";
    }

    public void CannonForce(float force)
    {
        forceCannon = force + 100;
        ForceText.text = forceCannon.ToString() + " N";
    }
}
