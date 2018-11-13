using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;        

    private Rigidbody2D rb2d;      

    public Button LeftButton;
    public Button RightButton;

    float moveHorizontal;
    bool IsCalled;

    public int InGameJunkCount;
    public Text InGameJunkCountText;

    public  bool gameover;

    public static PlayerController Instance;
    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
        void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        Button Left = LeftButton.GetComponent<Button>();
        Button right = RightButton.GetComponent<Button>();
    
        Left.onClick.AddListener(MoveLeft);
        right.onClick.AddListener(MoveRight);

        IsCalled = false;
        gameover = false;

        InGameJunkCount = 0;
    }

    void FixedUpdate()
    {
        
        Vector2 movement = new Vector2(moveHorizontal, 0f);
        rb2d.AddForce(movement * speed);
        if(IsCalled)
        {
            IsCalled = false;
            StartCoroutine(Example());
        }
    }

    public void MoveLeft()
    {
        moveHorizontal = -1f;
        IsCalled = true;        
    }

    public void MoveRight()
    {
        moveHorizontal = 1f;
        IsCalled = true;
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        moveHorizontal = 0f;
    }

    public void UpdateJunkValue()
    {
        InGameJunkCount++;
        InGameJunkCountText.text = "" + InGameJunkCount;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            Time.timeScale = 0;
             gameover = true;

          //  this.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Junk")
        {
            UpdateJunkValue();
            // Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}