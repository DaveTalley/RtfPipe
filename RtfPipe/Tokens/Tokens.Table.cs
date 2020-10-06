using System;
using System.Collections.Generic;
using System.Text;

namespace RtfPipe.Tokens
{
  public class RowDefaults : ControlTag
  {
    public override string Name => "trowd";
    public override TokenType Type => TokenType.RowFormat;
  }

  public class RowBreak : ControlTag
  {
    public override string Name => "row";
    public override TokenType Type => TokenType.BreakTag;
  }

  public class CellDefaults : ControlTag
  {
    public override string Name => "tcelld";
    public override TokenType Type => TokenType.RowFormat;
  }

  public class CellBreak : ControlTag
  {
    public override string Name => "cell";
    public override TokenType Type => TokenType.BreakTag;
  }

  public class CellSpacing : ControlWord<UnitValue>
  {
    public override string Name => "trgaph";
    public override TokenType Type => TokenType.RowFormat;

    public CellSpacing(UnitValue value) : base(value) { }
  }

  public class RightCellBoundary : ControlWord<UnitValue>
  {
    public override string Name => "cellx";
    public override TokenType Type => TokenType.CellFormat;

    public RightCellBoundary(UnitValue value) : base(value) { }
  }

  public class RowAutoFit : ControlWord<bool>
  {
    public override string Name => "trautofit";
    public override TokenType Type => TokenType.RowFormat;

    public RowAutoFit(bool value) : base(value) { }
  }

  public class RowLeft : ControlWord<UnitValue>
  {
    public override string Name => "trleft";
    public override TokenType Type => TokenType.RowFormat;

    public RowLeft(UnitValue value) : base(value) { }
  }

  public class RowAlign : ControlWord<TextAlignment>
  {
    public override string Name => "trq" + Value.ToString().ToLowerInvariant()[0];
    public override TokenType Type => TokenType.RowFormat;

    public RowAlign(TextAlignment value) : base(value) { }

    public override string ToString() => "\\" + Name;
  }

  public class TableBorderSide : ControlWord<BorderPosition>
  {
    public override string Name => "trbrdr" + Value.ToString().ToLowerInvariant()[0];
    public override TokenType Type => TokenType.RowFormat;

    public TableBorderSide(BorderPosition value) : base(value) { }
  }

  public class CellBorderSide : ControlWord<BorderPosition>
  {
    public override string Name => "clbrdr" + Value.ToString().ToLowerInvariant()[0];
    public override TokenType Type => TokenType.CellFormat;

    public CellBorderSide(BorderPosition value) : base(value) { }
  }

  public class TablePaddingTop : ControlWord<UnitValue>
  {
    public override string Name => "trpaddt";
    public override TokenType Type => TokenType.RowFormat;

    public TablePaddingTop(UnitValue value) : base(value) { }
  }

  public class TablePaddingRight : ControlWord<UnitValue>
  {
    public override string Name => "trpaddr";
    public override TokenType Type => TokenType.RowFormat;

    public TablePaddingRight(UnitValue value) : base(value) { }
  }

  public class TablePaddingBottom : ControlWord<UnitValue>
  {
    public override string Name => "trpaddb";
    public override TokenType Type => TokenType.RowFormat;

    public TablePaddingBottom(UnitValue value) : base(value) { }
  }

  public class TablePaddingLeft : ControlWord<UnitValue>
  {
    public override string Name => "trpaddl";
    public override TokenType Type => TokenType.RowFormat;

    public TablePaddingLeft(UnitValue value) : base(value) { }
  }

  public class CellWidthType : ControlWord<CellWidthUnit>
  {
    public override string Name => "clftsWidth";
    public override TokenType Type => TokenType.CellFormat;

    public CellWidthType(CellWidthUnit value) : base(value) { }
  }

  public class CellWidth : ControlWord<int>
  {
    public override string Name => "clwWidth";
    public override TokenType Type => TokenType.CellFormat;

    public CellWidth(int value) : base(value) { }
  }

  public class CellVerticalAlign : ControlWord<VerticalAlignment>
  {
    public override string Name => "clvertal" + Value.ToString().ToLowerInvariant()[0];
    public override TokenType Type => TokenType.CellFormat;

    public CellVerticalAlign(VerticalAlignment value) : base(value) { }

    public override string ToString() => "\\" + Name;
  }

  public class InTable : ControlTag
  {
    public override string Name => "intbl";
    public override TokenType Type => TokenType.RowFormat;
  }

  public class CellBackgroundColor : ControlWord<ColorValue>
  {
    public override string Name => "clcbpat";
    public override TokenType Type => TokenType.CellFormat;

    public CellBackgroundColor(ColorValue value) : base(value) { }
  }

  public class HeaderRow : ControlTag
  {
    public override string Name => "trhdr";
    public override TokenType Type => TokenType.RowFormat;
  }

  public class NestTableProperties : ControlTag
  {
    public override string Name => "nesttableprops";
  }

  public class NoNestedTables : ControlTag
  {
    public override string Name => "nonesttables";
  }

  public class NestCell : ControlTag
  {
    public override string Name => "nestcell";
    public override TokenType Type => TokenType.BreakTag;
  }

  public class NestRow : ControlTag
  {
    public override string Name => "nestrow";
    public override TokenType Type => TokenType.BreakTag;
  }

  public class NestingLevel : ControlWord<int>
  {
    public override string Name => "itap";
    public override TokenType Type => TokenType.ParagraphFormat;

    public NestingLevel(int value) : base(value) { }
  }

  public class NestColSpan : ControlWord<int>
  {
    public override string Name => "sscolspan";
    public override TokenType Type => TokenType.CellFormat;

    public NestColSpan(int value) : base(value) { }
  }
  public class CellMergeFirst : ControlTag
  {
    public override string Name => "clmgf";
    public override TokenType Type => TokenType.CellFormat;
  }
  public class CellMerge : ControlTag
  {
    public override string Name => "clmrg";
    public override TokenType Type => TokenType.CellFormat;
  }
  public class CellVerticalMergeFirst : ControlTag
  {
    public override string Name => "clvmgf";
    public override TokenType Type => TokenType.CellFormat;
  }
  public class CellVerticalMerge : ControlTag
  {
    public override string Name => "clvmrg";
    public override TokenType Type => TokenType.CellFormat;
  }
  public class LastRow : ControlTag
  {
    public override string Name => "lastrow";
    public override TokenType Type => TokenType.RowFormat;
  }
  public class CellPaddingTop : ControlWord<UnitValue>
  {
    public override string Name => "clpadt";
    public override TokenType Type => TokenType.CellFormat;

    public CellPaddingTop(UnitValue value) : base(value) { }
  }
  public class CellPaddingLeft : ControlWord<UnitValue>
  {
    public override string Name => "clpadl";
    public override TokenType Type => TokenType.CellFormat;

    public CellPaddingLeft(UnitValue value) : base(value) { }
  }
  public class CellPaddingRight : ControlWord<UnitValue>
  {
    public override string Name => "clpadr";
    public override TokenType Type => TokenType.CellFormat;

    public CellPaddingRight(UnitValue value) : base(value) { }
  }
  public class CellPaddingBottom : ControlWord<UnitValue>
  {
    public override string Name => "clpadb";
    public override TokenType Type => TokenType.CellFormat;

    public CellPaddingBottom(UnitValue value) : base(value) { }
  }
}
