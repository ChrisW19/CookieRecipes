

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction()
    );
cookiesRecipesApp.Run();

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

    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteractions.PrintExistingRecipes(allRecipes);

        _recipesUserInteractions.PromptToCreateRecipe();

        var ingredients = _recipesUserInteractions.ReadIngredientsFromUser();

        if(ingredients.Count > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipes);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteractions.ShowMessage("Recipe added:");
            _recipesUserInteractions.ShowMessage(recipes.ToString());    

        } else
        {
            _recipesUserInteractions.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteractions.Exit();
    }
}



public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}

public interface IRecipesRepository
{
}

public class RecipesRepository : IRecipesRepository
{
}