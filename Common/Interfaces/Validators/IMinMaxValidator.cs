namespace Common.Interfaces.Validators
{
    public interface IMinMaxValidator
    {
        void Validate(int min, int max, string minAlias = null, string maxAlias = null);
    }
}
