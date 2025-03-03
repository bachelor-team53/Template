## Data annotations (Entity properties)

### Column [Column("")]
    - Specify the column name
    - Example
        - [Column("blog_id")]

### Column Typename [Column(TypeName = "")]
    - Specify the Column type
    - Example
        - [Column(TypeName = "varchar(200)")]
        - [Column(TypeName = "decimal(5, 2)")]

### DataType [DataType()]
    - Represents an enum which spesifies different types to choose from
    - Example
        - [DataType(DataType.EmailAddress)]
        - [DataType(DataType.DateTime)]
    - Url
        - https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.datatype?view=net-9.0

### Display [Display()]
    - Gets or sets a value that is used for display in the UI
    - Example
        -   [Display(Name = "Age Limit")]
            public int AgeLimit { get; set; }
    - url
        - https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-9.0

### Display format [DisplayFormat()]
    - Specifies how data fields are displayed and formatted by ASP.NET Dynamic Data.
    - Example
        -   [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        - [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
    - Url
        - https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayformatattribute?view=net-9.0

### String length [StringLength()]
    - Specifies the length of a string, and has the ability to have a error message
    - Example
        - [StringLength(200)]
        - [StringLength(4, ErrorMessage = "The ThumbnailPhotoFileName value cannot exceed 4 characters. ")]

### Required [Required]
    - Assign column as required

### Key [Key]
    - Primary key

### Data generation [DatabaseGenerated()]
    - Use this when we want a generated value to be placed, for example with the [Key] attribute
    - Example
        - [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        -   [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    - Url
        - https://learn.microsoft.com/en-us/ef/core/modeling/generated-properties?tabs=data-annotations

### PrimaryKey [PrimaryKey()]
    - To assign primary key from multiple proerties
    - Example
        -   [PrimaryKey(nameof(State), nameof(LicensePlate))]
            internal class Car
            {
                public string State { get; set; }
                public string LicensePlate { get; set; }
            
                public string Make { get; set; }
                public string Model { get; set; }
            }

### Foreignkey("")
    - Describe the foreign key column
    - Example
        - [ForeignKey("PlaceId")]

### Json Ignore [JsonIgnore]
    - To ignore individual properties to be represented in a json
    - My agile group used this attribute to ignore entities inside of entities
    - Example
        - [JsonIgnore]
        - [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        - [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    - Url
        - https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/ignore-properties

### Not Mapped [Notmapped]
    - Denotes that a property or class should be excluded from database mapping.
    - Url
        - https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.schema.notmappedattribute?view=net-9.0

### Email Address [EmailAddressAttribute]
    - Validates an email address
    - Url
        - https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.emailaddressattribute?view=net-9.0
