# Makefile

.PHONY: test
test:
	prove --exec gforth t/*.fs
