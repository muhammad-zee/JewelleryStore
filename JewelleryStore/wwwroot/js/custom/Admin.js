$(document).ready(function (){
    $("#tbl_Products,#tbl_ProductTypes,#tbl_ProductCategories").dataTable();
    getProducts_PartiialView()
})

//function getProducts_PartiialView() {
//    $.ajax({
//        url: getAppRootPath() + 'Admin/getAll_Products',
//        type: 'POST',
//        contentType: 'application/json; charset=utf-8',
//        success: function (e) {

//            if (e.status == 'ok' && e.data.length > 0) {
             
//        },
//        error: function (e) {
//            Metronic.unblockUI('#tab_1_5.tab-pane');
//            unblockUI("#table_procducts");
//            alert(e.responseJSON);
//        }
//    });

//}
function getProducts_PartiialView() {
    blockUi();
    $.ajax({
        url: "/Admin/getProducts_PartiialView",
        type: "Get",
        dataType: 'html',
        async: true,
        cache: false,
        contentType: 'application/json; charset=utf-8'
    }).done(function (data) {
        $('#Products_PartialView').html('');
        $('#Products_PartialView').html(data);
        $("#tbl_Products").dataTable({
            "paging": true,
            "ordering": false,
            "info": false,
        });
        unblockUi();

    })
        .always(function () {


        });
}

