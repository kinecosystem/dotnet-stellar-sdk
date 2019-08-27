namespace kin_base.responses.results
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public class BumpSequenceSuccess : BumpSequenceResult
    {
        public override bool IsSuccess => true;
    }
}