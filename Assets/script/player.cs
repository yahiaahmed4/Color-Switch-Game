
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public float jumpforce = 8f;
    public Rigidbody2D rb;
	public SpriteRenderer sr;
	public string currentColor;
	public Color coloryahiaa;
	public Color color3zat;
	public Color colortata;
	public Color colorzoz;



	void Start()
	{
		SetRandomColor();
		
	}

	void Update()

    {
		
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)  )
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.tag == "colorchanger")
		{
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}
	
		if (col.tag != currentColor)
		{
			Debug.Log("GAME OVER!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		}

	}
	void SetRandomColor()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "yahiaa"; 
				sr.color = coloryahiaa;
				break;
			case 1:
				currentColor = "3zat";	
				sr.color = color3zat;
				break;
			case 2:
				currentColor = "tata";
				sr.color = colortata;
				break;
			case 3:
				currentColor = "zoz";
				sr.color = colorzoz;
				break;
		}
	}

}

