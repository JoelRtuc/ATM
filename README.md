## Usage
1. **Launch the application**: Follow the prompts in the console.
2. **Authenticate**: Enter your PIN and name to activate your account.
3. **Select an option**:
- `1`: Deposit funds.
- `2`: Withdraw funds.
- `3`: Check your account balance.
- `4`: Exit with message.

## Code Overview
### `Costumer` Class
The `Costumer` class represents a bank customer and includes the following:
- **Properties**:
- `Pin`: Writable but not readable for security.
- `Name`: The name of the customer.
- `Balance`: The current balance of the customer.
- **Methods**:
- `ActivateAccount(int pin, string name)`: Authenticates the customer based on their PIN and name.
- `Deposit(double amount)`: Adds funds to the customer's account.
- `Withdraw(double amount)`: Deducts funds from the customer's account.
- `CheckBalance()`: Displays the current balance.

### `Program` Class
The `Program` class contains the `Main` method, which handles:
- User authentication.
- Menu-driven options for deposit, withdrawal, and balance checking.
