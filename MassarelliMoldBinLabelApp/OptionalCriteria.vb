Public Class OptionalCriteria

    Private mLabelDataTable As DataTable
    Public Property LabelDataTable() As DataTable
        Get
            Return mLabelDataTable
        End Get
        Set(ByVal value As DataTable)
            mLabelDataTable = value
        End Set
    End Property

    Private mFileName As String
    Public Property FileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal value As String)
            mFileName = value
        End Set
    End Property

    Private mShowHide As String
    Public Property ShowHide() As String
        Get
            Return mShowHide
        End Get
        Set(ByVal value As String)
            mShowHide = value
        End Set
    End Property
    Private mMoldItemNo As String
    Public Property MoldItemNo() As String
        Get
            Return mMoldItemNo
        End Get
        Set(ByVal value As String)
            mMoldItemNo = value
        End Set
    End Property

    Private mPrinterName As String
    Public Property PrinterName() As String
        Get
            Return mPrinterName
        End Get
        Set(ByVal value As String)
            mPrinterName = value
        End Set
    End Property
    Private mPrintType As String
    Public Property PrintType() As String
        Get
            Return mPrintType
        End Get
        Set(ByVal value As String)
            mPrintType = value
        End Set
    End Property
    Private mReportPathFileName As String
    Public Property ReportPathFileName() As String
        Get
            Return mReportPathFileName
        End Get
        Set(ByVal value As String)
            mReportPathFileName = value
        End Set
    End Property
    Private mIsLoading As Boolean
    Public Property IsLoading() As Boolean
        Get
            Return mIsLoading
        End Get
        Set(ByVal value As Boolean)
            mIsLoading = value
        End Set
    End Property
    Private mDBName As String
    Public Property DBName() As String
        Get
            Return mDBName
        End Get
        Set(ByVal value As String)
            mDBName = value
        End Set
    End Property
    Private mCurrentDB As String
    Public Property CurrentDB() As String
        Get
            Return mCurrentDB
        End Get
        Set(ByVal value As String)
            mCurrentDB = value
        End Set
    End Property
    Private mDefaultDB As String
    Public Property DefaultDB() As String
        Get
            Return mDefaultDB
        End Get
        Set(ByVal value As String)
            mDefaultDB = value
        End Set
    End Property
    Private mLocation As String
    Public Property Location() As String
        Get
            Return mLocation
        End Get
        Set(ByVal value As String)
            mLocation = value
        End Set
    End Property

End Class
