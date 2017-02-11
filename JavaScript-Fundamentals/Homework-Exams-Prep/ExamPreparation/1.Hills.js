function solve(params) {
    var array = params[0].split(' ').map(Number),
        valley = 0,
        currentRockCount = 0,
        maxRockCount = 0;

    for (var i = 0; i < array.length; i += 1) {
        // going down(checking if we are droping down to a valley)
        if (array[i] > array[i + 1]) {  // check if the next num is smaller
            valley = array[i + 1];   //  for the moment its the smallest(valley)
            currentRockCount += 1;         // so 1 peak so far above the valley, so +1 rock 
        }
        // going up(checking if we are climbing up to a peak)
        if (array[i] < array[i + 1]) {  // check if current num is smaller than next num
            valley = array[i];  // so current num is the smallest(valley)
            currentRockCount += 1;  // +1 ROCK
            if (currentRockCount > maxRockCount) {  // if current rocks are more than max rocks...
                maxRockCount = currentRockCount;
            }
            if (array[i + 1] > array[i + 2]) {  // check if that's the heighest in the sequence , if yes than curren rock counter shoud start from 0 for the next sequence if there is one
                currentRockCount = 0;
            }
        }
    }
    console.log(maxRockCount);
}
solve(['5 1 7 6 3 6 4 2 3 8']);


// втори начин :
function solve(params) {
    var heights = params[0].split(' ').map(Number),
        count = 0,
        bestCount = -1,
        current,
        height,
        isDescending = true;

    current = heights[0];
    heights.push(-1);
    for (var i = 1; i < heights.length; i += 1) {

        height = heights[i];

        // descending - слизаме към долина
        if (isDescending) {
            if (current < height) {  // започваме да се качваме нагоре, ако влезем тук
                isDescending = false;  // спираме да слизаме и започваме да се катерим нагоре
            }
        }
        // ascending - качваме се към връх
        else {
            if (current > height) {
                // save count 
                // reset count
                bestCount = Math.max(bestCount, count);  // запазваме по-голямото от двете
                count = 0;
                isDescending = true;  // спираме да се катерим нагоре и започваме пак да слизаме надоло
            }
        }
        current = height;
        count += 1;
    }
    console.log(bestCount);
}

// трети начин:
function solve(params) {
    var heights = params[0].split(' ').map(Number),
        bestCount = -1,
        peaks = [0];

    for (var i = 1; i < heights.length; i += 1) {
        if (isGreaterThanNeighbours(i, heights)) {
            peaks.push(i);
        }
    }
    peaks.push(heights[heights.length - 1]);

    for (var j = 1; j < peak.length; j += 1) {
        bestCount = math.max(bestCount, peaks[j] - peaks[j - 1]);
    }
    console.log(bestCount);

    function isGreaterThanNeighbours(index, arr) {
        return arr[index - 1] < arr[index] && arr[index] > arr[index + 1];
    }
}