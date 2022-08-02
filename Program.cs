using System;
using Dungeons.Game.Services;
using Raylib_cs;

namespace Dungeons
{
    class Program
    {
        static void Main(string[] args)
        {
            //start game 
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
            SoundService soundService = new SoundService();
            videoService.OpenWindow();


        }
    }
}