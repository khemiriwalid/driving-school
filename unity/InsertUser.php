<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "root";
	$server_password = "";
	$dbName = "driving_school";
	
//Variable from the user	
	$cin = $_POST["cin"];
	$login = $_POST["login"];
	$mdp = $_POST["mdp"];
	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "INSERT INTO utilisateur (cin, login, mdp)
			VALUES ('".$cin."','".$login."','".$mdp."')";
	$result = mysqli_query($conn ,$sql);
	
	if(!result) echo "there was an error";
	else echo "Everything ok.";

?>


