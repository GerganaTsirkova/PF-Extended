Exercise: Arrays, Lists, Array and List Algorithms
Problems for exercises and homework for the “Programming Fundamentals HYPERLINK "https://softuni.bg/courses/programming-fundamentals" Extended HYPERLINK "https://softuni.bg/courses/programming-fundamentals"” course @ SoftUni.
Problem 1 - Anonymous Threat
The Anonymous have created a cyber hypervirus which steals data from the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions. 
You will receive a single input line containing STRINGS separated by spaces. 
The strings may contain any ASCII character except whitespace.
You will then begin receiving commands in one of the following formats:
•	merge {startIndex} {endIndex}
•	divide {index} {partitions}
Every time you receive the merge command, you must merge all elements from the startIndex, till the endIndex. In other words, you should concatenate them. 
Example: {abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}
If any of the given indexes is out of the array, you must take ONLY the range that is INSIDE the array and merge it.
Every time you receive the divide command, you must DIVIDE the element at the given index, into several small substrings with equal length. The count of the substrings should be equal to the given partitions. 
Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
If the string CANNOT be exactly divided into the given partitions, make all partitions except the LAST with EQUAL LENGTHS, and make the LAST one – the LONGEST. 
Example: {abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
The input ends when you receive the command “3:1”. At that point you must print the resulting elements, joined by a space.
Input
•	The first input line will contain the array of data.
•	On the next several input lines you will receive commands in the format specified above.
•	The input ends when you receive the command “3:1”.
Output
•	As output you must print a single line containing the elements of the array, joined by a space.
Constrains
•	The strings in the array may contain any ASCII character except whitespace.
•	The startIndex and the endIndex will be in range [-1000, 1000].
•	The endIndex will ALWAYS be GREATER than the startIndex.
•	The index in the divide command will ALWAYS be INSIDE the array.
•	The partitions will be in range [0, 100].
•	Allowed working time/memory: 100ms / 16MB.
Examples
Input	Output
Ivo Johny Tony Bony Mony
merge 0 3
merge 3 4
merge 0 3
3:1	IvoJohnyTonyBonyMony
abcd efgh ijkl mnop qrst uvwx yz
merge 4 10
divide 4 5
3:1	abcd efgh ijkl mnop qr st uv wx yz

Problem 2 - Icarus
Icarus is the majestic phoenix who has been alive from the beginning of creation. Icarus travels through different planes. When Icarus travels through a plane, he damages Reality itself with his overwhelming, beyond godlike flames.
You will receive a sequence of integers – the plane. After that you will receive 1 integer – an index in that sequence, which is Icarus’s starting position. Icarus’s INITIAL DAMAGE is 1.
You will then begin receiving commands in the following format: “{direction} {steps}”. The direction will be either “left” or “right”, and the steps will be an integer. Depending on the direction, Icarus must step through the sequence of integers to the left or right. Each time he steps on a NEW position, he damages it. In other words, he SUBTRACTS his current damage from the integer at that position. Walking left and right has its conditions though:
•	If Icarus passes beyond the start of the sequence (index: -1) while going left, he must go at the end of the sequence (index: length – 1).
•	If Icarus passes beyond the end of the sequence (index: length - 1) while going right, he must go at the start of the sequence (index: 0).
If 1 of the 2 cases stated above happens, Icarus increments his damage by 1.
The input ends when you receive the command “Supernova”. When that happens you must print what is left of the sequence.
Input
•	On the first input line you will get the sequence of integers, separated by spaces.
•	On the second input line you will get Icarus’s starting position.
•	On the next several input lines you will get the commands.
Output
•	As output you must print a single line containing the remaining elements of the sequence, separated by spaces.
Constrains
•	The integers in the sequence will be in range [0, 1000].
•	The initial position of Icarus will always be valid and inside the sequence’s indexes.
•	The direction will always be either “left” or “right”.
•	The steps will be in range [0, 1000].
•	There will be NO invalid input lines.
•	Allowed working time / memory: 100ms / 16MB.
Examples
Input	Output	Comments
50 50 25 50 50
3
left 2
right 2
left 2
right 2
Supernova	50 48 21 48 50	Initial index: 3
Initial state:
50 50 25 50 50
Go left 2 steps:
50 50 24 50 50
50 49 24 50 50
Go right 2 steps:
50 49 23 50 50
50 49 23 49 50
Go left 2 steps:
50 49 22 49 50
50 48 22 49 50
Go right 2 steps:
50 48 21 49 50
50 48 21 48 50
Final state:
50 48 21 48 50
5 3 5 5 5
2
left 5
left 5
Supernova	2 0 0 0 0	Initial index: 2
Initial state:
5 3 5 5 5
Go left 5 steps:
5 2 5 5 5
4 2 5 5 5
4 2 5 5 3
4 2 5 3 3
4 2 3 3 3
Go left 5 steps:
4 0 3 3 3
2 0 3 3 3
2 0 3 3 0
2 0 3 0 0
2 0 0 0 0
Final state:
2	0 0 0 0
          Problem 3 - Pokemon Don’t Go
Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer.
You will receive a sequence of integers, separated by spaces – the distances to the pokemons.
Then you will begin receiving integers, which will correspond to indexes in that sequence.
When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
•	You must INCREASE the value of all elements in the sequence which are LESS or EQUAL to the removed element, with the value of the removed element.
•	You must DECREASE the value of all elements in the sequence which are GREATER than the removed element, with the value of the removed element.
If the given index is LESS than 0, remove the first element of the sequence, and COPY the last element to its place.
If the given index is GREATER than the last index of the sequence, remove the last element from the sequence, and COPY the first element to its place.
The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is the REMOVED element.
The program ends when the sequence has no elements (there are no pokemons left for Ely to catch).
Input
•	On the first line of input you will receive a sequence of integers, separated by spaces.
•	On the next several lines you will receive integers – the indexes.
Output
•	When the program ends, you must print on the console, the summed up value of all REMOVED elements.
Constrains
•	The input data will consist ONLY of valid integers in the range [-2.147.483.648, 2.147.483.647].
Examples
Input	Output	Comments
4 5 3
1
1
0	14	The array is {4, 5, 3}. The index is 1.
We remove 5, and we increase all lower than it and decrease all higher than it.
In this case there are no higher than 5.
The result is {9, 8}.
The index is 1. So we remove 8, and decrease all higher than it. 
The result is {1}. 
The index is 0. So we remove 1. 
There are no elements left, so we print the sum of all removed elements. 
5 + 8 + 1 = 14.
5 10 6 3 5
2
4
1
1
3
0
0	51	Step 1: {11, 4, 9, 11}
Step 2: {22, 15, 20, 22}
Step 3: {7, 5, 7}
Step 4: {2, 2}
Step 5: {4, 4}
Step 6: {8}
Step 7: {} (empty).
Result = 6 + 11 + 15 + 5 + 2 + 4 + 8 = 51.
•	 

Problem 4 - Hornet Assault
The hornets are preparing an assault on beehives. It takes very little amount of hornets to annihilate a beehive, but the bees are far from defenseless. You must calculate how many beehives, can the hornets annihilate, before they die.
You will be given a sequence of integers, separated by a space. The integers will represent the beehives and the amount of bees in them. You will then receive another sequence of integers, which will represent the hornets, and their power. The power indicates how many bees a hornet can kill.
The hornets must start attacking the beehives one by one. If the bees are more or equal to the summed-up power of the hornets, the first (entered) hornet, currently alive, dies in the assault of the current beehive.
When the hornets assault a beehive, they kill an amount of bees, equal to their summed-up power. This means that you must decrease the integer of the beehive, with the value of the summed-up power, of the live hornets.
After you’ve successfully assaulted all beehives, you must print the result of the winning side. If there are ANY beehives with live bees inside them, you must print them. If there aren’t, you must print the live hornets.
Input
•	On the first line of input you will receive a sequence of integers, separated by spaces – the beehives.
•	On the second line of input you will receive a sequence of integers, separated by spaces – the hornets.
Output
•	Depending on the case of printing you must either print the live beehives, or the live hornets.
•	They are sequences of integers, so in both cases you must print them separated by a space. 
Constrains
•	The input will consist only of integers in range [0; 1,000,000].
•	There will be NO STALEMATE situations.
•	The input sequences may consist of up to 3000 elements. 
Examples
Input	Output	Comments
20 10 20 30
5 10 5 3	7	The summed power of the hornets is 23.
They kill the first 3 beehives, due to overwhelming power.

The last beehive has higher value, and its left with 7 bees alive inside it. The first hornet (5) dies.
All other beehives are dead, so we print only this one.
10 20 10 15
5 6 7	2 2	The summed power is 18. The first beehive dies. In the second one, 18 bees die, but due to higher power, the first hornet (5) dies.

Now the summed power is 13. The third beehive dies, but the fourth one has higher value. 13 bees die from the fourth beehive and the current first hornet (6) dies.
We have the second and the fourth beehive with 2 bees, each, so we print them.
20 100 40 45 20 10
40 10 5 40 5	10 5 40 5
Problem 5 - Kamino Factory
The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA sequence to use in the production. 
You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a DNA sequences of ones and zeroes, split by "!" (one or several).
You should select the sequence with the longest subsequence of ones. If there are several sequences with same length of subsequence of ones, print the one with the leftmost starting index, if there are several sequences with same length and starting index, select the sequence with the greater sum of its elements.
After you receive the last command "Clone them!" you should print the collected information in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"
Input / Constraints
•	The first line holds the length of the sequences – integer in range [1…100];
•	On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) of ones and zeroes, split by "!" (one or several).
 Output
