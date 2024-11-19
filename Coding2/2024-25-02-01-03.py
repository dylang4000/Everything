inp=input('enter a palidrome: ').lower()
if inp == inp[::-1]:
    print('palidrome fr')
elif inp != inp[::-1]:
    print('stupid')
else:
    print('do lowercase stupid')