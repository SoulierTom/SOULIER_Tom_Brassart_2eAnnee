using System;


[Flags]
public enum Day
{
    Monday = 1 << 0,
    Tuesday = 1 << 1,
    Wednesday = 1 << 2,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}
