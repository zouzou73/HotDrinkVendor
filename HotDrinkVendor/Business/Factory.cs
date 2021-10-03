using HotDrinkVendor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinkVendor.Business
{
    public static class Factory
    {

		private static double margin = 30;

		public static double drinkFactory(string drink)

		{
			double cost = 0;
			List<Ingredient> ingredients = new List<Ingredient>();
			switch (drink)
			{
				case "Expresso":

					ingredients.Add(new Cafe());
					ingredients.Add(new Eau());
					break;

				case "Allonge":

					ingredients.Add(new Cafe());
					ingredients.Add(new Eau());
					ingredients.Add(new Eau());
					break;

				case "Cappucino":

					ingredients.Add(new Cafe());
					ingredients.Add(new Milk());
					ingredients.Add(new Milk());
					ingredients.Add(new Eau());
					ingredients.Add(new Sucre());
					break;


				case "Chocolat":

					ingredients.Add(new Chocolat());
					ingredients.Add(new Chocolat());
					ingredients.Add(new Chocolat());
					ingredients.Add(new Milk());
					ingredients.Add(new Milk());
					ingredients.Add(new Eau());
					ingredients.Add(new Sucre());
					break;

				case "The":

					ingredients.Add(new The());
					ingredients.Add(new Eau());
					ingredients.Add(new Eau());
					break;

				default:
					throw new Exception("Unavailable Order");
					break;
			}
			foreach (var ingredient in ingredients)

			{
				cost += ingredient.Price;
			}
			return cost + cost * margin / 100;

		}
	}
}

