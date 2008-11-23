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
AppVerName=iTSfv 5.60.24.1 BETA
;VersionInfoVersion=5.5.2.5
;VersionInfoTextVersion=5.5.2.5 BETA
VersionInfoCompany=BetaONE
VersionInfoDescription=iTunes Store file validator
AppPublisher=BetaONE
AppPublisherURL=https://sourceforge.net/users/mcored/
AppSupportURL=http://sourceforge.net/forum/forum.php?forum_id=729721
AppUpdatesURL=http://sourceforge.net/project/showfiles.php?group_id=204248
DefaultDirName={userdocs}\Applications\iTSfv
DefaultGroupName=BetaONE\iTSfv
AllowNoIcons=yes
InfoBeforeFile=..\iTSfv\VersionHistory.txt
;InfoAfterFile=iTSfv\VersionHistory.txt
Compression=lzma
SolidCompression=yes
PrivilegesRequired=none
OutputDir=..\..\Output\

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\iTSfv\bin\iTSfv.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\iTSfv\bin\*.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "..\iTSfv\bin\*.mp3"; DestDir: "{app}"; Flags: ignoreversion

;Source: "..\iTSfv\bin\Interop.iTunesLib.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\iTSfv"; Filename: "{app}\iTSfv.exe"
Name: "{userdesktop}\iTSfv"; Filename: "{app}\iTSfv.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\iTSfv"; Filename: "{app}\iTSfv.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\iTSfv.exe"; Description: "{cm:LaunchProgram,iTSfv}"; Flags: nowait postinstall skipifsilent
;Filename: "{app}\manual-iTSfv.pdf"; Description: "{cm:LaunchProgram,iTSfv Manual}"; Flags: nowait unchecked postinstall shellexec skipifsilent
