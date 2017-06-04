<?php
	//Callbacks(text): 
		//"Success" - User inputs and database value corresponds.
		//"Incorrect" - User password is incorrect.
		//"Unknown" - User name not available to database.
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
			//Variables for userdatabase.
			$username = $_POST["login"];
			$password = $_POST["mdp"];
		
			//Check data to the database.
			$sql = "SELECT mdp FROM utilisateur WHERE cin = '".$username."' ";
			$result = mysqli_query($connection, $sql);
			
			
			
				if(mysqli_num_rows($result) > 0)
				{
					while($row = mysqli_fetch_assoc($result))
					{
						if($row['mdp'] == $password)
						{

							$sql = "SELECT type FROM utilisateur WHERE cin = '".$username."' ";
			                $result = mysqli_query($connection, $sql);
			                while($row = mysqli_fetch_assoc($result))
					        	{
									echo $row['type'];
								}
			
						}

						else
						{
							echo("Incorrect");
						}	
					}
				}
			
				else
				{
					echo("Incorrect");
				}
			
		
			
		}
		
		else
		{
			die("Coonection Failed.".mysql_connect_error());
			echo("Failed");
		}
	
	
	
?>