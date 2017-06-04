<?php
	$servername = "localhost";
	$username =  "root";
	$password = "";
	$dbName = "driving_school";
	$cin = $_POST["cin"];
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
		echo("Failed");
	}
	else
	 {
	
	$sql = "SELECT * FROM `utilisateur` where cin='".$cin."'";
	$result = mysqli_query($conn ,$sql);
	
	
	if(mysqli_num_rows($result) > 0){
		//show data for each row
		while($row = mysqli_fetch_assoc($result)){
			echo $row['login'] . ":".$row['mdp']. ":".$row['nom']. ":".$row['prenom']. ":".$row['numero']. ":".$row['adresse']. ":".$row['mail'];
		}
	}
	
	
	}
	


?>