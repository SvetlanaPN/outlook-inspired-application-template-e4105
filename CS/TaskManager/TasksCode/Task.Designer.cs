//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TaskManager.TaskDatabase
{

    public partial class Task : XPLiteObject
    {
        int fTaskId;
        [Key(true)]
        public int TaskId
        {
            get { return fTaskId; }
            set { SetPropertyValue<int>("TaskId", ref fTaskId, value); }
        }
        Person fPersonId;
        [Association(@"TaskReferencesPerson")]
        public Person PersonId
        {
            get { return fPersonId; }
            set { SetPropertyValue<Person>("PersonId", ref fPersonId, value); }
        }
        int fType;
        public int Type
        {
            get { return fType; }
            set { SetPropertyValue<int>("Type", ref fType, value); }
        }
        DateTime fStartDate;
        public DateTime StartDate
        {
            get { return fStartDate; }
            set { SetPropertyValue<DateTime>("StartDate", ref fStartDate, value); }
        }
        DateTime fEndDate;
        public DateTime EndDate
        {
            get { return fEndDate; }
            set { SetPropertyValue<DateTime>("EndDate", ref fEndDate, value); }
        }
        bool fAllDay;
        public bool AllDay
        {
            get { return fAllDay; }
            set { SetPropertyValue<bool>("AllDay", ref fAllDay, value); }
        }
        string fSubject;
        public string Subject
        {
            get { return fSubject; }
            set { SetPropertyValue<string>("Subject", ref fSubject, value); }
        }
        string fLocation;
        public string Location
        {
            get { return fLocation; }
            set { SetPropertyValue<string>("Location", ref fLocation, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        int fStatus;
        public int Status
        {
            get { return fStatus; }
            set { SetPropertyValue<int>("Status", ref fStatus, value); }
        }
        int fLabel;
        public int Label
        {
            get { return fLabel; }
            set { SetPropertyValue<int>("Label", ref fLabel, value); }
        }
        string fReminderInfo;
        [Size(SizeAttribute.Unlimited)]
        public string ReminderInfo
        {
            get { return fReminderInfo; }
            set { SetPropertyValue<string>("ReminderInfo", ref fReminderInfo, value); }
        }
        string fRecurrenceInfo;
        [Size(SizeAttribute.Unlimited)]
        public string RecurrenceInfo
        {
            get { return fRecurrenceInfo; }
            set { SetPropertyValue<string>("RecurrenceInfo", ref fRecurrenceInfo, value); }
        }
    }

}
