public static class TelemetryBuffer
{
    private static bool isShort(long reading) => (reading >= short.MinValue && reading <= -1);
    private static bool isUShort(long reading) => (reading >= 0 && reading <= ushort.MaxValue);
    private static bool isIntPositive(long reading) => (reading > ushort.MaxValue && reading <= int.MaxValue);
    private static bool isIntNegative(long reading) => (reading >= int.MinValue && reading <= -32_769);
    private static bool isUInt(long reading) => (reading > int.MaxValue && reading <= uint.MaxValue);
    public static byte[] ToBuffer(long reading)
    {
        var (prefix, payload) = reading switch
        {
            _ when isShort(reading) => ((byte)0xfe, BitConverter.GetBytes((short)reading)), // short
            _ when isUShort(reading) => ((byte)0x02, BitConverter.GetBytes((ushort)reading)), // ushort 
            _ when isIntPositive(reading) => ((byte)0xfc, BitConverter.GetBytes((int)reading)), // int
            _ when isIntNegative(reading) => ((byte)0xfc, BitConverter.GetBytes((int)reading)), // int
            _ when isUInt(reading) => ((byte)0x04, BitConverter.GetBytes((uint)reading)), // uint
            _ => ((byte)0xf8, BitConverter.GetBytes(reading)) // long
        };
        var result = new byte[9];
        result[0] = prefix;
        payload.CopyTo(result, 1);
        return result;
    }
    public static long FromBuffer(byte[] buffer)
    {
        var prefix = buffer[0];
        long result = prefix switch
        {
            0xfe => BitConverter.ToInt16(buffer, 1),
            0x02 => BitConverter.ToUInt16(buffer, 1),
            0xfc => BitConverter.ToInt32(buffer, 1),
            0x04 => BitConverter.ToUInt32(buffer, 1),
            0xf8 => BitConverter.ToInt64(buffer, 1),
            _ => default
        };
        return result;
    }
}
