var findFarmland = function(land) {
  
    let result = [];

    for (let i = 0; i < land.length; i++) {
        for (let j = 0; j < land[0].length; j++) {
            if(land[i][j] == 1) {
                let farmland = [i ,j, -1, -1];
                DFS(land, i, j, farmland);
                result.push(farmland);
            }
        }
    }

    return result;
};

function DFS(land, i, j, farmland) {

    land[i][j] = 2;

    if (i > farmland[2]) {
        farmland[2] = i;
    }

    if (j > farmland[3]) {
        farmland[3] = j;
    }

    if (i - 1 >= 0 && land[i - 1][j] == 1) {
        DFS(land, i - 1, j, farmland);
    }

    if (j - 1 >= 0 && land[i][j - 1] == 1) {
        DFS(land, i, j - 1, farmland);
    }

    if (i + 1 < land.length && land[i + 1][j] == 1) {
        DFS(land, i + 1, j, farmland);
    }

    if (j + 1 < land[0].length && land[i][j + 1] == 1) {
        DFS(land, i, j + 1, farmland);
    }
}