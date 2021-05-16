using DecoratorPattern.Base;

namespace DecoratorPattern.Ingredients
{
    public class TeaBag : Ingredient
    {
        public TeaBag(IIngredientGetable ingredientGetable) : base(ingredientGetable)
        {
        }

        protected override string GetIngredientInternal()
        {
            return "Tea Bag";
        }
    }
}
