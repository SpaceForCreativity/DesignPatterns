using DecoratorPattern.Base;

namespace DecoratorPattern.Ingredients

{
    public class Sugar : Ingredient
    {
        public Sugar(IIngredientGetable ingredientGetable) : base(ingredientGetable)
        {
        }

        protected override string GetIngredientInternal()
        {
            return nameof(Sugar);
        }
    }
}
