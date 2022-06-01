print("Hello World")

x=5
y="John"
#print(x)
#print(y)

a=4
A="sally"
#print(a)
#print(A)

#this is a comment in Python

#this list will have no formatting when printed. It will print just like this
thislist = ["apple", "banana", "orange", "lime"]
print(thislist)

#this loop causes the list to be printed one at a time
thislist = ["apple", "banana", "orange", "lime"]
for x in thislist:
 print(x)
print("")

#this is an easy input becuase it is a string
#username = input("Enter Username:")
#print("Username is: " + username)

#you need to use Float here because it is numbers
x=input("Enter value:")
y=input("enterValue")
z=(float(x)+float(y))
print(f'YOur value is: {z}')
print("")

x = pow(4,3)
print(x)

x=4
y=9
if x > y:
 print("x is greater than y")
else:
 print("y is greater than x")

import calendar

yy = 2022 # year
mm = 5 # month

print(calendar.month(yy, mm)) 


#concatenates two lists
list_1 = [1, 'a']
list_2 = [3, 4, 5]

list_joined = list_1 + list_2
print(list_joined)

