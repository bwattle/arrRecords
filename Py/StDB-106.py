from ast import literal_eval
# 21/9/21 Nev Goodyer - sites used are:
# https://realpython.com/python-data-structures/#dict-simple-data-objects
# https://www.w3schools.com/python/python_arrays.asp
# https://www.w3schools.com/python/trypython.asp?filename=demo_class4
# March 2022 - Aiden Gardner helped with the referencing of elements in arrStud 

class STUDENT:
  def __init__(students, studID, firstName, lastName, DOB, gender, avMk):
    students.studID = studID
    students.firstName = firstName
    students.lastName = lastName
    students.DOB = DOB
    students.gender = gender
    students.avMk = avMk

  def strConcat(index):
    print("Record", index.studID, "-", index.firstName, "-", 
          index.lastName, "-", index.DOB, "-", index.gender, "-", index.avMk)

arrStud =[
    STUDENT(1, "Johnny", "Depp","9/6/63","m",78.2),
    STUDENT(2, "Jennifer", "Lawrence","15/8/90","f",88.2),
    STUDENT(3, "George", "Clooney","6/5/61","m",68.2),
    STUDENT(4, "Scarlett", "Johansson","22/11/84","f",72.2)
]

# check of referencing elements of the class (array of records)
print(arrStud[1].firstName)
print(arrStud[1].lastName)

for i in range(0, len(arrStud)):    
    print(arrStud[i].studID, "-", arrStud[i].firstName, "-", arrStud[i].lastName, 
          "-", arrStud[i].DOB, "-", arrStud[i].gender, "-", arrStud[i].avMk)

print()
print()
print("Printing the array of records just gives object references")
print(arrStud)