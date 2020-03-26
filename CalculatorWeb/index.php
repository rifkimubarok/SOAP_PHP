<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3 mt-3">
                <div class="card">
                    <div class="card-header">
                        <h4>Aplikasi Aritmatika</h4>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-9">
                                <div class="row">
                                    <div class="col-md-12 form-group">
                                        <input type="number" class="form-control" name="nilai_a" id="nilai_a"
                                            step="0.01" placeholder="Nilai A">
                                    </div>
                                    <div class="col-md-12 form-group">
                                        <input type="number" class="form-control" name="nilai_b" id="nilai_b"
                                            step="0.01" placeholder="Nilai b">
                                    </div>
                                    <div class="col-md-12 form-group">
                                        <p>Hasil <br><span id="hasil"></span></p>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="row">
                                    <div class="col-md-12">
                                        <button class="btn btn-sm btn-aksi btn-primary mb-2" id="btn_add"
                                            style="width:4em;" data-value="Tambah">+</button>
                                    </div>
                                    <div class="col-md-12">
                                        <button class="btn btn-sm btn-aksi btn-primary mb-2" style="width:4em;"
                                            data-value="Kurang">-</button>
                                    </div>
                                    <div class="col-md-12">
                                        <button class="btn btn-sm btn-aksi btn-primary mb-2" style="width:4em;"
                                            data-value="kali">x</button>
                                    </div>
                                    <div class="col-md-12">
                                        <button class="btn btn-sm btn-aksi btn-primary mb-2" style="width:4em;"
                                            data-value="bagi">/</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
    let input_a = document.querySelector("#nilai_a"),
        input_b = document.querySelector("#nilai_b");
    let btn_aksi = document.getElementsByClassName("btn-aksi");
    let hasil = document.querySelector("#hasil");

    Array.from(btn_aksi).map(function(item, index) {
        item.addEventListener("click", function(e) {
            e.preventDefault();
            let action = item.getAttribute("data-value");
            get_result(action);
        })
    })

    function get_result(action) {
        let a = input_a.value;
        let b = input_b.value;
        let url = `http://localhost/webservice/calculatorweb/client.php?method=${action}&a=${a}&b=${b}`;
        fetch(url, {
                method: "GET"
            }).then(result => result.text())
            .then(response => {
                hasil.innerHTML = `${response}`;
            })
    }
    </script>
</body>

</html>