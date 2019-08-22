namespace kin_base.responses.results
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public class CreateAccountSuccess : CreateAccountResult
    {
        public override bool IsSuccess => true;
    }
}