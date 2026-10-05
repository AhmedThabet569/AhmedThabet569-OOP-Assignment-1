#Questions — answer 
1-Why is a single 20-parameter constructor for this class a problem in practice? 

=> as you can't remember order of the prameters
=> if you have to add more parmeters that will cause the constructor space 
=> if you miss one parameters may cause error 


2- 2 Is this purely a "constructor is too long" problem, or is there a deeper design issue with putting ~20 loosely
related properties on a single class in the first place?

=> yes , build classbuilder for this constructor is best solutoin 
you may include related parmeteder in one method that help you in create instance or object from it 

and if you want to add more parmeters 
