using AccessoryOptimizerLib.Models;
using LostArkLogger;
using System.Text;
using static LostArkLogger.PKTAuctionSearchResult;

Main();

void Main()
{
    bool workOutNecklace = false;
    if (workOutNecklace)
    {
        WorkoutNecklace();
    }

    bool workOutEarring = true;

    if (workOutEarring)
    {
        WorkoutEarring();
    }
}

void WorkoutNecklace()
{
    byte[] necklaceBytes = GetNecklaceData();
    necklaceBytes = RemoveFromByteArray(necklaceBytes, 10);

    byte[] buyout = GetValue(45000);
    //byte[] bid = GetValue(25000);

    byte[] engraving1 = GetValue((int)EngravingType.Peacemaker);
    byte[] engraving1Quantity = GetValue(4);

    byte[] engraving2 = GetValue((int)EngravingType.Disrespect);
    byte[] engraving2Quantity = GetValue(3);

    byte[] statType1 = GetValue((int)Stat_Type.Crit);
    byte[] statType1Quantity = GetValue(488);

    byte[] statType2 = GetValue((int)Stat_Type.Swiftness);
    byte[] statType2Quantity = GetValue(494);

    byte[] negativeEngravingType = GetValue((int)EngravingType.Move_Speed_Reduction);
    byte[] negativeEngravingQuantity = GetValue(2);

    byte[] itemId = GetValue((int)NecklaceItemIds.Radiant_Inquirer_Necklace);

    var buyout_byteToStart = Search(necklaceBytes, buyout.Reverse().ToArray());
    Console.WriteLine($"Buyout: {buyout_byteToStart}");
    //var bid_byteToStart = Search(necklaceBytes, bid.Reverse().ToArray());
    //Console.WriteLine($"Bid: {bid_byteToStart}");

    var engraving1_byteToStart = Search(necklaceBytes, engraving1.Reverse().ToArray());
    var engraving1Quantity_byteToStart = engraving1_byteToStart + 5;
    Console.WriteLine($"Engraving Type 1: {engraving1_byteToStart}");
    Console.WriteLine($"Engraving Quantity 1: {engraving1Quantity_byteToStart}");

    var engraving2_byteToStart = Search(necklaceBytes, engraving2.Reverse().ToArray());
    var engraving2Quantity_byteToStart = engraving2_byteToStart + 5;
    Console.WriteLine($"Engraving Type 2: {engraving2_byteToStart}");
    Console.WriteLine($"Engraving Quantity 2: {engraving2Quantity_byteToStart}");

    var statType1_byteToStart = Search(necklaceBytes, statType1.Reverse().ToArray());
    var statType1Quantity_byteToStart = Search(necklaceBytes, statType1Quantity.Reverse().ToArray());
    Console.WriteLine($"Stat Type 1: {statType1_byteToStart}");
    Console.WriteLine($"Stat Quantity 1: {statType1Quantity_byteToStart}");

    var statType2_byteToStart = Search(necklaceBytes, statType2.Reverse().ToArray());
    var statType2Quantity_byteToStart = Search(necklaceBytes, statType2Quantity.Reverse().ToArray());
    Console.WriteLine($"Stat Type 2: {statType2_byteToStart}");
    Console.WriteLine($"Stat Quantity 2: {statType2Quantity_byteToStart}");

    var negativeEngravingType_byteToStart = Search(necklaceBytes, negativeEngravingType.Reverse().ToArray());
    var negativeEngravingQuantity_byteToStart = negativeEngravingType_byteToStart + 9;
    Console.WriteLine($"Neg Engraving Type: {negativeEngravingType_byteToStart}");
    Console.WriteLine($"Neg Engraving Quantity: {negativeEngravingQuantity_byteToStart}");

    var itemId_byteToStart = Search(necklaceBytes, itemId.Reverse().ToArray());
    Console.WriteLine($"Item ID: {itemId_byteToStart}");
}

void WorkoutEarring()
{
    byte[] earringBytes = GetEarringData();
    earringBytes = RemoveFromByteArray(earringBytes, 10);

    byte[] buyout = GetValue(220000);
    byte[] bid = GetValue(125000);

    byte[] engraving1 = GetValue((int)EngravingType.Esoteric_Skill_Enhancement);
    byte[] engraving1Quantity = GetValue(5);

    byte[] engraving2 = GetValue((int)EngravingType.Grudge);
    byte[] engraving2Quantity = GetValue(3);

    byte[] statType1 = GetValue((int)Stat_Type.Swiftness);
    byte[] statType1Quantity = GetValue(297);

    byte[] negativeEngravingType = GetValue((int)EngravingType.Defence_Reduction);
    byte[] negativeEngravingQuantity = GetValue(3);

    byte[] itemId = GetValue(213300061);

    var buyout_byteToStart = Search(earringBytes, buyout.Reverse().ToArray());
    Console.WriteLine($"Buyout: {buyout_byteToStart}");
    var bid_byteToStart = Search(earringBytes, bid.Reverse().ToArray());
    Console.WriteLine($"Bid: {bid_byteToStart}");

    var engraving1_byteToStart = Search(earringBytes, engraving1.Reverse().ToArray());
    var engraving1Quantity_byteToStart = engraving1_byteToStart + 5;
    Console.WriteLine($"Engraving Type 1: {engraving1_byteToStart}");
    Console.WriteLine($"Engraving Quantity 1: {engraving1Quantity_byteToStart}");

    var engraving2_byteToStart = Search(earringBytes, engraving2.Reverse().ToArray());
    var engraving2Quantity_byteToStart = engraving2_byteToStart + 5;
    Console.WriteLine($"Engraving Type 2: {engraving2_byteToStart}");
    Console.WriteLine($"Engraving Quantity 2: {engraving2Quantity_byteToStart}");

    var statType1_byteToStart = Search(earringBytes, statType1.Reverse().ToArray());
    var statType1Quantity_byteToStart = Search(earringBytes, statType1Quantity.Reverse().ToArray());
    Console.WriteLine($"Stat Type 1: {statType1_byteToStart}");
    Console.WriteLine($"Stat Quantity 1: {statType1Quantity_byteToStart}");

    var negativeEngravingType_byteToStart = Search(earringBytes, negativeEngravingType.Reverse().ToArray());
    var negativeEngravingQuantity_byteToStart = negativeEngravingType_byteToStart + 9;
    Console.WriteLine($"Neg Engraving Type: {negativeEngravingType_byteToStart}");
    Console.WriteLine($"Neg Engraving Quantity: {negativeEngravingQuantity_byteToStart}");

    var itemId_byteToStart = Search(earringBytes, itemId.Reverse().ToArray());
    Console.WriteLine($"Item ID: {itemId_byteToStart}");
}

