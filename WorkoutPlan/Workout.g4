grammar Workout;

/*
 * Parser Rules
 */

 plan       : exercise+;
 exercise   : NAME SETS 'x' REPS ;

/*
 * Lexer Rules
 */

 NAME       : 'Squat' | 'Lunge' | 'LegCurl' | 'LegExtension' | 'HipThrust' ;
 SETS       : [1-4];
 REPS       : [1-9] | '1'[0-9] | '20';

// Ignore whitespace
WS: [ \t\r\n]+ -> skip;
