s = open('24.txt').readline()
count = mx = 1
for i in range(len(s) - 1):
    if s[i] not in 'QRS' or s[i + 1] not in 'QRS':
        count += 1
        mx = max(count, mx)
    else:
        count = 1
print(mx)
