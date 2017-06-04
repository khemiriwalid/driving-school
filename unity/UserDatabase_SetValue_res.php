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
			$date1 = $_POST["date1"];
			
		   $sqlCheck = "SELECT * FROM `reservation` WHERE date1 = '".$date1."' ";
			//$sqlCheck = "SELECT * FROM `reservation` WHERE 'date' = '1' ";
			$resultCheck = mysqli_query($connection, $sqlCheck);
			
			if(!mysqli_num_rows($resultCheck) > 0)
			{
			
			
					//Insert data to the database.
					$sqlSet = "INSERT INTO `reservation` (`id`, `date1`, `heure`, `type`, `validte`, `cin`, `respect`) VALUES(NULL,'".$date1."','8','conduit','0','0','0'),(NULL,'".$date1."','10','conduit','0','0','0'),(NULL,'".$date1."','12','conduit','0','0','0'),(NULL,'".$date1."','14','conduit','0','0','0'),(NULL,'".$date1."','16','conduit','0','0','0'),(NULL,'".$date1."','18','conduit','0','0','0'),(NULL,'".$date1."','20','conduit','0','0','0')";
					$resultSet = mysqli_query($connection, $sqlSet);
					
					if($resultSet)
					{


							$sqlSet = "INSERT INTO `reservation` (`id`, `date1`, `heure`, `type`, `validte`, `cin`, `respect`) VALUES(NULL,'".$date1."','8','code','0','0','0'),(NULL,'".$date1."','9','code','0','0','0'),(NULL,'".$date1."','10','code','0','0','0'),(NULL,'".$date1."','11','code','0','0','0'),(NULL,'".$date1."','12','code','0','0','0'),(NULL,'".$date1."','13','code','0','0','0'),(NULL,'".$date1."','14','code','0','0','0'),(NULL,'".$date1."','15','code','0','0','0'),(NULL,'".$date1."','16','code','0','0','0'),(NULL,'".$date1."','17','code','0','0','0')";
							$resultSet = mysqli_query($connection, $sqlSet);
							if($resultSet){echo("Success");}
							else  echo("Failed");

						
					}
					
					else
					{
						echo("Failed");
					}
				
			}
			
			else
			{
				echo("date existe");
			}	
				
			
		}
	
		else
		{
			die("Coonection Failed.".mysql_connect_error());
			echo("Failed");
		}
	
		
	
?>