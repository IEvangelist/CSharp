static IEnumerable<char> AlphabetSubset(char start, char end) {
    if ((start < 'a') || (start > 'z')) {
        throw new ArgumentOutOfRangeException(
            nameof(start),
            "start must be a letter");
    }

    for (var @char = start; @char < end; ++ @char)
        yield return @char;
    }
}

static IEnumerable<char> AlphabetSubset2(char start, char end) {
    if ((start < 'a') || (start > 'z')) {
        throw new ArgumentOutOfRangeException(
            nameof(start),
            "start must be a letter");
    }

    return AlphabetSubsetImpl(start, end);
}

static IEnumerable<char> AlphabetSubsetImpl(char start, char end) {
    for (var @char = start; @char < end; ++ @char) {
        yield return @char;
    }
}

static IEnumerable<char> AlphabetSubset3(char start, char end) {
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

{
    // #NotAsUgly
    int sumNumbers(int x, int y) => x + y;
    Func<int, int, int> addNumbers = (x, y) => x + y;
}









