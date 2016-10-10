using UnityEngine;
using System.Collections;

public class RocketMovement : MonoBehaviour {

    public float Speed;
    public float RotationSpeed;

    public int VertMod;
    public int HoriMod;
    public int RotaMod;

    public Rigidbody rb;

    //Scriptet fungerer fint, så længe spilleren 
    //kun bevæger sig ad en enkelt axis.
    //Hvis spilleren roterer 180 grader, 
    //begynder det at opføre sig lidt underligt.

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.forward * Speed * Time.deltaTime;
        transform.Rotate(new Vector3(Input.GetAxis("Vertical") * VertMod, Input.GetAxis("Horizontal") * HoriMod, Input.GetAxis("Rotational")*RotaMod) * RotationSpeed * Time.deltaTime, Space.Self);
        Debug.Log(transform.rotation.eulerAngles.x);
	}

    void OnCollisionEnter(Collision other)
    {

    }

    
}
