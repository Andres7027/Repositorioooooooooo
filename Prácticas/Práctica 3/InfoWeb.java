import java.io.*;

import java.net.*;

public class InfoWeb {

	public void descargarPagina() {
		
		try {
			
			URL url = new URL("https://www.itescam.edu.mx/"); 
			
			BufferedReader bf = new BufferedReader(new InputStreamReader(url.openStream()));
			
			File archivo = new File("Info.txt");
			
			BufferedWriter bw = new BufferedWriter(new FileWriter(archivo));
			
			String cadena;
			
			while((cadena = bf.readLine()) != null) {
				
				bw.write(cadena);
			}
			
			bf.close();
			bw.close();
			System.out.println("Archivo creado");
		}
		catch(Exception e) {
			
			e.printStackTrace();
		}
	}
	
	
	public static void main(String[] args) {
		
		InfoWeb test1 = new InfoWeb();
		
		test1.descargarPagina();

	}

}