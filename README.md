# _Word Count_

#### _Counts how many times a word occurs in a string, 21/2/2016_

#### By _**Brian Pritt**_

## Description

_This application takes two inputs: a string of words or sentence and a word to check against the sentence.  The application will will return the number of times the check word occurs in the sentence._

##_Program Specs:_
##_This application will_
*  Gather User input (consisting of one word and a check word), and see if they match, increment counter by one if true
    * input: "this" : "this"
    * output: 1
    * This test will demonstrate if the program can match one word to one word, the simplest function of this application.
*  Gather User input (consisting of one word and a check word), and see if they match, increment counter by one if true
    * input: "this" : "that"
    * output: 0
    * This test will demonstrate if the program can show that two single words are not a match.
* Gather User input (consisting of a list of words or sentence and a check word), and count how many matches there are , increment the counter by the number of matches;
    * input: "This this" : "this"
    * output: 2
    * This test will demonstrate if the program can count how many times a check word occurs in a sting of words.
*  Gather User input (consisting of a list of words and a check word), and see if they match regardless of case, increment counter by one if true;
    * input: "THIS" :"this"
    * output: 1
    * This test will demonstrate if the program can pick one word out of a string of words that matches the check word regardless of case.
*  Gather User input (consisting of a list of words or sentence and a check word), and see if there is a match, increment counter by 1 if true;
    * input: "this is nice" : "this"
    * output: 1
    * This test will demonstrate if the program can pick one word out of a string of words that matches the check word.
*  Gather User input (consisting of a list of words and a check word), and see if they match ignoring punctuation, increment counter by one if true;
      *  input: "This, is nice" :"this"
      *  output: 1
      *  This test will demonstrate if the program can pick one word out of a string of words that matches the check word regardless of case.



## Setup/Installation Requirements

To run this application you must do the following
* _Clone this repository_
* _From terminal, navigate to project directory_
* _Run >dnu restore_
* _Run >dnx kestrel_
* _In your browser, navigate to localhost:5004 to view the application_


## Known Bugs

_At time of commit, there were no known bugs_

## Support and contact details

_For support of bug reports contact
Brian Pritt:_
_http://github.com/brianpritt_

## Technologies Used

_This application is written in C#, using the Nancy Framework, the Razor view engine, and basic html and css._

### License

*GPLv3*

Copyright (c) 2016 **_Brian Pritt_**
