<?php
error_reporting(1);
require_once("src/nusoap.php");
$nama_zodiak = 'libra';

$wsdl = "http://localhost/webservice/server.php?wsdl";
$client = new nusoap_client($wsdl,'wsdl');
$param = ["nama_zodiak"=>$nama_zodiak];
$response = $client->call('RamalanZodiak',$param);
if($client->fault){
    echo "FAULT:<br>";
    echo "Code: { $client->faultcode }<br>";
    echo "String: { $client->faultstring }";
}else{
    echo $response;
}