// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/drivers/proto/ultrasonic_radar.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Drivers {

  /// <summary>Holder for reflection information generated from modules/drivers/proto/ultrasonic_radar.proto</summary>
  public static partial class UltrasonicRadarReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/drivers/proto/ultrasonic_radar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UltrasonicRadarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixtb2R1bGVzL2RyaXZlcnMvcHJvdG8vdWx0cmFzb25pY19yYWRhci5wcm90",
            "bxIOYXBvbGxvLmRyaXZlcnMaIW1vZHVsZXMvY29tbW9uL3Byb3RvL2hlYWRl",
            "ci5wcm90byJDCgpVbHRyYXNvbmljEiUKBmhlYWRlchgBIAEoCzIVLmFwb2xs",
            "by5jb21tb24uSGVhZGVyEg4KBnJhbmdlcxgCIAMoAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Drivers.Ultrasonic), global::Apollo.Drivers.Ultrasonic.Parser, new[]{ "Header", "Ranges" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///               x axis
  ///		       ^
  ///                     |
  ///                  *  |  *
  ///               *     |     *
  ///        \    *       |       *    /
  ///          \ *     range(i)    * /
  ///            \        |        /
  ///              \      |      /
  ///                \    |    /
  ///       y axis     \  |  /
  ///      &lt;---------------
  ///        ooooooooooooo   //ultrasonic radar front surface
  ///
  /// In every working cycle, each radar of the ultrasonic system
  /// return a range to form a range array, 'ranges'.
  /// </summary>
  public sealed partial class Ultrasonic : pb::IMessage<Ultrasonic> {
    private static readonly pb::MessageParser<Ultrasonic> _parser = new pb::MessageParser<Ultrasonic>(() => new Ultrasonic());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Ultrasonic> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Drivers.UltrasonicRadarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ultrasonic() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ultrasonic(Ultrasonic other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      ranges_ = other.ranges_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ultrasonic Clone() {
      return new Ultrasonic(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "ranges" field.</summary>
    public const int RangesFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_ranges_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> ranges_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Ranges {
      get { return ranges_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Ultrasonic);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Ultrasonic other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if(!ranges_.Equals(other.ranges_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= ranges_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      ranges_.WriteTo(output, _repeated_ranges_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += ranges_.CalculateSize(_repeated_ranges_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Ultrasonic other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      ranges_.Add(other.ranges_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18:
          case 21: {
            ranges_.AddEntriesFrom(input, _repeated_ranges_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code