namespace CookiesRecipe.Recipes.Ingredients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string PreparationInstructins =>
            "Add to other ingredients";

    }
}
