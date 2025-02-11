﻿using CookiesRecipe.Recipes.Ingredients;

namespace CookiesRecipe.Interfaces;

using CookiesRecipe.Recipe;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
