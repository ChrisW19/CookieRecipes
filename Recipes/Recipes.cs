using CookiesRecipe.Recipes.Ingredients;

namespace CookiesRecipe.Recipes
{
    public class Recipes
    {
        public IEnumerable<Ingredient> Ingredients { get; };

        public Recipes(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
