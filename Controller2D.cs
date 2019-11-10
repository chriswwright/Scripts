using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(BoxCollider2D))]
public class Controller2D : MonoBehaviour
{

    public GameObject tilemapGameObject;
    public GameObject tilemapScaffolding;
    Tilemap tilemap;
    Tilemap scaffolding;


    public LayerMask collisionMask;
    BoxCollider2D collider;
    RaycastOrigins raycastOrigins;

    const float skinWidth = .015f;
    public int horizontalRayCount = 4;
    public int verticalRayCount = 4;

    float horizontalRaySpacing;
    float verticalRaySpacing;
    public CollisionInfo collisions;
    public DirectionInfo direction;
    private bool drilling;
    private int drillCount = 0;


    void Start()
    {
        if (tilemapGameObject != null)
        {
            tilemap = tilemapGameObject.GetComponent<Tilemap>();
        }

        if(tilemapScaffolding != null)
        {
            scaffolding = tilemapScaffolding.GetComponent<Tilemap>();
        }

        collider = GetComponent<BoxCollider2D>();
        CalculateRaySpacing();
    }

    private void UpdateDirection()
    {
        drilling = false;
        if (Input.GetMouseButton(0)) {
            drilling = true;
        }
        if (!drilling)
        {
            drillCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            direction.left = true;
            direction.right = false;
            direction.down = false;
            direction.up = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            direction.right = true;
            direction.left = false;
            direction.down = false;
            direction.up = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            direction.down = true;
            direction.left = false;
            direction.right = false;
            direction.up = false
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            direction.down = false;
            direction.left = false;
            direction.right = false;
            direction.up = true;

        }
    }

    private void DestroyTile(Vector2 hitPoint)
    {

        if (tilemap != null && drilling == true && drillCount >= 300)
        {
          tilemap.SetTile(tilemap.WorldToCell(hitPoint), null);
            drillCount = 0;

        }

    }

    void HorizontalCollisions(ref Vector3 velocity)
    {
        float directionX = Mathf.Sign(velocity.x);
        float rayLength = Mathf.Abs(velocity.x) + skinWidth;
        for (int i = 0; i < horizontalRayCount; i++)
        {
            Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight;
            rayOrigin += Vector2.up * (horizontalRaySpacing * i);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, rayLength, collisionMask);
            Debug.DrawRay(rayOrigin, Vector2.right * directionX * rayLength, Color.red);


            if (hit && i>1 && i + 1< horizontalRayCount)
            {
                drillCount++;
                velocity.x = (hit.distance - skinWidth) * directionX;
                rayLength = hit.distance;

                collisions.left = directionX == -1;
                if (directionX == -1 && direction.left)
                {
                    Vector2 hitPoint = hit.point;
                    hitPoint.x -= .2f;
                    DestroyTile(hitPoint);
                }
                collisions.right = directionX == 1;
                if (directionX == 1 && direction.right)
                {
                    DestroyTile(hit.point);
                }
            }
        }
    }

    void VerticalCollisions(ref Vector3 velocity) {
        float directionY = Mathf.Sign(velocity.y);
        float rayLength = Mathf.Abs(velocity.y) + skinWidth;
        for (int i = 0; i < verticalRayCount; i++)
        {
            Vector2 rayOrigin = (directionY == -1) ? raycastOrigins.bottomLeft : raycastOrigins.topLeft;
            rayOrigin += Vector2.right * (verticalRaySpacing * i + velocity.x);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, rayLength, collisionMask);
            Debug.DrawRay(rayOrigin, Vector2.up * directionY * rayLength, Color.red);

            if (hit && i > 1 && i + 2 < verticalRayCount)
            {
                drillCount++;
                velocity.y = (hit.distance - skinWidth) * directionY;
                rayLength = hit.distance;

                collisions.below = directionY == -1;
                if (directionY == -1 && direction.down)
                {
                    Vector2 hitPoint = hit.point;
                    hitPoint.y -= .1f;
                    DestroyTile(hitPoint);
                }
                if (directionY == 1 && direction.up)
                {
                    Vector2 hitPoint = hit.point;
                    hitPoint.y += .1f;
                    DestroyTile(hitPoint);
                }
                collisions.above = directionY == 1;
            }
        }
    }

    void UpdateRaycastOrigins()
    {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2);

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
        raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.max.y);
        raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y);
    }

    void CalculateRaySpacing()
    {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2);

        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
        verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

        horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);
        verticalRaySpacing = bounds.size.x / (verticalRayCount - 1);
    }

    public void PlaceScaffolding()
    {
        if (Input.GetMouseButton(1) && tilemap.WorldToCell(Input.mousePosition) == null)
        {
           tilemap.SetTile(tilemap.WorldToCell(Input.GetMousePosition), tile.GetTileData(0,0))
        }
    }
    ***Check ***
    public void Move(Vector3 velocity) {
        UpdateRaycastOrigins();
        UpdateDirection();

        collisions.Reset();
        if (velocity.x != 0) {
        HorizontalCollisions(ref velocity); }
    if(velocity.y != 0) {
        VerticalCollisions(ref velocity); }

        transform.Translate(velocity);
    }

    struct RaycastOrigins
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;

    }

    public struct DirectionInfo
    {
        public bool above, down;
        public bool left, right;

        public void Reset()
        {
            above = down = false;
            left = right = false;
        }
    }

    public struct CollisionInfo {
        public bool above, below;
        public bool left, right;

        public void Reset()
        {
            above = below = false;
            left = right = false;
        }
    }


}
