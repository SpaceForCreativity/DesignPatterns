using System;

namespace DecoratorPattern.Base
{
    public abstract class Ingredient : IIngredientGetable
    {
        private readonly IIngredientGetable ingredientGetable;


        public Ingredient(IIngredientGetable ingredientGetable)
        {
            this.ingredientGetable = ingredientGetable;
        }


        public string GetIngredient()
        {
            var internalIngridient = GetIngredientInternal();

            if (ingredientGetable == null)
                return internalIngridient;
            else
                return $"{ingredientGetable.GetIngredient()}{Environment.NewLine}{internalIngridient}";
        }


        protected abstract string GetIngredientInternal();
    }
}
