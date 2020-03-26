<?php
error_reporting(1);
require_once("../src/nusoap.php");
$ns = "http://localhost/";
$server = new soap_server;
$server->configureWSDL('RamalanZodiak',$ns);
$server->wsdl->schemaTargetNamespace = $ns;
$server->register('RamalanZodiak',['nama_zodiak'=>'xsd:string'],['return'=>'xsd:string']);

function RamalanZodiak($nama_zodiak)
{
    if(strlen($nama_zodiak) <= 0){
        return new soap_fault('Client','','Harus ada nilainya!'.$nama_zodiak,'');
    }
    
    $db = new mysqli("localhost","root","mysql","zodiak");

    if($db->connect_error){
        // die("Connection failed: " . $db->connect_error);
        return new soap_fault('Database Sever','','Koneksi ke database gagal!.','');
    }
    
    $result = $db->query("select * from ramalan where nama_zodiak = '$nama_zodiak'");
    if($result->num_rows > 0){
        $data = "";
        while ($row = $result->fetch_object()) {
            $data .=  "
                <b>Zodiak : </b> $row->nama_zodiak <br>
                <b>Tanggal : </b> $row->tanggal <br>
                <b>keuangan : </b> $row->keuangan <br>
                <b>kesehatan : </b> $row->kesehatan <br>
                <b>angka_keberuntungan : </b> $row->angka_keberuntungan <br>
            ";
        }
        return $data;
    }else{
        return new soap_fault('data','',"Tidak ada zodiak dengan nama $nama_zodiak","");
    }
}

if(!isset($HTTP_RAW_POST_DATA))
    $HTTP_RAW_POST_DATA = file_get_contents('php://input');
$server->service($HTTP_RAW_POST_DATA);
exit();