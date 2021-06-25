let dataTable;

$(document).ready(function () {
    loadDataTable();
})

const loadDataTable = () => {
    dataTable = $('#tblData').DataTable({

        "ajax": {
            "url": "/admin/category/GetAll",
            "type": "GET",
            "dataType":"json"
        },
        "columns": [
            { "data": "name", "width": "50%" },
            { "data": "displayOrder", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href="/Admin/category/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer;width:120px;">

                                <i class='far fa-edit'></i> Edit</a>
                                &nbsp;
                            <a onclick=Delete("/Admin/category/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer;width:130px;">

                                <i class="fas fa-trash"></i> Delete</a>
                            </div>`;
                }, "width":"30%"
            }
        ],
        "language": {
            "emptyTable":"No records found."
        }, "width": "100%"
    })
}

const Delete = (url) => {
    swal({
        title: "Are you sure you want to proceed ?",
        text: "You won't be able to restore!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnconfirm:true
    }, () => {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message)
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message)
                }
            }

        })
    })
}

const showMessage = (msg) => {

   
}