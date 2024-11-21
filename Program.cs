using CookiesRecipe.App;
using CookiesRecipe.DataAccess;
using CookiesRecipe.FileAccess;
using CookiesRecipe.Recipe;
using CookiesRecipe.Recipes.Ingredients;


var ingredientsRegister = new IngredientsRegister();

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";

var fileMetadata = new FileMetadata(FileName, Format);

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(stringsRepository,
                           ingredientsRegister),
    new RecipesConsoleUserInteraction(ingredientsRegister)
    );
cookiesRecipesApp.Run(fileMetadata.ToPath());