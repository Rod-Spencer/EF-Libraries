create  index [IX_Manufacturing_Component_Assemblies_ParentSerial] on [Segway_Production].[dbo].[Manufacturing_Component_Assemblies] (Parent_Serial);
create  index [IX_Manufacturing_Component_Assemblies_ChildSerial] on [Segway_Production].[dbo].[Manufacturing_Component_Assemblies] (Child_Serial);
create  index [IX_Manufacturing_Component_Assemblies_DateTimeCreated] on [Segway_Production].[dbo].[Manufacturing_Component_Assemblies] (Date_Time_Created);


create  index [IX_Manufacturing_Component_Data_ParentSerial] on [Segway_Production].[dbo].[Manufacturing_Component_Data] (Parent_Serial);
create  index [IX_Manufacturing_Component_Data_DataType] on [Segway_Production].[dbo].[Manufacturing_Component_Data] (Data_Type);
create  index [IX_Manufacturing_Component_Data_DateTimeCreated] on [Segway_Production].[dbo].[Manufacturing_Component_Data] (Date_Time_Created);


create  index [IX_Manufacturing_Component_Events_ParentSerial] on [Segway_Production].[dbo].[Manufacturing_Component_Events] (Parent_Serial);
create  index [IX_Manufacturing_Component_Events_EventsType] on [Segway_Production].[dbo].[Manufacturing_Component_Events] (Event_Type);
create  index [IX_Manufacturing_Component_Events_DateTimeCreated] on [Segway_Production].[dbo].[Manufacturing_Component_Events] (Date_Time_Created);


create  index [IX_Manufacturing_Component_Serialized_SerialNumber] on [Segway_Production].[dbo].[Manufacturing_Component_Serialized] (Serial_Number);
create  index [IX_Manufacturing_Component_Serialized_PartType] on [Segway_Production].[dbo].[Manufacturing_Component_Serialized] (Part_Type);
create  index [IX_Manufacturing_Component_Serialized_Model] on [Segway_Production].[dbo].[Manufacturing_Component_Serialized] (Model_Name);
create  index [IX_Manufacturing_Component_Serialized_DateTimeCreated] on [Segway_Production].[dbo].[Manufacturing_Component_Serialized] (Date_Time_Created);


