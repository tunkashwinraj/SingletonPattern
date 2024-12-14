# SingletonPattern


This project demonstrates the implementation of the **Singleton Design Pattern** in a mortgage approval system using C#. The Singleton pattern ensures that there is only a single instance of the `MortgageFacade` class throughout the application's lifecycle. This instance manages mortgage approval processes, interacting with multiple subsystems like **Bank**, **Loan**, and **Credit**.

#### Key Components:

1. **MortgageFacade Singleton Class**: 
   The `MortgageFacadeSingleton` class consolidates the complex logic involved in mortgage approval into a single interface. This class:
   - Combines various subsystems to handle mortgage approval requests.
   - Verifies if a mortgage applicant's financial status meets the necessary conditions for approval.
   - Uses a **static readonly instance** to ensure that only one instance of the `MortgageFacadeSingleton` exists, providing consistent access across the application.

2. **Bank, Loan, and Credit Subsystems**:
   These are separate classes that represent different parts of the mortgage approval process:
   - **Bank**: Retrieves the current checking and savings balances for an applicant.
   - **Loan**: Checks the applicant’s outstanding loans.
   - **Credit**: Checks the applicant's credit rating to determine approval eligibility.

3. **Mortgage Approval Logic**:
   The logic is divided into several conditions:
   - The applicant’s total balance (checking + savings) must be sufficient to cover the loan amount requested.
   - If the total balance is below 20% of the requested loan, the mortgage is denied.
   - The applicant’s credit rating must be above a certain threshold (i.e., **GOOD**) for approval.

4. **Private Constructor**:
   The constructor of `MortgageFacadeSingleton` is **private**, ensuring that the class cannot be instantiated directly from outside. This enforces the Singleton pattern, ensuring only one instance is used throughout the application.

#### Workflow:

1. When the user clicks the **Mortgage Approval** button, the `MortgageFacadeSingleton` is accessed through the **static `Instance` property**.
2. The `MortgageApproval` method is called, where it performs various checks (bank balance, outstanding loans, and credit score) to determine if the mortgage should be approved or denied.
3. The result is displayed to the user with a success or failure message along with the reason for denial, if applicable.

#### Benefits of the Singleton Pattern:
- **Global Access**: The same instance of `MortgageFacadeSingleton` is used across multiple parts of the application.
- **Performance**: Since only one instance is created, memory usage is minimized, and the system can perform more efficiently.
- **Consistency**: The logic is centralized, ensuring consistency in processing mortgage applications.

#### Example Code for Button Handler:

```csharp
private void btnMortgageApproval_Click(object sender, EventArgs e)
{
    string reason = "";
    MortgageApplicant mapp = new MortgageApplicant
    {
        FirstName = "Bill",
        LastName = "Baker",
        BankAccountNum = 12345,
        LoanAccountNum = 12345,
        SSNum = "111-22-3333",
        LoanAmountAsked = 150000
    };

    MortgageFacadeSingleton mf = MortgageFacadeSingleton.Instance;
    bool approved = mf.MortgageApproval(mapp, ref reason);
    if (approved)
        MessageBox.Show("Your application has been approved..");
    else
        MessageBox.Show("Your application has been denied..\n" + reason);
}
```

This code demonstrates how to call the Singleton instance for mortgage approval processing and how the result is displayed to the user.

#### Conclusion:
This project illustrates how the **Singleton design pattern** can be effectively used in real-world applications like mortgage processing, where a single, consistent point of access is required for system operations. By centralizing the approval logic and subsystems, the project enhances maintainability, scalability, and performance.
