using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RtfPipe.Tokens
{
  public class Header : ControlTag
  {
    public override string Name => "header";
  }

  public class HeaderEven : ControlTag
  {
    public override string Name => "headerl";
  }

  public class HeaderOdd : ControlTag
  {
    public override string Name => "headerr";
  }

  public class HeaderFirst : ControlTag
  {
    public override string Name => "headerf";
  }

  public class Footer : ControlTag
  {
    public override string Name => "footer";
  }

  public class FooterEven : ControlTag
  {
    public override string Name => "footerl";
  }

  public class FooterOdd : ControlTag
  {
    public override string Name => "footerr";
  }

  public class FooterFirst : ControlTag
  {
    public override string Name => "footerf";
  }

  public class PaperWidth : ControlWord<UnitValue>
  {
    public override string Name => "paperw";
    public override TokenType Type => TokenType.HeaderTag;
    public PaperWidth(UnitValue value) : base(value) { }
  }
  public class PaperHeight : ControlWord<UnitValue>
  {
    public override string Name => "paperh";
    public override TokenType Type => TokenType.HeaderTag;
    public PaperHeight(UnitValue value) : base(value) { }
  }
  public class MarginLeft : ControlWord<UnitValue>
  {
    public override string Name => "margl";
    public override TokenType Type => TokenType.HeaderTag;
    public MarginLeft(UnitValue value) : base(value) { }
  }
  public class MarginRight : ControlWord<UnitValue>
  {
    public override string Name => "margr";
    public override TokenType Type => TokenType.HeaderTag;
    public MarginRight(UnitValue value) : base(value) { }
  }
  public class MarginTop : ControlWord<UnitValue>
  {
    public override string Name => "margt";
    public override TokenType Type => TokenType.HeaderTag;
    public MarginTop(UnitValue value) : base(value) { }
  }
  public class MarginBottom : ControlWord<UnitValue>
  {
    public override string Name => "margb";
    public override TokenType Type => TokenType.HeaderTag;
    public MarginBottom(UnitValue value) : base(value) { }
  }

  public class SectionWidth : ControlWord<UnitValue>
  {
    public override string Name => "pgwsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionWidth(UnitValue value) : base(value) { }
  }
  public class SectionHeight : ControlWord<UnitValue>
  {
    public override string Name => "pghsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionHeight(UnitValue value) : base(value) { }
  }
  public class SectionMarginLeft : ControlWord<UnitValue>
  {
    public override string Name => "marglsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionMarginLeft(UnitValue value) : base(value) { }
  }
  public class SectionMarginRight : ControlWord<UnitValue>
  {
    public override string Name => "margrsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionMarginRight(UnitValue value) : base(value) { }
  }
  public class SectionMarginTop : ControlWord<UnitValue>
  {
    public override string Name => "margtsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionMarginTop(UnitValue value) : base(value) { }
  }
  public class SectionMarginBottom : ControlWord<UnitValue>
  {
    public override string Name => "margbsxn";
    public override TokenType Type => TokenType.HeaderTag;
    public SectionMarginBottom(UnitValue value) : base(value) { }
  }
}
