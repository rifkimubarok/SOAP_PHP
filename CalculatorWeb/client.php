<?php

require_once("../src/nusoap.php");

$wsdl = "http://127.0.0.1:8080/webservice.asmx?wsdl";
$client = new nusoap_client($wsdl,'wsdl');

$action = isset($_GET["method"]) ? $_GET["method"] : "";
$a = isset($_GET["a"]) ? $_GET["a"] : "";
$b = isset($_GET["b"]) ? $_GET["b"] : "";

if($a === ""){
    echo "Nilai a tidak boleh kosong";
    exit();
}

if($b === ""){
    echo "Nilai b tidak boleh kosong";
    exit();
}

if($action === ""){
    echo "Aksi tidak boleh kosong";
    exit();
}


$param = ["a"=>intval($a),"b"=>intval($b)];
$result = "";
switch ($action) {
    case 'Tambah':
        $response = $client->call('Tambah',$param);
        if(isset($response["TambahResult"]))
            $result = $response["TambahResult"];
        else
            $result = "terjadi kesalahan";
        break;
    case 'Kurang':
        $response = $client->call('Kurang',$param);
        if(isset($response["KurangResult"]))
            $result = $response["KurangResult"];
        else
            $result = "terjadi kesalahan";
        break;
    case 'kali':
        $response = $client->call('kali',$param);
        if(isset($response["kaliResult"]))
            $result = $response["kaliResult"];
        else
            $result = "terjadi kesalahan";
        break;
    case 'bagi':
        $param = ["a"=>floatval($a),"b"=>floatval($b)];
        $response = $client->call('bagi',$param);
        if(isset($response["bagiResult"]))
            $result = $response["bagiResult"];
        else
            $result = "terjadi kesalahan";
        break;
    
    default:
        $result = "Aksi tidak boleh kosong";
        break;
}
if($client->fault){
    echo "FAULT:<br>";
    echo "Code: { $client->faultcode }<br>";
    echo "String: { $client->faultstring }";
}else{
    echo $result;
}
?>