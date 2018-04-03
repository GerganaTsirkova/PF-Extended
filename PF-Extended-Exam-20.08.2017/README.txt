Problem 1. Trainers
You expected something with lecturers? Nope, this is about Trainers – the train guys. So there are three teams of trainers – The Technical Trainers, The Theoretical Trainers and The Practical Trainers. They always compete about who will be most productive, so they’ve hired you – the best programmer, to calculate it, because they can’t.
You will receive N, an integer – the number of participants in the competition. For each participant, you will receive 3 input lines:
⦁	On the first input line you will receive an integer number – the distance to travel in miles.
⦁	On the second input line you will receive a floating-point number – the cargo that is being carried in tons.
⦁	On the third input line you will receive a string – the team of which the current participant is.
You can assume that 1 mile = 1600 meters and 1 ton = 1000 kilogram.
The data you were given will calculate the money earned by the current participant. You must calculate how much the cargo’s total worth is and then subtract from it the fuel expenses.
The train consumes 0.7 litters of fuel for every travelled meter. 
The cargo is worth 1.5 per kilogram.
The fuel is worth 2.5 per litter.
So the formula goes like: 
participantEarnedMoney = {cargoInKillograms * 1.5} – {0.7 * distanceInMeters * 2.5}
When you get the earned money of the participant, you should add it to the total money of the team he is from.
When you’ve processed all participants, print the team with the most earned money. 
Input
⦁	On the first line of input you will get N – an integer.
⦁	On the next N * 3 lines of input you will get data about participants.
Output
⦁	As output you must print the team with the most earned money, and its earned money.
⦁	The money should be rounded to 3 digits after the decimal point.
⦁	The format is: 
“The {teamName} Trainers win with ${totalEarnedTeamMoney}.”
Constrains
⦁	The integer N will be in range [0, 1000].
⦁	The distance in miles will be an integer in range [0, 1.000.000].
⦁	The cargo in tons will be a floating-point number in range [0, 1.000.000].
⦁	The team will either be “Technical”, “Theoretical” or “Practical”.
⦁	Allowed time / memory: 100ms / 16 MB.




Examples
Input	Output	Comment
2
10
25
Technical
1000
1550
Practical	The Technical Trainers win with $9500.000.	The first participant traveled 10 miles (16000 meters) and carried 25 tons cargo (25000 kilogram).
0.7 (fuel consumption) * 16000 
* 2.5 (fuel price) = 28000$ (fuel expenses)

1.5 (cargo price per kilogram) * 25000 = 37500$ (cargo income)

37500 – 28000 = 9500$ for Team Technical Trainers.

The second participant goes like this
0.7 * 1600000 * 2.5 = 2800000
1.5 * 1550000 = 2325000
2325000 – 2800000 = -475000$

4
150
300
Theoretical
100
300
Practical
100
200
Practical
300
5000
Technical	The Technical Trainers win with $6660000.000.	
Problem 2. Entertrain
You must be good at entertaining people, now how about “entertraining” people. The process of entertraining people is releasing wagons when your locomotive doesn’t have enough power to carry them. You’ll have to write a program that simulates the process.
You will be given N – an integer, indicating the locomotive’s power. After that you will begin receiving integers, each on a new line – the wagons and their weight. You must keep the wagons in a sequence.
When the total sum of the integers in the sequence becomes GREATER than the locomotive’s power, you must calculate the average of the sequence. Then you must take the element which is closest BY VALUE to the average and REMOVE it from the sequence. This is what entertraining means.
When you get the command “All ofboard!” you should end the input sequence. When that happens you should print the elements from the sequence of wagons in reversed order of input, with the locomotive’s power as the last element.
Input
⦁	On the first line you will get N – the locomotive’s power.
⦁	On the next several lines you will be getting integers – the wagons and their weight.
⦁	The input ends when you get the command “All ofboard!”.
Output
⦁	As output you must print the sequence of wagons in reversed order of input, with the locomotive’s power as last element.
⦁	The elements must be separated by a single space.
Constrains
⦁	All integers in the input will be in range [0, 1000].
⦁	Note that you are working with integers, all DIVISION is between integers.
⦁	There will never be 2 wagons with the same value, present at the same time.
⦁	Allowed time / memory: 100ms / 16 MB.


Examples
Input	Output	Comment
30
11
16
4
All ofboard!	4 16 30	The locomotive’s power is 30. We start adding wagons.
11, 16 (total weight = 27)
When we add 4, the total weight = 31, which is > 30.
The average is 31 / 3 = 10. The closest wagon by value to 10 is 11, so we remove it.
We receive the final command, and we print the train in reversed order of input with the locomotive as last.
The first entered is 11, but we removed it. The next is 16 and then 4.
So, 4, 16, 30 = “4 16 30”
50
11
20
25
All ofboard!	25 11 50	

