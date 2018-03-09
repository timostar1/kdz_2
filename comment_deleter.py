file_path = input('¬ведите путь к файлу: ')
# Jarvis.cs
res = ""
with open(file_path, "r") as f:
    s = f.readline()
    
    while s != "":
        #print(s.find(r"//"))
        try:
            ttt = s.find(r"//")
            #print(ttt)
            x = s[:ttt]
            if ttt == -1:
                res += x + '\n'
        except:
            pass
        s = f.readline()

with open(file_path + "_without_comments.txt", "w+") as f:
    f.write(res)
input()
