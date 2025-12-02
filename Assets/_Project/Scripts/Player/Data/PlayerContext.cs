using UnityEngine;

public class PlayerContext
{
    public IInputService Input { get; }
    public Rigidbody2D Rigidbody { get; }

    public PlayerData PlayerData { get; }

    public PlayerContext(IInputService input, Rigidbody2D rigidbody, PlayerData playerData)
    {
        Input = input;
        Rigidbody = rigidbody;
        PlayerData = playerData;
    }
}
