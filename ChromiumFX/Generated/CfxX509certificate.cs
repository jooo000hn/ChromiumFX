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

namespace Chromium {
    /// <summary>
    /// Structure representing a X.509 certificate.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
    /// </remarks>
    public class CfxX509certificate : CfxLibraryBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxX509certificate Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxX509certificate)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxX509certificate(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxX509certificate(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the subject of the X.509 certificate. For HTTPS server certificates
        /// this represents the web server.  The common name of the subject should
        /// match the host name of the web server.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxX509certPrincipal Subject {
            get {
                return CfxX509certPrincipal.Wrap(CfxApi.X509certificate.cfx_x509certificate_get_subject(NativePtr));
            }
        }

        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxX509certPrincipal Issuer {
            get {
                return CfxX509certPrincipal.Wrap(CfxApi.X509certificate.cfx_x509certificate_get_issuer(NativePtr));
            }
        }

        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxBinaryValue SerialNumber {
            get {
                return CfxBinaryValue.Wrap(CfxApi.X509certificate.cfx_x509certificate_get_serial_number(NativePtr));
            }
        }

        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CfxTime.GetTimeT() will return 0 if no date was specified.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxTime ValidStart {
            get {
                return CfxTime.WrapOwned(CfxApi.X509certificate.cfx_x509certificate_get_valid_start(NativePtr));
            }
        }

        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CfxTime.GetTimeT() will return 0 if no date was specified.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxTime ValidExpiry {
            get {
                return CfxTime.WrapOwned(CfxApi.X509certificate.cfx_x509certificate_get_valid_expiry(NativePtr));
            }
        }

        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxBinaryValue DerEncoded {
            get {
                return CfxBinaryValue.Wrap(CfxApi.X509certificate.cfx_x509certificate_get_derencoded(NativePtr));
            }
        }

        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public CfxBinaryValue PemEncoded {
            get {
                return CfxBinaryValue.Wrap(CfxApi.X509certificate.cfx_x509certificate_get_pemencoded(NativePtr));
            }
        }

        /// <summary>
        /// Returns the number of certificates in the issuer chain. If 0, the
        /// certificate is self-signed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public ulong IssuerChainSize {
            get {
                return (ulong)CfxApi.X509certificate.cfx_x509certificate_get_issuer_chain_size(NativePtr);
            }
        }

        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain. If we failed
        /// to encode a certificate in the chain it is still present in the array but
        /// is an NULL string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public void GetDerEncodedIssuerChain(out ulong chainCount, out CfxBinaryValue chain) {
            UIntPtr chainCount_tmp = UIntPtr.Zero;
            IntPtr chain_ptr;
            CfxApi.X509certificate.cfx_x509certificate_get_derencoded_issuer_chain(NativePtr, out chainCount_tmp, out chain_ptr);
            chainCount = (ulong)chainCount_tmp;
            chain = CfxBinaryValue.Wrap(chain_ptr);
        }

        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain. If we failed
        /// to encode a certificate in the chain it is still present in the array but
        /// is an NULL string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_x509_certificate_capi.h">cef/include/capi/cef_x509_certificate_capi.h</see>.
        /// </remarks>
        public void GetPemEncodedIssuerChain(out ulong chainCount, out CfxBinaryValue chain) {
            UIntPtr chainCount_tmp = UIntPtr.Zero;
            IntPtr chain_ptr;
            CfxApi.X509certificate.cfx_x509certificate_get_pemencoded_issuer_chain(NativePtr, out chainCount_tmp, out chain_ptr);
            chainCount = (ulong)chainCount_tmp;
            chain = CfxBinaryValue.Wrap(chain_ptr);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}