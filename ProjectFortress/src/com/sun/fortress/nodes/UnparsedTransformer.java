package com.sun.fortress.nodes;

import java.lang.String;
import java.math.BigInteger;
import java.io.Writer;
import java.util.Collections;
import java.util.List;
import java.util.Map;
import java.util.ArrayList;
import java.util.LinkedList;
import com.sun.fortress.nodes_util.*;
import com.sun.fortress.parser_util.*;
import com.sun.fortress.parser_util.precedence_opexpr.*;
import com.sun.fortress.useful.*;
import edu.rice.cs.plt.tuple.Option;

/**
 * Class UnparsedTransformer, a component of the ASTGen-generated composite hierarchy.
 * Note: null is not allowed as a value for any field.
 * @version  Generated automatically by ASTGen at Thu Oct 11 03:24:55 EDT 2018
 */
@SuppressWarnings("unused")
public class UnparsedTransformer extends Transformer {
    private final String _transformer;
    private final Id _nonterminal;

    /**
     * Constructs a UnparsedTransformer.
     * @throws java.lang.IllegalArgumentException  If any parameter to the constructor is null.
     */
    public UnparsedTransformer(ASTNodeInfo in_info, String in_transformer, Id in_nonterminal) {
        super(in_info);
        if (in_transformer == null) {
            throw new java.lang.IllegalArgumentException("Parameter 'transformer' to the UnparsedTransformer constructor was null");
        }
        _transformer = in_transformer.intern();
        if (in_nonterminal == null) {
            throw new java.lang.IllegalArgumentException("Parameter 'nonterminal' to the UnparsedTransformer constructor was null");
        }
        _nonterminal = in_nonterminal;
    }

    final public String getTransformer() { return _transformer; }
    final public Id getNonterminal() { return _nonterminal; }

    public <RetType> RetType accept(AbstractNodeVisitor<RetType> visitor) {
        return visitor.forUnparsedTransformer(this);
    }

    public <RetType> RetType accept(NodeVisitor<RetType> visitor) {
        return visitor.forUnparsedTransformer(this);
    }

    public void accept(AbstractNodeVisitor_void visitor) {
        visitor.forUnparsedTransformer(this);
    }

    public void accept(NodeVisitor_void visitor) {
        visitor.forUnparsedTransformer(this);
    }

    /**
     * Implementation of equals that is based on the values of the fields of the
     * object. Thus, two objects created with identical parameters will be equal.
     */
    public boolean equals(Object obj) {
        if (obj == null) return false;
        if ((obj.getClass() != this.getClass()) || (obj.hashCode() != this.hashCode())) {
            return false;
        }
        else {
            UnparsedTransformer casted = (UnparsedTransformer) obj;
            ASTNodeInfo temp_info = getInfo();
            ASTNodeInfo casted_info = casted.getInfo();
            if (!(temp_info == casted_info || temp_info.equals(casted_info))) return false;
            String temp_transformer = getTransformer();
            String casted_transformer = casted.getTransformer();
            if (!(temp_transformer == casted_transformer)) return false;
            Id temp_nonterminal = getNonterminal();
            Id casted_nonterminal = casted.getNonterminal();
            if (!(temp_nonterminal == casted_nonterminal || temp_nonterminal.equals(casted_nonterminal))) return false;
            return true;
        }
    }


    /**
     * Implementation of hashCode that is consistent with equals.  The value of
     * the hashCode is formed by XORing the hashcode of the class object with
     * the hashcodes of all the fields of the object.
     */
    public int generateHashCode() {
        int code = getClass().hashCode();
        ASTNodeInfo temp_info = getInfo();
        code ^= temp_info.hashCode();
        String temp_transformer = getTransformer();
        code ^= temp_transformer.hashCode();
        Id temp_nonterminal = getNonterminal();
        code ^= temp_nonterminal.hashCode();
        return code;
    }

    /**
     * Empty constructor, for reflective access.  Clients are 
     * responsible for manually instantiating each field.
     */
    protected UnparsedTransformer() {
        _transformer = null;
        _nonterminal = null;
    }

    /**
     * Single Span constructor, for template gap access.  Clients are 
     * responsible for never accessing other fields than the gapId and 
     * templateParams.
     */
    protected UnparsedTransformer(ASTNodeInfo info) {
        super(info);
        _transformer = null;
        _nonterminal = null;
    }

    public void walk(TreeWalker w) {
        if (w.visitNode(this, "UnparsedTransformer", 3)) {
            ASTNodeInfo temp_info = getInfo();
            if (w.visitNodeField("info", temp_info)) {
                temp_info.walk(w);
                w.endNodeField("info", temp_info);
            }
            String temp_transformer = getTransformer();
            if (w.visitNodeField("transformer", temp_transformer)) {
                w.visitString(temp_transformer);
                w.endNodeField("transformer", temp_transformer);
            }
            Id temp_nonterminal = getNonterminal();
            if (w.visitNodeField("nonterminal", temp_nonterminal)) {
                temp_nonterminal.walk(w);
                w.endNodeField("nonterminal", temp_nonterminal);
            }
            w.endNode(this, "UnparsedTransformer", 3);
        }
    }

}
