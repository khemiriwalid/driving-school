<?php
	//Callbacks(text):
		//"Success" - User inputs and database value corresponds.
		//"Unknown" - User inputs not available to database.
		//"Failed" - Failed to connect to database.
		//"Error" - User authentication is not valid.

	
	
	
		
		
	$servername = "localhost";
	$username =  "root";
	$password = "";
	$dbName = "driving_school";
		
		//Established the connection to the mySQL server.
		$connection = new mysqli($servername, $username, $password, $dbName);

		

		if($connection) 
		{
			//Check data to the database.
			$sql = "SELECT cin, login, mdp, nom, prenom, numero, adresse, mail, type FROM utilisateur where cin='11111111'";
			$result = mysqli_query($connection, $sql);
			
			if($result)
			{

				if(mysqli_num_rows($result) > 0)
				{
					while($row = mysqli_fetch_assoc($result))
					{
						echo ";".$row['cin'].":".$row['login'].":".$row['mdp'].":".$row['nom'].":".$row['prenom'].":".$row['type'].":".$row['numero'].":".$row['adresse'];
					}
				}
			
				else
				{
					echo("Unknown");
				}
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