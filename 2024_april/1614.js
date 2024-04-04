var maxDepth = function (s) {
    let stack = [];
    let max = 0;

    for (let i = 0; i < s.length; i++) {

        if (s[i] == '(') {
            stack.push('(');
        }
        else if (s[i] == ')') {

            if (stack.length > max) {
                max = stack.length;
            }

            stack.pop();
        }
    }

    return max;
};