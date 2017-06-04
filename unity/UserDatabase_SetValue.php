<?php
	//Callbacks(text): 
		//"Success" - Successfull adding inputs to database.
		//"Existed" - Username existed from the database
		//"Failed" - Failed adding inputs to database.
		//"Error" - User authentication is not valid.

	$servername = "localhost";
	$username =  "root";
	$password = "";
	$dbName = "driving_school";
		
		//Established the connection to the mySQL server.
		$connection = new mysqli($servername, $username, $password, $dbName);
		if($connection) 
		{
			//Variables for userdatabase.
			$nom = $_POST["nom"];
			$prenom = $_POST["prenom"];
			$cin = $_POST["cin"];
			$numero = $_POST["numero"];
			$adresse = $_POST["adresse"];
			$mail = $_POST["mail"];
			$login = $_POST["login"];
			$mdp = $_POST["mdp"];
		
			
			
					//Insert data to the database.
					$sqlSet = "INSERT INTO utilisateur (cin, login, mdp, nom, prenom, numero, adresse, mail, type) VALUES('".$cin."','".$login."','".$mdp."','".$nom."','".$prenom."','".$numero."','".$adresse."','".$mail."','client')";
					$resultSet = mysqli_query($connection, $sqlSet);
					
					if($resultSet)
					{
						echo("Success");
					}
					
					else
					{
						echo("Failed");
					}
				
				
				
			
		}
	
		else
		{
			die("Coonection Failed.".mysql_connect_error());
			echo("Failed");
		}
	
		
	
?>