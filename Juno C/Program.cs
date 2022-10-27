var Bootloader = 0;
var Version = "27";
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
var TemporaryCommand = Console.ReadLine();
if (TemporaryCommand == "Version")
{
    Console.WriteLine(" ");
    Console.WriteLine("Juno C");
    Console.WriteLine("Version 27");
}
else
{
    Console.WriteLine("Command Not Found.");
}
