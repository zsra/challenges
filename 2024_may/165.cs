public int CompareVersion(string version1, string version2) {
    var split1 = version1.Split(".");
    var split2 = version2.Split(".");

    int i=0;
    int j=0;
    while (i < split1.Length || j < split2.Length) {
        int one = i < split1.Length ? Int32.Parse(split1[i]) : 0;
        int two = j < split2.Length ? Int32.Parse(split2[j]) : 0;
        i++; j++;
        if (one == two) continue;
        return one < two ? -1 : 1;
    }

    return 0;
}