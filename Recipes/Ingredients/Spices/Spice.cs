namespace CookiesRecipe.Recipes.Ingredients.Spices;

public abstract class Spice : Ingredient
{
    public override string PreparationInstructions =>
        $"Take a 1/2 Teaspoon.  {base.PreparationInstructions}";
}
