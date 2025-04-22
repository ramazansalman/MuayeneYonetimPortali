using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tanimlamalar.Hospitals;

public partial class DepartmentsListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "Tanimlamalar.Hospitals.DepartmentsListFormatter";

    public DepartmentsListFormatterAttribute()
        : base(Key)
    {
    }
}