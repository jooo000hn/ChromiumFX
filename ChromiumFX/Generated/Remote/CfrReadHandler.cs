// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    using Event;

    /// <summary>
    /// Structure the client can implement to provide a custom stream reader. The
    /// functions of this structure may be called on any thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
    /// </remarks>
    public class CfrReadHandler : CfrClientBase {

        internal static CfrReadHandler Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrReadHandler)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrReadHandler(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrReadHandler(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrReadHandler() : base(new CfxReadHandlerCtorWithGCHandleRemoteCall()) {
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        /// <summary>
        /// Read raw binary data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public event CfrReadEventHandler Read {
            add {
                if(m_Read == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 0;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Read += value;
            }
            remove {
                m_Read -= value;
                if(m_Read == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 0;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrReadEventHandler m_Read;


        /// <summary>
        /// Seek to the specified offset position. |Whence| may be any one of SEEK_CUR,
        /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public event CfrSeekEventHandler Seek {
            add {
                if(m_Seek == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 1;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Seek += value;
            }
            remove {
                m_Seek -= value;
                if(m_Seek == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 1;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrSeekEventHandler m_Seek;


        /// <summary>
        /// Return the current offset position.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public event CfrTellEventHandler Tell {
            add {
                if(m_Tell == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 2;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Tell += value;
            }
            remove {
                m_Tell -= value;
                if(m_Tell == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 2;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrTellEventHandler m_Tell;


        /// <summary>
        /// Return non-zero if at end of file.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public event CfrReadHandlerEofEventHandler Eof {
            add {
                if(m_Eof == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 3;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Eof += value;
            }
            remove {
                m_Eof -= value;
                if(m_Eof == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 3;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrReadHandlerEofEventHandler m_Eof;


        /// <summary>
        /// Return true (1) if this handler performs work like accessing the file
        /// system which may block. Used as a hint for determining the thread to access
        /// the handler from.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public event CfrMayBlockEventHandler MayBlock {
            add {
                if(m_MayBlock == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 4;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_MayBlock += value;
            }
            remove {
                m_MayBlock -= value;
                if(m_MayBlock == null) {
                    var call = new CfxReadHandlerSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 4;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrMayBlockEventHandler m_MayBlock;


    }

    namespace Event {

        /// <summary>
        /// Read raw binary data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public delegate void CfrReadEventHandler(object sender, CfrReadEventArgs e);

        /// <summary>
        /// Read raw binary data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public class CfrReadEventArgs : CfrEventArgs {

            private CfxReadHandlerReadRemoteEventCall call;


            internal ulong m_returnValue;
            private bool returnValueSet;

            internal CfrReadEventArgs(CfxReadHandlerReadRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Get the Ptr parameter for the <see cref="CfrReadHandler.Read"/> render process callback.
            /// </summary>
            public RemotePtr Ptr {
                get {
                    CheckAccess();
                    return new RemotePtr(call.ptr);
                }
            }
            /// <summary>
            /// Get the Size parameter for the <see cref="CfrReadHandler.Read"/> render process callback.
            /// </summary>
            public ulong Size {
                get {
                    CheckAccess();
                    return (ulong)call.size;
                }
            }
            /// <summary>
            /// Get the N parameter for the <see cref="CfrReadHandler.Read"/> render process callback.
            /// </summary>
            public ulong N {
                get {
                    CheckAccess();
                    return (ulong)call.n;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrReadHandler.Read"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(ulong returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Ptr={{{0}}}, Size={{{1}}}, N={{{2}}}", Ptr, Size, N);
            }
        }

        /// <summary>
        /// Seek to the specified offset position. |Whence| may be any one of SEEK_CUR,
        /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public delegate void CfrSeekEventHandler(object sender, CfrSeekEventArgs e);

        /// <summary>
        /// Seek to the specified offset position. |Whence| may be any one of SEEK_CUR,
        /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public partial class CfrSeekEventArgs : CfrEventArgs {

            private CfxReadHandlerSeekRemoteEventCall call;


            internal int m_returnValue;
            private bool returnValueSet;

            internal CfrSeekEventArgs(CfxReadHandlerSeekRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Get the Offset parameter for the <see cref="CfrReadHandler.Seek"/> render process callback.
            /// </summary>
            public long Offset {
                get {
                    CheckAccess();
                    return call.offset;
                }
            }
            /// <summary>
            /// Get the Whence parameter for the <see cref="CfrReadHandler.Seek"/> render process callback.
            /// </summary>
            public int Whence {
                get {
                    CheckAccess();
                    return call.whence;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrReadHandler.Seek"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(int returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Offset={{{0}}}, Whence={{{1}}}", Offset, Whence);
            }
        }

        /// <summary>
        /// Return the current offset position.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public delegate void CfrTellEventHandler(object sender, CfrTellEventArgs e);

        /// <summary>
        /// Return the current offset position.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public partial class CfrTellEventArgs : CfrEventArgs {

            private CfxReadHandlerTellRemoteEventCall call;


            internal long m_returnValue;
            private bool returnValueSet;

            internal CfrTellEventArgs(CfxReadHandlerTellRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Set the return value for the <see cref="CfrReadHandler.Tell"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(long returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }
        }

        /// <summary>
        /// Return non-zero if at end of file.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public delegate void CfrReadHandlerEofEventHandler(object sender, CfrReadHandlerEofEventArgs e);

        /// <summary>
        /// Return non-zero if at end of file.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public class CfrReadHandlerEofEventArgs : CfrEventArgs {

            private CfxReadHandlerEofRemoteEventCall call;


            internal int m_returnValue;
            private bool returnValueSet;

            internal CfrReadHandlerEofEventArgs(CfxReadHandlerEofRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Set the return value for the <see cref="CfrReadHandler.Eof"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(int returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }
        }

        /// <summary>
        /// Return true (1) if this handler performs work like accessing the file
        /// system which may block. Used as a hint for determining the thread to access
        /// the handler from.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public delegate void CfrMayBlockEventHandler(object sender, CfrMayBlockEventArgs e);

        /// <summary>
        /// Return true (1) if this handler performs work like accessing the file
        /// system which may block. Used as a hint for determining the thread to access
        /// the handler from.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_stream_capi.h">cef/include/capi/cef_stream_capi.h</see>.
        /// </remarks>
        public partial class CfrMayBlockEventArgs : CfrEventArgs {

            private CfxReadHandlerMayBlockRemoteEventCall call;


            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfrMayBlockEventArgs(CfxReadHandlerMayBlockRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Set the return value for the <see cref="CfrReadHandler.MayBlock"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }
        }

    }
}
