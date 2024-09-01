$(function () {
    $('#categoriesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "There is no data in the table",
            "sInfo": "Showing records from _START_ to _END_ of _TOTAL_ records",
            "sInfoEmpty": "No record",
            "sInfoFiltered": "(Found in _MAX_ records)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Show _MENU_ record in page",
            "sLoadingRecords": "Loading...",
            "sProcessing": "Processing...",
            "sSearch": "Search:",
            "sZeroRecords": "No matching records found",
            "oPaginate": {
                "sFirst": "First",
                "sLast": "Last",
                "sNext": "Next",
                "sPrevious": "Previous"
            },
            "oAria": {
                "sSortAscending": ": Activate ascending order",
                "sSortDescending": ": Activate descending order"
            },
            "select": {
                "rows": {
                    "_": "%d record selected",
                    "0": "",
                    "1": "1 record selected"
                }
            }
        }
    });
});