using System;
using System.Collections.Generic;

namespace LamDucTai_2310900092.Models;

public partial class LdtEmployee
{
    public int LdtEmpId { get; set; }

    public string? LdtEmpName { get; set; }

    public string? LdtEmpLevel { get; set; }

    public DateOnly? LdtEmpStartDate { get; set; }

    public bool? LdtEmpStatus { get; set; }
}
