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

		$date1 = $_POST["date1"];
		//$date1 = "08/05/2017";

		if($connection) 
		{
			//Check data to the database.
			$sql = "SELECT validte FROM reservation where type='code' and  date1='".$date1."'";
			$result = mysqli_query($connection, $sql);
			
			if($result)
			{

				if(mysqli_num_rows($result) > 0)
				{
					while($row = mysqli_fetch_assoc($result))
					{
						echo ";".$row['validte'];
					}
				}
			
				else
				{
					echo("date invalide");
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