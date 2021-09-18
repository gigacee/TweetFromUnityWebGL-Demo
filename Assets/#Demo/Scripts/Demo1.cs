using UnityEngine;
#if !UNITY_EDITOR && UNITY_WEBGL
using System.Runtime.InteropServices;
#endif

public class Demo1 : MonoBehaviour
{
#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern string TweetFromUnity(string rawMessage);
#endif

    public void Tweet()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
        TweetFromUnity("Tweet Message");
#endif
    }
}
