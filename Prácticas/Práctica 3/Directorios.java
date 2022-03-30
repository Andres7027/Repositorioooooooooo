import java.io.IOException;

import java.nio.file.DirectoryStream;

import java.nio.file.Files;

import java.nio.file.Path;

import java.nio.file.Paths;

public class Directorios {

	public static void main(String[] args) {
	
		
		String nombreDirectorio = "https://www.itescam.edu.mx/portal/";
		
		try (DirectoryStream<Path> ds = Files.newDirectoryStream(Paths.get(nombreDirectorio))) {
		
			for(Path ruta : ds) {
				
				System.out.println(ruta.getFileName());
			}
			
		} catch(IOException e) {
			
			System.out.println("Error ==> " + e.getMessage());
			
		}

		
	}

}

