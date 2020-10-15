using System;
using System.Collections.Generic;
using System.Text;

namespace RtfPipe.Tokens
{
  public class PictureTag : ControlTag
  {
    public override string Name => "pict";
  }

  public class ShapePictureTag : ControlTag
  {
    public override string Name => "shppict";
  }

  public class EmfBlip : ControlTag
  {
    public override string Name => "emfblip";
    public override TokenType Type => TokenType.PictureTypeTag;
  }

  public class PngBlip : ControlTag
  {
    public override string Name => "pngblip";
    public override TokenType Type => TokenType.PictureTypeTag;
  }

  public class JpegBlip : ControlTag
  {
    public override string Name => "jpegblip";
    public override TokenType Type => TokenType.PictureTypeTag;
  }

  public class MacPict : ControlTag
  {
    public override string Name => "macpict";
    public override TokenType Type => TokenType.PictureTypeTag;
  }

  public class PmMetafile : ControlWord<int>
  {
    public override string Name => "pmmetafile";
    public override TokenType Type => TokenType.PictureTypeTag;

    public PmMetafile(int value) : base(value) { }
  }

  public class WmMetafile : ControlWord<int>
  {
    public override string Name => "wmmetafile";
    public override TokenType Type => TokenType.PictureTypeTag;

    public WmMetafile(int value) : base(value) { }
  }

  public class DiBitmap : ControlWord<int>
  {
    public override string Name => "dibitmap";
    public override TokenType Type => TokenType.PictureTypeTag;

    public DiBitmap(int value) : base(value) { }
  }

  public class WBitmap : ControlWord<int>
  {
    public override string Name => "wbitmap";
    public override TokenType Type => TokenType.PictureTypeTag;

    public WBitmap(int value) : base(value) { }
  }

  public class PictureWidth : ControlWord<UnitValue>
  {
    public override string Name => "picw";

    public PictureWidth(UnitValue value) : base(value) { }
  }

  public class PictureHeight : ControlWord<UnitValue>
  {
    public override string Name => "pich";

    public PictureHeight(UnitValue value) : base(value) { }
  }

  public class PictureWidthGoal : ControlWord<UnitValue>
  {
    public override string Name => "picwgoal";

    public PictureWidthGoal(UnitValue value) : base(value) { }
  }

  public class PictureHeightGoal : ControlWord<UnitValue>
  {
    public override string Name => "pichgoal";

    public PictureHeightGoal(UnitValue value) : base(value) { }
  }

  public class PictureScaleX : ControlWord<int>
  {
    public override string Name => "picscalex";

    public PictureScaleX(int value) : base(value) { }
  }

  public class PictureScaleY : ControlWord<int>
  {
    public override string Name => "picscaley";

    public PictureScaleY(int value) : base(value) { }
  }

  public class PictureBinaryLength : ControlWord<int>
  {
    public override string Name => "bin";

    public PictureBinaryLength(int value) : base(value) { }
  }

  public class Shape : ControlTag  { public override string Name => "shp"; }
  public class ShapeInstruction : ControlTag { public override string Name => "shpinst"; }
  public class ShapeWrapText : ControlWord<ShapeWrap>
  {
    public override string Name => "shpwr";
    public ShapeWrapText(ShapeWrap value) : base(value) { }

  }
  public class ShapePositionLeft : ControlWord<UnitValue>
  {
    public override string Name => "shpleft";
    public ShapePositionLeft(UnitValue value) : base(value) { }
  }
  public class ShapePositionRight : ControlWord<UnitValue>
  {
    public override string Name => "shpright";
    public ShapePositionRight(UnitValue value) : base(value) { }
  }
  public class ShapePositionTop : ControlWord<UnitValue>
  {
    public override string Name => "shptop";
    public ShapePositionTop(UnitValue value) : base(value) { }
  }
  public class ShapePositionBottom : ControlWord<UnitValue>
  {
    public override string Name => "shpbottom";
    public ShapePositionBottom(UnitValue value) : base(value) { }
  }
  public class ShapePositionXFromPage : ControlTag  { public override string Name => "shpbxpage"; }
  public class ShapePositionXFromMargin : ControlTag { public override string Name => "shpbxmargin"; }
  public class ShapePositionXFromColumn : ControlTag { public override string Name => "shpbxcolumn"; }
  public class ShapePositionXIgnore : ControlTag { public override string Name => "shpbxignore"; }
  public class ShapePositionYFromPage : ControlTag { public override string Name => "shpbypage"; }
  public class ShapePositionYFromMargin : ControlTag { public override string Name => "shpbymargin"; }
  public class ShapePositionYFromParagraph : ControlTag { public override string Name => "shpbypara"; }
  public class ShapePositionYIgnore : ControlTag { public override string Name => "shpbyignore"; }
  public class ShapeProperty : ControlTag { public override string Name => "sp"; }
  public class ShapePropertyName : ControlTag { public override string Name => "sn";  }
  public class ShapePropertyValue : ControlTag { public override string Name => "sv"; }
  public class ShapeText : ControlTag { public override string Name => "shptxt"; }

}
