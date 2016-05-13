using System;

public class DeckOfCards {

    private Card[] deck;
    private int currentCard;
    private const int NUMBER_OF_CARDS = 52;
    private Random randomNumbers;

    public DeckOfCards() {

        string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        randomNumbers = new Random();

        for (int i = 0; i < deck.Length; i++) {
            deck[i] = new Card(faces[i % 13], suits[i / 13]);
        }
    }

    public void Shuffle() {

        currentCard = 0;

        for (int i = 0; i < deck.Length; i++) {

            int next = randomNumbers.Next(NUMBER_OF_CARDS);

            Card temp = deck[i];
            deck[i] = deck[next];
            deck[next] = temp;

        }
    }   

    public Card DealCard() {

        if (currentCard < deck.Length) {
            return deck[currentCard++];
        } else {
            return null;
        }

    }

}