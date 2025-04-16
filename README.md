# Code Review Exercise

Welcome to the Code Review Exercise! This hands-on exercise will help you learn the code review process by experiencing it firsthand through a guided GitHub workflow.

## Instructions

### Getting Started

> Below we are just getting things set up.

1. In the top right click **Fork** (not forks in the About section)
2. Click **Create Fork**
3. Review the code in `src/CodeReviewTraining/OrderProcessor.cs`
4. Using the online code editor, remove the commend at the top of the file. ONLY this comment, nothing else yet.
5. Click **Commit changes...**

### Now we are ready to start

> In this scenario, you just wrote `OrderProcessor.cs` and your team is about to perform a code review on it.

### Step 1: Submit Your Initial PR

> You think your code is ready so you create a PR (Pull Request)

Without making any changes yet, create a pull request from your branch to the main repository
1. Click **Pull requests** from the top
2. Click **New Pull Request**
3. Click **Create pull request**
> Now this is where you give your PR a good name and strong description.
4. This screen shows you the diff of all the code in this PR.
5. Click the green button **Create pull request**
6. RIGHT HERE: Leave this page open, where it says _"from..."_ open that in a new tab.
7. Go back to the first tab and click **Checks**
8. The GitHub Action will run and leave feedback about the failing tests
9. Review the test failure details

### Step 2: Fixing So Tests Pass

> After you made your PR, you noticed your code isn't passing all the tests. Before bugging your team to review the code, lets get the tests passing.

1. Go back to the second tab (step 6 in previous)
2. Navigate to `src/CodeReviewTraining/OrderProcessor.cs`
3. Remove the commented out code that is causing the tests to fail. **ONLY REMOVE STEP 1, DON'T TOUCH STEP 2 YET"
    - Don't just comment these out and move on, look at the reasoning why
4. Once fixed, click **Commit changes...**
5. Navigate back to the PR tab. You should see this new commit on there and the tests start to run again.
    - If you don't see the new commit, make sure you are on the _**Conversation**_ tab

### Step 3: Address Code Quality Issues

> Your tests are now passing but you need to address your code quality comments from your team. To view their comments look at the _**Files changed**_ tab

1. Go back to the second tab
2. Navigate to `src/CodeReviewTraining/OrderProcessor.cs`
3. Remove ALL the commented out code
    - Don't just comment these out and move on, look at the reasoning why
4. Once fixed, click **Commit changes...**
5. Navigate back to the PR tab. You should see this new commit on there and the tests start to run again.
    - If you don't see the new commit, make sure you are on the _**Conversation**_ tab

### Step 4: Get PR Approval

> Now your code is ready for a PR! All your tests are passing and your team thinks the code is maintainable.


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