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
		$connection =new mysqli($servername, $username, $password, $dbName);

		if($connection) 
		{
			//Variables for userdatabase.
			//$cin = $_POST["cin"];
			$cin=$_POST["cin"];;

			//Getting data from the database.
			$sqlCheck = "SELECT cin FROM utilisateur WHERE cin = '".$cin."' ";
			$resultCheck = mysqli_query($connection, $sqlCheck);
			
			if(mysqli_num_rows($resultCheck) > 0)
			{
				$sqlDelete = "DELETE FROM `utilisateur` WHERE cin = '".$cin."' ";
				$resultDelete = mysqli_query($connection, $sqlDelete);
			
				if($resultDelete)
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
				echo("pas");
			}
		}
		
		else
		{
			die("Coonection Failed.".mysql_connect_error());
			echo("Failed");
		}
	
?>