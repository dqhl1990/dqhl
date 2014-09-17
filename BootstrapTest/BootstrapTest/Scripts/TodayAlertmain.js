$(function () {
    $('.form_time').datetimepicker({
        language: 'zh-CN',
        autoclose: 1,
        todayHighlight: 1,
        startView: 1,
        forceParse: 0
        
    });

})




//控制导航栏选中状态与否
$(function () {

    $(".controlmyself").mouseover(function () {
        $("#controlmyself").addClass("active");
    });
    $(".controlmyself").mouseout(function () {
        $("#controlmyself").removeClass("active");
    })

    $(".healthdocument").mouseover(function () {
        $("#healthdocument").addClass("active");
    });
    $(".healthdocument").mouseout(function () {
        $("#healthdocument").removeClass("active");
    })

    $(".educationclass").mouseover(function () {
        $("#educationclass").addClass("active");
    });
    $(".educationclass").mouseout(function () {
        $("#educationclass").removeClass("active");
    })

    $(".mydoctor").mouseover(function () {
        $("#mydoctor").addClass("active");
    });
    $(".mydoctor").mouseout(function () {
        $("#mydoctor").removeClass("active");
    })


    $("#addrecord").mouseover(function () {
        $("#addrecord").addClass("active");
    });
    $(".mydoctor").mouseout(function () {
        $("#mydoctor").removeClass("active");
    })
})
debugger;
var t_TodayAlert = null;
$(function () {
    $("#SaveNewTimeFromTASuccess").fadeTo(1, 0);

    var UserID = 1;
    debugger;
    $.ajax({
        url: "../TodayAlert/DisplayTA",
        type: "POST",
        data: { "UserID": UserID },
        dataType: "json"
    }).done(function (data) {
        if (data[0] == "空") {
            data = null;
        }
        debugger;
        t_TodayAlert = $("#TodayAlertTable").DataTable({
            "searching": false,
            "columnDefs": [
               {
                   "targets": -1,
                   "data": null,
                   "defaultContent": "<button class='btn btn-xs btn-success'><i class='fa fa-hand-o-right'> &nbsp;&nbsp;去完成</i></button>",
                   "width": "20%",
                   "orderable": false
               },

              {
                  "targets": [0],
                  "visible": false,
                  "searchable": false
              },
              {
                  "targets": [1],
                  "visible": false,
                  "searchable": false
              },
              {
                  "targets": [2],
                  "visible": false,
                  "searchable": false
              },
              {
                  "targets": [5],
                  "visible": false,
                  "searchable": false
              },
              {
                  "targets": [6],
                  "visible": false,
                  "searchable": false
              },
              {
                  "targets": [7],
                  "visible": false,
                  "searchable": false
              }
            ],
            "language": {
                "zeroRecords": "您还没有添加计划奥",
                "info": "第_PAGE_页/共_PAGES_页",
                "infoEmpty": "第一页还没有内容奥",
                "paginate": {
                    "next": "下一页",
                    "previous": "上一页"
                },
                "emptyTable": "今天没有任务奥！"
            },
            data: data
        });
        CompleteOrNotTrans();
    });



    $("#TodayAlertTable").on("mouseover", "tbody td", function () {

        var colIdx = t_TodayAlert.cell(this).index().column;
        var rowIdx = t_TodayAlert.cell(this).index().row;

        if (colIdx != null) {
            if (colIdx != 3 && colIdx != 8) {
                $(t_TodayAlert.cells().nodes()).removeClass("highlight");

                $(t_TodayAlert.cell(rowIdx, colIdx).nodes()).addClass("highlight");
            }
        }
    }).on("mouseleave", "tbody td", function () {

        $(t_TodayAlert.cells().nodes()).removeClass("highlight");

    });




    $("#TodayAlertTable").on("click", "tbody tr>td", function () {

        debugger;
        var colIdx = t_TodayAlert.cell(this).index().column;
        var rowIdx = t_TodayAlert.cell(this).index().row;
        var todayalertid = t_TodayAlert.cell(rowIdx, 0).data();
        var userid = t_TodayAlert.cell(rowIdx, 1).data();
        var planid = t_TodayAlert.cell(rowIdx, 2).data();
        debugger;
        if (colIdx == 4) {
            UpdateTimeFromTA(userid, planid, todayalertid, colIdx, rowIdx);
        }
    });
})


function UpdateTimeFromTA(userid, planid, todayalertid,colIdx,rowIdx) {
    $("#UpdateTimeFromTA").modal();
    $("#SaveNewTimeFromTA").unbind().click(function () {
        var newvalue = $("#NewTimeFromTA").val();
        $.ajax({
            url: "../TodayAlert/UpdateTimeFromTA",
            type: "POST",
            data: { "UserID": userid, "PlanID": planid, "TodayAlertID": todayalertid, "NewTimeFromTA": newvalue },
            dataType: "json"
        }).done(function (data) {
            $("#SaveNewTimeFromTASuccess").fadeTo(300, 1);
            $("#SaveNewTimeFromTASuccess").fadeTo(700, 0);
            var t = setTimeout('$("#UpdateTimeFromTA").modal("hide")', 1000);
            debugger;
            t_TodayAlert.cell(rowIdx, (colIdx + 1)).data("False").draw();
            t_TodayAlert.cell(rowIdx, colIdx).data(newvalue).draw();
            $(t_TodayAlert.cell(rowIdx, colIdx).nodes()).addClass("highlight");
            $(t_TodayAlert.cell(rowIdx, 7).nodes()).html("<button class='btn btn-xs btn-success'><i class='fa fa-hand-o-right'> &nbsp;&nbsp;去完成</i></button>");
        });
    });
}




function CompleteOrNotTrans() {
    debugger;
    var col = t_TodayAlert.column(0).data().length;
    debugger;
    for (var i = 0; i < col; i++) {
        debugger;
        var flag = t_TodayAlert.cell(i, 5).data();
        debugger;
        if (flag == "True") {
            debugger;
            $(t_TodayAlert.cell(i, 8).nodes()).html("<button class='btn btn-xs btn-danger' disabled='disabled'><i class='fa fa-angellist'> &nbsp;&nbsp;已完成</i></button>");
            debugger;
        }
    }
}






//完成任务接口
$(function () {
    $("#TodayAlertTable").on("click", "tbody button", function () {
        debugger;
        var colIdx = t_TodayAlert.cell($(this).parent()).index().column;
        var rowIdx = t_TodayAlert.cell($(this).parent()).index().row;
        var todayalertid = t_TodayAlert.cell(rowIdx, 0).data();
        var userid = t_TodayAlert.cell(rowIdx, 1).data();
        var planid = t_TodayAlert.cell(rowIdx, 2).data();
        var project = t_TodayAlert.cell(rowIdx, 3).data();
        var AlertDate = t_TodayAlert.cell(rowIdx, 6).data();
        var type = t_TodayAlert.cell(rowIdx, 7).data();
        debugger;

        //var flag = CallAddModal(type, project);
        var flag = 1;
        $.ajax({
            url: "../TodayAlert/GoToFinish",
            type: "POST",
            data: { "UserID": userid, "PlanID": planid, "Flag": flag, "AlertDate": AlertDate },
            dataType: "json"
        }).done(function (data) {
            debugger;
            if (data > 0) {
                t_TodayAlert.cell(rowIdx, 5).data("True").draw();
                CompleteOrNotTrans();
            }

        });

    });

})