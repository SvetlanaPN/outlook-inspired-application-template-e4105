﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Namespace TaskManager.TaskDatabase

    Partial Public Class Task
        Inherits XPLiteObject

        Private fTaskId As Integer
        <Key(True)> _
        Public Property TaskId() As Integer
            Get
                Return fTaskId
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("TaskId", fTaskId, value)
            End Set
        End Property
        Private fPersonId As Person
        <Association("TaskReferencesPerson")> _
        Public Property PersonId() As Person
            Get
                Return fPersonId
            End Get
            Set(ByVal value As Person)
                SetPropertyValue(Of Person)("PersonId", fPersonId, value)
            End Set
        End Property
        Private fType As Integer
        Public Property Type() As Integer
            Get
                Return fType
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Type", fType, value)
            End Set
        End Property
        Private fStartDate As Date
        Public Property StartDate() As Date
            Get
                Return fStartDate
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("StartDate", fStartDate, value)
            End Set
        End Property
        Private fEndDate As Date
        Public Property EndDate() As Date
            Get
                Return fEndDate
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("EndDate", fEndDate, value)
            End Set
        End Property
        Private fAllDay As Boolean
        Public Property AllDay() As Boolean
            Get
                Return fAllDay
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("AllDay", fAllDay, value)
            End Set
        End Property
        Private fSubject As String
        Public Property Subject() As String
            Get
                Return fSubject
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Subject", fSubject, value)
            End Set
        End Property
        Private fLocation As String
        Public Property Location() As String
            Get
                Return fLocation
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Location", fLocation, value)
            End Set
        End Property
        Private fDescription As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return fDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fDescription, value)
            End Set
        End Property
        Private fStatus As Integer
        Public Property Status() As Integer
            Get
                Return fStatus
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Status", fStatus, value)
            End Set
        End Property
        Private fLabel As Integer
        Public Property Label() As Integer
            Get
                Return fLabel
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Label", fLabel, value)
            End Set
        End Property
        Private fReminderInfo As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property ReminderInfo() As String
            Get
                Return fReminderInfo
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ReminderInfo", fReminderInfo, value)
            End Set
        End Property
        Private fRecurrenceInfo As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property RecurrenceInfo() As String
            Get
                Return fRecurrenceInfo
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RecurrenceInfo", fRecurrenceInfo, value)
            End Set
        End Property
    End Class

End Namespace
