﻿using System.ComponentModel;
using Windows.UI.Xaml;

public class ProgressPercentage : INotifyPropertyChanged
{
    public int _prog;
    public int prog
    {
        get
        {
            return _prog;
        }

        set
        {
            if (value != _prog)
            {
                _prog = value;
                NotifyPropertyChanged("prog");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ProgressUIVisibility : INotifyPropertyChanged
{
    public Visibility _isVisible;
    public Visibility isVisible
    {
        get
        {
            return _isVisible;
        }

        set
        {
            if (value != _isVisible)
            {
                _isVisible = value;
                NotifyPropertyChanged("isVisible");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class CollisionUIVisibility : INotifyPropertyChanged
{
    public Visibility _isVisible;
    public Visibility isVisible
    {
        get
        {
            return _isVisible;
        }

        set
        {
            if (value != _isVisible)
            {
                _isVisible = value;
                NotifyPropertyChanged("isVisible");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ConflictUIVisibility : INotifyPropertyChanged
{
    public Visibility _isVisible;
    public Visibility isVisible
    {
        get
        {
            return _isVisible;
        }

        set
        {
            if (value != _isVisible)
            {
                _isVisible = value;
                NotifyPropertyChanged("isVisible");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ProgressUIButtonText : INotifyPropertyChanged
{
    public string _buttonText;
    public string buttonText
    {
        get
        {
            return _buttonText;
        }

        set
        {
            if (value != _buttonText)
            {
                _buttonText = value;
                NotifyPropertyChanged("buttonText");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ProgressUIHeader : INotifyPropertyChanged
{
    public string _header;
    public string Header
    {
        get
        {
            return _header;
        }

        set
        {
            if (value != _header)
            {
                _header = value;
                NotifyPropertyChanged("Header");
                //Debug.WriteLine("NotifyPropertyChanged was called successfully for ProgressUI Visibility");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ProgressUIPath : INotifyPropertyChanged
{
    public string _path;
    public string Path
    {
        get
        {
            return _path;
        }

        set
        {
            if (value != _path)
            {
                _path = value;
                NotifyPropertyChanged("Path");
                //Debug.WriteLine("NotifyPropertyChanged was called successfully for ProgressUI Visibility");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class CollisionBoxHeader : INotifyPropertyChanged
{
    public string _header;
    public string Header
    {
        get
        {
            return _header;
        }

        set
        {
            if (value != _header)
            {
                _header = value;
                NotifyPropertyChanged("Header");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class CollisionBoxSubHeader : INotifyPropertyChanged
{
    public string _subHeader;
    public string SubHeader
    {
        get
        {
            return _subHeader;
        }

        set
        {
            if (value != _subHeader)
            {
                _subHeader = value;
                NotifyPropertyChanged("SubHeader");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ConflictBoxHeader : INotifyPropertyChanged
{
    public string _header;
    public string Header
    {
        get
        {
            return _header;
        }

        set
        {
            if (value != _header)
            {
                _header = value;
                NotifyPropertyChanged("Header");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}

public class ConflictBoxSubHeader : INotifyPropertyChanged
{
    public string _subHeader;
    public string SubHeader
    {
        get
        {
            return _subHeader;
        }

        set
        {
            if (value != _subHeader)
            {
                _subHeader = value;
                NotifyPropertyChanged("SubHeader");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string info)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
    }
}