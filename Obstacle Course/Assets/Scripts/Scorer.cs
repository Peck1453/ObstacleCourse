using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
 public void OnCollisionEnter(Collision other)
  {
      if(other.gameObject.tag != "Hit")
      {
      score++;

      Debug.Log($"You've bumped into a thing this many times: {score}");
      }

  }
}
