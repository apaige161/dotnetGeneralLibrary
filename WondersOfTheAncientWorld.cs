using System;

namespace Packt.Shared
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        //uses 1 byte per value rather than 4
        None = 0b_0000_0000,
        GreatPyramidsOfGiza = 0b_0000_0001,
        HangingGardensOfBabylon = 0b_0000_0010,
        StatueOfZuesAtOlympia = 0b_0000_0100,
        TempleOfArtemisAtEphesus = 0b_0000_1000,
        MausolemAtHalicarnassus = 0b_0001_0000,
        ColossusOfRhodes = 0b_0010_0000,
        LightHouseOfAlexandria = 0b_0100_0000
    }
}