<?php
	$servername = "localhost";
	$username =  "root";
	$password = "";
	$dbName = "driving_school";
	
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
		echo("Failed");
	}
	else
	 {
	
	$sql = "SELECT * FROM `utilisateur`";
	$result = mysqli_query($conn ,$sql);
	
	
	if(mysqli_num_rows($result) > 0){
		//show data for each row
		while($row = mysqli_fetch_assoc($result)){
			echo "\n".$row['cin'] . ":".$row['login']. ":".$row['mdp'];
		}
	}
	
	
	}
	


?>