﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class AdvisorTable
{
    public int AdvisorID { get; set; }
    public string AdvisorLastName { get; set; }
    public string AdvisorFirstName { get; set; }
    public string AdvisorUserName { get; set; }
    public string AdvisorLocation { get; set; }
}

public partial class AppointmentTable
{
    public int AppointmentID { get; set; }
    public System.TimeSpan AppointmentTime { get; set; }
    public System.DateTime AppointmentDate { get; set; }
    public string AppointmentReason { get; set; }
    public int AdvisorID { get; set; }
    public int StudentID { get; set; }
}

public partial class CarTable
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public System.TimeSpan CarTime { get; set; }
    public System.DateTime CarDate { get; set; }
}

public partial class EmailTable
{
    public int MSG_ID { get; set; }
    public string FromEmail { get; set; }
    public string ToEmail { get; set; }
    public string MSGtext { get; set; }
    public System.DateTime MSGdate { get; set; }
    public System.TimeSpan MSGtime { get; set; }
}

public partial class StudentTable
{
    public int StudentID { get; set; }
    public string StudentLastName { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentUserName { get; set; }
    public int StudentAdvisorID { get; set; }
}

public partial class UserTable
{
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public string UserRole { get; set; }
    public string UserEmail { get; set; }
}
