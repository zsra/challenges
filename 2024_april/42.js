var trap = function (height) {

    let water = [];
    let max = height[0];

    water.push(0);

    for (let i = 1; i < height.length; i++) {

        if (height[i] >= max) {
            max = height[i];
            water.push(0);
        }
        else {
            water.push(max - height[i]);
        }
    }

    max = height[height.length - 1];

    for (let i = height.length - 1; i >= 0; i--) {

        if (height[i] >= max) {
            max = height[i];
            water[i] = 0;
        }
        else {
            if (water[i] > max - height[i]) {
                water[i] = max - height[i];
            }
        }
    }

    let sum = 0;

    for (let i = 0; i < water.length; i++) {
        sum += water[i];
    }

    return sum;
};