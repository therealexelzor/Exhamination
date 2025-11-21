using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
  
    private Vector3 targetPos;
    private bool moving = false;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Mathf.Abs(Camera.main.transform.position.z);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            targetPos = new Vector3(worldPos.x, worldPos.y, transform.position.z);
            moving = true;
        }
    
        if (moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            if(Vector3.Distance(transform.position, targetPos) < 0.5f)
            {
                moving = false;

            } 
        }
    
    
    
        animator.SetBool("moving", moving);
    }
}