# A thousand and one stars

A videogame where you are the hero.

# Minimal viable product target features

- DONE: galactic background
- Planets: locations are on planets, asteroids and other space objects.
- special places: a character can move from location to location.
- Move characters: a character can move between places on the same planet, or between special places with linked space ports
- Encounters: when a character finished the move phase, he makes an encounter on his current location.
	+ A description paragraph opens
	+ The character choses between options
	+ The conclusion paragraph corresponding to his options appears.
- End turn: A player ends his turn after all phases are resolved (move, encounter, etc.). Moves to next player if any and starts at the first phase.
- End game: 
    - A character meets the victory condition.
    - The game is marked as finished, no more action can be taken. 
    - A text box opens with the conclusion.

# Issues


## Fixed

- the location takes the hover effect instead of the hero. There must be a way to know which one should be blocking the mouse.
	-> using collider 3d and set the z position of colliders to ensure they are interacted with in the right order.

# Sources

- Theme music: [CC0 Video Game Blockbuster](freepd.com/epic); Written by Rafael Krux. Evolving, epic and uplifting dramatic track made with cinematic orchestra, massive choir and more! This music is available for commercial and non-commercial purposes.
- Game music: [CC0 Future Setting F](https://freepd.com/Page2/)Sci-Fi Soundtrack Quirky vintage delayed synth. Mostly arpeggios. Could also be used as theme music. - Kevin MacLeod

# Missing resources
- Assets/Sprites/strategygameicons contains the sprites from [Strategy Game Icons](https://assetstore.unity.com/packages/2d/gui/icons/strategy-game-icons-64816) on the asset store.
- Text: Text Mesh Pro, the Ultimate Text Solution for Unity