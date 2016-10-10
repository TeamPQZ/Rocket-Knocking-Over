using UnityEngine;
using System.Collections;

public class CameraFollowObject : MonoBehaviour
{

    public GameObject Target;
    public float Speed;
    public float XModifier;
    public float YModifier;
    public float ZModifier;
    private Vector3 XYZMod;
    

    //Dette stykke kode fungerer til formålet,
    //et 3D objekt, der kun skal bevæge sig fremad.
    //Kameraet opfører sig modsat,
    //hvis det peger bagud.

    // Use this for initialization
    void Start()
    {
        XYZMod = new Vector3(XModifier, YModifier, ZModifier);
        transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, Target.transform.position.z) + XYZMod;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform.position);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.RotateAround(Target.transform.position, new Vector3(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"), 0), Speed * Time.deltaTime);
        }
        //Nedenstående lort redder dagen, i samarbejde med LateUpdate;
    }
}
