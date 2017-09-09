using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UVote.Models
{
    public class CandidateModel
    {
        [Required]
        [Display(Name = "Candidate ID")]
        [RegularExpression(@"^(\d{8})$")]
        public string CandidateId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [RegularExpression("[A-Za-z]+")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        [RegularExpression("[A-Za-z]+")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Manifesto")]
        public string Manifesto { get; set; }

        [Required]
        //[DataType(DataType.ImageUrl)]
        [Display(Name = "Avatar")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name ="Previous History")]
        public string PreviousHistory { get; set; }

        [Required]
        [Display(Name ="Campaign ID")]
        public string CampaignId { get; set; }

        [Required]
        public string EmployeeId { get; set; }

    }
}