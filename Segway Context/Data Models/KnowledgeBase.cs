using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class KnowledgeBase
{
    public int RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Kbcategory { get; set; }

    public string? Username { get; set; }

    public string? Errorcode { get; set; }

    public string? Summary { get; set; }

    public string? Problem { get; set; }

    public string? Issuestatus { get; set; }

    public string? Keywords { get; set; }

    public string? Solutionss { get; set; }

    public string? Solutionst { get; set; }

    public string? Solutionts { get; set; }

    public string? Products { get; set; }

    public string? Attach { get; set; }

    public string? ValidationNotes { get; set; }

    public int Deleted { get; set; }
}
