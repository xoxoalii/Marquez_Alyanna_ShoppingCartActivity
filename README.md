# Shopping Cart System

## Description
This project is a console-based shopping cart system written in C#. It allows users to browse products, select items, manage a cart, and complete checkout transactions while tracking stock levels. The system also generates receipts and maintains an order history for completed purchases.

## Features
##Product Management
-	Displays product list with price and stock
-	Prevents purchasing out-of-stock items
-	Automatically updates stock after purchase
## Cart System
-	Add items to cart
-	Prevent duplicate items by updating quantity instead
-	View cart with subtotal per item
-	Update item quantity
-	Remove individual items
-	Clear entire cart
## Checkout System
-	Calculates subtotal of all items
-	Applies 10% discount for purchases ₱5000 and above
-	Displays final total before payment
-	Validates payment input
-	Ensures payment is sufficient before proceeding
-	Computes change
##Receipt System
-	Generates receipt number
-	Displays full receipt details:
-	Items purchased
-	Total amount
-	Discount applied
-	Final total
-	Payment
-	Change
-	Date and time of transaction
## Order History
-	Stores all completed transactions

## AI Usage in this project
AI was used as a support tool throughout the development of this project, mainly to help clarify the requirements and improve the overall logic of the program. At the beginning, I asked, “Can you simplify this shopping cart system requirement for a beginner and explain how I should start coding it?” so I could better understand how to approach building the system. As I started coding, I used AI to guide me in structuring the program properly, especially in placing the loop correctly so the user could repeatedly add items. I also relied on AI to help debug issues related to input handling and program flow, such as when I asked, “Why does my program keep restarting instead of continuing properly?” To further improve my code, I asked, “Can you help me improve the logic of my shopping cart system code?” Through these interactions, I learned how to properly organize the control flow and where to position important conditions like validation and continuation prompts. After receiving suggestions, I revised the code by adjusting the structure, fixing logic errors, and simplifying parts of the implementation to make it easier for me to understand and explain.

## IN PART 2
AI was used as a support tool throughout the development of this project to improve understanding, logic, and structure of the system.
At the beginning, I asked:
“Can you simplify this shopping cart system requirement for a beginner and explain how I should start coding it?”

This helped me understand how to break the system into smaller parts such as product listing, cart handling, and checkout flow.

During development, I also asked:

“Why does my program keep restarting instead of continuing properly?”
This helped me fix loop structure issues and improve program flow so that the cart system behaves correctly.

I further used AI assistance to:
Improve cart logic (avoiding duplicate entries)
Fix stock handling issues
Organize checkout flow properly
Add receipt generation and order history formatting
Implement proper input validation for payment handling

Through these interactions, I learned how to properly structure a console-based system, separate features into logical sections, and improve overall code readability and functionality.

After receiving AI suggestions, I revised my code by:
Fixing logic errors in cart updates
Improving user input validation
Enhancing checkout and receipt generation flow

## Author
Alyanna V. Marquez

