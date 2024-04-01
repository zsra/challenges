var lengthOfLastWord = function(s) {
    let index = s.length - 1;
    let counter = 0;

    while (index >= 0) {

        if (counter == 0 && s[index] == ' ') {
            index--;
            continue;
        }

        else if (s[index] == ' ') {
            return counter;
        }

        else if (s[index] != ' ') {
            index--;
            counter++;
        }
    }

    return counter;
};