byte[] GetNecklaceData()
{
    return new byte[] { 1,0,0,0,0,0,0,0,0,0,181,110,197,5,0,0,0,0,1,64,156,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,49,233,115,2,0,0,96,48,82,179,182,12,0,0,67,0,1,0,0,0,0,0,0,0,1,0,0,0,31,24,108,23,1,0,0,0,0,0,0,0,0,0,0,0,0,5,0,0,5,0,244,1,0,0,1,1,0,0,120,0,0,0,1,0,0,0,144,1,0,0,18,0,0,0,2,240,1,0,0,244,1,0,0,1,1,0,0,120,0,0,0,1,0,0,0,144,1,0,0,15,0,0,0,2,239,1,0,0,3,0,0,0,3,3,0,0,105,0,0,0,1,0,0,0,1,0,0,0,33,3,0,0,3,1,0,0,0,5,0,0,0,2,3,0,0,105,0,0,0,1,0,0,0,5,0,0,0,121,0,0,0,3,5,0,0,0,3,0,0,0,1,3,0,0,105,0,0,0,1,0,0,0,3,0,0,0,248,0,0,0,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,200,175,0,0,0,0,0,0,0,0,208,7,0,0,0,0,0,0,64,156,0,0,0,0,0,0,230,135,250,120,154,128,0,0,20,50,5,0,0,0,0,0,1,0,0,0} ;
}

byte[] GetEarringData()
{
    return new byte[] {0,0,0,0,20,50,5,0,1,0,72,232,1,0,0,0,0,0,72,232,1,0,0,0,0,0,0,251,229,168,8,0,0,0,0,0,96,91,3,0,0,0,0,0,106,24,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18,254,12,0,0,0,0,0,1,0,0,0,183,158,201,5,0,0,96,12,93,179,182,12,0,0,46,0,1,0,0,0,0,0,0,0,1,0,0,0,31,24,108,23,1,0,0,0,0,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,0,4,0,1,0,0,0,64,1,0,0,41,1,0,0,2,240,0,0,0,44,1,0,0,1,1,0,0,18,0,0,0,1,0,0,0,105,0,0,0,3,0,0,0,3,1,0,0,0,3,0,0,0,3,8,0,0,33,3,0,0,1,0,0,0,105,0,0,0,5,0,0,0,3,5,0,0,0,5,0,0,0,2,8,46,1,127,0,0,0,1,0,0,0,105,0,0,0,3,0,0,0,3,3,0,0,0,3,0,0,0,1,8,0,0,118,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,230,167,254,36,172,177,0,0,1,0,0,0};
}

byte[] RemoveFromByteArray(byte[] src, int amountToDelete)
{
    byte[] dst = new byte[src.Length - amountToDelete];

    Array.Copy(src, amountToDelete, dst, 0, dst.Length);

    return dst;
}

int Search(byte[] src, byte[] pattern)
{
    Console.WriteLine(string.Join(",", pattern));
    int maxFirstCharSlot = src.Length - pattern.Length + 1;
    for (int i = 0; i < maxFirstCharSlot; i++)
    {
        if (src[i] != pattern[0]) // compare only first byte
            continue;

        // found a match on first byte, now try to match rest of the pattern
        for (int j = pattern.Length - 1; j >= 1; j--)
        {
            if (src[i + j] != pattern[j]) break;
            if (j == 1) return i;
        }
    }
    return -1;
}

byte[] GetValue(int intValue)
{
    byte[] intBytes = BitConverter.GetBytes(intValue);
    Array.Reverse(intBytes);
    byte[] result = intBytes;
    return result;
}

byte[] GetValue16(Int16 intValue)
{
    byte[] intBytes = BitConverter.GetBytes(intValue);
    Array.Reverse(intBytes);
    byte[] result = intBytes;
    return result;
}

uint GetInt16Value(byte[] bytes)
{
    Array.Reverse(bytes);
    uint intValue = BitConverter.ToUInt16(bytes, 0);
    return intValue;
}

uint GetInt32Value(byte[] bytes)
{
    Array.Reverse(bytes);
    uint intValue = BitConverter.ToUInt32(bytes, 0);
    return intValue;
}

long GetInt64Value(byte[] bytes)
{
    Array.Reverse(bytes);
    long intValue = BitConverter.ToInt64(bytes, 0);
    return intValue;
}