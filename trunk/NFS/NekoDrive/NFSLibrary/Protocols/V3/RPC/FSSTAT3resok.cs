/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class FSSTAT3resok : XdrAble {
    public post_op_attr obj_attributes;
    public size3 tbytes;
    public size3 fbytes;
    public size3 abytes;
    public size3 tfiles;
    public size3 ffiles;
    public size3 afiles;
    public uint32 invarsec;

    public FSSTAT3resok() {
    }

    public FSSTAT3resok(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        obj_attributes.xdrEncode(xdr);
        tbytes.xdrEncode(xdr);
        fbytes.xdrEncode(xdr);
        abytes.xdrEncode(xdr);
        tfiles.xdrEncode(xdr);
        ffiles.xdrEncode(xdr);
        afiles.xdrEncode(xdr);
        invarsec.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        obj_attributes = new post_op_attr(xdr);
        tbytes = new size3(xdr);
        fbytes = new size3(xdr);
        abytes = new size3(xdr);
        tfiles = new size3(xdr);
        ffiles = new size3(xdr);
        afiles = new size3(xdr);
        invarsec = new uint32(xdr);
    }

}
// End of FSSTAT3resok.cs