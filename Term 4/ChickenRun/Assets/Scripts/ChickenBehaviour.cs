using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChickenBehaviour : MonoBehaviour 
{
	private float speed = 0.05f;
	private int hits = 0;
	public Text hitsText;

    public GameObject carPrefab;

    void createCar()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }

        float worldHeight = Camera.main.orthographicSize * 2.0F;
        float worldWidth = worldHeight * Camera.main.aspect;

        float randomX = (worldWidth * Random.value) - worldWidth / 2.0F;
        float randomY = (worldHeight * Random.value) - worldHeight / 2.0F;

        GameObject car = (GameObject)Instantiate(carPrefab, new Vector3(randomX,randomY,0), Quaternion.identity);
        StartCoroutine(destroyCar(4.0f, car));
    }

    IEnumerator destroyCar(float delay, GameObject target)
    {
        yield return new WaitForSeconds(delay);

        Destroy(target);
    }

	// Use this for initialization
	void Start () 
	{
		hitsText.text = "Hits: 0";

        // Invoke("createCar", 1.0f);
        // Invoke("createCar", 2.0f);
        // Invoke("createCar", 3.0f);
        InvokeRepeating("createCar", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move under arrow key control
		transform.Translate(Input.GetAxis ("Horizontal") * speed, Input.GetAxis ("Vertical") * speed, 0);
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// display new hit count
		hits++;
		hitsText.text = "Hits: " + hits;

        gameObject.SetActive(false);
	}
}
