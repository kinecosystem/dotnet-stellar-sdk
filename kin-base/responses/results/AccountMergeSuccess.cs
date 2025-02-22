// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.results
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public class AccountMergeSuccess : AccountMergeResult
    {
        public override bool IsSuccess => true;

        /// <summary>
        /// How much got transferred from source account.
        /// </summary>
        public string SourceAccountBalance { get; set; }
    }
}
