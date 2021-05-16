using DecoratorPattern.Base;

namespace DecoratorPattern.Ingredients
{
    public class Water : Ingredient
    {
        public Water(IIngredientGetable ingredientGetable) : base(ingredientGetable)
        {
        }

        protected override string GetIngredientInternal()
        {
            return nameof(Water);
        }
    }
}
