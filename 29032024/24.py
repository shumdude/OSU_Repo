s = open('24.txt').readline()
previous = 0
mx = 1
count = 1
for i in range(1, len(s) - 1):
    if s[previous] <= s[i]:
        count += 1
        mx = max(count, mx)
    else:
        count = 1
    previous = i
print(mx)
