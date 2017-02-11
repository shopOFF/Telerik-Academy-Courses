#!/bin/bash
mcs Generator.cs && mono Generator.exe && mcs Solution.cs && mono Solution.exe --testgen