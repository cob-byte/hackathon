using UnityEngine;

public class Player : MonoBehaviour
{

   public GameManager gameManager;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    // Vector2 movement;

    // Vector3 temPos;//temporary Position


    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     //upDown
    //     //movement.x = Input.GetAxisRaw("Horizontal"); 
    //     movement.y = Input.GetAxisRaw("Vertical");
    // }

    // void FixedUpdate(){
    //     rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    // }





      // Vector2 movement;

    private SpriteRenderer spriteRenderer;
    public float moveHorizontal;
    public float moveVertical;
    public float strength = 5f;
    public float tilt = 5f;
    private Vector3 direction;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * strength;
        moveVertical = Input.GetAxis("Vertical") * strength;

        direction = new Vector2(moveHorizontal, moveVertical);

        // Update the position
        transform.position += direction * Time.deltaTime;

        // Tilt the airship based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
    }


    //public void OnCollisionEnter2D(Collision2D collision){
        //gameManager.GameOver();
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            gameManager.GameOver();
        }
        else if (other.gameObject.CompareTag("booster")) {
            gameManager.GameOver();
        }
    }
}
