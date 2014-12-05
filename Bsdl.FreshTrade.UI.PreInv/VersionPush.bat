/*
REM @ECHO OFF
SET hgPath=U:\Sources\Bsdl.FreshTrade
SET destfilePath="..\..\..\Properties\AssemblyInfo.cs"

IF NOT EXIST %hgPath%\NUL exit

hg id -n %hgpath% > tmpfile
set /p myvar= < tmpfile
del tmpfile

set csc="%WinDir%\Microsoft.NET\Framework\v2.0.50727\csc.exe"
%csc% /nologo /out:"%~0.exe" %0
"%~0.exe" %destfilePath% %myvar%
del "%~0.exe"
exit
*/
class Start
{
	private const string searchTextStart = "AssemblyVersion(\"";
	private const string searchTextEnd = "\")]";

	static void Main(string[] arg)
	{
		string bs = System.IO.File.ReadAllText(arg[0]);
		int posStart = bs.LastIndexOf(searchTextStart) + searchTextStart.Length;
		int posLen = bs.IndexOf(searchTextEnd, posStart) - posStart;
		int dotLastPos = bs.Substring(posStart, posLen).LastIndexOf('.') + 1;
		bs = bs.Remove(posStart + dotLastPos, posLen - dotLastPos).Insert(posStart + dotLastPos, arg[1].Replace("+", "")).TrimEnd(new char[] { '\r', '\n' });
		System.IO.File.WriteAllLines(arg[0], new string[]{bs});
	}
}
