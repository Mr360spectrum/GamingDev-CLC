using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Vector3 _initialPosition;
    public bool _launched = false;
    private float _sitting;
    public float _power = 200;
    public GameObject greenBird; 
    string currentSceneName;

    // Update is called once per frame
    void Update()
    {
        if (_launched && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            _sitting += Time.deltaTime;
        }
        if (transform.position.y > 100 || 
            transform.position.y < -10 || 
            transform.position.x > 50 || 
            transform.position.x < -50 ||
            _sitting > 5)
        {
            currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    //When bird is clicked
    private void OnMouseDown() 
    {
        _initialPosition = transform.position;
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    
    private void OnMouseUp() 
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 directionToInitalPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitalPosition * _power);
        _launched = true;
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void OnMouseDrag() 
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPos.x, newPos.y);
    }
}