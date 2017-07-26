// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Protocal {
  
  public static partial class Protocal {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_Protocal_Account__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Protocal.Account, global::Protocal.Account.Builder> internal__static_Protocal_Account__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Protocal() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Cg5Qcm90b2NhbC5wcm90bxIIUHJvdG9jYWwiLAoHQWNjb3VudBIPCgdhY2Nv" + 
          "dW50GAEgAigJEhAKCHBhc3N3b3JkGAIgAigJKiEKCUVQcm90b2NhbBIUChBl" + 
          "Q1NfQ2hlY2tBY2NvdW50EAE=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_Protocal_Account__Descriptor = Descriptor.MessageTypes[0];
        internal__static_Protocal_Account__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Protocal.Account, global::Protocal.Account.Builder>(internal__static_Protocal_Account__Descriptor,
                new string[] { "Account_", "Password", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Enums
  public enum EProtocal {
    eCS_CheckAccount = 1,
  }
  
  #endregion
  
  #region Messages
  public sealed partial class Account : pb::GeneratedMessage<Account, Account.Builder> {
    private static readonly Account defaultInstance = new Builder().BuildPartial();
    public static Account DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Account DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Account ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Protocal.Protocal.internal__static_Protocal_Account__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Account, Account.Builder> InternalFieldAccessors {
      get { return global::Protocal.Protocal.internal__static_Protocal_Account__FieldAccessorTable; }
    }
    
    public const int Account_FieldNumber = 1;
    private bool hasAccount_;
    private string account_ = "";
    public bool HasAccount_ {
      get { return hasAccount_; }
    }
    public string Account_ {
      get { return account_; }
    }
    
    public const int PasswordFieldNumber = 2;
    private bool hasPassword;
    private string password_ = "";
    public bool HasPassword {
      get { return hasPassword; }
    }
    public string Password {
      get { return password_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasAccount_) return false;
        if (!hasPassword) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasAccount_) {
        output.WriteString(1, Account_);
      }
      if (HasPassword) {
        output.WriteString(2, Password);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasAccount_) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Account_);
        }
        if (HasPassword) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Password);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Account ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Account ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Account ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Account ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Account ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Account ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Account ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Account ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Account ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Account ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Account prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Account, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Account result = new Account();
      
      protected override Account MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Account();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Protocal.Account.Descriptor; }
      }
      
      public override Account DefaultInstanceForType {
        get { return global::Protocal.Account.DefaultInstance; }
      }
      
      public override Account BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Account returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Account) {
          return MergeFrom((Account) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Account other) {
        if (other == global::Protocal.Account.DefaultInstance) return this;
        if (other.HasAccount_) {
          Account_ = other.Account_;
        }
        if (other.HasPassword) {
          Password = other.Password;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              Account_ = input.ReadString();
              break;
            }
            case 18: {
              Password = input.ReadString();
              break;
            }
          }
        }
      }
      
      
      public bool HasAccount_ {
        get { return result.HasAccount_; }
      }
      public string Account_ {
        get { return result.Account_; }
        set { SetAccount_(value); }
      }
      public Builder SetAccount_(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasAccount_ = true;
        result.account_ = value;
        return this;
      }
      public Builder ClearAccount_() {
        result.hasAccount_ = false;
        result.account_ = "";
        return this;
      }
      
      public bool HasPassword {
        get { return result.HasPassword; }
      }
      public string Password {
        get { return result.Password; }
        set { SetPassword(value); }
      }
      public Builder SetPassword(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasPassword = true;
        result.password_ = value;
        return this;
      }
      public Builder ClearPassword() {
        result.hasPassword = false;
        result.password_ = "";
        return this;
      }
    }
    static Account() {
      object.ReferenceEquals(global::Protocal.Protocal.Descriptor, null);
    }
  }
  
  #endregion
  
}
