package main

import (
	"io/ioutil"
	"log"
	"strings"
)

func main() {
	restoreBackup("TASystemSettings.ini")
	createBackup("TASystemSettings.ini")
	replaceOptions("TASystemSettings.ini")
}

func restoreBackup(filePath string) {
	backupPath := strings.Replace(filePath, ".ini", "_Backup.ini", 1)

	_, err := ioutil.ReadFile(backupPath)
	if err != nil {
		return
	}

	input, err := ioutil.ReadFile(backupPath)
	if err != nil {
		log.Fatal(err)
	}

	err = ioutil.WriteFile(filePath, input, 0644)
	if err != nil {
		log.Fatal(err)
	}
}

func createBackup(filePath string) {
	backupPath := strings.Replace(filePath, ".ini", "_Backup.ini", 1)

	_, err := ioutil.ReadFile(backupPath)
	if err == nil {
		return
	}

	input, err := ioutil.ReadFile(filePath)
	if err != nil {
		log.Fatal(err)
	}

	err = ioutil.WriteFile(backupPath, input, 0644)
	if err != nil {
		log.Fatal(err)
	}
}

func replaceOptions(filePath string) {
	input, err := ioutil.ReadFile(filePath)

	if err != nil {
		log.Fatalln(err)
	}

	lines := strings.Split(string(input), "\n")
	linesModified := 0

	canReplace := false
	for i, line := range lines {

		if strings.Contains(line, "[SystemSettings]") {
			canReplace = true
		} else if line == "\r" {
			canReplace = false
		}

		if strings.Contains(line, "Fullscreen=" )&& canReplace {
			lines[i] = "Fullscreen=False\r"
			linesModified++
		} else if strings.Contains(line, "ResX=") && !strings.Contains(line, "Binner") && canReplace {
			lines[i] = "ResX=3840\r"
			linesModified++
		} else if strings.Contains(line, "ResY=") && !strings.Contains(line, "Binner")  && canReplace {
			lines[i] = "ResY=1080\r"
			linesModified++
		}
	}

	if linesModified > 3 {
		log.Fatalln("Found more than 3 matching options")
	}

	output := strings.Join(lines, "\n")
	err = ioutil.WriteFile(filePath, []byte(output), 0644)
	if err != nil {
		log.Fatalln(err)
	}
}
