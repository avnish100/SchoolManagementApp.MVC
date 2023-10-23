﻿using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data;

public partial class Enrollment
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ClassId { get; set; }

    public string? Grade { get; set; }

    public virtual Course? Class { get; set; }

    public virtual Lecturer? Student { get; set; }
}
