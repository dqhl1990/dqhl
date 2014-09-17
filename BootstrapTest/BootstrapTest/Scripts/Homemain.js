//时间控件-修改闹钟
$(function () {
    $('.form_time').datetimepicker({
        language: 'zh-CN',
        autoclose: 1,
        todayHighlight: 1,
        startView: 1,
        forceParse: 0
        
    });

})

//时间空间-修改日期

$(function () {
    $('.form_date').datetimepicker({
        language: 'zh-CN',
        autoclose: 1,
        todayHighlight: 1,
        startView: 2,
        forceParse: 0,
        minView:2,
        maxView:2,
        todayBtn:1
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

//在外部JS文件里应用html帮助器的方法
//MyWebUrlSettings.HomeSearchGoals

//载入页面时显示已设定值或默认值
var MYGOALS = null;
$(function () {

    var UserID = 1;
    
    debugger;
    $.ajax({
        url: "../Home/SearchGoals",
        type: "POST",
        data: { "UserID": UserID },
        dataType: "json"
    }).done(function (data) {
        debugger;
        MYGOALS = data;
        var a = data;
        $("#HbA1c").val(a.HbA1c);
        
        if (a.FPGflag == true) {
            $("#FPGUnit").html("mmol/L<span class='caret'></span>");
            $("#FPG").attr("placeholder", "4.4～6.1");
            $("#FPG").val(a.FPGmmolL);
        }
        else {
            $("#FPGUnit").html("mg/dl<span class='caret'></span>");
            $("#FPG").attr("placeholder", "80～110");
            $("#FPG").val(a.FPGmgdl);
        }
        
        if (a.PPGflag == true) {
            $("#PPGUnit").html("mmol/L<span class='caret'></span>");
            $("#PPG").attr("placeholder", "4.4～8.0");
            $("#PPG").val(a.PPGmmolL);
        }
        else {
            $("#PPGUnit").html("mg/dl<span class='caret'></span>");
            $("#PPG").attr("placeholder", "80～145");
            $("#PPG").val(a.PPGmgdl);
        }
        $("#BPH").val(a.BPH);
        $("#BPL").val(a.BPL);
        
        if (a.Tchflag == true) {
            $("#TchUnit").html("mmol/L<span class='caret'></span>");
            $("#Tch").attr("placeholder", "≤4.5");
            $("#Tch").val(a.TchmmolL);
        }
        else {
            $("#TchUnit").html("mg/dl<span class='caret'></span>");
            $("#Tch").attr("placeholder", "≤174");
            $("#Tch").val(a.Tchmgdl);
        }
        
        if (a.LDLchflag == true) {
            $("#LDLchUnit").html("mmol/L<span class='caret'></span>");
            $("#LDLch").attr("placeholder", "≤2.5");
            $("#LDLch").val(a.LDLchmmolL);
        }
        else {
            $("#LDLchUnit").html("mg/dl<span class='caret'></span>");
            $("#LDLch").attr("placeholder", "≤97");
            $("#LDLch").val(a.LDLchmgdl);
        }
        
        if (a.HDLchflag == true) {
            $("#HDLchUnit").html("mmol/L<span class='caret'></span>");
            $("#HDLch").attr("placeholder", "＞1.04(1.30女)");
            $("#HDLch").val(a.HDLchmmolL);
        }
        else {
            $("#HDLchUnit").html("mg/dl<span class='caret'></span>");
            $("#HDLch").attr("placeholder", "＞40(50女)");
            $("#HDLch").val(a.HDLchmgdl);
        }
        
        if (a.TGflag == true) {
            $("#TGUnit").html("mmol/L<span class='caret'></span>");
            $("#TG").attr("placeholder", "≤1.5");
            $("#TG").val(a.TGmmolL);
        }
        else {
            $("#TGUnit").html("mg/dl<span class='caret'></span>");
            $("#TG").attr("placeholder", "≤133");
            $("#TG").val(a.TGmgdl);
        }
        
        if (a.Uaflag == true) {
            $("#UaUnit").html("umol/L<span class='caret'></span>");
            $("#Ua").attr("placeholder", "≤426");
            $("#Ua").val(a.UaumolL);
        }
        else {
            $("#UaUnit").html("mg/dl<span class='caret'></span>");
            $("#Ua").attr("placeholder", "≤7.2");
            $("#Ua").val(a.Uamgdl);
        }
        
        if (a.AlbCrflag == true) {
            $("#AlbCrUnit").html("mg/mmol<span class='caret'></span>");
            $("#AlbCr").attr("placeholder", "≤2.5(3.5女)");
            $("#AlbCr").val(a.AlbCrmgmmol);
        }
        else {
            $("#AlbCrUnit").html("mg/g<span class='caret'></span>");
            $("#AlbCr").attr("placeholder", "≤22(31女)");
            $("#AlbCr").val(a.AlbCrmgg);
        }
        $("#Athlete").val(a.Athlete);
        $("#Weight").val(a.Weight);
        debugger;
    })

})


//修改单位
$(function () {
    $("#FPGUnit1").click(function () {
        $("#FPGUnit").html("mmol/L<span class='caret'></span>");
        $("#FPG").attr("placeholder", "4.4～6.1");
        $("#FPG").val(MYGOALS.FPGmmolL);
    });
    $("#FPGUnit2").click(function () {
        $("#FPGUnit").html("mg/dl<span class='caret'></span>");
        $("#FPG").attr("placeholder", "80～110");
        $("#FPG").val(MYGOALS.FPGmgdl);
    });
    $("#PPGUnit1").click(function () {
        $("#PPGUnit").html("mmol/L<span class='caret'></span>");
        $("#PPG").attr("placeholder", "4.4～8.0");
        $("#PPG").val(MYGOALS.PPGmmolL);
    });
    $("#PPGUnit2").click(function () {
        $("#PPGUnit").html("mg/dl<span class='caret'></span>");
        $("#PPG").attr("placeholder", "80～145");
        $("#PPG").val(MYGOALS.PPGmgdl);
    });
    $("#TchUnit1").click(function () {
        $("#TchUnit").html("mmol/L<span class='caret'></span>");
        $("#Tch").attr("placeholder", "≤4.5");
        $("#Tch").val(MYGOALS.TchmmolL);
    });
    $("#TchUnit2").click(function () {
        $("#TchUnit").html("mg/dl<span class='caret'></span>");
        $("#Tch").attr("placeholder", "≤174");
        $("#Tch").val(MYGOALS.Tchmgdl);
    });
    $("#LDLchUnit1").click(function () {
        $("#LDLchUnit").html("mmol/L<span class='caret'></span>");
        $("#LDLch").attr("placeholder", "≤2.5");
        $("#LDLch").val(MYGOALS.LDLchmmolL);
    });
    $("#LDLchUnit2").click(function () {
        $("#LDLchUnit").html("mg/dl<span class='caret'></span>");
        $("#LDLch").attr("placeholder", "≤97");
        $("#LDLch").val(MYGOALS.LDLchmgdl);
    });
    $("#HDLchUnit1").click(function () {
        $("#HDLchUnit").html("mmol/L<span class='caret'></span>");
        $("#HDLch").attr("placeholder", "＞1.04(1.30女)");
        $("#HDLch").val(MYGOALS.HDLchmmolL);
    });
    $("#HDLchUnit2").click(function () {
        $("#HDLchUnit").html("mg/dl<span class='caret'></span>");
        $("#HDLch").attr("placeholder", "＞40(50女)");
        $("#HDLch").val(MYGOALS.HDLchmgdl);
    });
    $("#TGUnit1").click(function () {
        $("#TGUnit").html("mmol/L<span class='caret'></span>");
        $("#TG").attr("placeholder", "≤1.5");
        $("#TG").val(MYGOALS.TGmmolL);
    });
    $("#TGUnit2").click(function () {
        $("#TGUnit").html("mg/dl<span class='caret'></span>");
        $("#TG").attr("placeholder", "≤133");
        $("#TG").val(MYGOALS.TGmgdl);
    });
    $("#UaUnit1").click(function () {
        $("#UaUnit").html("umol/L<span class='caret'></span>");
        $("#Ua").attr("placeholder", "≤426");
        $("#Ua").val(MYGOALS.UaumolL);
    });
    $("#UaUnit2").click(function () {
        $("#UaUnit").html("mg/dl<span class='caret'></span>");
        $("#Ua").attr("placeholder", "≤7.2");
        $("#Ua").val(MYGOALS.Uamgdl);
    });
    $("#AlbCrUnit1").click(function () {
        $("#AlbCrUnit").html("mg/mmol<span class='caret'></span>");
        $("#AlbCr").attr("placeholder", "≤2.5(3.5女)");
        $("#AlbCr").val(MYGOALS.AlbCrmgmmol);
    });
    $("#AlbCrUnit2").click(function () {
        $("#AlbCrUnit").html("mg/g<span class='caret'></span>");
        $("#AlbCr").attr("placeholder", "≤22(31女)");
        $("#AlbCr").val(MYGOALS.AlbCrmgg);
    });
})



//提交控制目标
$(function () {
    $("#SaveControlGoals").click(function () {
        var HbA1c = $("#HbA1c").val();
        var FPG = $("#FPG").val();
        var Unit1 = $("#FPGUnit").text();
        if (Unit1 == "mmol/L") {
            var FPGflag = true;
        }
        else {
            var FPGflag = false;
        }
        var PPG = $("#PPG").val();
        var Unit2 = $("#PPGUnit").text();
        if (Unit2 == "mmol/L") {
            var PPGflag = true;
        }
        else {
            var PPGflag = false;
        }
        var BPH = $("#BPH").val();
        var BPL = $("#BPL").val();
        var Tch = $("#Tch").val();
        var Unit3 = $("#TchUnit").text();
        if (Unit3 == "mmol/L") {
            var Tchflag = true;
        }
        else {
            var Tchflag = false;
        }
        var LDLch = $("#LDLch").val();
        var Unit4 = $("#LDLchUnit").text();
        if (Unit4 == "mmol/L") {
            var LDLchflag = true;
        }
        else {
            var LDLchflag = false;
        }
        var HDLch = $("#HDLch").val();
        var Unit5 = $("#HDLchUnit").text();
        if (Unit5 == "mmol/L") {
            var HDLchflag = true;
        }
        else {
            var HDLchflag = false;
        }
        var TG = $("#TG").val();
        var Unit6 = $("#TGUnit").text();
        if (Unit6 == "mmol/L") {
            var TGflag = true;
        }
        else {
            var TGflag = false;
        }
        var Ua = $("#Ua").val();
        var Unit7 = $("#UaUnit").text();
        if (Unit7 == "umol/L") {
            var Uaflag = true;
        }
        else {
            var Uaflag = false;
        }
        var AlbCr = $("#AlbCr").val();
        var Unit8 = $("#AlbCrUnit").text();
        if (Unit8 == "mg/mmol") {
            var AlbCrflag = true;
        }
        else {
            var AlbCrflag = false;
        }
        var Athlete = $("#Athlete").val();
        var Weight = $("#Weight").val();
        debugger;
        $.ajax({
            url: "../Home/UpateGoals",
            type: "POST",
            data: { "UserID": 1, "HbA1c": HbA1c, "FPG": FPG, "FPGflag": FPGflag, "PPG": PPG, "PPGflag": PPGflag, "BPH": BPH, "BPL": BPL, "Tch": Tch, "Tchflag": Tchflag, "LDLch": LDLch, "LDLchflag": LDLchflag, "HDLch": HDLch, "HDLchflag": HDLchflag, "TG": TG, "TGflag": TGflag, "Ua": Ua, "Uaflag": Uaflag, "AlbCr": AlbCr, "AlbCrflag": AlbCrflag, "Athlete": Athlete, "Weight": Weight },
            dataType: "json"
        }).done(function (data) {
            if (data.UserID != 0) {
                MYGOALS = data;
                $("#SaveControlGoalsSuccess").fadeTo(500, 1);
                $("#SaveControlGoalsSuccess").fadeTo(1000, 0);
            }

        });
    })
})














//血糖监测计划初始化及操作
debugger;
var table = null;
$(function () {
    $("#SaveControlGoalsSuccess").fadeTo(1, 0);
    $("#SaveBSPlanSuccess").fadeTo(1, 0);
    $("#SaveNewBSProjectSuccess").fadeTo(1, 0);
    $("#SaveNewBSFrequencySuccess").fadeTo(1, 0);
    $("#SaveNewBSTimeSuccess").fadeTo(1, 0);
    $("#SaveNewBSDateSuccess").fadeTo(1, 0);


    $.ajax({
        url: "../Home/SearchBSPlan",
        type: "POST",
        data: { "UserID": 1 },
        dataType: "json"
    }).done(function (data) {
        debugger;
        if (data[0] == "空") {
            data = null;
        }

        debugger;
        table = $("#BSPlanTable").DataTable({
            "searching": false,
            "columnDefs": [
               {
                   "targets": -1,
                   "data": null,
                   "defaultContent": "<button class='btn btn-xs btn-secondary'><i class='fa fa-times'></i></button>",
                   "width": "30%",
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
                  "targets": [6],
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
                }
            },

            data: data
        });

    });






    $("#BSPlanTable").on("mouseover", "tbody td", function () {

        var colIdx = table.cell(this).index().column;
        var rowIdx = table.cell(this).index().row;

        if (colIdx != null) {
            if (colIdx != 7) {
                $(table.cells().nodes()).removeClass("highlight");

                $(table.cell(rowIdx, colIdx).nodes()).addClass("highlight");
            }
        }
    }).on("mouseleave", "tbody td", function () {

        $(table.cells().nodes()).removeClass("highlight");

    });


    $("#BSPlanTable").on("click", "tbody tr>td", function () {

        debugger;
        var colIdx = table.cell(this).index().column;
        var rowIdx = table.cell(this).index().row;
        var title = table.column(colIdx).header().innerHTML;
        var userid = table.cell(rowIdx, 0).data();
        var planid = table.cell(rowIdx, 1).data();
        debugger;
        switch (title) {
            case "监测项目":
                UpdateBSProject(userid, planid, title, colIdx, rowIdx);
                break;
            case "频率":
                UpdateBSFrequency(userid, planid, title, colIdx, rowIdx);
                break;
            case "闹钟":
                UpdateBSTime(userid, planid, title, colIdx, rowIdx);
                break;
            case "起效日期":
                UpdateBSDate(userid, planid, title, colIdx, rowIdx);
                break;
        }
    });


})


//修改血糖检测项目信息函数
function UpdateBSProject(userid,planid,title,colIdx,rowIdx) 
{
    $("#UpdateBSProject").modal();
    debugger;
    $("#SaveNewBSProject").unbind().click(function () {
        var newproject = $("#NewBSProject").val();
        var UserID = userid;
        var PlanID = planid;
        var Project = title;
        debugger;
        $.ajax({
            url: "../Home/UpdatePlan",
            type: "POST",
            data: { "UserID": UserID, "PlanID": PlanID, "Project": Project, "NewValue": newproject },
            dataType: "json"
        }).done(function (data) {
            if (data == 1) {
                debugger;
                $("#SaveNewBSProjectSuccess").fadeTo(300, 1);
                $("#SaveNewBSProjectSuccess").fadeTo(700, 0);
                var t = setTimeout('$("#UpdateBSProject").modal("hide")', 1000);
                debugger;
                table.cell(rowIdx, colIdx).data(newproject).draw();
                $(table.cell(rowIdx, colIdx).nodes()).addClass("highlight");                
                debugger;
            }

        });
    });

}

//修改血糖检测频率信息函数
function UpdateBSFrequency(userid, planid, title, colIdx, rowIdx) {
    $("#UpdateBSFrequency").modal();
    debugger;
    $("#SaveNewBSFrequency").unbind().click(function () {
        var newproject = $("#NewBSFrequency").val();
        var UserID = userid;
        var PlanID = planid;
        var Project = title;
        debugger;
        $.ajax({
            url: "../Home/UpdatePlan",
            type: "POST",
            data: { "UserID": UserID, "PlanID": PlanID, "Project": Project, "NewValue": newproject },
            dataType: "json"
        }).done(function (data) {
            if (data == 1) {
                debugger;
                $("#SaveNewBSFrequencySuccess").fadeTo(300, 1);
                $("#SaveNewBSFrequencySuccess").fadeTo(700, 0);
                var t = setTimeout('$("#UpdateBSFrequency").modal("hide")', 1000);
                debugger;
                table.cell(rowIdx, colIdx).data(newproject).draw();
                $(table.cell(rowIdx, colIdx).nodes()).addClass("highlight");
                debugger;
            }

        });
    });

}






//修改血糖检测时间信息函数
function UpdateBSTime(userid, planid, title, colIdx, rowIdx) {
    $("#UpdateBSTime").modal();
    debugger;
    $("#SaveNewBSTime").unbind().click(function () {
        var newproject = $("#NewBSTime").val();
        var UserID = userid;
        var PlanID = planid;
        var Project = title;
        debugger;
        $.ajax({
            url: "../Home/UpdatePlan",
            type: "POST",
            data: { "UserID": UserID, "PlanID": PlanID, "Project": Project, "NewValue": newproject },
            dataType: "json"
        }).done(function (data) {
            if (data == 1) {
                debugger;
                $("#SaveNewBSTimeSuccess").fadeTo(300, 1);
                $("#SaveNewBSTimeSuccess").fadeTo(700, 0);
                var t = setTimeout('$("#UpdateBSTime").modal("hide")', 1000);
                debugger;
                table.cell(rowIdx, colIdx).data(newproject).draw();
                $(table.cell(rowIdx, colIdx).nodes()).addClass("highlight");
                debugger;
            }

        });
    });
}









//修改血糖检测起效日期信息函数
function UpdateBSDate(userid, planid, title, colIdx, rowIdx) {
    $("#UpdateBSDate").modal();
    debugger;
    $("#SaveNewBSDate").unbind().click(function () {
        var newproject = $("#NewBSDate").val();
        var UserID = userid;
        var PlanID = planid;
        var Project = title;
        debugger;
        $.ajax({
            url: "../Home/UpdatePlan",
            type: "POST",
            data: { "UserID": UserID, "PlanID": PlanID, "Project": Project, "NewValue": newproject },
            dataType: "json"
        }).done(function (data) {
            if (data == 1) {
                debugger;
                $("#SaveNewBSDateSuccess").fadeTo(300, 1);
                $("#SaveNewBSDateSuccess").fadeTo(700, 0);
                var t = setTimeout('$("#UpdateBSDate").modal("hide")', 1000);
                debugger;
                table.cell(rowIdx, colIdx).data(newproject).draw();
                $(table.cell(rowIdx, colIdx).nodes()).addClass("highlight");
                debugger;
            }

        });
    });
}









//测试













//血糖监测计划提交
$(function () {
    $("#SaveBSPlan").click(function () {
        var UserID = 1;
        var project = $("#BSProject").val();
        var frequency = $("#BSFrequency").val();
        var time = $("#BSTime").val();
        var date = $("#BSDate").val();
        var type = 1;
        $.ajax({
            url: "../Home/InsertBSPlan",
            type: "POST",
            data: { "UserID": UserID, "Project": project, "Frequency": frequency, "Time": time, "Date": date,"Type":type },
            dataType: "json"
        }).done(function (data) {
            debugger;
            if (data != null) {
                var length = data.length;

                table.clear().draw();
                for (var i = 0; i < length; i++) {
                    table.row.add(data[i]).draw();
                }
                debugger;
                $("#SaveBSPlanSuccess").fadeTo(300, 1);
                $("#SaveBSPlanSuccess").fadeTo(700, 0);
                var t = setTimeout('$("#AddBSPlan").modal("hide")', 1000);
            }
        })
    })
})




//删除指定的计划
$(function () {
    $("#BSPlanTable").on("click", "tbody button", function () {
        debugger;
        var colIdx = table.cell($(this).parent()).index().column;
        var rowIdx = table.cell($(this).parent()).index().row;
        var title = table.column(colIdx).header().innerHTML;
        var userid = table.cell(rowIdx, 0).data();
        var planid = table.cell(rowIdx, 1).data();
        var newproject = null;
        debugger;

        $.ajax({
            url: "../Home/UpdatePlan",
            type: "POST",
            data: { "UserID": userid, "PlanID": planid, "Project": title, "NewValue": newproject },
            dataType: "json"
        }).done(function (data) {
           debugger;
           table.row(rowIdx).remove().draw();
        });
    });

})