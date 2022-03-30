import java.io.*;

import java.net.*;

public class IP {

	public static void main(String[] args) {
		
		try {
		
			String host = "itescam.edu.mx";
			
			/*
			System.out.printf("La direcci�n de %s es %s \n", host, InetAddress.getByName(host).getHostAddress());
			
			System.out.println();
			
			System.out.printf("El nombre del host para la IP %s es %s\n", numIp, InetAddress.getByName(numIp).getHostName());
			
			System.out.println();
			*/
			
			String ip = "La direcci�n IP de " + host + " es: " + InetAddress.getByName(host).getHostAddress();
			
			File Ip = new File("IP.txt");
			
			BufferedWriter br = new BufferedWriter(new FileWriter(Ip));
			
			br.write(ip);
			br.close();
			
			System.out.println("Archivo creado");
		}
		catch(Exception e) {
			
			e.printStackTrace();
			
		}
		
	}

}
