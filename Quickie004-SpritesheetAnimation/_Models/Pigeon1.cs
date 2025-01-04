using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickie004;

public class Pigeon1
{
    private static Texture2D _texture;
    private Vector2 _position;
    private readonly Animation _anim;

    public Pigeon1(Vector2 pos)
    {
        _texture ??= Globals.Content.Load<Texture2D>("pigeon_walking-Sheet");
        _anim = new(_texture, 4, 1, 0.1f);
        _position = pos;
    }

    public void Update()
    {
        _anim.Update();
    }

    public void Draw()
    {
        _anim.Draw(_position);
    }
}
