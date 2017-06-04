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
	
	//Make Connection
	$connection = new mysqli($servername, $username, $password, $dbName);

		if($connection) 
		{
			//Variables for userdatabase.
			$cin = $_POST["cin"];
			$nom = $_POST["nom"];
			$prenom = $_POST["prenom"];
			$login = $_POST["login"];
			$mdp = $_POST["mdp"];
			$adresse = $_POST["adresse"];
			$mail = $_POST["mail"];
			$numero = $_POST["numero"];

			
				
					//Insert data to the database.					
					$sqlUpdate = "UPDATE utilisateur SET 
						nom = '".$nom."', 
						prenom = '".$prenom."', 
						login = '".$login."', 
						mdp = '".$mdp."', 
						adresse = '".$adresse."', 
						mail = '".$mail."', 
						numero = '".$numero."'
						WHERE cin = '".$cin."' ";
						
					$resultUpdate = mysqli_query($connection, $sqlUpdate);
					
					if($resultUpdate)
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