var deckRevealedIncreasing = function(deck) {
    let revealedDeck = [];
    let queue = [];

    deck.sort(function (a, b) {  return a - b;  });

    for(let index = 0; index < deck.length; index++) {
        queue.push(index);
    }

    for(let index = 0; index < deck.length; index++) {
        revealedDeck[queue[0]] = deck[index];
        queue.shift();
        queue.push(queue[0]);
        queue.shift();
    }

    return revealedDeck;
};