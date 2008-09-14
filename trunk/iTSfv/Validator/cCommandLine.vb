﻿Imports CommandLineParser
Imports System.Text

Public Class cCommandLine

    Const FLAG_ADD_FILES As String = "add_files"
    Const FLAG_ADD_FOLDER As String = "add_folder"
    Const FLAG_ADJUST_RATINGS As String = "adjust_ratings"
    Const FLAG_REMOVE_DEAD As String = "remove_dead"
    Const FLAG_REMOVE_FOREIGN As String = "remove_foreign"
    Const FLAG_REMOVE_DEAD_FOREIGN As String = "remove_dead_foreign"
    Const FLAG_VALIDATE_LIBRARY As String = "validate_library"

    Private mAddFiles As Boolean = False
    Public ReadOnly Property AddFiles() As Boolean
        Get
            Return mAddFiles
        End Get
    End Property

    Private mAddFolder As Boolean = False
    Public ReadOnly Property AddFolder() As Boolean
        Get
            Return mAddFolder
        End Get
    End Property

    Private mAddFolderPath As String = ""
    Public ReadOnly Property AddFolderPath() As String
        Get
            Return mAddFolderPath
        End Get
    End Property

    Private mAdjustRatings As Boolean = False
    Public ReadOnly Property AdjustRatings() As Boolean
        Get
            Return mAdjustRatings
        End Get
    End Property

    Private mRemoveDead As Boolean = False
    Public ReadOnly Property RemoveDeadFiles() As Boolean
        Get
            Return mRemoveDead
        End Get
    End Property

    Private mRemoveForeign As Boolean = False
    Public ReadOnly Property RemoveForeignFiles() As Boolean
        Get
            Return mRemoveForeign
        End Get
    End Property

    Private mRemoveDeadForeign As Boolean = False
    Public ReadOnly Property RemoveDeadForeignFiles() As Boolean
        Get
            Return mRemoveDeadForeign
        End Get
    End Property

    Private mValidateLibrary As Boolean = False
    Public ReadOnly Property ValidateLibrary() As Boolean
        Get
            Return mValidateLibrary
        End Get
    End Property

    Public Sub New()

        '' ONLY WORKS IF ARGUMENTS ARE SET 
        If Environment.GetCommandLineArgs.Length > 1 Then

            Dim parser As New CommandLineParser.CommandLineParser
            SetupCommandLineEntries(parser)

            Dim strArgs As String = Environment.CommandLine
            strArgs = strArgs.Replace(String.Format("{0}\", Application.StartupPath), "").Trim
            strArgs = strArgs.Replace(String.Format("""{0}"" ", Application.ExecutablePath), "").Trim
            strArgs = strArgs.Replace(String.Format("""{0}"" ", Application.ExecutablePath.Replace(".EXE", ".vshost.exe")), "").Trim
            strArgs = strArgs.Replace(String.Format("""{0}"" ", Application.ExecutablePath.Replace(".exe", ".vshost.exe")), "").Trim
            strArgs = strArgs.Replace(String.Format("""{0}"" ", IO.Path.GetFileName(Application.ExecutablePath)), "").Trim
            strArgs = strArgs.Replace(String.Format("{0} ", IO.Path.GetFileName(Application.ExecutablePath)), "").Trim

            parser.CommandLine = strArgs
            msAppendDebug(String.Format("Processing Command Line: {0}", parser.CommandLine))

            If parser.Parse() Then

                msAppendDebug("Command Line parsed successfully...")

                For i As Integer = 0 To parser.Entries.Count - 1

                    Dim entry As CommandLineEntry = parser.Entries.Item(i)

                    If entry.Value.Equals(FLAG_ADD_FILES) Then
                        mAddFiles = True
                    ElseIf entry.Value.Equals(FLAG_ADD_FOLDER) Then
                        If parser.Entries.Count > 1 Then
                            i += 1
                            Dim folderPath As String = parser.Entries.Item(i).Value
                            If folderPath <> String.Empty Then
                                mAddFolder = True
                                mAddFolderPath = folderPath
                                msAppendDebug(String.Format("Command to add folder: {0}", folderPath))
                            End If
                        End If
                    ElseIf entry.Value.Equals(FLAG_ADJUST_RATINGS) Then
                        mAdjustRatings = True
                    ElseIf entry.Value.Equals(FLAG_REMOVE_DEAD) Then
                        mRemoveDead = True
                    ElseIf entry.Value.Equals(FLAG_REMOVE_FOREIGN) Then
                        mRemoveForeign = True
                    ElseIf entry.Value.Equals(FLAG_REMOVE_DEAD_FOREIGN) Then
                        mRemoveDeadForeign = True
                    ElseIf entry.Value.Equals(FLAG_VALIDATE_LIBRARY) Then
                        mValidateLibrary = True
                    End If

                Next

            Else

                For i As Integer = 0 To parser.Errors.Errors.Length - 1
                    msAppendDebug(parser.Errors.Errors(i))
                Next
                msAppendDebug(String.Format("Command Line with {0} arguments did not process.", Environment.GetCommandLineArgs.Length.ToString))

            End If

        End If

    End Sub

    Private Sub SetupCommandLineEntries(ByVal parser As CommandLineParser.CommandLineParser)

        Dim anEntry As CommandLineEntry
        ' create a flag type entry that accepts a -f (file) 
        ' flag, (meaning the next parameter is a file 
        ' name), and is required 
        anEntry = parser.CreateEntry _
           (CommandTypeEnum.Flag, FLAG_ADD_FOLDER)
        parser.Entries.Add(anEntry)

        ' store the new Entry in a local reference
        ' for use with the next CommandLineEntry's 
        ' MustFollow property.
        Dim fileEntry As CommandLineEntry
        fileEntry = anEntry

        ' now create am ExistingFile type entry that must
        ' follow the -f flag.
        anEntry = parser.CreateEntry _
        (CommandTypeEnum.ExistingFolder)
        anEntry.MustFollowEntry = fileEntry
        parser.Entries.Add(anEntry)

        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_ADD_FILES))
        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_ADJUST_RATINGS))
        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_REMOVE_DEAD))
        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_REMOVE_FOREIGN))
        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_REMOVE_DEAD_FOREIGN))
        parser.Entries.Add(parser.CreateEntry(CommandTypeEnum.Flag, FLAG_VALIDATE_LIBRARY))


    End Sub

End Class