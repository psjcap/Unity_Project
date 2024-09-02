using System.Text;

public static class StringUtil
{
    private static StringBuilder _sb = new StringBuilder(256);

    public static string Format(string format, object arg0)
    {
        _sb.Clear();
        _sb.AppendFormat(format, arg0);
        return _sb.ToString();
    }

    public static string Format(string format, object arg0, object arg1)
    {
        _sb.Clear();
        _sb.AppendFormat(format, arg0, arg1);
        return _sb.ToString();
    }

    public static string Format(string format, object arg0, object arg1, string arg2)
    {
        _sb.Clear();
        _sb.AppendFormat(format, arg0, arg1, arg2);
        return _sb.ToString();
    }

    public static string Format(string format, params object[] args)
    {
        _sb.Clear();
        _sb.AppendFormat(format, args);
        return _sb.ToString();
    }

    public static string GetFullPathFromAssetPath(string assetPath)
    {
        _sb.Clear();
        _sb.AppendFormat("Assets/BundleResources/{0}", assetPath);
        return _sb.ToString();
    }

    public static string GetAssetPathFromFullPath(string fullPath)
    {
        _sb.Clear();
        if (!fullPath.StartsWith("Assets/BundleResources/"))
            return string.Empty;
        return fullPath.Substring("Assets/BundleResources/".Length);
    }
}