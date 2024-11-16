namespace CookiesRecipe.Recipes.Ingredients.Spices
{
    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructins =>
            $"Take a 1/2 Teaspoon.  {base.PreparationInstructins}";
    }
}
