(function () {
	var btnAdd = document.getElementById("btn-add-item"),
		btnRemove = document.getElementById("btn-remove-item"), // added by me 
		list = document.getElementById("list");

	function formatTime(date) {
		var hours,
			hoursString,
			minutes,
			minutesString,
			seconds,
			secondsString;
		if (!date) {
			date = new Date();
		}

		hours = date.getHours();
		hoursString = ((hours / 10 > 0) ? "" : "0") + hours;
		minutes = date.getMinutes();
		minutesString = ((minutes / 10 > 0) ? "" : "0") + minutes;
		seconds = date.getSeconds();
		secondsString = ((seconds / 10 > 0) ? "" : "0") + seconds;
		return hoursString + ":" + minutesString + ":" + secondsString;
	}

	btnAdd.addEventListener("click", function (e) {
		var time = formatTime();
		console.log(time);
		list.innerHTML += "<li class='list-item'>" + time + "</li>";
	});

	// added by me, removing the first element func
	btnRemove.addEventListener("click", function (b) {
		var elements=document.getElementsByTagName("ul")[0];
		var elementToRemove=elements.getElementsByTagName("li")[0];
		elements.removeChild(elementToRemove);
		alert("You have just removed the first element");
	});

} ());