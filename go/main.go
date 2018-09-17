package main

import (
	"fmt"
	"io/ioutil"
	"strings"
)

func main() {
	path := "TASystemSettings.ini"
	fullscreen := "Fullscreen=True"
	borderless := "Borderless=False"
	resx := "ResX=1920"

	dat, err := ioutil.ReadFile(path)
	check(err)
	lines := strings.Split(string(dat), "\n")

	for _, x := range lines {
		if strings.Contains(x, fullscreen) {
			fmt.Println(x)
		}
		if strings.Contains(x, borderless) {
			fmt.Println(x)
		}
		if strings.Contains(x, resx) {
			fmt.Println(x)
		}
	}
}

func check(e error) {
	if e != nil {
		panic(e)
	}
}
