using CookiesRecipe.Interfaces;

namespace CookiesRecipe.App;

using CookiesRecipe.Recipe;
public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteractions;

    public CookiesRecipesApp(
        IRecipesRepository recipesRepository,
        IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteractions = recipesUserInteraction;
    }

    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteractions.PrintExistingRecipes(allRecipes);

        _recipesUserInteractions.PromptToCreateRecipe();

        var ingredients = _recipesUserInteractions.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteractions.ShowMessage("Recipe added:");
            _recipesUserInteractions.ShowMessage(recipe.ToString());

        }
        else
        {
            _recipesUserInteractions.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteractions.Exit();
    }
}