The output should be printed on the console and consists of two lines in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"
 Examples
Input	Output	Comments
5
1!0!1!1!0
0!1!1!0!0
Clone them!	Best DNA sample 2 with sum: 2.
0 1 1 0 0	We receive 2 sequences with same length of subsequence of ones, but the second is printed, because its subsequence starts at index[1].
Input	Output	Comments
4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!	Best DNA sample 1 with sum: 3.
1 1 0 1	We receive 3 sequences. Both 1 and 3 have same length of subsequence of ones -> 2, and both start from index[0], but the first is printed, because its sum is greater.

"FEAR IS THE PATH TO THE DARK SIDE...
FEAR LEADS TO ANGER...
ANGER LEADS TO HATE...
HATE LEADS TO SUFFERING...."
Problem 6 - Max Sequence of Equal Elements
Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.
Examples
Input	Output
3 4 4 5 5 5 2 2	5 5 5
7 7 4 4 5 5 3 3	7 7
1 2 3 3	3 3
Hints
•	Scan positions p from left to right and keep the start and length of the current sequence of equal numbers ending at p.
•	Keep also the currently best (longest) sequence (bestStart + bestLength) and update it after each step.
Problem 7 – Snowmen
The Snowmen Fray has been on since the dawn of time. Professor Olaf is currently studying the ancient war methods, and needs you to write a program that simulates a battle between snowmen.
You will receive a sequence of integers, separated by spaces – the snowmen, 
which are indexed from 0 – sequence.length – 1.
You must traverse the elements, from the first till the last. Each element is an attacker index, and its integer value is its target index. If the integer value is greater than the length of the sequence, divide it modulo (%) by the length of the sequence. Example: target = 12, length = 7, target = 12 % 7 - > 5.
When you extract attacker index and the target index, you must calculate the absolute value of the difference between them. 
•	If the difference is an even number, the attacker wins.
•	if the difference is an odd number, the target wins.
•	If the attacker and the target are equal (they are the same indexes), that means that snowman suicides.
If an element loses a battle or suicides, it should NOT be able to attack. It can still be a target though.
When you finish traversing the whole sequence, you must remove all elements that have lost or suicided, and then you must start over. The process must be repeated until there is 1 snowman left in the sequence.
For each attacker and target, you must print “{attacker} x {target} -> {winner} wins”. 
The attacker and the target are indexes, and the winner is the index of the winner.
In that case you must print “{attacker} performed harakiri”.
Input
•	As input you will receive a single input line containing the sequence of integers, separated by spaces.
Output
•	As output you must print each action between attacker and target, in the formats specified above.
Constraints
•	The elements of the sequence will be between 0 and 100.
•	The integers in the sequence will be in range [0, 1000]. 
•	Allowed working time / memory: 100ms / 16MB.
Examples
Input	Output	Comment
4 3 2 1 0	0 x 4 -> 0 wins
1 x 3 -> 1 wins
2 performed harakiri
0 performed harakiri	First: Attacker – 0, Target – 4. Difference = 4 (even) Attacker wins, Target lost.
Second: Attacker – 1, Target – 3. Difference = 2 (even) Attacker wins, Target lost.
Third: Attacker – 2, Target – 2. Equal, Attacker suicided.
All other elements have lost. We remove them from the sequence. Sequence – 4 3. Length = 2.
First: Attacker – 0, Target – 4 (% 2) = 0. Equal, Attacker suicided.
There is 1 element left, we stop the program.


