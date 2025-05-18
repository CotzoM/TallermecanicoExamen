/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mike.tallermecanicofrontend.formulario;

import com.mike.tallermecanicofrontend.TallerMecanicoFrontend;

import com.google.gson.Gson;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
/**
 *
 * @author Mike Cotzojay
 */
public class ApiTaller {

    /**
     *
     * @return
     */
    public static Vehiculo obtenervVehiculo() {
        try {
            URL url = new URL("https://localhost:7062/api/Vehiculo");
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");

            BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
            StringBuilder json = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                json.append(line);
            }
            reader.close();

            Gson gson = new Gson();
            System.out.println("trae json "+json.toString());
        
            
          
           return gson.fromJson(json.toString(), TallerMecanicoFrontend.class);
            


        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    private static class Gson {

        public Gson() {
        }
    }
}
