// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SnackTime.App.Settings.ProtoGenerated {

  /// <summary>Holder for reflection information generated from proto/settings.proto</summary>
  public static partial class SettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRwcm90by9zZXR0aW5ncy5wcm90bxIWc25hY2t0aW1lLmFwcC5zZXR0aW5n",
            "cyJuCghTZXR0aW5ncxIPCgdmaWxlRGlyGAEgASgJEhMKC3RlbXBGaWxlRGly",
            "GAIgASgJEg8KB21wdlBhdGgYAyABKAkSDwoHc3ZwUGF0aBgEIAEoCRIaChJt",
            "ZWRpYVNlcnZlckFkZHJlc3MYBSABKAlCKKoCJVNuYWNrVGltZS5BcHAuU2V0",
            "dGluZ3MuUHJvdG9HZW5lcmF0ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.App.Settings.ProtoGenerated.Settings), global::SnackTime.App.Settings.ProtoGenerated.Settings.Parser, new[]{ "FileDir", "TempFileDir", "MpvPath", "SvpPath", "MediaServerAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Settings : pb::IMessage<Settings> {
    private static readonly pb::MessageParser<Settings> _parser = new pb::MessageParser<Settings>(() => new Settings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Settings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.App.Settings.ProtoGenerated.SettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings(Settings other) : this() {
      fileDir_ = other.fileDir_;
      tempFileDir_ = other.tempFileDir_;
      mpvPath_ = other.mpvPath_;
      svpPath_ = other.svpPath_;
      mediaServerAddress_ = other.mediaServerAddress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings Clone() {
      return new Settings(this);
    }

    /// <summary>Field number for the "fileDir" field.</summary>
    public const int FileDirFieldNumber = 1;
    private string fileDir_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FileDir {
      get { return fileDir_; }
      set {
        fileDir_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tempFileDir" field.</summary>
    public const int TempFileDirFieldNumber = 2;
    private string tempFileDir_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TempFileDir {
      get { return tempFileDir_; }
      set {
        tempFileDir_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mpvPath" field.</summary>
    public const int MpvPathFieldNumber = 3;
    private string mpvPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MpvPath {
      get { return mpvPath_; }
      set {
        mpvPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "svpPath" field.</summary>
    public const int SvpPathFieldNumber = 4;
    private string svpPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SvpPath {
      get { return svpPath_; }
      set {
        svpPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mediaServerAddress" field.</summary>
    public const int MediaServerAddressFieldNumber = 5;
    private string mediaServerAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MediaServerAddress {
      get { return mediaServerAddress_; }
      set {
        mediaServerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Settings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Settings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileDir != other.FileDir) return false;
      if (TempFileDir != other.TempFileDir) return false;
      if (MpvPath != other.MpvPath) return false;
      if (SvpPath != other.SvpPath) return false;
      if (MediaServerAddress != other.MediaServerAddress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FileDir.Length != 0) hash ^= FileDir.GetHashCode();
      if (TempFileDir.Length != 0) hash ^= TempFileDir.GetHashCode();
      if (MpvPath.Length != 0) hash ^= MpvPath.GetHashCode();
      if (SvpPath.Length != 0) hash ^= SvpPath.GetHashCode();
      if (MediaServerAddress.Length != 0) hash ^= MediaServerAddress.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FileDir.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileDir);
      }
      if (TempFileDir.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TempFileDir);
      }
      if (MpvPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MpvPath);
      }
      if (SvpPath.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SvpPath);
      }
      if (MediaServerAddress.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MediaServerAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FileDir.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileDir);
      }
      if (TempFileDir.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TempFileDir);
      }
      if (MpvPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MpvPath);
      }
      if (SvpPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SvpPath);
      }
      if (MediaServerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MediaServerAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Settings other) {
      if (other == null) {
        return;
      }
      if (other.FileDir.Length != 0) {
        FileDir = other.FileDir;
      }
      if (other.TempFileDir.Length != 0) {
        TempFileDir = other.TempFileDir;
      }
      if (other.MpvPath.Length != 0) {
        MpvPath = other.MpvPath;
      }
      if (other.SvpPath.Length != 0) {
        SvpPath = other.SvpPath;
      }
      if (other.MediaServerAddress.Length != 0) {
        MediaServerAddress = other.MediaServerAddress;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            FileDir = input.ReadString();
            break;
          }
          case 18: {
            TempFileDir = input.ReadString();
            break;
          }
          case 26: {
            MpvPath = input.ReadString();
            break;
          }
          case 34: {
            SvpPath = input.ReadString();
            break;
          }
          case 42: {
            MediaServerAddress = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code