25 31 6 9 2 4 7	0 x 4 -> 0 wins
1 x 3 -> 1 wins
2 x 6 -> 2 wins
5 x 4 -> 4 wins
0 x 1 -> 1 wins
1 performed harakiri	
Problem 8 - Numbers
Write a program to read a sequence of integers and find and print the top 5 numbers that are greater than the average value in the sequence, sorted in descending order.
•	Input
Read from the console a single line holding space separated number.
•	Output
Print the above described numbers on a single line, space separated. If less than 5 numbers hold the above mentioned property, print less than 5 numbers. Print “No” if no numbers hold the above property.
•	Constrains
All input numbers are integers in range [-1 000 000 … 1 000 000]. The count of numbers is in range [1…10 000].
•	Examples
Input	Output	Comments
10 20 30 40 50	50 40	Average number = 30.
Numbers greater than 30 are: {40, 50}. 
The top 5 numbers among them in descending order are: {50, 40}.
Note that we have only 2 numbers, so all of them are included in the top 5.
5 2 3 4 -10 30 40 50 20 50 60 60 51	60 60 51 50 50	Average number = 28.08.
Numbers greater than 20.078 are:
{30, 40, 50, 50, 60, 60, 51}.
The top 5 numbers among them in descending order are: {60, 60, 51, 50, 50}.
1	No	Average number = 1.
There are no numbers, greater than 1.
-1 -2 -3 -4 -5 -6	-1 -2 -3	Average number = -3.5.
Numbers greater than -3.5 are: {-1, -2, -3}.
The top 5 numbers among them in descending order are: {-1, -2, -3}.

