Need to start again effectively

It got too complicated with having the old system and trying to build the new system around it, it was sticky and awkward 

SO, we are going to start again
The Wearhouse will be a way to hold everything in one class, it will manage the logic with the orders and the stock which hasn't moved anywhere.
# Wearhouse
List of orders
List of items not in an order
*other potential attributes*


# Order
ID
List of items on the order
Who currently has it
Who signed it out
start date 
end date


# Items
ID
Name
Description
Condition
Location
Pack QTN 


# THE PLAN

We need to create the system back to a point where we can start making the database again. cus that where the hiccup occurred
So get a screen for viewing all the orders, when an order is viewed it should take us to a different screen which shows us the details of that order with the items.
You should be able to create an order, figure out the logic for adding items, have a list of all the items currently in storage and have them checked boxed for the user to pick whihc ones they want.

# MANTRAS
Comment code throughout, took a break from this project and it's such a wall to come back into it.
Implement one system at a time and commit and push that with a good commit message and comments. ALSO versions as well
Better naming of variables, if a list is only used to show the UI the data then that should be reflected in the var name, if the var is used for accessing the database and only for making that brdige this should be communicated
