using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class KnowledgebaseHistory
{
    public decimal? RecId { get; set; }

    public string? ChangeType { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Username { get; set; }

    public decimal SolRecId { get; set; }

    public DateTime? SolDateTimeEntered { get; set; }

    public string? SolKbcategory { get; set; }

    public string? SolUsername { get; set; }

    public string? SolErrorcode { get; set; }

    public string? SolSummary { get; set; }

    public string? SolProblem { get; set; }

    public string? SolIssuestatus { get; set; }

    public string? SolKeywords { get; set; }

    public string? SolSolutionss { get; set; }

    public string? SolSolutionst { get; set; }

    public string? SolSolutionts { get; set; }

    public string? SolProducts { get; set; }

    public string? SolAttach { get; set; }

    public string? SolValidationNotes { get; set; }

    public decimal SolDeleted { get; set; }
}
