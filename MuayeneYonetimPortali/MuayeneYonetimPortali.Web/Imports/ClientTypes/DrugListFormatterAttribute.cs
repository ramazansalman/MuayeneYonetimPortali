using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MuayeneYonetimPortali;

public partial class DrugListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "MuayeneYonetimPortali.DrugListFormatter";

    public DrugListFormatterAttribute()
        : base(Key)
    {
    }
}