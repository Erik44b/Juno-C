var Bootloader = 0;
var Version = "Version 27";
var VersionInt = 27;
Console.WriteLine("Juno C");
Console.WriteLine("Version 27");
if (Bootloader == VersionInt)
    Console.WriteLine("The Bootloader has been Installed Successfully.");
else if (Bootloader == 0)
    Console.WriteLine("The Bootloader has not yet been Installed.");
    Console.WriteLine("Installing Bootloader...");
    Bootloader = VersionInt;
    if (Bootloader == 27)
        Console.WriteLine("The Bootloader has been Installed Successfully.");
Console.WriteLine("Juno C >");
for (Bootloader = 27; Bootloader > 0; Bootloader = 27)
{
    var TemporaryCommand = Console.ReadLine();
    if (TemporaryCommand == "Version")
    {
        Console.WriteLine(" ");
        Console.WriteLine("Juno C");
        Console.WriteLine(Version);
    }
    else if (TemporaryCommand == "Directory")
    {
        Console.WriteLine("Directory");
        Console.WriteLine("--------------");
        Console.WriteLine("- Bootloader");
        Console.WriteLine("- Version");
        Console.WriteLine("- Directory");
    }
    else if (TemporaryCommand == "Bootloader")
    {
        Console.WriteLine("Juno C Bootloader");
        Console.WriteLine("Version 27");
        Console.WriteLine("Functions");
        Console.WriteLine(" - File Menu");
    }
    else if (TemporaryCommand == "File Menu")
    {
        Console.WriteLine("File Menu");
        Console.WriteLine("- Directory");
        Console.WriteLine("  - DirectoryLog");
        Console.WriteLine("- Version");
        Console.WriteLine("  - VersionInt");
        Console.WriteLine("- Bootloader");
        Console.WriteLine("  - File Menu");
        Console.WriteLine("  - Juno System Files");
    }
    else if (TemporaryCommand == "Juno System Files")
    {
        Console.WriteLine("This file is protected by the Juno Kernel. Access is denied.");
    }
    else if (TemporaryCommand == "Clear")
    {
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Command Not Found.");
    }

}
