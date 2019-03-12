Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Crypter

    Public Enum CryptAlgorithms
        Rijndael = 1
        TripleDES = 2
        DES = 3
        RC2 = 4
        XorTS = 5
    End Enum

    'append _sCryptTagger to a crypted file, we can see it's crypt
    Private _sCryptTagger As String = "|~?~*%TS%*~?~|"

    Private _sKey As String
    Private _sIV As String
    Private _sFileIn As String
    Private _sFileOut As String
    Private _blnIsCrypted As Boolean = False

    Private _CryptAlgorithm As CryptAlgorithms = CryptAlgorithms.Rijndael
    Private _SymmetricAlgorithm As SymmetricAlgorithm

    Private _sProvider() As String = {"Rijndael", "TripleDES", "DES", "RC2", "XorTS"}

    'string added to key to make the max length pending of choosen provider 
    'contents of string may be changed, DO NOT change Length
    Private Const _sFixKey32 As String = "®ÉÂYµùðcJœšZÎ­ôNa·’qGäc3É¡2ÆoÁ6w"

    'string added to IV to make length pending of choosen provider
    'contents of string may be changed, DO NOT change Length
    Private Const _sFixIV16 As String = "Ó¦lÏ¬çJ³â»¶‚€>žã"


#Region "Crypt Property"

    'standard crypt algorithm is Rijndael
    Public Sub New()
        Me.CryptAlgorithm = CryptAlgorithms.Rijndael
    End Sub

    Public Sub New(ByVal CryptCryptAlgorithm As CryptAlgorithms)
        Me.CryptAlgorithm = CryptCryptAlgorithm
    End Sub

    Public Property Key() As String
        Get
            Return _sKey
        End Get
        Set(ByVal Value As String)
            _sKey = Value
            If Not (_CryptAlgorithm = CryptAlgorithms.XorTS) Then
                _SymmetricAlgorithm.Key = getKey()
            End If
        End Set
    End Property

    Public Property IV() As String
        Get
            Return _sIV
        End Get
        Set(ByVal Value As String)
            _sIV = Value
            If Not (_CryptAlgorithm = CryptAlgorithms.XorTS) Then
                _SymmetricAlgorithm.IV = getIV()
                _SymmetricAlgorithm.Key = getKey()
            End If
        End Set
    End Property

    Public Property FileOut() As String
        Get
            Return _sFileOut
        End Get
        Set(ByVal Value As String)
            _sFileOut = Value
        End Set
    End Property

    Public Property FileIn() As String
        Get
            Return _sFileIn
        End Get
        Set(ByVal Value As String)
            _sFileIn = Value
        End Set
    End Property

    Public Overloads Property CryptAlgorithm() As CryptAlgorithms
        Get
            Return _CryptAlgorithm
        End Get
        Set(ByVal Value As CryptAlgorithms)
            _CryptAlgorithm = Value
            If Not (_CryptAlgorithm = CryptAlgorithms.XorTS) Then
                _SymmetricAlgorithm = SymmetricAlgorithm.Create(CType(Choose(_CryptAlgorithm, _sProvider), String))
                _SymmetricAlgorithm.IV = getIV()
                _SymmetricAlgorithm.Key = getKey()
            End If
        End Set
    End Property

    Public Overloads Property CryptAlgorithm(ByVal dummy As String) As String
        Get
            Return CType(Choose(_CryptAlgorithm, _sProvider), String)
        End Get
        Set(ByVal Value As String)
        End Set
    End Property
