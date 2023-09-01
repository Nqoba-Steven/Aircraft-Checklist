using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Entry.Revisions
{
    [Table(Names.Tables.Revisions.Learjet.TableName, Schema = Names.Tables.Revisions.Schema)]
    public class LearjetRevision : RevisionBase
    {

    }
}
