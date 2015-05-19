/*
REM @ECHO OFF
SET hgPath= %cd%
for /f "tokens=* delims= " %%a in ("%hgPath%") do set hgPath=%%a

echo %hgpath%
IF NOT EXIST "%hgPath%" exit 5

hg id -n "%hgpath%" > tmpfile
set /p myvar= < tmpfile
echo %myvar%
del tmpfile

set csc="%WinDir%\Microsoft.NET\Framework\v4.0.30319\csc.exe"
%csc% /nologo /out:"%~0.exe" %0

set destfile[1]="Bsdl.FreshTrade.UI.PreInv\Properties\AssemblyInfo.cs"

for /F "tokens=2 delims==" %%s in ('set destfile[') do "%~0.exe" %%s %myvar%

del "%~0.exe"
exit 0
*/
class Start
{
  private const string searchTextStart1 = "AssemblyVersion(\"";
  private const string searchTextStart2 = "AssemblyFileVersion(\"";  
  private const string searchTextEnd = "\")]";

  static string ReplaceVersion(string content, string startMarker, string endMarker, string version)
  {
    int posStart = content.LastIndexOf(startMarker) + startMarker.Length;
    int posLen = content.IndexOf(endMarker, posStart) - posStart;
    int dotLastPos = content.Substring(posStart, posLen).LastIndexOf('.') + 1;
    return content.Remove(posStart + dotLastPos, posLen - dotLastPos).Insert(posStart + dotLastPos, version.Replace("+", "")).TrimEnd(new char[] { '\r', '\n' });
  
  }
  
  static void Main(string[] arg)
  {
    string bs = System.IO.File.ReadAllText(arg[0]);
    bs = ReplaceVersion(bs, searchTextStart1, searchTextEnd, arg[1]);
    bs = ReplaceVersion(bs, searchTextStart2, searchTextEnd, arg[1]);
    System.IO.File.WriteAllLines(arg[0], new string[]{bs});
  }
}