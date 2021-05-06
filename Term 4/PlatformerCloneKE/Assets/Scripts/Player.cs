using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 velocity;
    public float jumpVelocity;
    public float gravity;

    public LayerMask wallMask;
    public LayerMask floorMask;

    private bool walk, walkLeft, walkRight, jump;
    private bool grounded = false;

    public enum PlayerState
    {
        jumping,
        idle,
        walking
    }

    private PlayerState playerState = PlayerState.idle;

    public void fall()
    {
        velocity.y = 0;
        playerState = PlayerState.jumping;
        grounded = false;
    }

    public void checkPlayerInput()
    {
        bool inputLeft = Input.GetKey(KeyCode.LeftArrow);
        bool inputRight = Input.GetKey(KeyCode.RightArrow);
        bool inputJump = Input.GetKeyDown(KeyCode.Space);

        walk = (inputLeft ^ inputRight) ;
        walkLeft = inputLeft && !inputRight;
        walkRight = inputRight && !inputLeft;
        jump = inputJump;
    }
    public void updatePlayerPos()
    {
        Vector3 pos = transform.localPosition;
        Vector3 scale = transform.localScale;

        if(walk)
        {
            if (walkLeft)
            {
                pos.x -= velocity.x * Time.deltaTime;
                scale.x = -1;
            }
            if (walkRight)
            {
                pos.x += velocity.x * Time.deltaTime;
                scale.x = 1;
            }
            pos = checkWallRays(pos, scale.x);
        }
        if (jump && playerState != PlayerState.jumping)
        {
            playerState = PlayerState.jumping;
            velocity = new Vector2(velocity.x, jumpVelocity);
        }
        if (playerState == PlayerState.jumping)
        {
            pos.y += velocity.y * Time.deltaTime;
            velocity.y -= gravity * Time.deltaTime;
        }
        if (velocity.y <= 0)
        {
            pos = checkFloorRays(pos);
        }
        if (velocity.y > 0)
        {
            pos = checkCeilingRays(pos);
        }

        transform.localPosition = pos;
        transform.localScale = scale;
    }

    public void updateAnimationState()
    {
        // GetComponent<Animator>().SetBool("state", false);

        if (grounded && !walk)
        {
            GetComponent<Animator>().SetBool("isJumping", false);
            GetComponent<Animator>().SetBool("isRunning", false);
        }
        if (grounded && walk)
        {
            GetComponent<Animator>().SetBool("isJumping", false);
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        if (playerState == PlayerState.jumping)
        {
            GetComponent<Animator>().SetBool("isJumping", true);
            GetComponent<Animator>().SetBool("isRunning", false);
        }
    }

    public Vector3 checkWallRays(Vector3 pos, float direction)
    {
        Vector2 originTop = new Vector2(pos.x + direction * 0.4f, pos.y + 1f - 0.2f);
        Vector2 originMid = new Vector2(pos.x + direction * 0.4f, pos.y);
        Vector2 originBottom = new Vector2(pos.x + direction * 0.4f, pos.y - 1f + 0.2f);

        RaycastHit2D wallTop = Physics2D.Raycast(originTop, new Vector2(direction, 0), velocity.x * Time.deltaTime, wallMask);
        RaycastHit2D wallMid = Physics2D.Raycast(originMid, new Vector2(direction, 0), velocity.x * Time.deltaTime, wallMask);
        RaycastHit2D wallBottom = Physics2D.Raycast(originBottom, new Vector2(direction, 0), velocity.x * Time.deltaTime, wallMask);

        if ((wallTop.collider != null || wallBottom.collider != null || wallMid.collider != null))
        {
            pos.x -= velocity.x * Time.deltaTime * direction;
        }

        return pos;
    }

    public Vector3 checkCeilingRays(Vector3 pos)
    {
        Vector2 originRight = new Vector2(pos.x - 0.5f + 0.2f, pos.y + 1f);
        Vector2 originMidTop = new Vector2(pos.x, pos.y + 1f);
        Vector2 originLeft = new Vector2(pos.x + 0.5f - 0.2f, pos.y + 1f);

        RaycastHit2D ceilingRight = Physics2D.Raycast(originRight, Vector2.up, velocity.y * Time.deltaTime, floorMask);
        RaycastHit2D ceilingLeft = Physics2D.Raycast(originLeft, Vector2.up, velocity.y * Time.deltaTime, floorMask);
        RaycastHit2D ceilingMid = Physics2D.Raycast(originMidTop, Vector2.up, velocity.y * Time.deltaTime, floorMask);

        if (ceilingLeft.collider != null || ceilingRight.collider != null || ceilingMid.collider != null)
        {
            RaycastHit2D hitRay = ceilingRight;
            if (ceilingLeft)
            {
                hitRay = ceilingLeft;
            }
            else if (ceilingRight)
            {
                hitRay = ceilingRight;
            }
            else if (ceilingMid)
            {
                hitRay = ceilingMid;
            }
            pos.y = hitRay.collider.bounds.center.y - hitRay.collider.bounds.size.y / 2 -1;
            fall();
        }

        return pos;
    }

    public Vector3 checkFloorRays(Vector3 pos)
    {
        Vector2 originRight = new Vector2(pos.x + 0.5f - 0.2f, pos.y - 1f);
        Vector2 originMidBottom = new Vector2(pos.x, pos.y - 1f);
        Vector2 originLeft = new Vector2(pos.x - 0.5f + 0.2f, pos.y - 1f);

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

            playerState = PlayerState.idle;
            grounded = true;
            velocity.y = 0;

            pos.y = hitRay.collider.bounds.center.y + hitRay.collider.bounds.size.y / 2 + 1;
        }
        else
        {
            if (playerState != PlayerState.jumping)
            {
                fall();
            }
        }

        return pos;
    }

    private void Start()
    {
        fall();
    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerInput();
        updatePlayerPos();
        updateAnimationState();
    }
}
