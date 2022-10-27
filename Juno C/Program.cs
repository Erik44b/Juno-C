var Bootloader = 0;
Console.WriteLine("Juno C");
Console.WriteLine("Version 27");
if (Bootloader == 27)
    Console.WriteLine("The Bootloader has been Installed Successfully.");
else if (Bootloader == 0)
    Console.WriteLine("The Bootloader has not yet been Installed.");
    Console.WriteLine("Installing Bootloader...");
    Bootloader = 27;
    if (Bootloader == 27)
        Console.WriteLine("The Bootloader has been Installed Successfully.");
Console.WriteLine("Juno C > ____");