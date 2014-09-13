using UnityEngine;
using System.Collections;

public class Flavors {
	public const int blue = 1;
	public const int green = 2;
	public const int red = 3;

	private static int[] colors = new int[3]{blue,green,red};

	public static int randColor(){
		return colors[(int)(UnityEngine.Random.value * colors.Length)];
	}
}