Problem 3. Trainegram
It’s like telegram, but … between trains. You have been tasked to write a software that read encoded trainegram messages. Trainegram messages are used to send meta information about trains.
A locomotive consists of 2 surrounding square brackets and a “less than” symbol and a dot at the end (“<[].”). Between the brackets, the locomotive may contain ANY symbol except letters and digits.
Valid locomotives: “<[*/*].”, “<[---].”, “<[.;[].”... Invalid locomotives: “[//].”, “<[*-*]”, “<[asd1].”
A locomotive might be accompanied by several wagons. A wagon consists of a dot, 2 surrounding square brackets and another dot (“.[].”). Between the brackets, the wagon may contain ONLY letters and digits.
Valid wagons: “.[asd].”, “.[131].”, “.[as2].”, “.[].” ... Invalid wagons: “[asd]”, “.[3-D].”.
On each input line you will receive a message. You should check if that message IS a train. 
A train ALWAYS has a locomotive and may have several wagons.
A train ALWAYS starts at the start of the message and ends at its end. 
A train ALWAYS starts with a locomotive. Example: “<[/**]..[asd]..[3dx].”
The input sequence ends when you receive the command “Traincode!”. When that happens, you must print all valid trains you’ve found, each on a new line, by order of input.
Input
⦁	The input will come in the form of several lines containing messages.
⦁	The input ends when you receive the command “Traincode!”.
Output
⦁	As output you must print all valid trains, each on a new line, by order of input.
Constrains
⦁	There will be no more than 1000 input lines.
⦁	The strings in the input lines may contain any ASCII character.
⦁	The strings in the input lines may be INVALID.
⦁	Allowed time / memory: 100ms / 16 MB.
Examples
Input	Output
<[/**]..[asd]..[3dx]..[]..[].
<>
Traincode!	<[/**]..[asd]..[3dx]..[]..[].

<[{]..[7]..[]..[]..[C2I43].
<[(_#/}$)$]..[GO5A]..[G5]..[3W4].
<[^]..[54]..[S].
<[@].
<[)$-{,]..[PB1N]..[R757G].
<[]..[]..[10]..[223F]..[GBM4].
<[!]..[]
<[)_]..[3N]..[TS]..[0NS58].
Traincode!	<[{]..[7]..[]..[]..[C2I43].
<[(_#/}$)$]..[GO5A]..[G5]..[3W4].
<[^]..[54]..[S].
<[@].
<[)$-{,]..[PB1N]..[R757G].
<[]..[]..[10]..[223F]..[GBM4].
<[)_]..[3N]..[TS]..[0NS58].


Problem 4. Trainlands
So a train goes from A to B… Okay that’s too mainstream. Trainlands! Trainlands is a game of trains, in which trains develop themselves into gigantic trains for the competition. It got too trainy so let’s get to the main logic.
The train has a name (string), and wagons. The wagons have a name (string) and power (integer). 
The input comes in one of the following formats:
{trainName} -> {wagonName} : {wagonPower}
Creates a train with the given name and adds a wagon to it with the given name and power. If the train already exists, it just adds the given wagon to it.
{trainName} -> {otherTrainName}
Adds all of the wagons from the other train to the first train, and REMOVES the other train. If the first train does NOT exist, create it, and then add the wagons. The other train will ALWAYS be EXISTENT.
{trainName} = {otherTrainName}
Copies the other train’s wagons, without affecting the other train. Copying means, that the first train’s wagons become the same as the other train’s wagons. If the first train does NOT exist, create it. The other train will ALWAYS be EXISTENT.
When you get the command “It’s Training Men!” you should end the input sequence and print all of the trains and their wagons. The trains must be ordered by total wagon power, in descending order, and by wagon count in ascending order as secondary criteria. For each train you should print its wagons, ordered by wagon power in descending order.
Input
⦁	The input comes in the form of commands in one of the formats specified above.
⦁	The input ends when the command “It’s Training Men!” is entered. 
Output
⦁	As output you must print all of the trains and their wagons ordered as specified above.
⦁	The format of printing is:
Train: {trainName}
###{wagon1Name} – {wagon1Power}
###{wagon2Name} – {wagon2Power}
. . .
Constrains
⦁	The names of the trains and the wagons will be strings.
⦁	The names may contain any ASCII character, except “ ”, “-”, “:”, “>”, “=”.
⦁	The wagon power will be a valid integer in range [0, 1.000.000].
⦁	There will be NO invalid input.
⦁	The wagons will always have unique names in the scope of their train.
⦁	Allowed time / memory: 100ms / 16 MB.

 
Examples
Input	Output
Kivil -> KAKA : 1387
Zone -> Gh : 4081
Kivil -> RAMZES666 : 4677
Desolator -> MiraclE~ : 8432
Zone -> Kivil
It's Training Men!	Train: Zone
###RAMZES666 - 4677
###Gh - 4081
###KAKA - 1387
Train: Desolator
###MiraclE~ - 8432
Kepler -> MinD_ContRoL : 3782
Daun -> Fn : 6816
Miner -> Gh : 1198
Miner -> Sccc : 9030
Miner -> KAKA : 7409
Anna -> Miner
Daun = Anna
It's Training Men!	Train: Daun
###Sccc - 9030
###KAKA - 7409
###Gh - 1198
Train: Anna
###Sccc - 9030
###KAKA - 7409
###Gh - 1198
Train: Kepler
###MinD_ContRoL - 3782

