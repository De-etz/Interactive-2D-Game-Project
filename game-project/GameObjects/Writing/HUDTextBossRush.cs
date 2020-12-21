﻿using game_project.ECS.Components;
using Microsoft.Xna.Framework;

namespace game_project.GameObjects.Writing
{
    public class HUDTextBossRush : TextEntity
    {
        public HUDTextBossRush(Vector2 pos, string stringToWrite, Color? color = null, float scale = 1f, bool animate = false)
        {
            GetComponent<Transform>().position = pos;
            Constants.SetLayerDepth(this, Constants.LayerDepth.Text);

            Text text = new Text(stringToWrite.ToUpper(), animate);
            text.Visible = false;
            text.Scale = scale;
            if (color == null)
            {
                text.Color = Color.White;
            }
            else
            {
                text.Color = (Color)color;
            }
            this.AddComponent(text);

            BehaviorScript script = new HUDBossRushManager();
            this.AddComponent(script);
        }

    }
}
