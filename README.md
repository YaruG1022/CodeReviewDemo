# Code Review Training Exercise

Welcome to the Code Review Training Exercise! This hands-on exercise will help you learn the code review process by experiencing it firsthand through a guided GitHub workflow.

## Learning Objectives

By completing this exercise, you will learn:

1. How to identify and fix common code issues
2. The difference between functional correctness and code quality
3. How to respond to code review feedback
4. Best practices for C# development

## Instructions

### Getting Started

1. Fork this repository to your own GitHub account
2. Clone your forked repository to your local machine
3. Create a new branch from main (e.g., `git checkout -b my-code-review`)
4. Review the code in `src/CodeReviewTraining/OrderProcessor.cs`

### Step 1: Submit Your Initial PR

1. Without making any changes yet, create a pull request from your branch to the main repository
2. The GitHub Action will run and leave feedback about the failing tests
3. Review the test failure details

### Step 2: Make the Tests Pass

1. Look for the code sections marked with `STEP 1` comments in `OrderProcessor.cs`
2. Uncomment the necessary code sections to make the tests pass:
   - Null checks
   - Input validation
   - Exception handling
3. Commit and push your changes to update the PR
4. Wait for the GitHub Action to run again

### Step 3: Address Code Quality Issues

1. Once the tests are passing, the GitHub Action will perform a code review
2. It will identify code quality issues that still need to be fixed
3. Look for the code sections marked with `STEP 2` comments in `OrderProcessor.cs`
4. Uncomment the necessary code sections to address each code quality issue:
   - Documentation
   - Logging
5. Commit and push your changes to update the PR again

### Step 4: Get PR Approval

1. Once all code quality issues are fixed, the GitHub Action will automatically approve your PR
2. Review the final feedback and reflect on what you've learned

## Code Review Checklist

During this exercise, you'll address these common code review checklist items:

- [ ] **Null checks**: Are all inputs validated for null?
- [ ] **Input validation**: Is the data validated before processing?
- [ ] **Exception handling**: Are exceptions properly caught and handled?
- [ ] **Documentation**: Is the code well-documented with XML comments?
- [ ] **Logging**: Are important operations and errors properly logged?

## Troubleshooting

- If your PR doesn't trigger the GitHub Action, check if you've created it correctly
- Make sure you're uncommenting the correct sections of code
- If tests are still failing, carefully review the test output for clues

## Next Steps

After completing this exercise, consider:

1. Creating your own code review checklist for future projects
2. Reviewing the unit tests to understand how they verify functionality
3. Adding additional improvements to the code beyond what was required
4. Setting up a similar workflow for your own projects

Good luck and happy coding!