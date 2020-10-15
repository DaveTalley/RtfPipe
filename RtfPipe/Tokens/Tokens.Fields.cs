using System;
using System.Collections.Generic;
using System.Text;

namespace RtfPipe.Tokens
{
  public class Field : ControlTag
  {
    public override string Name => "field";
  }

  public class FieldInstructions : ControlTag
  {
    public override string Name => "fldinst";
  }

  public class FieldResult : ControlTag
  {
    public override string Name => "fldrslt";
  }

  public class BookmarkStart : ControlTag
  {
    public override string Name => "bkmkstart";
  }

  public class BookmarkEnd : ControlTag
  {
    public override string Name => "bkmkend";
  }

  public class FormField : ControlTag
  {
    public override string Name => "formfield";
  }
  public class FieldName : ControlTag
  {
    public override string Name => "ffname";
  }
  public class FieldType : ControlWord<FieldTypeCode>
  {
    public override string Name => "fftype";
    public FieldType(FieldTypeCode value) : base(value) { }
  }
  public class FieldCheckBoxSize : ControlWord<UnitValue>
  {
    public override string Name => "ffhps";
    public FieldCheckBoxSize(UnitValue value) : base(value) { }
  }
  public class FieldListResult : ControlWord<int>
  {
    public override string Name => "ffres";
    public FieldListResult(int value) : base(value) { }
  }
  public class FieldListDefault : ControlWord<int>
  {
    public override string Name => "ffdefres";
    public FieldListDefault(int value) : base(value) { }
  }
}
