using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float gravity;
    public Vector2 velocity;
    public bool isWalkingLeft = true;
    public LayerMask floorMask;
    public LayerMask wallMask;
    
    private bool grounded = false;

    private enum EnemyState
    {
        walking,
        falling,
        dead
    }

    private EnemyState enemyState = EnemyState.falling;

    private void OnBecameVisible()
    {
        enabled = true;
    }

    public void fall()
    {
        velocity.y = 0;
        enemyState = EnemyState.falling;
        grounded = false;
    }

    public void updateEnemyPos()
    {
        if (enemyState != EnemyState.dead)
        {
            Vector3 pos = transform.localPosition;
            Vector3 scale = transform.localScale;

            if (enemyState == EnemyState.falling)
            {
                pos.y += velocity.y * Time.deltaTime;
                velocity.y -= gravity * Time.deltaTime;
            }
            if (enemyState == EnemyState.walking)
            {
                if (isWalkingLeft)
                {
                    pos.x -= velocity.x * Time.deltaTime;
                    scale.x = -1;
                }
                else    
                {
                    pos.x += velocity.x * Time.deltaTime;
                    scale.x = 1;
                }
            }
            if (velocity.y <= 0)
            {
                pos = checkFloorRays(pos);
            }

            transform.localPosition = pos;
            transform.localScale = scale;
        }
    }

    public Vector3 checkFloorRays(Vector3 pos)
    {
        Vector2 originRight = new Vector2(pos.x + 0.5f - 0.2f, pos.y - 0.5f);
        Vector2 originMidBottom = new Vector2(pos.x, pos.y - 0.5f);
        Vector2 originLeft = new Vector2(pos.x - 0.5f + 0.2f, pos.y - 0.5f);

        RaycastHit2D floorRight = Physics2D.Raycast(originRight, Vector2.down, velocity.y * Time.deltaTime, floorMask);
        RaycastHit2D floorLeft = Physics2D.Raycast(originLeft, Vector2.down, velocity.y * Time.deltaTime, floorMask);
        RaycastHit2D floorMid = Physics2D.Raycast(originMidBottom, Vector2.down, velocity.y * Time.deltaTime, floorMask);

        if (floorLeft.collider != null || floorRight.collider != null || floorMid.collider != null)
        {
            RaycastHit2D hitRay = floorRight;
            if (floorLeft)
            {
                hitRay = floorLeft;
            }
            else if (floorRight)
            {
                hitRay = floorRight;
            }
            else if (floorMid)
            {
                hitRay = floorMid;
            }

            enemyState = EnemyState.walking;
            grounded = true;
            velocity.y = 0;

            pos.y = hitRay.collider.bounds.center.y + hitRay.collider.bounds.size.y / 2 + 0.5f;
        }
        else
        {
            if (enemyState != EnemyState.falling)
            {
                fall();
            }
        }

        return pos;
    }

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        fall();
    }

    // Update is called once per frame
    void Update()
    {
        updateEnemyPos();
    }
}
