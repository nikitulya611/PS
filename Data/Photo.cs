using System;
using System.Security.Cryptography.X509Certificates;

namespace MyPhotoshop
{
	public class Photo
	{
		public Photo(int _width, int _height)
        {
			width = _width;
			height = _height;
			data = new Pixel[width, height];
        }

		public Pixel this [int ind1, int ind2]
        {
			get
            {
				return data[ind1, ind2];
            }

            set
            {
				data[ind1, ind2] = value;
            }
        }

		public readonly int width;
		public readonly int height;
		private readonly Pixel[,] data;
	}
}

