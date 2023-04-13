using AccessoryOptimizerLib.Models;
using LostArkLogger;
using System.Text;
using static LostArkLogger.PKTAuctionSearchResult;

Main();

void Main()
{
    WorkoutNecklace();
    //WorkoutEarring();
}

void WorkoutNecklace()
{
    byte[] necklaceBytes = GetNecklaceData();
    Console.WriteLine("Length: " + necklaceBytes.Length + "\n");
    necklaceBytes = RemoveFromByteArray(necklaceBytes, 14);

    byte[] buyout = GetValue(10000);
    byte[] bid = GetValue(3000);

    byte[] engraving1 = GetValue((int)EngravingType.Full_Bloom);
    byte[] engraving1Quantity = GetValue(4);

    byte[] engraving2 = GetValue((int)EngravingType.Adrenaline);
    byte[] engraving2Quantity = GetValue(3);

    byte[] statType1 = GetValue((int)Stat_Type.Specialization);
    byte[] statType1Quantity = GetValue(498);

    byte[] statType2 = GetValue((int)Stat_Type.Endurance);
    byte[] statType2Quantity = GetValue(496);

    byte[] negativeEngravingType = GetValue((int)EngravingType.Move_Speed_Reduction);
    byte[] negativeEngravingQuantity = GetValue(2);

    byte[] itemId = GetValue((int)NecklaceItemIds.Wailing_Chaos_Necklace);

    Console.WriteLine($"Buyout: ");
    var buyout_byteToStart = Search(necklaceBytes, buyout.Reverse().ToArray());
    Console.WriteLine($"Bid: ");
    var bid_byteToStart = Search(necklaceBytes, bid.Reverse().ToArray());

    Console.WriteLine($"Engraving Type 1: ");
    var engraving1_byteToStart = Search(necklaceBytes, engraving1.Reverse().ToArray());

    Console.WriteLine($"Engraving Quantity 1: ");
    var engraving1Quantity_byteToStart = Search(necklaceBytes, engraving1Quantity.Reverse().ToArray());

    Console.WriteLine($"Engraving Type 2: ");
    var engraving2_byteToStart = Search(necklaceBytes, engraving2.Reverse().ToArray());
    Console.WriteLine($"Engraving Quantity 2: ");
    var engraving2Quantity_byteToStart = Search(necklaceBytes, engraving2Quantity.Reverse().ToArray());

    Console.WriteLine($"Stat Type 1: ");
    var statType1_byteToStart = Search(necklaceBytes, statType1.Reverse().ToArray());
    Console.WriteLine($"Stat Quantity 1: ");
    var statType1Quantity_byteToStart = Search(necklaceBytes, statType1Quantity.Reverse().ToArray());

    Console.WriteLine($"Stat Type 2: ");
    var statType2_byteToStart = Search(necklaceBytes, statType2.Reverse().ToArray());
    Console.WriteLine($"Stat Quantity 2: ");
    var statType2Quantity_byteToStart = Search(necklaceBytes, statType2Quantity.Reverse().ToArray());

    Console.WriteLine($"Neg Engraving Type: ");
    var negativeEngravingType_byteToStart = Search(necklaceBytes, negativeEngravingType.Reverse().ToArray());
    Console.WriteLine($"Neg Engraving Quantity: ");
    var negativeEngravingQuantity_byteToStart = Search(necklaceBytes, negativeEngravingQuantity.Reverse().ToArray());

    Console.WriteLine($"Item ID: ");
    var itemId_byteToStart = Search(necklaceBytes, itemId.Reverse().ToArray());
}

