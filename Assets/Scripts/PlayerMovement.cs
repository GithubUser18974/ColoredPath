using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rg;
    public int forwardForce = 500;
    public int SwipForce = 500;
    [SerializeField]
    private GameObject centerPos;
    [SerializeField]
    private GameObject rightPos;
    [SerializeField]
    private GameObject leftPos;
    [SerializeField]
    private float gravity = -9.8f;
    public float jumpSpeed = 25;
    public Renderer mStartPos;
    [SerializeField]
    private Renderer chrone;
    [SerializeField]
    private GameObject vRoad1;
    [SerializeField]
    private GameObject vRoad2;
    public float vPosZ = 45;
    public float vPosY = -5;
    public float vPosZRate = 45;
    private float vPosYRate = -0.87f;
    private int vPlayerPos = 0; // c>0 , r>1 , l >2
    private bool vCanJump = true;
    public FairZone fairZone;
    private bool vIsDead = false;
    public GameObject vGameOverCanvas;
    public GameObject PlayerDestruction;
    private int ZoneCounter = 0;
    private static int vScore = 0;
    public ParticleSystem plusParticle;
    public Text vScoreText;
    public SwipeFourDirections vMobileInput;
    /// <summary>
    /// //////////////////
    /// </summary>
    private AudioSource vAudioSource;
    public AudioClip vCoinSound;
    public AudioClip vDeathSound;
    void Start() {
        rg = this.GetComponent<Rigidbody>();
        centerPos.SetActive(false);
        PlayerPrefs.SetInt("isover", 0);
        vScoreText.text = "" + vScore;
        vAudioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update() {
        //rg.velocity = new Vector3(0.0f, 0.0f, 0.2f);
        //  rg.AddForce(0, 0, force * Time.deltaTime);
        rg.velocity = new Vector3(rg.velocity.x, rg.velocity.y, forwardForce * Time.deltaTime);
        mMoingInput();
        if (vIsDead)
        {
            GameObject vPlayerDestruction = Instantiate(PlayerDestruction, new Vector3(transform.position.x, transform.position.y, transform.position.z - 2), transform.rotation);
            this.gameObject.SetActive(false);
            vGameOverCanvas.SetActive(true);
            rg.velocity = new Vector3(0, 0, 0);
            Debug.Log("Score " + vScore);
            PlayerPrefs.SetInt("isover", 1);
        }
    }
    void mMoingInput()
    {
        if (vMobileInput.mSwipeLeft==true || Input.GetKey(KeyCode.LeftArrow))
        {
            mMoveLeft();
        }
        else if (vMobileInput.mSwipeRight == true || Input.GetKey(KeyCode.RightArrow))
        {
            mMoveRight();
        }
        else if (vMobileInput.mSwipeUp == true || Input.GetKey(KeyCode.Space))
        {
            mMoveUp();
        }
        else { Debug.Log("noooo"); }
        
    }
    public  void mMoveLeft() {
        if (vPlayerPos == 2)
        {
            rg.velocity = new Vector3(SwipForce * Time.deltaTime, 0, 0);
        }
        else
        {
            rg.velocity = new Vector3(-1 * SwipForce * Time.deltaTime, 0, 0);

        }
    }
    public void mMoveRight() {
        if (vPlayerPos == 1)
        {
            rg.velocity = new Vector3(-1 * SwipForce * Time.deltaTime, 0, 0);
        }
        else
        {
            rg.velocity = new Vector3(SwipForce * Time.deltaTime, 0, 0);
        }
    }
    public void mMoveUp() {
        if (vCanJump)
            Launch();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "center")
        {
            rg.velocity = new Vector3(0, rg.velocity.y, forwardForce * Time.deltaTime);
            this.transform.right = centerPos.transform.right;
            leftPos.SetActive(true);
            rightPos.SetActive(true);
            centerPos.SetActive(false);
            vPlayerPos = 0;
        }
        else if (other.tag == "plus") //////////////////////////////////
        {
            vScore += 10;
            vScoreText.text = "" + vScore;
            plusParticle.Play();
            vAudioSource.clip = vCoinSound;
            vAudioSource.Play();
            
        }
        else if (other.tag == "left")
        {
            rg.velocity = new Vector3(0, rg.velocity.y, forwardForce * Time.deltaTime);
            this.transform.right = centerPos.transform.right;
            leftPos.SetActive(false);
            rightPos.SetActive(true);
            centerPos.SetActive(true);
            vPlayerPos = 2;
        }
        else if (other.tag == "right")
        {

            rg.velocity = new Vector3(0, rg.velocity.y, forwardForce * Time.deltaTime);
            this.transform.right = centerPos.transform.right;
            leftPos.SetActive(true);
            rightPos.SetActive(false);
            centerPos.SetActive(true);
            vPlayerPos = 1;
        }
        else if (other.tag == "zone1")
        {
            Debug.Log("Start Zone 1 " + vPosYRate);

            vRoad2.transform.Rotate(0, 0, 0);
            vRoad2.transform.position = new Vector3(0, vPosY, vPosZ);
            vPosZ += vPosZRate;
            other.GetComponent<BoxCollider>().enabled = false;
            vRoad2.GetComponent<BoxCollider>().enabled = true;
            fairZone.mColorZone_1();
            ZoneCounter++;

        }

    
        else if (other.tag == "zone2")
        {
         
                vRoad1.transform.position = new Vector3(0, vPosY, vPosZ);
                vPosZ += vPosZRate;
                other.GetComponent<BoxCollider>().enabled = false;
                vRoad1.GetComponent<BoxCollider>().enabled = true;
                fairZone.mColorZone_2();
                ZoneCounter++;
            
            Debug.Log("End Zone 2 " + vPosY);

        }
        else if (other.tag == "enemy")
        {

            vIsDead = true;
        }
    }
    void Launch()
    {
        vCanJump = false;
        //if (!isGound) { return; }
        Physics.gravity = Vector3.up * gravity;
        rg.useGravity = true;
        rg.velocity = CalculateLaunchData().initialVelocity;
    }
    LaunchData CalculateLaunchData()
    {
       Vector3 displacementXZ = new Vector3(0, 0, .5f);
        float displacementY = .7f;
        float time = Mathf.Sqrt(-2 * jumpSpeed / gravity) + Mathf.Sqrt(2 * (displacementY - jumpSpeed) / gravity);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * jumpSpeed);
        Vector3 velocityXZ = displacementXZ / time;

        return new LaunchData(velocityXZ + velocityY * -Mathf.Sign(gravity), time);
    }
    struct LaunchData
    {
        public readonly Vector3 initialVelocity;
        public readonly float timeToTarget;

        public LaunchData(Vector3 initialVelocity, float timeToTarget)
        {
            this.initialVelocity = initialVelocity;
            this.timeToTarget = timeToTarget;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
      
         if (collision.collider.tag == "floor")
        {
            vCanJump = true;
            if (chrone.material.color != collision.collider.gameObject.GetComponent<Renderer>().material.color)
            {

               vIsDead = true;
            }
           
        }
    }
    public int mgetScore()
    {
        return vScore;
    }
 
}
