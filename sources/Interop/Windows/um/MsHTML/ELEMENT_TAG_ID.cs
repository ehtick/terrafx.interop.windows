// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ELEMENT_TAG_ID
    {
        TAGID_NULL = 0,
        TAGID_UNKNOWN = 1,
        TAGID_A = 2,
        TAGID_ACRONYM = 3,
        TAGID_ADDRESS = 4,
        TAGID_APPLET = 5,
        TAGID_AREA = 6,
        TAGID_B = 7,
        TAGID_BASE = 8,
        TAGID_BASEFONT = 9,
        TAGID_BDO = 10,
        TAGID_BGSOUND = 11,
        TAGID_BIG = 12,
        TAGID_BLINK = 13,
        TAGID_BLOCKQUOTE = 14,
        TAGID_BODY = 15,
        TAGID_BR = 16,
        TAGID_BUTTON = 17,
        TAGID_CAPTION = 18,
        TAGID_CENTER = 19,
        TAGID_CITE = 20,
        TAGID_CODE = 21,
        TAGID_COL = 22,
        TAGID_COLGROUP = 23,
        TAGID_COMMENT = 24,
        TAGID_COMMENT_RAW = 25,
        TAGID_DD = 26,
        TAGID_DEL = 27,
        TAGID_DFN = 28,
        TAGID_DIR = 29,
        TAGID_DIV = 30,
        TAGID_DL = 31,
        TAGID_DT = 32,
        TAGID_EM = 33,
        TAGID_EMBED = 34,
        TAGID_FIELDSET = 35,
        TAGID_FONT = 36,
        TAGID_FORM = 37,
        TAGID_FRAME = 38,
        TAGID_FRAMESET = 39,
        TAGID_GENERIC = 40,
        TAGID_H1 = 41,
        TAGID_H2 = 42,
        TAGID_H3 = 43,
        TAGID_H4 = 44,
        TAGID_H5 = 45,
        TAGID_H6 = 46,
        TAGID_HEAD = 47,
        TAGID_HR = 48,
        TAGID_HTML = 49,
        TAGID_I = 50,
        TAGID_IFRAME = 51,
        TAGID_IMG = 52,
        TAGID_INPUT = 53,
        TAGID_INS = 54,
        TAGID_KBD = 55,
        TAGID_LABEL = 56,
        TAGID_LEGEND = 57,
        TAGID_LI = 58,
        TAGID_LINK = 59,
        TAGID_LISTING = 60,
        TAGID_MAP = 61,
        TAGID_MARQUEE = 62,
        TAGID_MENU = 63,
        TAGID_META = 64,
        TAGID_NEXTID = 65,
        TAGID_NOBR = 66,
        TAGID_NOEMBED = 67,
        TAGID_NOFRAMES = 68,
        TAGID_NOSCRIPT = 69,
        TAGID_OBJECT = 70,
        TAGID_OL = 71,
        TAGID_OPTION = 72,
        TAGID_P = 73,
        TAGID_PARAM = 74,
        TAGID_PLAINTEXT = 75,
        TAGID_PRE = 76,
        TAGID_Q = 77,
        TAGID_RP = 78,
        TAGID_RT = 79,
        TAGID_RUBY = 80,
        TAGID_S = 81,
        TAGID_SAMP = 82,
        TAGID_SCRIPT = 83,
        TAGID_SELECT = 84,
        TAGID_SMALL = 85,
        TAGID_SPAN = 86,
        TAGID_STRIKE = 87,
        TAGID_STRONG = 88,
        TAGID_STYLE = 89,
        TAGID_SUB = 90,
        TAGID_SUP = 91,
        TAGID_TABLE = 92,
        TAGID_TBODY = 93,
        TAGID_TC = 94,
        TAGID_TD = 95,
        TAGID_TEXTAREA = 96,
        TAGID_TFOOT = 97,
        TAGID_TH = 98,
        TAGID_THEAD = 99,
        TAGID_TITLE = 100,
        TAGID_TR = 101,
        TAGID_TT = 102,
        TAGID_U = 103,
        TAGID_UL = 104,
        TAGID_VAR = 105,
        TAGID_WBR = 106,
        TAGID_XMP = 107,
        TAGID_ROOT = 108,
        TAGID_OPTGROUP = 109,
        TAGID_ABBR = 110,
        TAGID_SVG_A = 111,
        TAGID_SVG_ALTGLYPH = 112,
        TAGID_SVG_ALTGLYPHDEF = 113,
        TAGID_SVG_ALTGLYPHITEM = 114,
        TAGID_SVG_ANIMATE = 115,
        TAGID_SVG_ANIMATECOLOR = 116,
        TAGID_SVG_ANIMATEMOTION = 117,
        TAGID_SVG_ANIMATETRANSFORM = 118,
        TAGID_SVG_CIRCLE = 119,
        TAGID_SVG_CLIPPATH = 120,
        TAGID_SVG_COLOR_PROFILE = 121,
        TAGID_SVG_CURSOR = 122,
        TAGID_SVG_DEFINITION_SRC = 123,
        TAGID_SVG_DEFS = 124,
        TAGID_SVG_DESC = 125,
        TAGID_SVG_ELLIPSE = 126,
        TAGID_SVG_FEBLEND = 127,
        TAGID_SVG_FECOLORMATRIX = 128,
        TAGID_SVG_FECOMPONENTTRANSFER = 129,
        TAGID_SVG_FECOMPOSITE = 130,
        TAGID_SVG_FECONVOLVEMATRIX = 131,
        TAGID_SVG_FEDIFFUSELIGHTING = 132,
        TAGID_SVG_FEDISPLACEMENTMAP = 133,
        TAGID_SVG_FEDISTANTLIGHT = 134,
        TAGID_SVG_FEFLOOD = 135,
        TAGID_SVG_FEFUNCA = 136,
        TAGID_SVG_FEFUNCB = 137,
        TAGID_SVG_FEFUNCG = 138,
        TAGID_SVG_FEFUNCR = 139,
        TAGID_SVG_FEGAUSSIANBLUR = 140,
        TAGID_SVG_FEIMAGE = 141,
        TAGID_SVG_FEMERGE = 142,
        TAGID_SVG_FEMERGENODE = 143,
        TAGID_SVG_FEMORPHOLOGY = 144,
        TAGID_SVG_FEOFFSET = 145,
        TAGID_SVG_FEPOINTLIGHT = 146,
        TAGID_SVG_FESPECULARLIGHTING = 147,
        TAGID_SVG_FESPOTLIGHT = 148,
        TAGID_SVG_FETILE = 149,
        TAGID_SVG_FETURBULENCE = 150,
        TAGID_SVG_FILTER = 151,
        TAGID_SVG_FONT = 152,
        TAGID_SVG_FONT_FACE = 153,
        TAGID_SVG_FONT_FACE_FORMAT = 154,
        TAGID_SVG_FONT_FACE_NAME = 155,
        TAGID_SVG_FONT_FACE_SRC = 156,
        TAGID_SVG_FONT_FACE_URI = 157,
        TAGID_SVG_FOREIGNOBJECT = 158,
        TAGID_SVG_G = 159,
        TAGID_SVG_GLYPH = 160,
        TAGID_SVG_GLYPHREF = 161,
        TAGID_SVG_HKERN = 162,
        TAGID_SVG_IMAGE = 163,
        TAGID_SVG_LINE = 164,
        TAGID_SVG_LINEARGRADIENT = 165,
        TAGID_SVG_MARKER = 166,
        TAGID_SVG_MASK = 167,
        TAGID_SVG_METADATA = 168,
        TAGID_SVG_MISSING_GLYPH = 169,
        TAGID_SVG_MPATH = 170,
        TAGID_SVG_PATH = 171,
        TAGID_SVG_PATTERN = 172,
        TAGID_SVG_POLYGON = 173,
        TAGID_SVG_POLYLINE = 174,
        TAGID_SVG_RADIALGRADIENT = 175,
        TAGID_SVG_RECT = 176,
        TAGID_SVG_SCRIPT = 177,
        TAGID_SVG_SET = 178,
        TAGID_SVG_STOP = 179,
        TAGID_SVG_STYLE = 180,
        TAGID_SVG_SVG = 181,
        TAGID_SVG_SWITCH = 182,
        TAGID_SVG_SYMBOL = 183,
        TAGID_SVG_TEXT = 184,
        TAGID_SVG_TEXTPATH = 185,
        TAGID_SVG_TITLE = 186,
        TAGID_SVG_TREF = 187,
        TAGID_SVG_TSPAN = 188,
        TAGID_SVG_USE = 189,
        TAGID_SVG_VIEW = 190,
        TAGID_SVG_VKERN = 191,
        TAGID_AUDIO = 192,
        TAGID_SOURCE = 193,
        TAGID_VIDEO = 194,
        TAGID_CANVAS = 195,
        TAGID_DOCTYPE = 196,
        TAGID_KEYGEN = 197,
        TAGID_PROCESSINGINSTRUCTION = 198,
        TAGID_ARTICLE = 199,
        TAGID_ASIDE = 200,
        TAGID_FIGCAPTION = 201,
        TAGID_FIGURE = 202,
        TAGID_FOOTER = 203,
        TAGID_HEADER = 204,
        TAGID_HGROUP = 205,
        TAGID_MARK = 206,
        TAGID_NAV = 207,
        TAGID_SECTION = 208,
        TAGID_PROGRESS = 209,
        TAGID_MATHML_ANNOTATION_XML = 210,
        TAGID_MATHML_MATH = 211,
        TAGID_MATHML_MI = 212,
        TAGID_MATHML_MN = 213,
        TAGID_MATHML_MO = 214,
        TAGID_MATHML_MS = 215,
        TAGID_MATHML_MTEXT = 216,
        TAGID_DATALIST = 217,
        TAGID_TRACK = 218,
        TAGID_ISINDEX = 219,
        TAGID_COMMAND = 220,
        TAGID_DETAILS = 221,
        TAGID_SUMMARY = 222,
        TAGID_X_MS_WEBVIEW = 223,
        TAGID_COUNT = 224,
        TAGID_LAST_PREDEFINED = 10000,
        ELEMENT_TAG_ID_Max = 2147483647,
    }
}