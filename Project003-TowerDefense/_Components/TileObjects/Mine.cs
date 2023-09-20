namespace Project003;

public class Mine : TileObject
{
    public int Damage { get; set; }
    public float Range { get; set; }
    public bool OnlyGround { get; set; }

    public Mine(TileObjects objectType, Texture2D texture) : base(objectType, texture)
    {
        BlockingBuild = true;
    }
}
