using UnityEngine;

public class CharacterController : MonoBehaviour {

    public Animator animator;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetFloat("Walk", 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.left * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetFloat("Run", 1);
        }

        animator.SetFloat("Run", 0);
        animator.SetFloat("Walk", 0);

    }
}
