using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class przesuwanie : MonoBehaviour {

    public float max;
    public float min;
    public float speed;
    public bool x;
    public bool y;
    public bool z;

    private bool direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(x ? (direction ? wartoscBezwzgledna(speed) : wartoscBezwzgledna(speed) * -1) : 0, y ? (direction ? wartoscBezwzgledna(speed) : wartoscBezwzgledna(speed) * -1) : 0, z ? (direction ? wartoscBezwzgledna(speed) : wartoscBezwzgledna(speed) * -1) : 0));

        if (x)
        {
            if (transform.position.x >= max)
                direction = false;

            if (transform.position.x <= min)
                direction = true;
        }

        if (y)
        {
            if (transform.position.y >= max)
                direction = false;

            if (transform.position.y <= min)
                direction = true;
        }

        if (z)
        {
            if (transform.position.z >= max)
                direction = false;

            if (transform.position.z <= min)
                direction = true;
        }
    }

    float wartoscBezwzgledna(float speed0)
    {
        return speed > 0 ? speed : speed * -1;
    }

}
