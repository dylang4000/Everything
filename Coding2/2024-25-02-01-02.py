max = int(input("GIVE ME MAX! "))
for num in range(1, max+1):
    remainder = num % 10
    if num == 11:
        print(f"{num}th")
    elif num == 12:
        print(f"{num}th")
    elif num == 13:
        print(f"{num}th")
    else:
        match remainder:
            case 1:
                print(f"{num}st")
            case 2:
                print(f"{num}nd")
            case 3:
                print(f"{num}rd")
            case 4|5|6|7|8|9|0:
                print(f"{num}th")