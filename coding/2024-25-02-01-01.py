def countdigits(num):
    digitcount=0
    while num !=0:
        num //=10 #floor assingment operator
        digitcount +=1 

    return digitcount
n1=abs(int(input("your number?")))

print(f'there are {countdigits(n1)}  in {n1}')