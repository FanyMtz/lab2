<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Search</title>
</head>
<body>
<form action="/Video/Search method="post">
    <fieldset>
    <legend>Buscar Video</legend>
    <label>idVideo</label>
        <input type="text" name="idVideo" />
        <h1>
        </h1>
        <input  type="submit" value="Buscar" />

    </fieldset>
    </form>
</body>
</html>
