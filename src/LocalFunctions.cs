internal static IEnumerable<char> AlphabetSubset(char start, char end)
{
    if ((start < 'a') || (start > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(start), "start must be a letter");
    }
    if ((end < 'a') || (end > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(end), "end must be a letter");
    }
    if (end <= start)
    {
        throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
    }

    for (var @char = start; @char < end; ++ @char)
    {
        yield return @char;
    }
}

internal static IEnumerable<char> AlphabetSubset2(char start, char end)
{
    if ((start < 'a') || (start > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(start), "start must be a letter");
    }
    if ((end < 'a') || (end > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(end), "end must be a letter");
    }
    if (end <= start)
    {
        throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
    }

    return AlphabetSubsetImpl(start, end);
}

private static IEnumerable<char> AlphabetSubsetImpl(char start, char end)
{
    for (var @char = start; @char < end; ++ @char)
    {
        yield return @char;
    }
}

internal static IEnumerable<char> AlphabetSubset3(char start, char end)
{
    if ((start < 'a') || (start > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(start), "start must be a letter");
    }
    if ((end < 'a') || (end > 'z'))
    {
        throw new ArgumentOutOfRangeException(nameof(end), "end must be a letter");
    }
    if (end <= start)
    {
        throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
    }

    return alphabetSubsetImpl();

    IEnumerable<char> alphabetSubsetImpl()
    {
        for (var @char = start; @char < end; ++ @char)
        {
            yield return @char;
        }
    }
}
