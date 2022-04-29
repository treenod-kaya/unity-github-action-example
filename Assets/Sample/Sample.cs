using UnityEngine;
using com.game.package;

public class Sample : MonoBehaviour
{
    // test pull request
    private void Start()
    {
        int sum = RuntimeExample.Sum(1, 2);
        Debug.Log(sum);
    }
}
