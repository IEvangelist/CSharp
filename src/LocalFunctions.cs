internal static IEnumerable<char> AlphabetSubset(char start, char end) {
    if ((start < 'a') || (start > 'z')) {
        throw new ArgumentOutOfRangeException(
            nameof(start),
            "start must be a letter");
    }

    for (var @char = start; @char < end; ++ @char)
        yield return @char;
    }
}

internal static IEnumerable<char> AlphabetSubset2(char start, char end) {
    if ((start < 'a') || (start > 'z')) {
        throw new ArgumentOutOfRangeException(
            nameof(start),
            "start must be a letter");
    }

    return AlphabetSubsetImpl(start, end);
}

private static IEnumerable<char> AlphabetSubsetImpl(char start, char end) {
    for (var @char = start; @char < end; ++ @char) {
        yield return @char;
    }
}

internal static IEnumerable<char> AlphabetSubset3(char start, char end) {
    if ((start < 'a') || (start > 'z')) {
        throw new ArgumentOutOfRangeException(
            nameof(start), 
            "start must be a letter");
    }

    return alphabetSubsetImpl();

    IEnumerable<char> alphabetSubsetImpl() {
        for (var @char = start; @char < end; ++ @char) {
            yield return @char;
        }
    }
}
