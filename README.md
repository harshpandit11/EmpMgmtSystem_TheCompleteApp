# EmpMgmtSystem_TheCompleteApp
Thecodebase for the complete EmpMgmtSystem


Harshad Comments :- 1)This is the codebase for a sample console application which I created to test the ctc++ report creation on 2 builds.

2)On build 1 i took out a code coverage coverage report successfully using the VS integration add on . I exercised all of the method via my manual tests
3)Then I did some code changes .. Increased the number of lines of a method and added a few validations (if and else loops)
4)Compiled/Built the solution and then took out code coverage on this new build version
5)In this new build I carried out testing on the newly added lines of code and leaving out the lines of code already covered in build 1.So the coverage
report as expected showed only the new lines of code in GREEN.
6)I merged the 2 reports using the following commands :-

Eg :- ctcxmlmerge ctcreportBuild1.xml ctcreportbuild2.xml -p MergedScenario2.txt

Then converted this MergedScenario2.txt to html via :-

ctc2html -i MergedScenario2.txt

Result :-
Please refer the MergedScenario2.txt/html  for the merged result.It is also attached to the email.
The report highlights only the method call(public void GetEmpDesignation(double EmpSal) in GREEN ,the rest all of the code is without any highlighting
whether RED/Green. It gives a picture that nothing was covered but in fact all of the code is covered if we compare the tests executed on both builds.

I think the following limitations is causing the problem. This limitation is also mentioned by Jetbrains for their dotcover tool which we are using now.

The original code files have not been changed between the builds. Same
functions are on same lines and functions end on same lines. Only the conditional
compilation and macro expansions have changed the code as ctc sees it.
.
In the participating builds the code has been instrumented in the same way. Also
at ctcpost time the XML reports are obtained with same “coverage view”.
