using System;
namespace FlowerApi.Enum
{
	public static class CategoryList
	{
		public static List<String> getCategoryNames()
        {
			return new List<string>() { "flowers", "plants", "gifts", "trappings" };
        }
	}
}

