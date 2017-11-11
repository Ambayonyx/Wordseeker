English - Assignment
====================

This is a programming excercise in which you have to solve the Wordseeker puzzle.

Given a puzzle existing of:
 - a grid of characters in a field
 - a list of words
 - a solution which can be found by:
    - find words from list on the grid 
    - the words are oriented:
        - horizontally from left to right
        - vertically from top to bottom
        - diagonally from top to botom
    - a character from the grid may occur in multiple words
    - a character which doesn't occur in any word is part of the solution
    - the characters create a word read in the normal direction (left to right, top to bottom)

Implement an algorithm which will:
 - localize the words of the list, and presents them giving the begin coordinate and direction
 - present the solution as a word.

You get a User Interface (*DevelopersForm*):
 - Which reads text files containing the field and the lists of words
 - Calls an implementation of the solver via the *IWordSeekerSolver*, 
   which is implemented by your algorithm. See the *btnSolve_Click* method in the *DevelopersForm* class.
 - An example of a solver *MauriceSolver*. 
   Is it the best implementation? 
   Thinks about the strength and weakness of this implementation.

Nederlands - Opdrachtomschrijving
=================================

Dit is een programmeer oefening waarin je een Woordzoeker puzzel moet oplossen.

Puzzel bestaat uit:
 - Grid met letters in een veld
 - Lijst met woorden
 - Oplossing
 - Regels
    - Vind de woorden uit de lijst in het grid
    - De woorden staan:
       - verticaal van boven naar beneden
       - horizontaal van links naar rechts
       - diagonaal van boven naar onder
    - Een letter uit het grid mag in meerdere woorden voorkomen
    - Een letter die in GEEN woord voorkomt is een deel van de oplossing
       - Deze letters vormen een woord in de richting zoals men normaal leest.

Maak een programma dat:
 - De woorden localiseert, en presenteert mbv begin coordinaat en richting
 - En de oplossing presenteert in de vorm van een woord


Je krijgt een User Interface (*DevelopersForm*):
 - Die tekstbestanden kan lezen met het veld en de lijst met woorden.
 - Die een implementatie van de oplosser aanroept via het *IWordSeekerSolver* interface en 
   die you oplosalgoritme implementeerd. Bekijk de *btnSolve_Click* methode in de *DevelopersForm* klasse.
 - Een voorbeeld van de oplosser: *MauriceSolver*. 
   Is dit de beste implementation? 
   Denk na over de sterktes en zwaktes van deze implementatie.


Een algorithme
==============

**Let op: het stuk hieronder moet je eigenlijk zelf doen. Dat lukt jou ook**

 1. Doe voor alle woorden in de lijst 
     2 Doe voor iedere richting,
         Doe voor iedere coordinaat
           Als het woord er staat dan
             Sla coordinaat op en sla richting op en stop met dit woord zoeken
 5. Zo niet zoek niet gebruikte letters
 6. Vorm woord door niet gebruikte letters achter elkaar te zetten
 7. Toon de woorden met coordinaat en richting
 8. Toon oplossing
       
       
 