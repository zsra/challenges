var timeRequiredToBuy = function (tickets, k) {
    let queue = []
    for (let i = 0; i < tickets.length; i++) {
        queue.push(i);
    }
    let count = 0
    while (tickets[k] > 0) {
        let top = queue[0]
        tickets[top]--
        count++
        queue.shift()
        if (tickets[top] !== 0)
            queue.push(top)
    }
    return count

};