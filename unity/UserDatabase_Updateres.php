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
			$date1 = $_POST["date1"];
			$heure = $_POST["heure"];
		

			
				
					//Insert data to the database.					
					$sqlUpdate = "UPDATE reservation SET 
						cin = '".$cin."', 
						validte = '1' WHERE date1 = '".$date1."' and heure='".$heure."'";
						
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