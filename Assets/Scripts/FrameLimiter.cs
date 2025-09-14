using UnityEngine;

public class FrameLimiter : MonoBehaviour
{
    public int targetFPS = 60; // Set your desired frame rate here

    void Awake()
    {
        Application.targetFrameRate = targetFPS;
    }
}