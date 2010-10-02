/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class entry : XdrAble {
    public int fileid;
    public filename name;
    public nfscookie cookie;
    public entry nextentry;

    public entry() {
    }

    public entry(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        entry _this = this;
        do {
            xdr.xdrEncodeInt(_this.fileid);
            _this.name.xdrEncode(xdr);
            _this.cookie.xdrEncode(xdr);
            _this = _this.nextentry;
            xdr.xdrEncodeBoolean(_this != null);
        } while ( _this != null );
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        entry _this = this;
        entry _next;
        do {
            _this.fileid = xdr.xdrDecodeInt();
            _this.name = new filename(xdr);
            _this.cookie = new nfscookie(xdr);
            _next = xdr.xdrDecodeBoolean() ? new entry() : null;
            _this.nextentry = _next;
            _this = _next;
        } while ( _this != null );
    }

}
// End of entry.cs