#End Region

    Private Sub EncryptData()
        'dim outside the Try, so we can close the stream and del tmp files on error
        Dim oFsIn As FileStream
        Dim oFsOut As FileStream
        Dim sTmpFileOut As String = Me.tmpFileNameOut()

        Try
            oFsIn = New FileStream(_sFileIn, FileMode.Open, FileAccess.Read)

            'create a temp file for the cryted stream
            oFsOut = New FileStream(sTmpFileOut, FileMode.OpenOrCreate, FileAccess.Write)
            oFsOut.SetLength(0)

            'ms-help://MS.VSCC/MS.MSDNVS/cpref/html/frlrfSystemSecurityCryptAlgorithmCryptoStreamMembersTopic.htm
            Dim oCryptStream As New CryptoStream(oFsOut,
                     _SymmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write)

            'open a binary stream, so we do not use Dim byte() array
            Dim oBr As New BinaryReader(oFsIn)

            oCryptStream.Write(oBr.ReadBytes(CType(oFsIn.Length, Integer)), 0, CType(oFsIn.Length, Integer))

            'ms-help://MS.VSCC/MS.MSDNVS/cpref/html/frlrfSystemSecurityCryptAlgorithmCryptoStreamClassFlushFinalBlockTopic.htm
            oCryptStream.FlushFinalBlock()

            'write the tagger so that you'll know the crypt state
            oFsOut.Write(Encoding.ASCII.GetBytes(_sCryptTagger), 0, _sCryptTagger.Length)
            oFsOut.Flush()

            oCryptStream.Close()
            oFsIn.Close()
            oBr.Close()
            oFsOut.Close()

            Me.SwapFile(sTmpFileOut)

        Catch ex As Exception
            'close and cleanup and throw the error
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            If Not oFsIn Is Nothing Then oFsIn.Close()
            If Not oFsOut Is Nothing Then oFsOut.Close()

            If File.Exists(sTmpFileOut) Then KillFile(sTmpFileOut)

            Throw New ApplicationException(ex.Message, ex)

        End Try

    End Sub


    Private Sub DecryptData()
        'dim outside the Try, so we can close the stream and del tmp files on error
        Dim oFsIn As FileStream
        Dim oFsOut As FileStream
        Dim sTmpFileIn As String = Me.GetTempFileName
        Dim sTmpFileOut As String = Me.tmpFileNameOut

        Try
            'do not write in its original, so make a copy to a temp file
            File.Copy(_sFileIn, sTmpFileIn, True)

            'delete the tagger, so the file is in its origin length
            oFsIn = New FileStream(sTmpFileIn, FileMode.Open, FileAccess.ReadWrite)
            oFsIn.SetLength(oFsIn.Length - _sCryptTagger.Length)

            'create a temp file for the decrypted stream
            oFsOut = New FileStream(sTmpFileOut, FileMode.OpenOrCreate, FileAccess.Write)
            oFsOut.SetLength(0)

            'ms-help://MS.VSCC/MS.MSDNVS/cpref/html/frlrfSystemSecurityCryptAlgorithmCryptoStreamMembersTopic.htm
            Dim oCryptStream As New CryptoStream(oFsIn,
                           _SymmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read)

            'open a binary stream, now we can read and write direct without Dim byte() array
            'Reads primitive data types as binary values in a specific encoding.
            Dim oBr As New BinaryReader(oCryptStream)

            Dim oBw As New BinaryWriter(oFsOut)
            oBw.Write(oBr.ReadBytes(CType(oFsIn.Length, Integer) - 1))
            oBw.Flush()


            oCryptStream.Close()
            oBr.Close()
            oBw.Close()

            oFsIn.Close()
            oFsOut.Close()

            'we do not need the temp file anymore, so delete
            KillFile(sTmpFileIn)
            Me.SwapFile(sTmpFileOut)

        Catch ex As Exception
            'close and cleanup and throw the error
            If Not oFsIn Is Nothing Then oFsIn.Close()
            If Not oFsOut Is Nothing Then oFsOut.Close()

            If File.Exists(sTmpFileOut) Then KillFile(sTmpFileOut)
            If File.Exists(sTmpFileIn) Then KillFile(sTmpFileIn)

            Throw New ApplicationException(ex.Message, ex)
        End Try
    End Sub

    Public Function IsCrypted(Optional ByVal sFileIn As String = Nothing) As Boolean
        Dim sFileToCheck As String = CType(IIf(sFileIn = Nothing, _sFileIn, sFileIn), String)
        Dim oFsIn As FileStream
        Dim bytTag(_sCryptTagger.Length - 1) As Byte

        Try
            oFsIn = New FileStream(sFileToCheck, FileMode.Open, FileAccess.Read)
            oFsIn.Position = (oFsIn.Length - _sCryptTagger.Length)
            oFsIn.Read(bytTag, 0, bytTag.Length)
        Catch ex As Exception
            If Not oFsIn Is Nothing Then oFsIn.Close()
            Throw New ApplicationException(ex.Message, ex)
        End Try
        oFsIn.Close()
        Return (_sCryptTagger = Encoding.ASCII.GetString(bytTag))
    End Function

    Public Sub Encrypt()
        If Not File.Exists(_sFileIn) Then
            Throw New ApplicationException("File does not exist: " & _sFileIn)
        ElseIf Me.IsCrypted() Then
            Throw New ApplicationException("File " & _sFileIn & vbCrLf & " is already crypted")
        End If
        _blnIsCrypted = False

        If _CryptAlgorithm = CryptAlgorithms.XorTS Then
            Me.DeEnCryptXorTS()
        Else
            Me.EncryptData()
        End If
    End Sub

    Public Sub Decrypt()
        If Not File.Exists(_sFileIn) Then
            Throw New ApplicationException("File does not exist: " & _sFileIn)
        ElseIf Not Me.IsCrypted() Then
            Throw New ApplicationException("File " & _sFileIn & vbCrLf & " is NOT crypted, so decrypting is not possible")
        End If

        _blnIsCrypted = True

        If _CryptAlgorithm = CryptAlgorithms.XorTS Then
            Me.DeEnCryptXorTS()
        Else
            Me.DecryptData()
        End If
    End Sub

    Private Sub DeEnCryptXorTS()
        Dim oFsIn As FileStream
        Dim oFsOut As FileStream
        Dim sTmpFileOut As String

        Try
            oFsIn = New FileStream(_sFileIn, FileMode.Open, FileAccess.Read)

            Dim abyt(CType(oFsIn.Length - CType(IIf(_blnIsCrypted, _sCryptTagger.Length + 1, 1), Long), Integer)) As Byte
            oFsIn.Read(abyt, 0, abyt.Length)
            oFsIn.Close()

            sTmpFileOut = Me.tmpFileNameOut()

            oFsOut = New FileStream(sTmpFileOut, FileMode.OpenOrCreate, FileAccess.Write)
            oFsOut.SetLength(0)
            oFsOut.Write(Me.CryptToggleXorTS(abyt), 0, abyt.Length)

            If Not _blnIsCrypted Then
                'write the tagger so that you'll know the cryted state
                oFsOut.Write(Encoding.ASCII.GetBytes(_sCryptTagger), 0, _sCryptTagger.Length)
                oFsOut.Close()
            End If

            oFsOut.Close()

            Me.SwapFile(sTmpFileOut)
        Catch ex As Exception
            'close and cleanup and throw the error
            If Not oFsIn Is Nothing Then oFsIn.Close()
            If Not oFsOut Is Nothing Then oFsOut.Close()

            If File.Exists(sTmpFileOut) Then KillFile(sTmpFileOut)

            Throw New ApplicationException(ex.Message, ex)

        End Try
    End Sub

    Private Function CryptToggleXorTS(ByVal bytValue() As Byte) As Byte()
        Dim bytKey() As Byte = Me.getKey()
        Dim iPassLoop As Integer = 0
        Dim iValueLen As Integer = bytValue.Length - 1
        Dim iValueLoop As Integer
        Dim KeyLen As Integer = bytKey.Length
        For iValueLoop = 0 To iValueLen
            bytValue(iValueLoop) = (bytValue(iValueLoop) Xor bytKey(iPassLoop))
            iPassLoop += 1
            If iPassLoop = KeyLen Then iPassLoop = 0
        Next
        Return bytValue
    End Function

    Private Function getKey() As Byte()
        Dim sTmpKey As String = _sKey & _sFixKey32
        sTmpKey = sTmpKey.Substring(0, CType(Choose(_CryptAlgorithm, 32, 24, 8, 16, 32), Integer))
        Dim oPassDeriveByte As PasswordDeriveBytes = New PasswordDeriveBytes(sTmpKey, getIV)
