
#!/usr/bin/python
import serial, string

output = " "
ser = serial.Serial('/dev/ttyUSB0', 115200, 8, 'N', 1, timeout=5)
x = 0;
try:
	while x<1000000:
		print("----")
		while output != "":
			x = x+1
			output = ser.readline()
			print(output)
		output = " "
	print(99999);
except:
	print(x)
	