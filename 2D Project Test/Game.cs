// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("2D Test!");
            Window.SetSize(800, 800);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear Screen first
            Window.ClearBackground(Color.LightGray);

            //Draw a Rectangle
            Draw.FillColor = Color.Blue;
            Color Bluish = new Color(0, 25, 175);

            Draw.LineColor = Bluish;
            Draw.LineSize = 10.0f;

            //Vector2 rectanglePosition = new Vector2(300, 200);
            Vector2 rectangleSize = new Vector2(200, 100);
            Draw.Rectangle(Input.GetMousePosition() - rectangleSize/2, rectangleSize);

        }
    }

}
