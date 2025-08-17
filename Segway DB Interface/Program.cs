using Segway.EF.SegwayCntxt;
using SpenSoft.EF.BeamNG;
using SpenSoft.EF.JobSearch;
using SpenSoft.EF.Syteline;




using var JSdb = new JobSearchContext(); // Replace with your actual DbContext
var activities = JSdb.Activities
    .OrderBy(x => x.Date)
    .ToList();

var activityStatus = JSdb.ActivityStatus
    .ToList();

var activityStatuses = JSdb.ActivityStatuses
    .OrderBy(x => x.Description)
    .ToList();

using var bngDB = new BeamNGContext();

var vehicles = bngDB?.Vehicles?
    .OrderBy(x => x.Name)
    .ToList();

var configurations = bngDB?.Configurations?
    .OrderBy(x => x.Name)
    .ToList();

var images = bngDB?.Images?.ToList();

var classif = bngDB?.Classification?.ToList();

var bodies = bngDB?.Body_Style?.ToList();

var drive = bngDB?.Drive_Train?.ToList();

var countries = bngDB?.Country?.ToList();

var imagesData = bngDB?.Images_Data?.ToList();


if (true)
{
    using var db = new SegwayContext(); // Replace with your actual DbContext

    // INSERT
    //var newEntity = new Manufacturing_Component_Assemblies { /* set properties */ };
    //db.YourEntities.Add(newEntity);
    //db.SaveChanges();
    //Console.WriteLine("Inserted!");

    // SELECT
    var entities = db.Manufacturing_Component_Assemblies
        .OrderBy(x => x.Date_Time_Created)
        .Skip(0)
        .Take(10)
        .ToList();

    foreach (var entity in entities)
    {
        Console.WriteLine($"Parent: {entity.Parent_Serial}, Child: {entity.Child_Serial}, P: {entity.Part_Type}, Create: {entity.Date_Time_Created}, By: {entity.Created_By}");
    }
}

#if true
using var SytDB = new SytelineContext(); // Replace with your actual DbContext
var units = SytDB.FsUnits
    //.Where(x => x.SerNum == "dummy") //.StartsWith("16202"))
    .OrderBy(x => x.CreateDate)
    .Skip(0)
    .Take(10)
    .ToList();

foreach (var un in units)
{
    Console.WriteLine($"Unit: {un.SerNum}, Cust: {un.CustNum}, Usr: {un.UsrNum}, C: {un.CreateDate}, By: {un.CreatedBy}, Sts: {un.UnitStatCode}");
}

#endif

//var entity = db.Manufacturing_Component_Assemblies.OrderBy(x => x.Date_Time_Created).Skip(0);
//if (entity != null) Console.WriteLine($"Parent: {entity.Parent_Serial}, Child: {entity.Child_Serial}, P: {entity.Part_Type}");
//entity = db.Manufacturing_Component_Assemblies.OrderBy(x => x.Date_Time_Created).LastOrDefault();
//if (entity != null) Console.WriteLine($"Parent: {entity.Parent_Serial}, Child: {entity.Child_Serial}, P: {entity.Part_Type}");

// UPDATE
//if (entity != null)
//{
//    entity.SomeProperty = "Updated value";
//    db.SaveChanges();
//    Console.WriteLine("Updated!");
//}

// DELETE
//if (entity != null)
//{
//    db.YourEntities.Remove(entity);
//    db.SaveChanges();
//    Console.WriteLine("Deleted!");
//}
