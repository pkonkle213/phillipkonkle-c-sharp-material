using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models
{
    public class Auction
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The field title should not be blank.", MinimumLength = 0)]
        public string Title { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The field description should not be blank.", MinimumLength = 0)]
        public string Description { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The field user should not be blank.", MinimumLength = 0)]
        public string User { get; set; }

        [Required]
        [Range(1,double.MaxValue,ErrorMessage = "The field current bid should be greater than 0.")]
        public double CurrentBid { get; set; }
    }
}
