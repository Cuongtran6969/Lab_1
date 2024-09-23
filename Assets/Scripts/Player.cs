using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;
    public bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * Time.deltaTime * xDirection;
        if ((transform.position.x <= -4.84 && xDirection < 0) || (transform.position.x >= 6.1 && xDirection > 0))
        {
            return;
        }
        if (isFacingRight == true && xDirection == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
        if (isFacingRight == false && xDirection == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
