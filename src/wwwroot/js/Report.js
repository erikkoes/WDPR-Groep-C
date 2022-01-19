   
   function addpage(){
    var report = document.createElement("Button");
    var reportForm = document.createElement("Form");
    var hiddenInputMessage = document.createElement("input");
    var hiddenInputUser = document.createElement("input");
    report.textContent = "Report";
    report.classList.add("btn");
    report.classList.add("btn-primary");
    report.classList.add("ReportMessage");
    report.type = "submit";
    report.formaction = "ReportMessage/Report";
    
    
    document.getElementById("jsid").appendChild(reportForm);
    reportForm.appendChild(hiddenInputMessage);
    reportForm.appendChild(hiddenInputUser);
    reportForm.appendChild(report);
    
   }