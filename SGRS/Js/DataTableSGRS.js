
(function ($) {

    'use strict';

    $("#datatable").DataTable({
        "language": {
            "paginate": {
                "previous": "anterior",
                "next": "posterior"
            },
            "search": "Buscar:",
            "info": "Total de registros _TOTAL_",
            "infoEmpty": "0 Registros",
            "loadingRecords": "Cargando...",
            "processing": "Procesando...",
            "emptyTable": "No tiene ningún registro",
            "lengthMenu": "Muestra _MENU_ Registros"
        },
        "search": "Buscar:",
        "lengthMenu": [[5, 10, 25, -1], [5, 10, 25, "All"]]

    });


}).apply(this, [jQuery]);

