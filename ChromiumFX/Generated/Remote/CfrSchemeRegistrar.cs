// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    /// <summary>
    /// Structure that manages custom scheme registrations.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_scheme_capi.h">cef/include/capi/cef_scheme_capi.h</see>.
    /// </remarks>
    public class CfrSchemeRegistrar : CfrLibraryBase {

        internal static CfrSchemeRegistrar Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrSchemeRegistrar)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrSchemeRegistrar(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrSchemeRegistrar(RemotePtr remotePtr) : base(remotePtr) {}

        /// <summary>
        /// Register a custom scheme. This function should not be called for the built-
        /// in HTTP, HTTPS, FILE, FTP, ABOUT and DATA schemes.
        /// If |isStandard| is true (1) the scheme will be treated as a standard
        /// scheme. Standard schemes are subject to URL canonicalization and parsing
        /// rules as defined in the Common Internet Scheme Syntax RFC 1738 Section 3.1
        /// available at http://www.ietf.org/rfc/rfc1738.txt
        /// In particular, the syntax for standard scheme URLs must be of the form:
        /// &lt;pre>
        /// [scheme]://[username]:[password]@[host]:[port]/[url-path]
        /// &lt;/pre> Standard scheme URLs must have a host component that is a fully
        /// qualified domain name as defined in Section 3.5 of RFC 1034 [13] and
        /// Section 2.1 of RFC 1123. These URLs will be canonicalized to
        /// "scheme://host/path" in the simplest case and
        /// "scheme://username:password@host:port/path" in the most explicit case. For
        /// example, "scheme:host/path" and "scheme:///host/path" will both be
        /// canonicalized to "scheme://host/path". The origin of a standard scheme URL
        /// is the combination of scheme, host and port (i.e., "scheme://host:port" in
        /// the most explicit case).
        /// For non-standard scheme URLs only the "scheme:" component is parsed and
        /// canonicalized. The remainder of the URL will be passed to the handler as-
        /// is. For example, "scheme:///some%20text" will remain the same. Non-standard
        /// scheme URLs cannot be used as a target for form submission.
        /// If |isLocal| is true (1) the scheme will be treated as local (i.e., with
        /// the same security rules as those applied to "file" URLs). Normal pages
        /// cannot link to or access local URLs. Also, by default, local URLs can only
        /// perform XMLHttpRequest calls to the same URL (origin + path) that
        /// originated the request. To allow XMLHttpRequest calls from a local URL to
        /// other URLs with the same origin set the
        /// CfrSettings.FileAccessFromFileUrlsAllowed value to true (1). To allow
        /// XMLHttpRequest calls from a local URL to all origins set the
        /// CfrSettings.UniversalAccessFromFileUrlsAllowed value to true (1).
        /// If |isDisplayIsolated| is true (1) the scheme will be treated as display-
        /// isolated. This means that pages cannot display these URLs unless they are
        /// from the same scheme. For example, pages in another origin cannot create
        /// iframes or hyperlinks to URLs with this scheme.
        /// This function may be called on any thread. It should only be called once
        /// per unique |schemeName| value. If |schemeName| is already registered or
        /// if an error occurs this function will return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_scheme_capi.h">cef/include/capi/cef_scheme_capi.h</see>.
        /// </remarks>
        public bool AddCustomScheme(string schemeName, bool isStandard, bool isLocal, bool isDisplayIsolated) {
            var call = new CfxSchemeRegistrarAddCustomSchemeRemoteCall();
            call.@this = RemotePtr.ptr;
            call.schemeName = schemeName;
            call.isStandard = isStandard;
            call.isLocal = isLocal;
            call.isDisplayIsolated = isDisplayIsolated;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }
    }
}
