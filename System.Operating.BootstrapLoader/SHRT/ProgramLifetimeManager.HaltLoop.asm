SECTION		.text
BITS		64
GLOBAL		HaltLoop

HaltLoop:
	HLT
	JMP		HaltLoop
