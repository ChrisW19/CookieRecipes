using CookiesRecipe.Recipes.Ingredients.Flours;
using CookiesRecipe.Recipes.Ingredients.Spices;

namespace CookiesRecipe.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
{
    new WheatFlour(),
    new SpletFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamon(),
    new Cinnamon(),
    new CocoaPowder(),

};

    public Ingredient GetById(int id)
    {
        foreach (var ingredient in All)
        {
            if (ingredient.Id == id)
            {
                return ingredient;
            }
        }
        return null;
    }
}
