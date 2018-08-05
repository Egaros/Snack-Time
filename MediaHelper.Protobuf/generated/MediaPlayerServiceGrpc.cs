// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MediaPlayerService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace MediaHelper.Protobuf.generated {
  public static partial class MediaPlayerService
  {
    static readonly string __ServiceName = "MediaPlayerServices.MediaPlayerService";

    static readonly grpc::Marshaller<global::MediaHelper.Protobuf.generated.EmptyMessage> __Marshaller_EmptyMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MediaHelper.Protobuf.generated.EmptyMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MediaHelper.Protobuf.generated.PlayingMediaInfo> __Marshaller_PlayingMediaInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MediaHelper.Protobuf.generated.PlayingMediaInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MediaHelper.Protobuf.generated.OpenFile> __Marshaller_OpenFile = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MediaHelper.Protobuf.generated.OpenFile.Parser.ParseFrom);

    static readonly grpc::Method<global::MediaHelper.Protobuf.generated.EmptyMessage, global::MediaHelper.Protobuf.generated.PlayingMediaInfo> __Method_Info = new grpc::Method<global::MediaHelper.Protobuf.generated.EmptyMessage, global::MediaHelper.Protobuf.generated.PlayingMediaInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Info",
        __Marshaller_EmptyMessage,
        __Marshaller_PlayingMediaInfo);

    static readonly grpc::Method<global::MediaHelper.Protobuf.generated.OpenFile, global::MediaHelper.Protobuf.generated.EmptyMessage> __Method_Open = new grpc::Method<global::MediaHelper.Protobuf.generated.OpenFile, global::MediaHelper.Protobuf.generated.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Open",
        __Marshaller_OpenFile,
        __Marshaller_EmptyMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MediaHelper.Protobuf.generated.MediaPlayerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MediaPlayerService</summary>
    public abstract partial class MediaPlayerServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::MediaHelper.Protobuf.generated.PlayingMediaInfo> Info(global::MediaHelper.Protobuf.generated.EmptyMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::MediaHelper.Protobuf.generated.EmptyMessage> Open(global::MediaHelper.Protobuf.generated.OpenFile request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MediaPlayerService</summary>
    public partial class MediaPlayerServiceClient : grpc::ClientBase<MediaPlayerServiceClient>
    {
      /// <summary>Creates a new client for MediaPlayerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MediaPlayerServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MediaPlayerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MediaPlayerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MediaPlayerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MediaPlayerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::MediaHelper.Protobuf.generated.PlayingMediaInfo Info(global::MediaHelper.Protobuf.generated.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Info(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MediaHelper.Protobuf.generated.PlayingMediaInfo Info(global::MediaHelper.Protobuf.generated.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Info, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MediaHelper.Protobuf.generated.PlayingMediaInfo> InfoAsync(global::MediaHelper.Protobuf.generated.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MediaHelper.Protobuf.generated.PlayingMediaInfo> InfoAsync(global::MediaHelper.Protobuf.generated.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Info, null, options, request);
      }
      public virtual global::MediaHelper.Protobuf.generated.EmptyMessage Open(global::MediaHelper.Protobuf.generated.OpenFile request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Open(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MediaHelper.Protobuf.generated.EmptyMessage Open(global::MediaHelper.Protobuf.generated.OpenFile request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Open, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MediaHelper.Protobuf.generated.EmptyMessage> OpenAsync(global::MediaHelper.Protobuf.generated.OpenFile request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OpenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MediaHelper.Protobuf.generated.EmptyMessage> OpenAsync(global::MediaHelper.Protobuf.generated.OpenFile request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Open, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MediaPlayerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MediaPlayerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MediaPlayerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Info, serviceImpl.Info)
          .AddMethod(__Method_Open, serviceImpl.Open).Build();
    }

  }
}
#endregion
