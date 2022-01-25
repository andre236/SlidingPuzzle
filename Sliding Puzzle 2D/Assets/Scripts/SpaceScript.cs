using System.Collections;
using UnityEngine;

public class SpaceScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("DelayToStart");
    }

    public void AllowPieceMove()
    {
        RaycastHit2D rayToUp = Physics2D.Raycast(transform.position, Vector2.up, 2.2f);

        RaycastHit2D rayToDown = Physics2D.Raycast(transform.position, Vector2.down, 2.2f);

        RaycastHit2D rayToLeft = Physics2D.Raycast(transform.position, Vector2.left, 2.2f);

        RaycastHit2D rayToRight = Physics2D.Raycast(transform.position, Vector2.right, 2.2f);

        if (rayToUp.collider == gameObject.CompareTag("Piece"))
        {
            rayToUp.collider.gameObject.GetComponent<MovementPiece>().ChangeCanMove(true);
        }

        if (rayToDown.collider == gameObject.CompareTag("Piece"))
        {
            rayToDown.collider.gameObject.GetComponent<MovementPiece>().ChangeCanMove(true);
        }

        if (rayToLeft.collider == gameObject.CompareTag("Piece"))
        {
            rayToLeft.collider.gameObject.GetComponent<MovementPiece>().ChangeCanMove(true);
        }

        if (rayToRight.collider == gameObject.CompareTag("Piece"))
        {
            rayToRight.collider.gameObject.GetComponent<MovementPiece>().ChangeCanMove(true);
        }
    }

    private IEnumerator DelayToStart()
    {
        yield return new WaitForSeconds(0.2f);
        AllowPieceMove();
    }
}
