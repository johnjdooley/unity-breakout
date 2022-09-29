using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public enum STATE { PRELAUNCH, ACTIVE }

    public int brickRowCount = 1;
    public int brickColCount = 5;
    public float hSpacing = 2;
    public float hOffset = 1f;
    public float vSpacing = 0.5f;
    public float vOffset = 5f;


    STATE currentState = STATE.PRELAUNCH;
    Paddle paddle;
    Ball ball;
    Score score;
    Brick brick;


    void Start()
    {
        paddle = GameObject.FindWithTag("Paddle").GetComponent<Paddle>();
        ball = GameObject.FindWithTag("Ball").GetComponent<Ball>();
        score = GameObject.FindWithTag("Score").GetComponent<Score>();
        brick = transform.Find("Brick").GetComponent<Brick>();
        brick.score = score;

        SetupBricks();
    }

    void SetupBricks()
    {
        for(int y = 0; y < brickRowCount; y++){
            for(int x = 0; x < brickColCount; x++){
                Brick newBrick = Object.Instantiate(brick, new Vector3(hOffset + (x - brickColCount * 0.5f) * hSpacing, y* vSpacing + vOffset,0), Quaternion.identity);
                newBrick.gameObject.SetActive(true);
                newBrick.SetValue((y+1) * 10);
            }
        }
    }

    void Update()
    {
        if (currentState == STATE.PRELAUNCH)
        {
            UpdatePrelaunch();
        }
        else {
            UpdateActive();
        }
    }

    void UpdatePrelaunch()
    {
        ball.transform.position = paddle.transform.position + Vector3.up * 0.5f;

        if (Input.GetButtonUp("Jump"))
        {
           currentState = STATE.ACTIVE;
            ball.launch();
        }
    }

    // Update is called once per frame
    void UpdateActive()
    {
        
    }

    public void LoseLife(){
        currentState = STATE.PRELAUNCH;
        ball.disable();
    }
}
