using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // [Header("Movement")]


    TcpListener listener;
    int port = 8080;
    string receivedData;

    void Start()
    {
        listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        StartCoroutine(WaitForConnection());
    }



    IEnumerator WaitForConnection()
    {
        while (true)
        {
            if (listener.Pending())
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] bytes = new byte[1024];
                int length = stream.Read(bytes, 0, bytes.Length);
                receivedData = Encoding.ASCII.GetString(bytes, 0, length);
                Debug.Log("Received: " + receivedData);
                stream.Close();
                client.Close();
            }
            yield return null;
        }
    }

    void OnApplicationQuit()
    {
        listener.Stop();
    }


}
