using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AllowPieceMove();
    }

    void AllowPieceMove()
    {
        RaycastHit2D rayToUp = Physics2D.Raycast(transform.position, Vector2.up, 2.2f);

        RaycastHit2D rayToDown = Physics2D.Raycast(transform.position, Vector2.down, 2.2f);

        RaycastHit2D rayToLeft = Physics2D.Raycast(transform.position, Vector2.left, 2.2f);

        RaycastHit2D rayToRight = Physics2D.Raycast(transform.position, Vector2.right, 2.2f);

        if (rayToUp.collider == gameObject.CompareTag("Piece"))
        {
            rayToUp.collider.gameObject.GetComponent<Piece>().ChangeCanMove();
        }

        if (rayToDown.collider == gameObject.CompareTag("Piece"))
        {
            rayToDown.collider.gameObject.GetComponent<Piece>().ChangeCanMove();
        }

        if (rayToLeft.collider == gameObject.CompareTag("Piece"))
        {
            rayToLeft.collider.gameObject.GetComponent<Piece>().ChangeCanMove();
        }

        if (rayToRight.collider == gameObject.CompareTag("Piece"))
        {
            rayToRight.collider.gameObject.GetComponent<Piece>().ChangeCanMove();
        }
    }
}