#Disable Warning BC40000 ' Type or member is obsolete
        Return oPassDeriveByte.GetBytes(sTmpKey.Length)
#Enable Warning BC40000 ' Type or member is obsolete
    End Function

    Private Function getIV() As Byte()
        Dim sIV As String = _sIV & _sFixIV16
        Dim crypter As Crypter = Me
        Dim IVsize As Short = IIf(Me._CryptAlgorithm = Crypter.CryptAlgorithms.Rijndael, 16, 8)
        Return Encoding.ASCII.GetBytes(sIV.Substring(0, IVsize))
    End Function

    Private Function tmpFileNameOut() As String
        If _sFileOut = "" OrElse (_sFileIn = _sFileOut) Then
            tmpFileNameOut = Me.GetTempFileName()
        Else
            tmpFileNameOut = _sFileOut
        End If
    End Function

    Private Sub SwapFile(ByVal TmpFile As String)
        If _sFileOut = "" OrElse (_sFileIn = _sFileOut) Then

            While (True) 'must open exclusive for overwriting

                Try
                    Dim fs As FileStream = New FileStream(_sFileIn, FileMode.Append,
                                                     FileAccess.Write, FileShare.None)
                    fs.Close()
                    Exit While
                Catch e As Exception
                    If MessageBox.Show(e.Message & vbCrLf & "Try Again", "Error", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                        Exit Sub
                    End If
                End Try

            End While

            File.Copy(TmpFile, _sFileIn, True)  'swap file
            KillFile(TmpFile)
        End If
    End Sub

    Private Sub KillFile(ByVal sFileName As String)
        'is not allowed to call the file back with other programms
        Dim fs As FileStream = New FileStream(sFileName, FileMode.OpenOrCreate, FileAccess.Write)
        fs.SetLength(0)
        fs.Close()
        Kill(sFileName)
    End Sub

    Private Function GetTempFileName() As String
        Dim sTmpFile As String
        Dim i As Integer
        If Path.HasExtension(_sFileIn) Then
            sTmpFile = _sFileIn.Trim(Path.GetExtension(_sFileIn).ToCharArray)
        Else
            sTmpFile = _sFileIn
        End If
        For i = 1 To 999
            If Not File.Exists((sTmpFile & i.ToString("000") & ".DAT")) Then
                sTmpFile &= i.ToString("000") & ".DAT"
                Exit For
            End If
        Next
        If i = 1000 Then 'to many .dat files
            sTmpFile = Path.GetTempFileName
        Else
            'create the temp file
            Dim fs As FileStream = New FileStream(sTmpFile, FileMode.OpenOrCreate)
            fs.SetLength(0)
            fs.Close()
        End If
        Return sTmpFile
    End Function

End Class
