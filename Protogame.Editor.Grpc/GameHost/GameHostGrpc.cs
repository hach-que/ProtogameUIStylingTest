// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GameHost.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Protogame.Editor.Grpc.GameHost {
  public static partial class GameHostServer
  {
    static readonly string __ServiceName = "GameHostServer";

    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest> __Marshaller_SetRenderTargetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse> __Marshaller_SetRenderTargetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest> __Marshaller_SetMousePositionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse> __Marshaller_SetMousePositionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest> __Marshaller_GetMousePositionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse> __Marshaller_GetMousePositionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest> __Marshaller_QueueSerializedEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse> __Marshaller_QueueSerializedEventResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest> __Marshaller_SetPlaybackModeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse> __Marshaller_SetPlaybackModeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest, global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse> __Method_SetRenderTargets = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest, global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetRenderTargets",
        __Marshaller_SetRenderTargetsRequest,
        __Marshaller_SetRenderTargetsResponse);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest, global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse> __Method_SetMousePosition = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest, global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetMousePosition",
        __Marshaller_SetMousePositionRequest,
        __Marshaller_SetMousePositionResponse);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest, global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse> __Method_GetMousePosition = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest, global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMousePosition",
        __Marshaller_GetMousePositionRequest,
        __Marshaller_GetMousePositionResponse);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest, global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse> __Method_QueueSerializedEvent = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest, global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueueSerializedEvent",
        __Marshaller_QueueSerializedEventRequest,
        __Marshaller_QueueSerializedEventResponse);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest, global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse> __Method_SetPlaybackMode = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest, global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetPlaybackMode",
        __Marshaller_SetPlaybackModeRequest,
        __Marshaller_SetPlaybackModeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GameHostServer</summary>
    public abstract partial class GameHostServerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse> SetRenderTargets(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse> SetMousePosition(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse> GetMousePosition(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse> QueueSerializedEvent(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse> SetPlaybackMode(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GameHostServer</summary>
    public partial class GameHostServerClient : grpc::ClientBase<GameHostServerClient>
    {
      /// <summary>Creates a new client for GameHostServer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GameHostServerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GameHostServer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GameHostServerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GameHostServerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GameHostServerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse SetRenderTargets(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetRenderTargets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse SetRenderTargets(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetRenderTargets, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse> SetRenderTargetsAsync(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetRenderTargetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse> SetRenderTargetsAsync(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetRenderTargets, null, options, request);
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse SetMousePosition(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetMousePosition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse SetMousePosition(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetMousePosition, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse> SetMousePositionAsync(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetMousePositionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse> SetMousePositionAsync(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetMousePosition, null, options, request);
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse GetMousePosition(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMousePosition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse GetMousePosition(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMousePosition, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse> GetMousePositionAsync(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMousePositionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse> GetMousePositionAsync(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMousePosition, null, options, request);
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse QueueSerializedEvent(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return QueueSerializedEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse QueueSerializedEvent(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueueSerializedEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse> QueueSerializedEventAsync(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return QueueSerializedEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse> QueueSerializedEventAsync(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueueSerializedEvent, null, options, request);
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse SetPlaybackMode(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetPlaybackMode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse SetPlaybackMode(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetPlaybackMode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse> SetPlaybackModeAsync(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetPlaybackModeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse> SetPlaybackModeAsync(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetPlaybackMode, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GameHostServerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GameHostServerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameHostServerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetRenderTargets, serviceImpl.SetRenderTargets)
          .AddMethod(__Method_SetMousePosition, serviceImpl.SetMousePosition)
          .AddMethod(__Method_GetMousePosition, serviceImpl.GetMousePosition)
          .AddMethod(__Method_QueueSerializedEvent, serviceImpl.QueueSerializedEvent)
          .AddMethod(__Method_SetPlaybackMode, serviceImpl.SetPlaybackMode).Build();
    }

  }
}
#endregion
