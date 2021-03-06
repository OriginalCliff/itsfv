; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Code]

function InitializeSetup(): Boolean;
var
    ErrorCode: Integer;
    NetFrameWorkInstalled : Boolean;
    Result1 : Boolean;
begin

           NetFrameWorkInstalled := RegKeyExists(HKLM,'SOFTWARE\Microsoft\.NETFramework\policy\v3.0');
           if NetFrameWorkInstalled =true then
           begin
              Result := true;
           end;
           if NetFrameWorkInstalled = false then
           begin
               NetFrameWorkInstalled := RegKeyExists(HKLM,'SOFTWARE\Microsoft\.NETFramework\policy\v2.0');
               if NetFrameWorkInstalled =true then
               begin
                  Result := true;
               end;
               if NetFrameWorkInstalled =false then
               begin
                         Result1 := MsgBox('This setup requires the .NET Framework. Please download and install the .NET Framework and run this setup again.',
                              mbInformation, MB_OKCANCEL) = idOK;
                         if Result1 =false then
                         begin
                            Result:=false;
                         end
                         else
                         begin
                              Result:=false;
                                ShellExec('open', 'http://go.microsoft.com/fwlink/?LinkId=70848', '', '', SW_SHOW, ewNoWait, ErrorCode);
                        end;
               end;
          end;
end;

[Setup]

AppName=iTSfv
AppVerName=iTSfv 5.25.0.3
VersionInfoVersion=5.25.0.3
VersionInfoTextVersion=5.25.0.3
VersionInfoCompany=BetaONE
VersionInfoDescription=iTunes Store file validator
AppPublisher=BetaONE
AppPublisherURL=https://sourceforge.net/users/mcored/
AppSupportURL=http://sourceforge.net/forum/forum.php?forum_id=729721
AppUpdatesURL=http://sourceforge.net/project/showfiles.php?group_id=204248
DefaultDirName={pf}\iTSfv
DefaultGroupName=BetaONE\iTSfv
AllowNoIcons=yes
InfoBeforeFile=iTSfv\VersionHistory.txt
InfoAfterFile=iTSfv\ReleaseNotes.txt
Compression=lzma
SolidCompression=yes
PrivilegesRequired=none

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
;src
Source: "iTSfv\*.sln"; DestDir: "{app}\src\"; Flags: ignoreversion;
Source: "iTSfv\*"; DestDir: "{app}\src\"; Flags: ignoreversion;
Source: "iTSfv\Resources\*"; DestDir: "{app}\src\Resources"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\ArtworkSearch\*"; DestDir: "{app}\src\ArtworkSearch"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\iTunesLib\*"; DestDir: "{app}\src\iTunesLib"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\Forms\*"; DestDir: "{app}\src\Forms"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\Playlists\*"; DestDir: "{app}\src\Playlists"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\Validator\*"; DestDir: "{app}\src\Validator"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\Help\*"; DestDir: "{app}\src\Help"; Flags: recursesubdirs ignoreversion;
Source: "iTSfv\My Project\*"; DestDir: "{app}\src\My Project"; Flags: recursesubdirs ignoreversion;
;binary
Source: "iTSfv\bin\iTSfv.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "iTSfv\bin\*.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "iTSfv\bin\Interop.iTunesLib.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "manual-iTSfv.pdf"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\iTSfv"; Filename: "{app}\iTSfv.exe"
;Name: "{group}\iTSfv Manual"; Filename: "{app}\manual-iTSfv.pdf"
Name: "{userdesktop}\iTSfv"; Filename: "{app}\iTSfv.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\iTSfv"; Filename: "{app}\iTSfv.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\iTSfv.exe"; Description: "{cm:LaunchProgram,iTSfv}"; Flags: nowait postinstall skipifsilent
Filename: "{app}\manual-iTSfv.pdf"; Description: "{cm:LaunchProgram,iTSfv Manual}"; Flags: nowait unchecked postinstall shellexec skipifsilent