Problem 9 – Command Interpreter
Jagged arrays, regular expressions, asynchronous programming… Tough stuff. But simple structures like arrays are piece of cake, right? Let’s see how well you can manipulate data in a collection.
You will be given a series of strings on a single line, separated by one or more whitespaces. These represent the collection you’ll be working with.
On the next input lines, until you receive the command "end", you’ll receive a series of commands in one of the following formats:
•	"reverse from [start] count [count]" – this instructs you to reverse a portion of the array – just [count] elements starting at index [start];
•	"sort from [start] count [count]" – this instructs you to sort a portion of the array - [count] elements starting at index [start];
•	"rollLeft [count] times" – this instructs you to move all elements in the array to the left [count] times. On each roll, the first element is placed at the end of the array;
•	"rollRight [count] times" – this instructs you to move all elements in the array to the right [count] times. On each roll, the last element is placed at the beginning of the array;
If any of the provided indices or counts is invalid (non-existent or negative), you should print a message on the console – "Invalid input parameters." and keep the collection unchanged.
After you’re done, print the resulting array in the following format: "[arr0, arr1 … arrN]". The examples should help you understand the task better.
Input
•	The input data should be read from the console.
•	The first input line will hold a series of strings, separated by one or more whitespaces.
•	The next lines will hold commands in the described formats (exactly).
•	The input ends with the keyword "end".
•	The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output should be printed on the console. 
•	Each time an invalid command is received (containing an invalid index or count parameter), print the following line: "Invalid input parameters."
•	After receiving the "end" command, print the resulting array on the console in the format specified above.
Constraints
•	The count of strings in the collection will be in the range [1 … 50].
•	The number of commands will be in the range [1 … 20].
•	All commands will be in the described format; an invalid command is a command containing invalid [start] or [count], there won’t be any missing or misspelled words.
•	[start] and [count] will be integers in the range [-231 … 231 - 1].
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
Examples
Input	Output
1 2 5 8 7 3 10 6 4 9
reverse from 2 count 4
end	[1, 2, 3, 7, 8, 5, 10, 6, 4, 9]

Problem 10. Ladybugs
You are given a field size and the indexes of ladybugs inside the field. After that on every new line until the "end" command is given, a ladybug changes its position either to its left or to its right by a given fly length. 
A command to a ladybug looks like this: "0 right 1". This means that the little insect placed on index 0 should fly one index to its right. If the ladybug lands on a fellow ladybug, it continues to fly in the same direction by the same fly length. If the ladybug flies out of the field, it is gone.
For example, imagine you are given a field with size 3 and ladybugs on indexes 0 and 1. If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1 but as there is another ladybug there it will continue further to the right by additional length of 1, landing on index 2. After that, if the same ladybug needs to fly to its right by the length of 1 (2 right 1), it will land somewhere outside of the field, so it flies away:

If you are given ladybug index that does not have ladybug there, nothing happens. If you are given ladybug index that is outside the field, nothing happens. 
Your job is to create the program, simulating the ladybugs flying around doing nothing. At the end, print all cells in the field separated by blank spaces. For each cell that has a ladybug on it print '1' and for each empty cells print '0'. For the example above, the output should be '0 1 0'. 
Input
•	On the first line you will receive an integer - the size of the field
•	On the second line you will receive the initial indexes of all ladybugs separated by a blank space. The given indexes may or may not be inside the field range
•	On the next lines, until you get the "end" command you will receive commands in the format: "{ladybug index} {direction} {fly length}"
•	Output
•	Print the all cells within the field in format: "{cell} {cell} … {cell}"
•	If a cell has ladybug in it, print '1'
•	If a cell is empty, print '0' 
•	Constrains
•	The size of the field will be in the range [0 … 1000]
•	The ladybug indexes will be in the range [-2,147,483,647 … 2,147,483,647]
•	The number of commands will be in the range [0 … 100] 
•	The fly length will be in the range [-2,147,483,647 … 2,147,483,647]
 
•	Examples
Input	Output	Comments
3
0 1
0 right 1
2 right 1
end	0 1 0	1 1 0 - Initial field
0 1 1 - field after "0 right 1"
0 1 0 - field after "2 right 1"

Input	Output		Input	Output
3
0 1 2
0 right 1
1 right 1
2 right 1
end	0 0 0		5
3
3 left 2
1 left -2
end	0 0 0 1 0


