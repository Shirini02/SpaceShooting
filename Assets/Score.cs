using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    int score=0;
    private void OnCollisionEnter(Collision collision)
    {
        
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            score++;
            Destroy(collision.gameObject, 2.0f);
            print("The score is:" + score);

            //scorecalculator();

        }
        else if(collision.gameObject.CompareTag("Player"))
        {
            print("Game Over");
            print("Your score is" + transform.position.x);
            Destroy(collision.gameObject, 0);
        }
       


    }
   
    /*void scorecalculator()
    {
        score=score+1;

        print("The score is:" + score);
    }
   */

    
}
