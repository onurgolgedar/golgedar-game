﻿using GolgedarEngine;

namespace GolgedarGame.GameObjects
{
   class Wall : GameObject, IPusher
   {
      public Wall() : base("Wall.png")
      {
      }

      public uint Weight => uint.MaxValue;

      public override void Draw()
      {
         DrawSelf();
      }
      public override void Loop()
      {
      }
   }
}
