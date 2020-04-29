// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: helloworld.proto
// </auto-generated>
// Original file comments:
// Copyright 2015 gRPC authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Helloworld {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "helloworld.Greeter";

    static readonly grpc::Marshaller<global::Helloworld.HelloRequest> __Marshaller_helloworld_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Helloworld.HelloReply> __Marshaller_helloworld_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Helloworld.Msg> __Marshaller_helloworld_Msg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.Msg.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Helloworld.Empty> __Marshaller_helloworld_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Helloworld.HelloRequest, global::Helloworld.HelloReply> __Method_SayHello = new grpc::Method<global::Helloworld.HelloRequest, global::Helloworld.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_helloworld_HelloRequest,
        __Marshaller_helloworld_HelloReply);

    static readonly grpc::Method<global::Helloworld.Msg, global::Helloworld.Empty> __Method_SendPCList = new grpc::Method<global::Helloworld.Msg, global::Helloworld.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendPCList",
        __Marshaller_helloworld_Msg,
        __Marshaller_helloworld_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Helloworld.HelloworldReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Helloworld.HelloReply> SayHello(global::Helloworld.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Helloworld.Empty> SendPCList(global::Helloworld.Msg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::Helloworld.Empty SendPCList(global::Helloworld.Msg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendPCList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Helloworld.Empty SendPCList(global::Helloworld.Msg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendPCList, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Helloworld.Empty> SendPCListAsync(global::Helloworld.Msg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendPCListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Helloworld.Empty> SendPCListAsync(global::Helloworld.Msg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendPCList, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SendPCList, serviceImpl.SendPCList).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Helloworld.HelloRequest, global::Helloworld.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_SendPCList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Helloworld.Msg, global::Helloworld.Empty>(serviceImpl.SendPCList));
    }

  }
}
#endregion
