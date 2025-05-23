﻿using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Patients")]
[BasedOnRow(typeof(PatientsRow), CheckNames = true)]
public class PatientsForm
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Tckn { get; set; }
    public List<object> NoteList { get; set; }
    public IsActive IsActive { get; set; }

}