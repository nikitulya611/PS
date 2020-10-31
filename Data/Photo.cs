using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public Photo(int _width, int _height)
        {
			width = _width;
			height = _height;
			data = new Pixel[width, height];
			for (int x = 0; x < width; x++)
				for (int y = 0; y < height; y++)
					data[x, y] = new Pixel();
        }

		public readonly int width;
		public readonly int height;
		public readonly Pixel[,] data;
	}
}

