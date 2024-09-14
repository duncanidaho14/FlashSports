namespace FlashSportsScore.Core.FlashSports.Domain
{
    public class FlashSport
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Score Score { get; set; }
        #endregion
    }
}
