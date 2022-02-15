using System.Reflection;
using Diga.WebView2.WinForms;
using Diga.WebView2.WinForms.Scripting.DOM;

namespace HtmlControlExample;



public class MyControl
{
    private readonly WebView _WebView;
    private readonly DOMDocument _Document;
    private DOMElement? _Form;
    private DOMElement? _DivLine1;
    private DOMElement? _DivLine2;
    private DOMElement? _DivLine3;
    private DOMElement? _InputEmail;
    private DOMElement? _inputPassword;
    private DOMElement? _inputCheckBox;
    private DOMElement? _Div;
    private DOMElement? _Button;
    public event EventHandler<EventArgs>? Click;
    public MyControl(WebView control)
    {
            
        this._WebView = control;
        this._Document = this._WebView.GetDOMDocument();
        BuildPage();
    }

    private string GetElementValue(DOMElement element)
    {
        
        if (!element.VarExist()) return "";
        string var = element.GetVarName();
        string result = this._WebView.ExecuteScriptSync($"return {var}.value;");
        return result;
    }

    private bool GetElementChecked(DOMElement element)
    {
        if (!element.VarExist()) return false;
        string var = element.GetVarName();
        string result = this._WebView.ExecuteScriptSync($"return {var}.checked;");
        return Convert.ToBoolean( result);
    }
    public string GetPassword()
    {
        if (this._inputPassword == null) return "";
        return GetElementValue(this._inputPassword);

    }

    public string GetEmail()
    {
        if (this._InputEmail == null) return "";
        return GetElementValue(this._InputEmail);
    }

    public bool GetIsChecked()
    {
        if (this._inputCheckBox == null) return false;
        return GetElementChecked(this._inputCheckBox);
        
    }
    private void BuildPage()
    {
        this._Div = this._Document.createElement("div");
        this._Div.style.margin = "10px 10px 10px 10px";
        //this._Div.setAttribute("style","margin:10px 10px 10px 10px;");
        this._Form = this._Document.createElement("form");
        this._DivLine1 = this._Document.createElement("div");
        this._DivLine1.className = "mb-3";
        DOMElement lblEmail = this._Document.createElement("label");
        lblEmail.className = "form-label";
        lblEmail.setAttribute("for","exampleInputEmail1");
        lblEmail.innerHTML = "Email address";
        this._DivLine1.appendChild(lblEmail);
        this._InputEmail = this._Document.createElement("input");
        this._InputEmail.className = "form-control";
        this._InputEmail.setAttribute("type", "email");
        this._InputEmail.id = "exampleInputEmail1";
        this._InputEmail.setAttribute("aria-describedby","emailHelp");
        this._DivLine1.appendChild(this._InputEmail);
        DOMElement footerEmail = this._Document.createElement("div");
        footerEmail.className = "form-text";
        footerEmail.innerHTML = "We&rsquo;ll never share your email with anyone else.";
        footerEmail.id = "emailHelp";
        this._DivLine1.appendChild(footerEmail);
        this._Form.appendChild(this._DivLine1);


        this._DivLine2 = this._Document.createElement("div");
        this._DivLine2.className = "mb-3";
        DOMElement lblPassword = this._Document.createElement("label");
        lblPassword.className = "form-label";
        lblPassword.setAttribute("for","exampleInputPassword1");
        lblPassword.innerHTML = "Password";
        this._DivLine2.appendChild(lblPassword);
        this._inputPassword = this._Document.createElement("input");
        this._inputPassword.setAttribute("type","password");
        this._inputPassword.className = "form-control";
        this._inputPassword.id = "exampleInputPassword1";
        this._DivLine2.appendChild(this._inputPassword);
        this._Form.appendChild(this._DivLine2);

        this._DivLine3 = this._Document.createElement("div");
        this._DivLine3.className = "mb-3 form-check";
        this._inputCheckBox = this._Document.createElement("input");
        this._inputCheckBox.className = "form-check-input";
        this._inputCheckBox.setAttribute("type","checkbox");
        this._inputCheckBox.id = "exampleCheck1";
        this._DivLine3.appendChild(this._inputCheckBox);
        DOMElement lblInputCheckBox = this._Document.createElement("label");
        lblInputCheckBox.className = "form-check-label";
        lblInputCheckBox.setAttribute("for","exampleCheck1");
        lblInputCheckBox.innerHTML = "Check me out";
        this._DivLine3.appendChild(lblInputCheckBox);
        this._Form.appendChild(this._DivLine3);

        this._Button = this._Document.createElement("button");
        this._Button.className = "btn btn-primary";
        //this._Button.setAttribute("type","submit");
        this._Button.innerHTML = "OK";
        //this._Form.appendChild(this._Button);
        this._Button.Click += OnButtonClick;
        this._Div.appendChild(this._Form);
        this._Div.appendChild(this._Button);
        this._Document.body.appendChild(this._Div);


    }

    private void OnButtonClick(object? sender, DOMMouseEventArgs e)
    {
        this.Click?.Invoke(this,EventArgs.Empty);
    }
}