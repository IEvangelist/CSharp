int LegacyTryPattern(string number) {
    int i;
    if (int.TryParse(number, out i)) {
        return i;
    }
    else { 
        return -1;
    }

    // The "i" variable is valid here
}

int NewTryPattern(string number) {
    // Note: we can be explicit, but implicit is valid
    if (int.TryParse(number, out int i)) {
        return i;
    }
    else {
        return -1; // "i" is available to us here.
    }
    // The "i" variable leaks into this scope.
}

void ScopeExample() {
    if (DateTime.TryParse("OMG", out var date)) {
        if (TimeSpan.TryParse("What's happening?", out var ts)) {
            var newDate = date.Add(ts);
        }
    }

    // Note: the "ts" variable is NOT leaked in this scope!
}

int ExpressiveTryPattern(string number)
    => int.TryParse(number, out var value) ? value : -1;









// Hacker!
