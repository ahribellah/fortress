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
 * Class ParenthesizedInfo, a component of the ASTGen-generated composite hierarchy.
 * Note: null is not allowed as a value for any field.
 * @version  Generated automatically by ASTGen at Thu Oct 11 03:24:55 EDT 2018
 */
@SuppressWarnings("unused")
public abstract class ParenthesizedInfo extends ASTNodeInfo {
    private final boolean _parenthesized;

    /**
     * Constructs a ParenthesizedInfo.
     * @throws java.lang.IllegalArgumentException  If any parameter to the constructor is null.
     */
    public ParenthesizedInfo(Span in_span, boolean in_parenthesized) {
        super(in_span);
        _parenthesized = in_parenthesized;
    }

    public boolean isParenthesized() { return _parenthesized; }

    public abstract int generateHashCode();
    /**
     * Empty constructor, for reflective access.  Clients are 
     * responsible for manually instantiating each field.
     */
    protected ParenthesizedInfo() {
        _parenthesized = false;
    }

}
