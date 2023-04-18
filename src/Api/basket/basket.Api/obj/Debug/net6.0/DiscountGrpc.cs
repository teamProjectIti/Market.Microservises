// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: discount.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Discound.Grpc.Protos {
  public static partial class DiscountProtoService
  {
    static readonly string __ServiceName = "DiscountProtoService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.GetDiscountRequest> __Marshaller_GetDiscountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.GetDiscountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.CouponModel> __Marshaller_CouponModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.CouponModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.CreateDiscountRequest> __Marshaller_CreateDiscountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.CreateDiscountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.UpdateDiscountRequest> __Marshaller_UpdateDiscountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.UpdateDiscountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.DeleteDiscountRequest> __Marshaller_DeleteDiscountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.DeleteDiscountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Discound.Grpc.Protos.DeleteDiscountResponse> __Marshaller_DeleteDiscountResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Discound.Grpc.Protos.DeleteDiscountResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Discound.Grpc.Protos.GetDiscountRequest, global::Discound.Grpc.Protos.CouponModel> __Method_GetDiscount = new grpc::Method<global::Discound.Grpc.Protos.GetDiscountRequest, global::Discound.Grpc.Protos.CouponModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDiscount",
        __Marshaller_GetDiscountRequest,
        __Marshaller_CouponModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Discound.Grpc.Protos.CreateDiscountRequest, global::Discound.Grpc.Protos.CouponModel> __Method_CreateDiscount = new grpc::Method<global::Discound.Grpc.Protos.CreateDiscountRequest, global::Discound.Grpc.Protos.CouponModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateDiscount",
        __Marshaller_CreateDiscountRequest,
        __Marshaller_CouponModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Discound.Grpc.Protos.UpdateDiscountRequest, global::Discound.Grpc.Protos.CouponModel> __Method_UpdateDiscount = new grpc::Method<global::Discound.Grpc.Protos.UpdateDiscountRequest, global::Discound.Grpc.Protos.CouponModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateDiscount",
        __Marshaller_UpdateDiscountRequest,
        __Marshaller_CouponModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Discound.Grpc.Protos.DeleteDiscountRequest, global::Discound.Grpc.Protos.DeleteDiscountResponse> __Method_DeleteDiscount = new grpc::Method<global::Discound.Grpc.Protos.DeleteDiscountRequest, global::Discound.Grpc.Protos.DeleteDiscountResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteDiscount",
        __Marshaller_DeleteDiscountRequest,
        __Marshaller_DeleteDiscountResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Discound.Grpc.Protos.DiscountReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DiscountProtoService</summary>
    public partial class DiscountProtoServiceClient : grpc::ClientBase<DiscountProtoServiceClient>
    {
      /// <summary>Creates a new client for DiscountProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DiscountProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DiscountProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DiscountProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DiscountProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DiscountProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel GetDiscount(global::Discound.Grpc.Protos.GetDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDiscount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel GetDiscount(global::Discound.Grpc.Protos.GetDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> GetDiscountAsync(global::Discound.Grpc.Protos.GetDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDiscountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> GetDiscountAsync(global::Discound.Grpc.Protos.GetDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel CreateDiscount(global::Discound.Grpc.Protos.CreateDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateDiscount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel CreateDiscount(global::Discound.Grpc.Protos.CreateDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> CreateDiscountAsync(global::Discound.Grpc.Protos.CreateDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateDiscountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> CreateDiscountAsync(global::Discound.Grpc.Protos.CreateDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel UpdateDiscount(global::Discound.Grpc.Protos.UpdateDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateDiscount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.CouponModel UpdateDiscount(global::Discound.Grpc.Protos.UpdateDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> UpdateDiscountAsync(global::Discound.Grpc.Protos.UpdateDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateDiscountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.CouponModel> UpdateDiscountAsync(global::Discound.Grpc.Protos.UpdateDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.DeleteDiscountResponse DeleteDiscount(global::Discound.Grpc.Protos.DeleteDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteDiscount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Discound.Grpc.Protos.DeleteDiscountResponse DeleteDiscount(global::Discound.Grpc.Protos.DeleteDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteDiscount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.DeleteDiscountResponse> DeleteDiscountAsync(global::Discound.Grpc.Protos.DeleteDiscountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteDiscountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Discound.Grpc.Protos.DeleteDiscountResponse> DeleteDiscountAsync(global::Discound.Grpc.Protos.DeleteDiscountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteDiscount, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DiscountProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DiscountProtoServiceClient(configuration);
      }
    }

  }
}
#endregion