void WorkoutEarring()
{
    byte[] earringBytes = GetEarringData();
    Console.WriteLine("Length: " + earringBytes.Length + "\n");
    earringBytes = RemoveFromByteArray(earringBytes, 14);

    byte[] buyout = GetValue(150000);
    byte[] bid = GetValue(99999);

    byte[] engraving1 = GetValue((int)EngravingType.Full_Bloom);
    byte[] engraving1Quantity = GetValue(5);

    byte[] engraving2 = GetValue((int)EngravingType.Vital_Point_Hit);
    byte[] engraving2Quantity = GetValue(3);

    byte[] statType1 = GetValue((int)Stat_Type.Swiftness);
    byte[] statType1Quantity = GetValue(300);

    byte[] negativeEngravingType = GetValue((int)EngravingType.Atk_Speed_Reduction);
    byte[] negativeEngravingQuantity = GetValue(3);

    byte[] itemId = GetValue((int)EarringItemIds.Wailing_Chaos_Earrings);


    Console.WriteLine($"Buyout: ");
    var buyout_byteToStart = Search(earringBytes, buyout.Reverse().ToArray());
    Console.WriteLine($"Bid: ");
    var bid_byteToStart = Search(earringBytes, bid.Reverse().ToArray());

    Console.WriteLine($"Engraving Type 1: ");
    var engraving1_byteToStart = Search(earringBytes, engraving1.Reverse().ToArray());

    Console.WriteLine($"Engraving Quantity 1: ");
    var engraving1Quantity_byteToStart = Search(earringBytes, engraving1Quantity.Reverse().ToArray());

    Console.WriteLine($"Engraving Type 2: ");
    var engraving2_byteToStart = Search(earringBytes, engraving2.Reverse().ToArray());
    Console.WriteLine($"Engraving Quantity 2: ");
    var engraving2Quantity_byteToStart = Search(earringBytes, engraving2Quantity.Reverse().ToArray());

    Console.WriteLine($"Stat Type 1: ");
    var statType1_byteToStart = Search(earringBytes, statType1.Reverse().ToArray());
    Console.WriteLine($"Stat Quantity 1: ");
    var statType1Quantity_byteToStart = Search(earringBytes, statType1Quantity.Reverse().ToArray());

    Console.WriteLine($"Neg Engraving Type: ");
    var negativeEngravingType_byteToStart = Search(earringBytes, negativeEngravingType.Reverse().ToArray());
    Console.WriteLine($"Neg Engraving Quantity: ");
    var negativeEngravingQuantity_byteToStart = Search(earringBytes, negativeEngravingQuantity.Reverse().ToArray());

    Console.WriteLine($"Item ID: ");
    var itemId_byteToStart = Search(earringBytes, itemId.Reverse().ToArray());
}

byte[] GetNecklaceData()
{
    return new byte[] { 20, 50, 5, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 243, 115, 180, 5, 0, 0, 192, 14, 62, 179, 182, 12, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 31, 24, 108, 23, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 1, 0, 0, 0, 1, 1, 0, 0, 19, 0, 0, 0, 244, 1, 0, 0, 110, 0, 0, 0, 2, 144, 1, 0, 0, 240, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 16, 0, 0, 0, 244, 1, 0, 0, 110, 0, 0, 0, 2, 144, 1, 0, 0, 242, 1, 0, 0, 1, 0, 0, 0, 3, 7, 0, 0, 35, 3, 0, 0, 3, 0, 0, 0, 105, 0, 0, 0, 3, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 2, 7, 90, 2, 50, 1, 0, 0, 4, 0, 0, 0, 105, 0, 0, 0, 3, 4, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 1, 7, 0, 0, 43, 1, 0, 0, 3, 0, 0, 0, 105, 0, 0, 0, 3, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 184, 11, 0, 0, 0, 0, 0, 0, 184, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 16, 39, 0, 0, 0, 0, 0, 0, 0, 231, 71, 238, 128, 220, 230, 0, 0, 88, 2, 0, 0, 0, 0, 0, 0, 189, 67, 75, 14, 0, 0, 0, 0, 1, };
}

byte[] GetEarringData()
{
    return new byte[] { 20, 50, 5, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 220, 80, 191, 12, 0, 0, 160, 9, 63, 179, 182, 12, 0, 0, 23, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 31, 24, 108, 23, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 18, 0, 0, 0, 44, 1, 0, 0, 54, 1, 0, 0, 2, 240, 0, 0, 0, 44, 1, 0, 0, 1, 0, 0, 0, 3, 8, 0, 0, 34, 3, 0, 0, 3, 0, 0, 0, 105, 0, 0, 0, 3, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 8, 90, 2, 50, 1, 0, 0, 5, 0, 0, 0, 105, 0, 0, 0, 3, 5, 0, 0, 0, 5, 0, 0, 0, 1, 0, 0, 0, 1, 8, 0, 0, 142, 0, 0, 0, 3, 0, 0, 0, 105, 0, 0, 0, 3, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 159, 134, 1, 0, 0, 0, 0, 0, 159, 134, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 240, 73, 2, 0, 0, 0, 0, 0, 0, 231, 71, 44, 206, 174, 227, 0, 0, 136, 19, 0, 0, 0, 0, 0, 0, 222, 212, 76, 14, 0, 0, 0, 0, 1 };
}

byte[] RemoveFromByteArray(byte[] src, int amountToDelete)
{
    byte[] dst = new byte[src.Length - amountToDelete];

    Array.Copy(src, amountToDelete, dst, 0, dst.Length);

    return dst;
}

int Search(byte[] src, byte[] pattern)
{
    Console.WriteLine("Bytes: " + string.Join(",", pattern));
    Console.Write("Positions found: ");
    int maxFirstCharSlot = src.Length - pattern.Length + 1;
    for (int i = 0; i < maxFirstCharSlot; i++)
    {
        if (src[i] != pattern[0]) // compare only first byte
            continue;

        // found a match on first byte, now try to match rest of the pattern
        for (int j = pattern.Length - 1; j >= 1; j--)
        {
            if (src[i + j] != pattern[j]) break;
            if (j == 1) Console.Write(i + ", ");
        }
    }
    Console.WriteLine("\n");
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