s = int(input("Ingresa segundos: "))
            

h = s / 3600
m = (s % 3600) / 60
sr = s % 60

print(f"\n{h:.2f} : {m:.2f} : {sr}")