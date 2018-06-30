// Expressing ranges
var range = 1..7;

struct Range : IEnumerable<int>
{
    public int Start { get; }
    public int End { get; }

    public Range(int start, int end)
    {
        Start = start;
        End = end;
    }

    public StructRangeEnumerator GetEnumerator()
        => new StructRangeEnumerator(Start, End);

    // overloads for Equals, GetHashCode...
}

// Index argument, concise syntax for slicing arrays
Span<T> this[Range range] {
    get => Slice(start: range.Start, 
                 length: range.End - range.Start);
}

// Since it's an impl of IEnumerable we can do this
foreach (var item in min..max) {
    // Wow, that is nice!
}

// Likewise, pattern matching gets to use this too
switch (value) {
    case 1..5:
        // value in range
        break;
}










// Hacker!
