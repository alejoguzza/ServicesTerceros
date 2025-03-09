﻿using System.ComponentModel.DataAnnotations;

namespace Terceros.Applications.DTOs.People;

public class PeopleDTO
{
    [Display(Name = "message")]
    public string Message { get; set; }

    [Display(Name = "total_records")]
    public int Total_records { get; set; }

    [Display(Name = "total_pages")]
    public int Total_pages { get; set; }

    [Display(Name = "previous")]
    public string Previous { get; set; }

    [Display(Name = "next")]
    public string Next { get; set; }

    [Display(Name = "results")]
    public List<ResultDTO> Results { get; set; }

    [Display(Name = "apiVersion")]
    public string ApiVersion { get; set; }

    [Display(Name = "timestamp")]
    public string Timestamp { get; set; }

    [Display(Name = "support")]
    public SupportDTO Support { get; set; }

    [Display(Name = "social")]
    public SocialDTO Social { get; set; }
}
